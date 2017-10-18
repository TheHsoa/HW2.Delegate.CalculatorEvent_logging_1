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
        public UInt64 Id { get; set; }

        public string JuridicalPerson { get; set; }

        private double Cost { get; set; }

        public Order(UInt64 id, string jurPerson)
        {
            Id = id;
            JuridicalPerson = jurPerson;
            Cost = 0;
        }

        public void AddPosition(OrderType type)
        {
            Cost += OrderTypeCostMapper.GetCost[type];
        }
    }
}
