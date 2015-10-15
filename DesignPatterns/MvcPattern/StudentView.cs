using System;

namespace DesignPatterns.MvcPattern
{
    public class StudentView
    {
        public void ShowStudentDetails(string studentName, int studentId)
        {
            Console.WriteLine("Student: ");
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Id: " + studentId + Environment.NewLine);
        }
    }
}
