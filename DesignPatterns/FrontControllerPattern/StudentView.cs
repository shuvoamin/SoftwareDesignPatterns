using System;
using System.Diagnostics;

namespace DesignPatterns.FrontControllerPattern
{
    public class StudentView
    {
        public void Show()
        {
            Trace.WriteLine("Displaying Student Page" + Environment.NewLine);
        }
    }
}
