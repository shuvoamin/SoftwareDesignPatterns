using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public String ToString()
        {
            return "Stop State";
        }
    }
}
