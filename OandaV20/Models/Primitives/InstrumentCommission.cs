namespace OandaV20.Models.Primitives
{
    public class InstrumentCommission
    {
        public double Commission;
        public double UnitsTraded;
        public double MinimumCommission;
        
        public InstrumentCommission()
        {
        }
        public InstrumentCommission(double commission, double unitsTraded, double minimumCommission)
        {
            this.Commission = commission;
            this.UnitsTraded = unitsTraded;
            this.MinimumCommission = minimumCommission;
        }
    }
}
