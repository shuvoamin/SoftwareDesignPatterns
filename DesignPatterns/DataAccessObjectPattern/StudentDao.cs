namespace DesignPatterns.DataAccessObjectPattern
{
    public class StudentDao
    {
        private string _name;
        private int _id;

        public StudentDao(string name, int id)
        {
            _name = name;
            _id = id;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Interfaces.IStudentDao IStudentDao
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
