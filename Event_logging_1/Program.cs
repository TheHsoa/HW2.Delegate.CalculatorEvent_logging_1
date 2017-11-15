using System;

namespace Event_logging_1
{
    internal class Program
    {
        private static void Main()
        {
            var someOrder = new Order(1, "McDonalds");

            someOrder.AddOrderPositionEvent += (sender, e) => Console.WriteLine($"Added new position {e.OrderType} to order with id = {((Order)sender).Id} and JuridicalPerson = {((Order)sender).JuridicalPerson}");

            someOrder.AddPosition(OrderType.Banner);

            Console.ReadKey();
        }
    }
}
