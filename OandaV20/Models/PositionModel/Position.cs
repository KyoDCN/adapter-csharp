using OandaV20.Models.Primitives;

namespace OandaV20.Models.PositionModel
{
    public class Position
    {
        public InstrumentName Instrument;
        public AccountUnits PL;
        public AccountUnits UnrealizedPL;
        public AccountUnits MarginUsed;
        public AccountUnits ResettablePL;
        public AccountUnits Financing;
        public AccountUnits Commission;
        public AccountUnits GuaranteedExecutionFees;
        public PositionSide Long;
        public PositionSide Short;

        public Position()
        {
            this.Instrument = new InstrumentName();
            this.PL = new AccountUnits();
            this.UnrealizedPL = new AccountUnits();
            this.MarginUsed = new AccountUnits();
            this.ResettablePL = new AccountUnits();
            this.Financing = new AccountUnits();
            this.Commission = new AccountUnits();
            this.GuaranteedExecutionFees = new AccountUnits();
            this.Long = new PositionSide();
            this.Short = new PositionSide();
        }

        public Position(InstrumentName instrument, AccountUnits pL, AccountUnits unrealizedPL, AccountUnits marginUsed, AccountUnits resettablePL, AccountUnits financing, AccountUnits commission, AccountUnits guaranteedExecutionFees, PositionSide @long, PositionSide @short)
        {
            this.Instrument = instrument;
            this.PL = pL;
            this.UnrealizedPL = unrealizedPL;
            this.MarginUsed = marginUsed;
            this.ResettablePL = resettablePL;
            this.Financing = financing;
            this.Commission = commission;
            this.GuaranteedExecutionFees = guaranteedExecutionFees;
            this.Long = @long;
            this.Short = @short;
        }
    }
}
