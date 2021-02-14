using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchro_Connect.Model
{
    public class DiscussionBoard
    {
        public List<Message> History { get; set; }
        
        public DiscussionBoard()
        {
            History = new List<Message>();
        }
        public void SendMessage(String message, User sender)
        {
            Message theMessage = new Message(message, sender.DisplayName);
            History.Add(theMessage);
            //update database
        }

        public List<String> GetListOfMessages()
        {
            List<String> log = new List<String>();
            foreach (Message m in History)
            {
                String message = m.sender + ": " + m.message;
                log.Add(message);
            }

            return log;
        }
    }
}
