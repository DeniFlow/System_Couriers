using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Couriers
{
    public class Company
    {
        Random rnd = new Random();
        public const double PricePerDistance = 100;

        public const int FootCourierSpeed = 2;
        public const int FootCourierCapacity = 15;

        public const int MobileCourierSpeed = 4;
        public const int MobileCourierCapacity = 25;


        public static List<Courier> footCouriers = new();
        public static List<Courier> mobileCouriers = new();
        public static List<Orders> orders = new();
        public static List<Orders> orders2 = new();
        public static List<Courier> allCouriers = new();
        public static void PlanningOrders()
        {
            double min_distance = 100000000;
            for (int i = 0, j = 0, ind = 0; j < Company.allCouriers.Count; i++)
            {
                double distance = Math.Round(Math.Pow(Math.Pow(orders[i].FromLocation_X - allCouriers[j].Location_X, 2)
                + Math.Pow(orders[i].FromLocation_Y - allCouriers[j].Location_Y, 2), 0.5), 2);
                if (distance < min_distance)
                {
                    min_distance = distance;
                    ind = i;
                }
                if (i == Company.orders.Count - 1)
                {
                    Console.WriteLine($"Курьер {j + 1}.Скорость курьера:{allCouriers[j].Speed} выполняет заказ {orders[ind].GetInfo()}");
                    orders.RemoveAt(ind);
                    j++;
                    i = -1;
                    ind = 0;
                }
            }

        }
       
        public static void Profit()
        {
            double sum = 0;
            for (int i = 0; i < orders2.Count; i++)
            {
                sum += PricePerDistance * orders2[i].GetDistance();
            }
            Console.WriteLine($" Выручка за сегодня:{Math.Round(sum)} руб");
        }
    }
}
