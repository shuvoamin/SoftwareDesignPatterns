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
        }
    
        public static void Output()
        {
            //illegal construct
            //Compile Time Error: The constructor SingleObject() is not visible
            //SingleObject object = new SingleObject();

            //Get the only object available
            var singleObject = SingleObject.GetInstance();

            //show the message
            singleObject.ShowMessage();
        }
    }
}
