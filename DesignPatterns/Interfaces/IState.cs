using DesignPatterns.StatePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interfaces
{
    public interface IState
    {
        void DoAction(Context context);
    }
}
