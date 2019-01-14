using Newtonsoft.Json;
using OandaV20.Models.OrderModel.Requests;
using OandaV20.Models.Primitives;
using System.Collections.Generic;

namespace OandaV20.Models.TransactionModel.Definitions
{
    public class PositionFinancing
    {
        public InstrumentName Instrument;
        public AccountUnits Financing;
        public List<OpenTradeFinancing> OpenTradeFinancings;

        public PositionFinancing()
        {
            this.Instrument = new InstrumentName();
            this.Financing = new AccountUnits();
            this.OpenTradeFinancings = new List<OpenTradeFinancing>();
        }
        public PositionFinancing(
            InstrumentName instrument, 
            AccountUnits financing, 
            List<OpenTradeFinancing> openTradeFinancings
        ) {
            this.Instrument = instrument;
            this.Financing = financing;
            this.OpenTradeFinancings = openTradeFinancings;
        }
    }
}
