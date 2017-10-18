using System;
using System.Security.Cryptography.X509Certificates;

namespace Event_logging_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var someOrder = new Order(1, "McDonalds");

            someOrder.AddPosition(OrderType.Banner);
        }
    }
}
