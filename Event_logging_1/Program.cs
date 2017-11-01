namespace Event_logging_1
{
    internal class Program
    {
        private static void Main()
        {
            var someOrder = new Order(1, "McDonalds");

            var orderSubscriber = new OrderEventSubscriber(someOrder);

            someOrder.AddPosition(OrderType.Banner);

            System.Console.ReadKey();
        }
    }
}
