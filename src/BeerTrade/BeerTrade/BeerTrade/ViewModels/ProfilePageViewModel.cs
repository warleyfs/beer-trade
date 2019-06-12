using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerTrade.ViewModels
{
    public sealed class ProfilePageViewModel : BaseViewModel
    {
        public ProfilePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }
    }
}
