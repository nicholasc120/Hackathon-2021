using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchro_Connect.Model
{
    public class Message
    {
        public String message;
        public String sender;

        public Message(String message, String sender)
        {
            this.message = message;
            this.sender = sender;
        }
    }
}
