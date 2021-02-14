import ast
import boto3
import json
from botocore.vendored import requests

print('Loading function')
dynamo = boto3.resource('dynamodb')


def respond(err, res=None):
    return {
        'statusCode': '400' if err else '200',
        'body': err.message if err else json.dumps(res),
        'headers': {
            'Content-Type': 'application/json',
        },
    }


def lambda_handler(event, context):
    '''Demonstrates a simple HTTP endpoint using API Gateway. You have full
    access to the request and response payload, including headers and
    status code.

    To scan a DynamoDB table, make a GET request with the TableName as a
    query string parameter. To put, update, or delete an item, make a POST,
    PUT, or DELETE request respectively, passing in the payload to the
    DynamoDB API as a JSON body.
    '''
    # print("Received event: " + json.dumps(event, indent=2))
    
    operations = {
        'POST': createMeeting,
        'GET': getAuthenticated
    }

    operation = event['httpMethod']
    if operation in operations:
        payload = event['queryStringParameters'] if operation == 'GET' else json.loads(event['body'])
        return respond(None, operations[operation](payload))
    else:
        return respond(ValueError('Unsupported method "{}"'.format(operation)))

def saveAccessKey(dynamodb, accessKey):
    table = dynamodb.Table('AccessKey')

    response = table.update_item(
        Key={
            'user': 0,
        },
        UpdateExpression="set accessToken =:k",
        ExpressionAttributeValues={
            ':k': accessKey,
        },
        ReturnValues="UPDATED_NEW"
    )
    return response
    
def getAccessKey(dynamodb):
    table = dynamodb.Table('AccessKey')
    try:
        response = table.get_item(Key={'user': 0})
    except ClientError as e:
        print(e.response['Error']['Message'])
    else:
        return response['Item']['accessToken']


def getAuthenticated(something):
    code  = something['code']
    url = 'https://zoom.us/oauth/token'
    queryParams = {
        'grant_type': 'authorization_code',
        'code': code,
        'redirect_uri': 'https://byjsxnki07.execute-api.us-west-2.amazonaws.com/devel/user'
        
    }
    requestHeaders = {
        'Authorization': 'Basic WkJvRzJzMkpSWlNEX0ZvUVpIMlpkZzppZTJaSk4zdG1lcnRYaXlhUmRBZXQ5ZjZkWGZnTDlJWA==',
        "Content-Type": "application/json"
    }
    myobj = {
        'headers': requestHeaders,
        'queryParameters': queryParams
    }

    x = requests.post(url, params=queryParams, headers=requestHeaders)
    dict_str = x.content.decode("UTF-8")
    mydata = ast.literal_eval(dict_str)
    ACCESS_TOKEN = mydata['access_token']
    saveAccessKey(dynamo, ACCESS_TOKEN)
    return

def createMeeting(something):
    ACCESS_TOKEN = getAccessKey(dynamo)
    url = 'https://api.zoom.us/v2/users/me/meetings'
    body = {
      "topic": "Some Topic",
      "type": 8,
      "start_time": "2020-03-30T12:02:00Z",
      "password": "hello",
      "agenda": "studying",
      "recurrence": {
        "type": 2,
        "repeat_interval": 1,
        "weekly_days": 3,
        "end_times": 12,
      },
      "settings": {
        "host_video": True,
        "participant_video": True,
        "join_before_host": True,
        "mute_upon_entry": True,
        "approval_type": 0,
        "registration_type": 3,
        "audio": "both",
        "auto_recording": "none",
      }
    }
    requestHeaders = {
        'Authorization': f'Bearer {ACCESS_TOKEN}',
        "Content-Type": "application/json"

