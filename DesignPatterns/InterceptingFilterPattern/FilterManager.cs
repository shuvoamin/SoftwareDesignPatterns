using DesignPatterns.Interfaces;

namespace DesignPatterns.InterceptingFilterPattern
{
    public class FilterManager
    {
        FilterChain _filterChain;

        public FilterManager(Target target)
        {
            _filterChain = new FilterChain();
            _filterChain.SetTarget(target);
        }

        public FilterChain FilterChain
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void SetFilter(IFilter filter)
        {
            _filterChain.AddFilter(filter);
        }

        public void FilterRequest(string request)
        {
            _filterChain.Execute(request);
        }
    }
}
