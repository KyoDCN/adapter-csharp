namespace OandaV20.Models.OrderModel.Definitions
{
    public class UnitsAvailableDetails
    {
        public double Long;
        public double Short;

        public UnitsAvailableDetails()
        {
        }
        public UnitsAvailableDetails(double longVal, double shortVal)
        {
            this.Long = longVal;
            this.Short = shortVal;
        }
    }
}
