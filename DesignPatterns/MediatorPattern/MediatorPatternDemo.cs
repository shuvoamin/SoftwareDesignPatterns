namespace DesignPatterns.MediatorPattern
{
    public class MediatorPatternDemo
    {
        public UserMediator UserMediator
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
            var robert = new UserMediator("Robert");
            var john = new UserMediator("John");

            robert.SendMessage("Hi! John!");
            john.SendMessage("Hello! Robert!");
        }
    }
}
