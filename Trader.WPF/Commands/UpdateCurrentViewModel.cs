using System;
using System.Windows.Input;
using Trader.WPF.State.Navigate;
using Trader.WPF.ViewModels;

namespace Trader.WPF.Commands
{

    public class UpdateCurrentViewModel : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private INavigate _navigate;

        public UpdateCurrentViewModel(INavigate navigate)
        {
            _navigate = navigate;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                switch ((ViewType)parameter)
                {
                    case ViewType.Home:
                        _navigate.CurrentViewModel = new HomeViewModel();
                        break;
                    case ViewType.Portfolio:
                        _navigate.CurrentViewModel = new PortfolioViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
