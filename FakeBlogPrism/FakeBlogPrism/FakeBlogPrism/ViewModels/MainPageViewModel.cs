using FakeBlogPrism.Models;
using FakeBlogPrism.Services;
using Prism.Navigation;
using System.Collections.ObjectModel;

namespace FakeBlogPrism.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ObservableCollection<Blog> Blogs { get; set; }
        private BlogServices _blogService;
        private Blog _selectedBlog;
        public Blog SelectedBlog
        {
            get { return _selectedBlog; }
            set
            {
                SetProperty(ref _selectedBlog, value);

                if(_selectedBlog != null)
                {
                    NavigateToBlog();
                    //SetProperty(ref _selectedBlog, null); 
                    _selectedBlog = null;
                }
            }
        }

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Blogs";
            _blogService = new BlogServices();
            Blogs = new ObservableCollection<Blog>(_blogService.GetBlogs());
        }
        
        private void NavigateToBlog()
        {
            var parameter = new NavigationParameters();
            parameter.Add("blog", SelectedBlog);
            NavigationService.NavigateAsync("BlogPage", parameter);
        }
    }
}
