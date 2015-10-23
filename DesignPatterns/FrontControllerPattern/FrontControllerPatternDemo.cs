namespace DesignPatterns.FrontControllerPattern
{
    public class FrontControllerPatternDemo
    {
        public FrontController FrontController
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    
        public static void Output()
        {
            var frontController = new FrontController();
            frontController.DispatchRequest("HOME");
            frontController.DispatchRequest("STUDENT");
        }
    }
}
