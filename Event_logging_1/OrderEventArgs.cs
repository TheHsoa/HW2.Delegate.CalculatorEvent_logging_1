using System;

namespace Event_logging_1
{
    public class OrderEventArgs : EventArgs
    {
        public OrderEventArgs(OrderType orderType)
        {
            OrderType = orderType;
        }

        public OrderType OrderType { get; private set; }
    }
}
