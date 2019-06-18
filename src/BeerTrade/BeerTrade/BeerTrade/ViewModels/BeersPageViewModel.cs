using BeerTrade.Utils;
using Prism.Navigation;

namespace BeerTrade.ViewModels
{
    [Preserve(AllMembers = true)]
    public sealed class BeersPageViewModel : BaseViewModel
    {
        public BeersPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }
    }
}
