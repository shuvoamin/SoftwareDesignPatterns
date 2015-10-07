using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            set
            {
            }
        }
    
        public static void Output()
        {
            FilterManager filterManager = new FilterManager(new Target());
            filterManager.SetFilter(new AuthenticationFilter());
            filterManager.SetFilter(new DebugFilter());

            ClientFilter client = new ClientFilter();
            client.SetFilterManager(filterManager);
            client.SendRequest("HOME");
        }
    }
}
