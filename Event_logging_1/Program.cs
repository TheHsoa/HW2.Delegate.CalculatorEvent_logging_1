namespace Event_logging_1
{
    internal class Program
    {
        private static void Main()
        {
            var someOrder = new Order(1, "McDonalds");

            someOrder.SubscribeOnAddPosition((x, y) => System.Console.WriteLine($"Added new position {y} to order with id = {x.Id} and JuridicalPerson = {x.JuridicalPerson}"));
            
            someOrder.AddPosition(OrderType.Banner);

            System.Console.ReadKey();
        }
    }
}
