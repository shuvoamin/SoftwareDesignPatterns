using DesignPatterns.Interfaces;
using System.Collections.Generic;

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

        public IFilter IFilter
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
