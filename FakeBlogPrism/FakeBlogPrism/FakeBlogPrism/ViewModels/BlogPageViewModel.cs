using FakeBlogPrism.Models;
using Prism.Navigation;

namespace FakeBlogPrism.ViewModels
{
    public class BlogPageViewModel : ViewModelBase 
	{
        private Blog _blogDetail;

        public Blog BlogDetail
        {
            get { return _blogDetail; }
            set { SetProperty(ref _blogDetail , value); }
        }

        public BlogPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            BlogDetail = (Blog)parameters["blog"];
        }
    }
}
