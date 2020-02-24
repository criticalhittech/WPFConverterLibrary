using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPFConverterLibrary
{
    //Based on sample: 
    //https://github.com/CrossGeeks/UsefulConvertersSample/blob/master/UsefulConvertersSample/ViewModels/MainPageViewModel.cs
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public double FullValAmount { get; set; } = 23.335;
        public DateTime Date { get; set; } = DateTime.Now.AddDays(-1);
        public string UserName { get; set; } = "John";
        public List<string> Items { get; set; } = new List<string>() { "Item1" };
        public double LuminanceDark { get; set; } = 0.8;
        public double LuminaceLight { get; set; } = 0.2;

        public SolidColorBrush ColorBrush { get; } = new SolidColorBrush(Colors.BurlyWood);

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

