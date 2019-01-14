using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Requests;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public class MarketOrderMarginCloseout
    {
        public readonly MarketOrderMarginCloseoutReason Value;

        // CONSTRUCTORS
        public MarketOrderMarginCloseout()
        {
            this.Value = new MarketOrderMarginCloseoutReason();
        }
        public MarketOrderMarginCloseout(MarketOrderMarginCloseoutReason value)
        {
            this.Value = value;
        }

        // IMPLICIT OPERATORS
        public static implicit operator MarketOrderMarginCloseout(MarketOrderMarginCloseoutReason value)
        {
            return new MarketOrderMarginCloseout(value);
        }
        public static implicit operator MarketOrderMarginCloseoutReason(MarketOrderMarginCloseout marketOrderMarginCloseout)
        {
            return marketOrderMarginCloseout.Value;
        }
    }
}
