using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Couriers
{
    public class Courier
    {
        public  int Speed {get; protected set;}
        public int Capacity { get; protected set;}
        public int Location_X {get; protected set;}
        public int Location_Y { get; protected set; }
        public string InitialLocation()
        {
            return "(" + Location_X.ToString() + "," + Location_Y.ToString()+")";
        }
        public string GetInfo()
        {
            return string.Format(
                " Скорость: {0} |" +
                " Грузоподъёмность {1} |" +
            " Находится в {2}",
                Speed, Capacity, InitialLocation());
        }
       
    }
}
