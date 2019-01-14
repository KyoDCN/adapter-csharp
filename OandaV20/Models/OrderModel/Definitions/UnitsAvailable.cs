namespace OandaV20.Models.OrderModel.Definitions
{
    public class UnitsAvailable
    {
        public UnitsAvailableDetails Default;
        public UnitsAvailableDetails ReduceFirst;
        public UnitsAvailableDetails ReduceOnly;
        public UnitsAvailableDetails OpenOnly;

        public UnitsAvailable()
        {
            this.Default = new UnitsAvailableDetails();
            this.ReduceFirst = new UnitsAvailableDetails();
            this.ReduceOnly = new UnitsAvailableDetails();
            this.OpenOnly = new UnitsAvailableDetails();
        }
        public UnitsAvailable(
            UnitsAvailableDetails defaultVal, 
            UnitsAvailableDetails reduceFirst, 
            UnitsAvailableDetails reduceOnly, 
            UnitsAvailableDetails openOnly)
        {
            this.Default = defaultVal;
            this.ReduceFirst = reduceFirst;
            this.ReduceOnly = reduceOnly;
            this.OpenOnly = openOnly;
        }
    }
}