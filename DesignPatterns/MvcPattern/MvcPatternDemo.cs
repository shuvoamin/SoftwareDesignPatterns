using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MvcPattern
{
    public class MvcPatternDemo
    {
        public StudentController StudentController
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
            //fetch student record based on his roll no from the database
            Student model = RetriveStudentFromDatabase();

            //Create a view : to write student details on console
            StudentView view = new StudentView();

            StudentController controller = new StudentController(model, view);

            //update model data
            controller.UpdateView("John => Name updated (previous name Robert)", 2);
        }

        private static Student RetriveStudentFromDatabase()
        {
            Student student = new Student();
            student.Name = "Robert";
            student.Id = 2;
            return student;
        }
    }
}
