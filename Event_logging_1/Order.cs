using System;

namespace Event_logging_1
{
    public enum OrderType
    {
        Banner = 0,
        PriorityInTheRubric,
        CommentToTheCompany,
        AmountOfClicks,
        AdsInOtherCompany,
    }

    public class Order
    {
        private event Action<Order, OrderType> OnAdd = (x, y) => {};

        public ulong Id { get; set; }

        public string JuridicalPerson { get; set; }

        private double Cost { get; set; }

        public Order(ulong id, string jurPerson)
        {
            Id = id;
            JuridicalPerson = jurPerson;
            Cost = 0;
        }

        public void SubscribeOnAddPosition(Action<Order, OrderType> addAction)
        {
            OnAdd += addAction;
        }

        public void AddPosition(OrderType type)
        {
            Cost += OrderTypeCostMapper.GetCost[type];
            OnAdd(this, type);
        }
    }
}
