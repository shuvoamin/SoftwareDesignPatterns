using System;
using System.Diagnostics;

namespace DesignPatterns.FrontControllerPattern
{
    public class HomeView
    {
        public void Show()
        {
            Trace.WriteLine("Displaying Home Page" + Environment.NewLine);
        }
    }
}
