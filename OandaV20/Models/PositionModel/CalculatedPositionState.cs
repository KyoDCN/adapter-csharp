using OandaV20.Models.Primitives;

namespace OandaV20.Models.PositionModel
{
    public class CalculatedPositionState
    {
        public InstrumentName Instrument;
        public AccountUnits NetUnrealizedPL;
        public AccountUnits LongUnrealizedPL;
        public AccountUnits ShortUnrealizedPL;
        public AccountUnits MarginUsed;

        public CalculatedPositionState()
        {
            this.Instrument = new InstrumentName();
            this.NetUnrealizedPL = new AccountUnits();
            this.LongUnrealizedPL = new AccountUnits();
            this.ShortUnrealizedPL = new AccountUnits();
            this.MarginUsed = new AccountUnits();
        }

        public CalculatedPositionState(InstrumentName instrument, AccountUnits netUnrealizedPL, AccountUnits longUnrealizedPL, AccountUnits shortUnrealizedPL, AccountUnits marginUsed)
        {
            this.Instrument = instrument;
            this.NetUnrealizedPL = netUnrealizedPL;
            this.LongUnrealizedPL = longUnrealizedPL;
            this.ShortUnrealizedPL = shortUnrealizedPL;
            this.MarginUsed = marginUsed;
        }
    }
}
