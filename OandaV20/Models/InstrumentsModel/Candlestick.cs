using System;

namespace OandaV20.Models.InstrumentsModel
{
    public class Candlestick
    {
        public DateTime Time;
        public CandlestickData Bid;
        public CandlestickData Ask;
        public CandlestickData Mid;
        public int Volume;
        public bool Complete;

        public Candlestick()
        {
            this.Time = new DateTime();
            this.Bid = new CandlestickData();
            this.Ask = new CandlestickData();
            this.Mid = new CandlestickData();
        }
        public Candlestick(DateTime time, CandlestickData bid, CandlestickData ask, CandlestickData mid, int volume, bool complete)
        {
            this.Time = time;
            this.Bid = bid;
            this.Ask = ask;
            this.Mid = mid;
            this.Volume = volume;
            this.Complete = complete;
        }
    }
}
