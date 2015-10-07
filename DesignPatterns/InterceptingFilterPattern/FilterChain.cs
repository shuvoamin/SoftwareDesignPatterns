using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.InterceptingFilterPattern
{
    public class FilterChain
    {
        private List<IFilter> _filters = new List<IFilter>();
        private Target _target;

        public Target Target
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DesignPatterns.Interfaces.IFilter IFilter
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void AddFilter(IFilter filter)
        {
            _filters.Add(filter);
        }

        public void Execute(string request)
        {
            foreach (IFilter filter in _filters)
            {
                filter.Execute(request);
            }

            _target.Execute(request);
        }

        public void SetTarget(Target target)
        {
            _target = target;
        }
    }
}
