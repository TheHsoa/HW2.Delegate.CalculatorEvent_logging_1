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

    public delegate void AddPositionEventHandler(Order sender, OrderEventArgs e);

    public class Order
    {
        public event AddPositionEventHandler AddOrderPositionEvent;

        protected virtual void OnRaiseAddPositionEvent(OrderEventArgs e)
        {
            AddOrderPositionEvent?.Invoke(this, e);
        }

        public ulong Id { get; set; }

        public string JuridicalPerson { get; set; }

        private double Cost { get; set; }

        public Order(ulong id, string jurPerson)
        {
            Id = id;
            JuridicalPerson = jurPerson;
            Cost = 0;
        }

        public void AddPosition(OrderType type)
        {
            Cost += OrderTypeCostMapper.GetCost[type];

            OnRaiseAddPositionEvent(new OrderEventArgs(type));
        }
    }
}
