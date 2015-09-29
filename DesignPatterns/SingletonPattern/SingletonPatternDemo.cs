using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    public class SingletonPatternDemo
    {
        public SingleObject SingleObject
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
            //illegal construct
            //Compile Time Error: The constructor SingleObject() is not visible
            //SingleObject object = new SingleObject();

            //Get the only object available
            SingleObject singleObject = SingleObject.getInstance();

            //show the message
            singleObject.showMessage();
        }
    }
}
