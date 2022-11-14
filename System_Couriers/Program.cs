using System;


namespace System_Couriers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество пеших курьеров");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0;i < N; i++)
            {
                Company.footCouriers.Add(FootCourier.CreateFootCourier());
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(Company.footCouriers[i].GetInfo());
            }
            Console.WriteLine("Введите количество курьеров на самокате");
            int M = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                Company.mobileCouriers.Add(MobileCourier.CreateMobileCourier());
            }
            for (int i = 0; i < M; i++)
            {
                Console.WriteLine(Company.mobileCouriers[i].GetInfo());
            }
            Company.allCouriers = Company.mobileCouriers.Concat(Company.footCouriers).ToList();
            for (int i = 0; i < Company.orders.Count; i++)
            {
                Company.orders2.Add(Company.orders[i]);
            }
            


            Console.WriteLine("Сколько заказов запланировано на сегодня?");
            int K = int.Parse(Console.ReadLine());
            for (int i = 0;i < K; i++)
            {
                Company.orders.Add(Orders.CreateOrders());
            }
            for (int i = 0; i < K; i++)
            {
                Console.WriteLine(Company.orders[i].GetInfo());
            }

            for (int i = 0; i < Company.orders.Count; i++)
            {
                Company.orders2.Add(Company.orders[i]);
            }

            Console.WriteLine("//////////////////");
            Company.PlanningOrders();

            Console.WriteLine("//////////////////");
            Company.Profit();
            Console.WriteLine("//////////////////");

            

        }
    }
}