using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interfaces
{
    public interface IItem
    {
        string name();
        IPacking packing();
        float price();
    }
}
