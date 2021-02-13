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
        public User sender;

        public Message(String message, User sender)
        {
            this.message = message;
            this.sender = sender;
        }
    }
}
