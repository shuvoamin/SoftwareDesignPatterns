using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DataAccessObjectPattern
{
    public class DaoPatternDemo
    {
        public DesignPatterns.Interfaces.IStudentDao IStudentDao
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public static void Output()
        {
            IStudentDao studentDao = new StudentDaoImplementation();

            //print all students
            foreach (StudentDao student in studentDao.GetAllStudents())
            {
                Console.WriteLine("Student: [RollNo : " + student.Id + ", Name : " + student.Name + " ]" + Environment.NewLine);
            }


            //update student
            StudentDao studentUpdate = studentDao.GetAllStudents()[0];
            studentUpdate.Name = "Michael";
            studentDao.UpdateStudent(studentUpdate);

            //get the student
            studentDao.GetStudent(0);
            Console.WriteLine("Student: [RollNo : " + studentUpdate.Id + ", Name : " + studentUpdate.Name + " ]" + Environment.NewLine);
        }
    }
}
