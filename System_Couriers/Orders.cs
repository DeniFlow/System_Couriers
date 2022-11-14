using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace System_Couriers
{

    public class Orders
    {
        Random rnd = new Random();
       
        
        public int FromLocation_X { get; protected set; }
        public int FromLocation_Y { get; protected set; }
        public int ToLocation_X { get; protected set; }
        public int ToLocation_Y { get; protected set; }
        public Orders()
        {
            FromLocation_X = rnd.Next(20);
            FromLocation_Y = rnd.Next(20);
            ToLocation_X = rnd.Next(20);
            ToLocation_Y = rnd.Next(20);
        }
        public static Orders CreateOrders()
        {
            Orders Order = new Orders();
            return Order;
        }
        public string FromLocation()
        {
            return "(" + FromLocation_X.ToString() + "," + FromLocation_Y.ToString() + ")";
        }
        public string ToLocation()
        {
            return "(" + ToLocation_X.ToString() + "," + ToLocation_Y.ToString() + ")";
        }
        public double GetDistance()
        {
            return Math.Round(Math.Pow(Math.Pow(FromLocation_X - ToLocation_X, 2)
                + Math.Pow(FromLocation_Y - ToLocation_Y, 2), 0.5), 2);
        }

        public string GetInfo()
        {
            return string.Format(
                " Находится в: {0} |" +
                " Отнести в точку {1} |"+
                "Дистанция (км) {2}"
            , FromLocation(), ToLocation(),GetDistance());
                
        }
        
    }
}    

    


