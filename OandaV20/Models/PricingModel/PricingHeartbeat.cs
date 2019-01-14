using System;

namespace OandaV20.Models.PricingModel
{
    public class PricingHeartbeat
    {
        public string Type;
        public DateTime DateTime;

        public PricingHeartbeat()
        {
            this.Type = "HEARTBEAT";
            this.DateTime = new DateTime();
        }
        public PricingHeartbeat(string type, DateTime dateTime)
        {
            this.Type = type;
            this.DateTime = dateTime;
        }
    }
}
