using BeerTrade.Utils;
using Prism.Navigation;

namespace BeerTrade.ViewModels
{
    [Preserve(AllMembers = true)]
    public sealed class FeedPageViewModel : BaseViewModel
    {
        public FeedPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }
    }
}
