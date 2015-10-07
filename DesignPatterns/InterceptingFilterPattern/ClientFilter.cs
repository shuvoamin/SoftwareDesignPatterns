using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            set
            {
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
