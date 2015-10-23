namespace DesignPatterns.ServiceLocatorPattern
{
    public class ServiceLocatorPatternDemo
    {
        public ServiceLocator ServiceLocator
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
            var service = ServiceLocator.GetService("SERVICE1");
            service.Execute();
            service = ServiceLocator.GetService("SERVICE2");
            service.Execute();
            service = ServiceLocator.GetService("SERVICE1");
            service.Execute();
            service = ServiceLocator.GetService("SERVICE2");
            service.Execute();	
        }
    }
}
