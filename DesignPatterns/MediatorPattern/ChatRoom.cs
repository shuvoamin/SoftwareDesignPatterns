using System;

namespace DesignPatterns.MediatorPattern
{
    public class ChatRoom
    {
        public static void ShowMessage(UserMediator user, String message)
        {
            Console.WriteLine(DateTime.Now.ToString() + " [" + user.Name + "] : " + message + Environment.NewLine);
        }
    }
}
