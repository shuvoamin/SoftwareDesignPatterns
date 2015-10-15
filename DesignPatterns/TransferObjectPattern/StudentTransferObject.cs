namespace DesignPatterns.TransferObjectPattern
{
    public class StudentTransferObject
    {
        private string _name;
        private int _id;

        public StudentTransferObject(string name, int id)
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
    }
}
