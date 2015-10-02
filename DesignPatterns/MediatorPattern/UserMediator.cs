using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern
{
    public class UserMediator
    {
        private String _name;

        public String Name 
        { 
            get { return _name; }
            set { _name = value; } 
        }

        public ChatRoom ChatRoom
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public UserMediator(String name)
        {
            _name = name;
        }

        public void SendMessage(String message)
        {
            ChatRoom.ShowMessage(this, message);
        }
    }
}
