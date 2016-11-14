namespace DesignPatterns.InterceptingFilterPattern
{
    public class InterceptingFilterPatternDemo
    {
        public ClientFilter ClientFilter
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
    
        public static void Output()
        {
            var filterManager = new FilterManager(new Target());
            filterManager.SetFilter(new AuthenticationFilter());
            filterManager.SetFilter(new DebugFilter());

            var client = new ClientFilter();
            client.SetFilterManager(filterManager);
            client.SendRequest("HOME");
        }
    }
}
