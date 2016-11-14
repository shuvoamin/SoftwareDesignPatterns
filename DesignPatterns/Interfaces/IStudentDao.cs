using DesignPatterns.DataAccessObjectPattern;
using System.Collections.Generic;

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
