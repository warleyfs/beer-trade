﻿using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeerTrade.ViewModels
{
    public sealed class MainPageViewModel: BaseViewModel
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }
    }
}
