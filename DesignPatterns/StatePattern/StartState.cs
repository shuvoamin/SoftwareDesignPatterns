using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

namespace DesignPatterns.StatePattern
{
    public class StartState : IState
    {
        public IState State
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    
        public void DoAction(Context context)
        {
            Trace.WriteLine("Player is in state" + Environment.NewLine);
            context.State = this;
        }

        public override string ToString()
        {
            return "Start State";
        }
    }
}
