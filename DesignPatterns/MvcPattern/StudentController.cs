namespace DesignPatterns.MvcPattern
{
    public class StudentController
    {
        private readonly Student _model;
        private readonly StudentView _view;

        public StudentController(Student model, StudentView view)
        {
            _model = model;
            _view = view;
        }

        public Student Student
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public StudentView StudentView
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public void UpdateView(string name, int id)
        {
            _model.Name = name;
            _model.Id = id;

            _view.ShowStudentDetails(_model.Name, _model.Id);
        }
    }
}
