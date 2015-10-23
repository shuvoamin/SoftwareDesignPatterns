using System;

namespace DesignPatterns.MediatorPattern
{
    public class ChatRoom
    {
        public static void ShowMessage(UserMediator user, string message)
        {
            Console.WriteLine(DateTime.Now + " [" + user.Name + "] : " + message + Environment.NewLine);
        }
    }
}
