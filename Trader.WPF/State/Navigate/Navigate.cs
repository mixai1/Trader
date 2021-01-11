using System.Windows.Input;
using Trader.WPF.Commands;
using Trader.WPF.Observable;
using Trader.WPF.ViewModels;

namespace Trader.WPF.State.Navigate
{
    public class Navigate : ObservableObject, INavigate
    {
        private BaseViewModel _currentViewModel;

        public BaseViewModel CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public ICommand UpdateCurrentViewModelCommand  => new UpdateCurrentViewModel(this); 
    }
}
