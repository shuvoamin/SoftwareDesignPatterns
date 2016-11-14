using System;
using System.Diagnostics;

namespace DesignPatterns.MediatorPattern
{
    public class ChatRoom
    {
        public static void ShowMessage(UserMediator user, string message)
        {
            Trace.WriteLine(DateTime.Now + " [" + user.Name + "] : " + message + Environment.NewLine);
        }
    }
}
