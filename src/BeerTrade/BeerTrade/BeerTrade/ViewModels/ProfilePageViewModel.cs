using BeerTrade.Utils;
using Prism.Navigation;

namespace BeerTrade.ViewModels
{
    [Preserve(AllMembers = true)]
    public sealed class ProfilePageViewModel : BaseViewModel
    {
        public ProfilePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }
    }
}
