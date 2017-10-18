using System.Collections.Generic;

namespace Event_logging_1
{
    public static class OrderTypeCostMapper
    {
        public static Dictionary<OrderType, double> GetCost =
            new Dictionary<OrderType, double>
            {
                { OrderType.AdsInOtherCompany, 2.56 },
                { OrderType.AmountOfClicks, 10.0 },
                { OrderType.Banner, 7.32 },
                { OrderType.CommentToTheCompany, 123.12 },
                { OrderType.PriorityInTheRubric, 48.33 }
            };
    }
}
