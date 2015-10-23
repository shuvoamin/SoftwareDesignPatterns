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
        }
    
        public static void Output()
        {
            //fetch student record based on his roll no from the database
            var model = RetriveStudentFromDatabase();

            //Create a view : to write student details on console
            var view = new StudentView();

            var controller = new StudentController(model, view);

            //update model data
            controller.UpdateView("John => Name updated (previous name Robert)", 2);
        }

        private static Student RetriveStudentFromDatabase()
        {
            var student = new Student();
            student.Name = "Robert";
            student.Id = 2;
            return student;
        }
    }
}
