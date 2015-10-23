using System;

namespace DesignPatterns.MediatorPattern
{
    public class UserMediator
    {
        private string _name;

        public string Name 
        { 
            get { return _name; }
            set { _name = value; } 
        }

        public ChatRoom ChatRoom
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public UserMediator(string name)
        {
            _name = name;
        }

        public void SendMessage(string message)
        {
            ChatRoom.ShowMessage(this, message);
        }
    }
}
