using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.DataAccessObjectPattern
{
    public class StudentDaoImplementation : IStudentDao
    {
        //list is working as a database
        List<StudentDao> _students;

        public StudentDaoImplementation()
        {
            _students = new List<StudentDao>();
            StudentDao student1 = new StudentDao("Robert", 1);
            StudentDao student2 = new StudentDao("John", 2);
            _students.Add(student1);
            _students.Add(student2);
        }

        public IStudentDao StudentDao
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        //Override
        public void DeleteStudent(StudentDao student)
        {
            _students.Remove(student);
            Console.WriteLine("StudentDao: Id No " + student.Id + ", deleted from database" + Environment.NewLine);
        }

        //retrive list of students from the database
        //Override
        public List<StudentDao> GetAllStudents()
        {
            return _students;
        }

        //Override
        public StudentDao GetStudent(int id)
        {
            return _students.FirstOrDefault(s => s.Id.Equals(id));
        }

        //Override
        public void UpdateStudent(StudentDao student)
        {
            _students[student.Id].Name = student.Name;
            Console.WriteLine("StudentDao: Roll No " + student.Id + ", updated in the database" + Environment.NewLine);
        }
    }
}
