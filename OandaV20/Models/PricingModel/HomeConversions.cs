using OandaV20.Models.Primitives;

namespace OandaV20.Models.PricingModel
{
    public class HomeConversions
    {
        public Currency Currency;
        public double AccountGain;
        public double AccountLoss;
        public double PositionValue;

        public HomeConversions()
        {
            this.Currency = new Currency();
        }
        public HomeConversions(Currency currency, double accountGain, double accountLoss, double positionValue)
        {
            this.Currency = currency;
            this.AccountGain = accountGain;
            this.AccountLoss = accountLoss;
            this.PositionValue = positionValue;
        }
    }
}
