using System;
using System.Diagnostics;

namespace DesignPatterns.TransferObjectPattern
{
    public class TransferObjectPatternDemo
    {
        public StudentBusinessObject StudentBusinessObject
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    
        public static void Output()
        {
            var studentBusinessObject = new StudentBusinessObject();

            //print all students
            foreach (var student in studentBusinessObject.GetAllStudents())
            {
                Trace.WriteLine("Student: [RollNo : " + student.Id + ", Name : " + student.Name + " ]" + Environment.NewLine);
            }

            //update student
            var updateStudent = studentBusinessObject.GetAllStudents()[0];
            updateStudent.Name = "Michael";
            studentBusinessObject.UpdateStudent(updateStudent);

            //get the student
            updateStudent = studentBusinessObject.GetStudent(0);
            Trace.WriteLine("Student: [RollNo : " + updateStudent.Id + ", Name : " + updateStudent.Name + " ]" + Environment.NewLine);
        }
    }
}
