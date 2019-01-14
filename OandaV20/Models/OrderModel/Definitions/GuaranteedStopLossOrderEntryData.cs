using OandaV20.Models.Primitives;

namespace OandaV20.Models.OrderModel.Definitions
{
    public class GuaranteedStopLossOrderEntryData
    {
        public double MinimumDistance;
        public double Premium;
        public GuaranteedStopLossOrderLevelRestriction LevelRestriction;

        public GuaranteedStopLossOrderEntryData()
        {
            this.LevelRestriction = new GuaranteedStopLossOrderLevelRestriction();
        }

        public GuaranteedStopLossOrderEntryData(double minimumDistance, double premium, GuaranteedStopLossOrderLevelRestriction levelRestriction)
        {
            this.MinimumDistance = minimumDistance;
            this.Premium = premium;
            this.LevelRestriction = levelRestriction;
        }
    }
}
