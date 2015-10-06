using DesignPatterns.DataAccessObjectPattern;
using DesignPatterns.MvcPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interfaces
{
    public interface IStudentDao
    {  
        List<StudentDao> GetAllStudents();
        StudentDao GetStudent(int id);
        void UpdateStudent(StudentDao student);
        void DeleteStudent(StudentDao student);
    }
}
