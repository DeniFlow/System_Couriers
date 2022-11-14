using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Couriers
{
   
    public class FootCourier : Courier
    {
        Random rnd = new Random();
        public FootCourier()
        {
            Speed = Company.FootCourierSpeed;
            Capacity = Company.FootCourierCapacity;
            Location_X = rnd.Next(20);
            Location_Y = rnd.Next(20);
        }
        public static Courier CreateFootCourier()
        {
            FootCourier footCourier = new FootCourier();
            return footCourier;
        }
        
    }
}
