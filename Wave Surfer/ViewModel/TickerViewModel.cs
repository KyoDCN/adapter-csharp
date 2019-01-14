namespace WaveSurfer.ViewModel
{
    using Newtonsoft.Json;
    using OandaV20.API;
    using OandaV20.Models.PricingModel;
    using OandaV20.Models.Primitives;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Windows.Data;

    public class TickerViewModel
    {
        ObservableCollection<TickerListItem> tickerLists { get; set; }

        public TickerViewModel()
        {
            tickerLists = new ObservableCollection<TickerListItem>();            
            GetPricingStream();
        }

        public async void GetPricingStream()
        {
            PricingAPI pricing = new PricingAPI();
            var list = new List<InstrumentName>()
            {
                EInstrumentName.EUR_GBP,
                EInstrumentName.EUR_JPY,
                EInstrumentName.EUR_NZD,
                EInstrumentName.EUR_USD,
                EInstrumentName.GBP_AUD,
                EInstrumentName.GBP_CAD,
                EInstrumentName.GBP_CHF,
                EInstrumentName.GBP_JPY,
                EInstrumentName.GBP_NZD,
                EInstrumentName.NZD_CAD,
                EInstrumentName.NZD_CHF,
                EInstrumentName.NZD_JPY,
                EInstrumentName.NZD_USD,
                EInstrumentName.USD_CAD,
                EInstrumentName.USD_SGD,
                EInstrumentName.USD_CHF,
                EInstrumentName.USD_JPY
            };
            using (Stream stream = await pricing.GetStreamPricingForInstruments(list))            
            using (StreamReader reader = new StreamReader(stream))
            {
                while (true)
                {
                    string jsonBody = await reader.ReadLineAsync();                    
                    dynamic tickerInfo = JsonConvert.DeserializeObject<dynamic>(jsonBody);

                    if (tickerInfo["type"].ToString() == "HEARTBEAT")
                        continue;

                    var item = tickerLists.SingleOrDefault(x => x.Instrument == tickerInfo["instrument"].ToString());

                    if(item == null)
                    {
                        tickerLists.Add(
                            new TickerListItem()
                            {
                                Instrument = tickerInfo["instrument"].ToString(),
                                Bid = tickerInfo["closeoutBid"].ToString(),
                                Ask = tickerInfo["closeoutAsk"].ToString()
                            }
                        );
                    } else
                    {                        
                        if (float.Parse(item.Bid) != float.Parse(tickerInfo["closeoutBid"].ToString()))
                        {
                            if (float.Parse(item.Bid) > float.Parse(tickerInfo["closeoutBid"].ToString()))
                                item.BidColor = 1;
                            else if (float.Parse(item.Bid) < float.Parse(tickerInfo["closeoutBid"].ToString()))
                                item.BidColor = 2;
                            item.Bid = tickerInfo["closeoutBid"].ToString();
                        }
                        
                        if (float.Parse(item.Ask) != float.Parse(tickerInfo["closeoutAsk"].ToString()))
                        {
                            if (float.Parse(item.Ask) > float.Parse(tickerInfo["closeoutAsk"].ToString()))
                                item.AskColor = 1;
                            else if (float.Parse(item.Ask) < float.Parse(tickerInfo["closeoutAsk"].ToString()))
                                item.AskColor = 2;
                            item.Ask = tickerInfo["closeoutAsk"].ToString();
                        }
                    }                    
                }
            }
        }

        public ObservableCollection<TickerListItem> GetTickerLists()
        {
            return tickerLists;
        }
    }

    public class TickerListItem : INotifyPropertyChanged
    {
        /// <summary>
        /// Instrument Name
        /// </summary>
        public string Instrument { get; set; }

        /// <summary>
        /// Bid Properties
        /// </summary>
        private int _BidColor;
        public int BidColor
        {
            get { return _BidColor; }
            set { _BidColor = value; NotifyPropertyChanged(); }
        }

        private string _Bid;
        public string Bid
        {
            get { return _Bid; }
            set {
                _Bid = (
                    Instrument.Contains("JPY") 
                    ? string.Format("{0:0.000}", float.Parse(value)) 
                    : string.Format("{0:0.00000}", float.Parse(value))
                );
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Ask Properties
        /// </summary>
        private int _AskColor;
        public int AskColor
        {
            get { return _AskColor; }
            set { _AskColor = value; NotifyPropertyChanged(); }
        }
        private string _Ask;
        public string Ask
        {
            get { return _Ask; }
            set
            {
                _Ask = (
                    Instrument.Contains("JPY") 
                    ? string.Format("{0:0.000}", float.Parse(value)) 
                    : string.Format("{0:0.00000}", float.Parse(value))
                );
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }    
}
