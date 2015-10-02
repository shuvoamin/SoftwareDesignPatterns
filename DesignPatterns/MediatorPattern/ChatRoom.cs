using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
