using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern
{
    public class Context
    {
        private IState _state;

        public Context()
        {
            _state = null;
        }

        public IState State
        {
            get { return _state; }
            set { _state = value; }
        }
    }
}
