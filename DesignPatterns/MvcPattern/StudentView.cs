using System;
using System.Diagnostics;

namespace DesignPatterns.MvcPattern
{
    public class StudentView
    {
        public void ShowStudentDetails(string studentName, int studentId)
        {
            Trace.WriteLine("Student: ");
            Trace.WriteLine("Name: " + studentName);
            Trace.WriteLine("Id: " + studentId + Environment.NewLine);
        }
    }
}
