using OandaV20.Models.TransactionModel.Definitions;
using System.Collections.Generic;

namespace OandaV20.Models.Primitives
{
    public class InstrumentRoot
    {
        public List<Instrument> Instruments { get; set; }
        public TransactionID LastTransactionID { get; set; }
    }

    public class Instrument
    {
        public InstrumentName Name;
        public InstrumentType Type;
        public string DisplayName;
        public int PipLocation;
        public int DisplayPrecision;
        public int TradeUnitsPrecision;
        public double MinimumTradeSize;
        public double MaximumTrailingStopDistance;
        public double MinimumTrailingStopDistance;
        public double MaximumPositionSize;
        public double MaximumOrderUnits;
        public double MarginRate;
        public InstrumentCommission Commission;

        public Instrument()
        {
            this.Name = new InstrumentName();
            this.Type = new InstrumentType();
            this.Commission = new InstrumentCommission();
        }
        public Instrument(
            InstrumentName name, 
            InstrumentType type, 
            string displayName, 
            int pipLocation, 
            int displayPrecision, 
            int tradeUnitsPrecision, 
            double minimumTradeSize, 
            double maximumTrailingStopDistance, 
            double minimumTrailingStopDistance, 
            double maximumPositionSize, 
            double maximumOrderUnits, 
            double marginRate, 
            InstrumentCommission commission
        ) {
            this.Name = name;
            this.Type = type;
            this.DisplayName = displayName;
            this.PipLocation = pipLocation;
            this.DisplayPrecision = displayPrecision;
            this.TradeUnitsPrecision = tradeUnitsPrecision;
            this.MinimumTradeSize = minimumTradeSize;
            this.MaximumTrailingStopDistance = maximumTrailingStopDistance;
            this.MinimumTrailingStopDistance = minimumTrailingStopDistance;
            this.MaximumPositionSize = maximumPositionSize;
            this.MaximumOrderUnits = maximumOrderUnits;
            this.MarginRate = marginRate;
            this.Commission = commission;
        }
    }
}