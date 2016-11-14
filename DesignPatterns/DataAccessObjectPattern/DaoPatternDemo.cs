using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

namespace DesignPatterns.DataAccessObjectPattern
{
    public class DaoPatternDemo
    {
        public IStudentDao StudentDao
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    
        public static void Output()
        {
            IStudentDao studentDao = new StudentDaoImplementation();

            //print all students
            foreach (var student in studentDao.GetAllStudents())
            {
                Trace.WriteLine("Student: [RollNo : " + student.Id + ", Name : " + student.Name + " ]" + Environment.NewLine);
            }


            //update student
            var studentUpdate = studentDao.GetAllStudents()[0];
            studentUpdate.Name = "Michael";
            studentDao.UpdateStudent(studentUpdate);

            //get the student
            studentDao.GetStudent(0);
            Trace.WriteLine("Student: [RollNo : " + studentUpdate.Id + ", Name : " + studentUpdate.Name + " ]" + Environment.NewLine);
        }
    }
}
