using WaveSurfer.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WaveSurfer.Views.UserControls
{
    /// <summary>
    /// Interaction logic for Ticker.xaml
    /// </summary>
    public partial class Ticker : UserControl
    {
        public Ticker()
        {
            InitializeComponent();
            var tickerVM = new TickerViewModel();
            DataContext = tickerVM;
            TickerDataGrid.ItemsSource = tickerVM.GetTickerLists();

        }        
    }

    public class FormatInstrumentName : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string original = (string)value;
            return original.Replace("_", "/");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class FormatPriceBase : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string original = (string)value;
            return original.Substring(0, original.Length - 2);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class FormatPriceDoubleDigit : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string original = (string)value;
            return original.Substring(original.Length - 2, 2);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
