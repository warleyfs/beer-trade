using BeerTrade.Utils;
using Prism.Navigation;

namespace BeerTrade.ViewModels
{
    [Preserve(AllMembers = true)]
    public sealed class MainPageViewModel: BaseViewModel
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }
    }
}
