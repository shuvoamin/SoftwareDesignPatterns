using DesignPatterns.Interfaces;

namespace DesignPatterns.DataAccessObjectPattern
{
    public class StudentDao
    {
        public StudentDao(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; set; }

        public int Id { get; set; }

        public IStudentDao StudentDaoIDao
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
