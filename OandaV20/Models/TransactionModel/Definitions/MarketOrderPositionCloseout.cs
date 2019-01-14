using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Requests;
using OandaV20.Models.Primitives;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public class MarketOrderPositionCloseout
    {
        public InstrumentName Instrument;
        public string Units;

        public MarketOrderPositionCloseout()
        {
            this.Instrument = new InstrumentName();
        }
        public MarketOrderPositionCloseout(InstrumentName instrument, string units)
        {
            this.Instrument = instrument;
            this.Units = units;
        }
    }
}
