using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.StatePattern
{
    public class StartState : IState
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
            Console.WriteLine("Player is in state" + Environment.NewLine);
            context.State = this;
        }

        public override string ToString()
        {
            return "Start State";
        }
    }
}
