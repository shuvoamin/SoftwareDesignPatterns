namespace DesignPatterns.SingletonPattern
{
    public class SingletonPatternDemo
    {
        public SingleObject SingleObject
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
            //illegal construct
            //Compile Time Error: The constructor SingleObject() is not visible
            //SingleObject object = new SingleObject();

            //Get the only object available
            var singleObject = SingleObject.getInstance();

            //show the message
            singleObject.showMessage();
        }
    }
}
