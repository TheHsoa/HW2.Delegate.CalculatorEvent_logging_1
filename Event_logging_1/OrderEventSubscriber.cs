using System;
namespace Event_logging_1
{
    public class OrderEventSubscriber
    {
        public OrderEventSubscriber(Order order)
        {
            order.AddOrderPositionEvent += HandleAddOrderPositionEvent;
        }

        private static void HandleAddOrderPositionEvent(Order sender, OrderEventArgs e)
        {
            Console.WriteLine($"Added new position {e.OrderType} to order with id = {sender.Id} and JuridicalPerson = {sender.JuridicalPerson}");
        }
    }
}
