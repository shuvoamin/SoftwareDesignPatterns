using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.StatePattern
{
    public class StopState : IState
    {
        public DesignPatterns.Interfaces.IState IState
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in stop state" + Environment.NewLine);
            context.State = this;
        }

        public override string ToString()
        {
            return "Stop State";
        }
    }
}
