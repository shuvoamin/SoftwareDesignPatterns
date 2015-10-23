namespace DesignPatterns.TransferObjectPattern
{
    public class StudentTransferObject
    {
        public StudentTransferObject(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; set; }

        public int Id { get; set; }
    }
}
