using BeerTrade.Utils;
using Prism.Navigation;

namespace BeerTrade.ViewModels
{
    [Preserve(AllMembers = true)]
    public sealed class TradesPageViewModel : BaseViewModel
    {
        public TradesPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }
    }
}
