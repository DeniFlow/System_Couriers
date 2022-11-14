using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace System_Couriers
{
    public class MobileCourier : Courier
    {
        Random rnd = new Random();
        public MobileCourier()
        {
            Speed = Company.MobileCourierSpeed;
            Capacity = Company.MobileCourierCapacity;
            Location_X = rnd.Next(20);
            Location_Y = rnd.Next(20);
        }
        public static Courier CreateMobileCourier()
        {
            MobileCourier mobileCourier = new MobileCourier();
            return mobileCourier;
        }
        
    }
}
