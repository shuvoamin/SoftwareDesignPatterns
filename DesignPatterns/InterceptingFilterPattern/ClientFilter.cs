namespace DesignPatterns.InterceptingFilterPattern
{
    public class ClientFilter
    {
        FilterManager _filterManager;

        public FilterManager FilterManager
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public void SetFilterManager(FilterManager filterManager)
        {
            _filterManager = filterManager;
        }

        public void SendRequest(string request)
        {
            _filterManager.FilterRequest(request);
        }
    }
}
