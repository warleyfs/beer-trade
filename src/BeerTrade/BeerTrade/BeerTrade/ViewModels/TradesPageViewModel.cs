using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerTrade.ViewModels
{
    public sealed class TradesPageViewModel : BaseViewModel
    {
        public TradesPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }
    }
}
