using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
