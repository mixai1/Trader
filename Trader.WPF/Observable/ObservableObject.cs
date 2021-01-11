using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Trader.WPF.Observable
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string poropetryName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(poropetryName));
        }
    }
}
