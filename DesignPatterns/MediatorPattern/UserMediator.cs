using System;

namespace DesignPatterns.MediatorPattern
{
    public class UserMediator
    {
        public string Name { get; set; }

        public ChatRoom ChatRoom
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public UserMediator(string name)
        {
            Name = name;
        }

        public void SendMessage(string message)
        {
            ChatRoom.ShowMessage(this, message);
        }
    }
}
