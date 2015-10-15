using System;
using System.Collections.Generic;

namespace DesignPatterns.TransferObjectPattern
{
    public class StudentBusinessObject
    {
        //list is working as a database
        List<StudentTransferObject> _students;

        public StudentBusinessObject()
        {
            _students = new List<StudentTransferObject>();
            StudentTransferObject student1 = new StudentTransferObject("Robert", 0);
            StudentTransferObject student2 = new StudentTransferObject("John", 1);
            _students.Add(student1);
            _students.Add(student2);
        }

        public StudentTransferObject StudentTransferObject
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public void DeleteStudent(StudentTransferObject student)
        {
            _students.Remove(student);
            Console.WriteLine("Student: Roll No " + student.Id + ", deleted from database" + Environment.NewLine);
        }

        //retrive list of students from the database
        public List<StudentTransferObject> GetAllStudents()
        {
            return _students;
        }

        public StudentTransferObject GetStudent(int id)
        {
            return _students[id];
        }

        public void UpdateStudent(StudentTransferObject student)
        {
            _students[student.Id].Name = student.Name;
            Console.WriteLine("Student: Roll No " + student.Id + ", updated in the database" + Environment.NewLine);
        }
    }
}
