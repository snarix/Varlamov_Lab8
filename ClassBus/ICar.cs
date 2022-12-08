using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBus
{
    public interface ICar
    {
        public int Capacity { get;}
        public int Lenght { get;}
        public int CountSitting { get;}

        string Drive(ICar car);
    }
}
