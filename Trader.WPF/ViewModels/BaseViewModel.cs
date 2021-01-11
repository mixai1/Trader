using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trader.WPF.Commands;
using Trader.WPF.State.Navigate;

namespace Trader.WPF.ViewModels
{
    public class BaseViewModel
    {
        public INavigate Navigate { get; set; } = new Navigate();
    }
}
