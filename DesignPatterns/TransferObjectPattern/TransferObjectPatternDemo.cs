using System;

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
            set
            {
            }
        }
    
        public static void Output()
        {
            var studentBusinessObject = new StudentBusinessObject();

            //print all students
            foreach (var student in studentBusinessObject.GetAllStudents())
            {
                Console.WriteLine("Student: [RollNo : " + student.Id + ", Name : " + student.Name + " ]" + Environment.NewLine);
            }

            //update student
            var updateStudent = studentBusinessObject.GetAllStudents()[0];
            updateStudent.Name = "Michael";
            studentBusinessObject.UpdateStudent(updateStudent);

            //get the student
            updateStudent = studentBusinessObject.GetStudent(0);
            Console.WriteLine("Student: [RollNo : " + updateStudent.Id + ", Name : " + updateStudent.Name + " ]" + Environment.NewLine);
        }
    }
}
