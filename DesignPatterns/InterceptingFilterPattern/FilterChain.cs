﻿using DesignPatterns.Interfaces;
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
        }

        public IFilter Filter
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public void AddFilter(IFilter filter)
        {
            _filters.Add(filter);
        }

        public void Execute(string request)
        {
            foreach (var filter in _filters)
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
