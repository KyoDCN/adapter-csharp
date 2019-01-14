using OandaV20.Models.OrderModel.Definitions;
using OandaV20.Models.PricingModel;

namespace OandaV20.Models.OrderModel.Definitions
{
    public class DynamicOrderState
    {
        public OrderID Id;
        public PriceValue TrailingStopValue;
        public PriceValue TriggerDistance;
        public bool IsTriggerDistanceExact;

        public DynamicOrderState()
        {
            this.Id = new OrderID();
            this.TrailingStopValue = new PriceValue();
            this.TriggerDistance = new PriceValue();
        }
        public DynamicOrderState(OrderID id, PriceValue trailingStopValue, PriceValue triggerDistance, bool isTriggerDistanceExact)
        {
            this.Id = id;
            this.TrailingStopValue = trailingStopValue;
            this.TriggerDistance = triggerDistance;
            this.IsTriggerDistanceExact = isTriggerDistanceExact;
        }
    }
}