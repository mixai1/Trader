using System.Windows.Input;
using Trader.WPF.ViewModels;

namespace Trader.WPF.State.Navigate
{
    public enum ViewType
    {
        Home,
        Portfolio
    }

    public interface INavigate
    {
        BaseViewModel CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
