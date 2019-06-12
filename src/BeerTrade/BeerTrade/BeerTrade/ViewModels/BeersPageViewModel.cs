using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerTrade.ViewModels
{
    public sealed class BeersPageViewModel : BaseViewModel
    {
        public BeersPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }
    }
}
