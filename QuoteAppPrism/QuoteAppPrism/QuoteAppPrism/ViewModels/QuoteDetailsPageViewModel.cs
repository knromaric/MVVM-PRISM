using Prism.Mvvm;
using Prism.Navigation;
using QuoteAppPrism.Models;
using System;

namespace QuoteAppPrism.ViewModels
{
    public class QuoteDetailsPageViewModel : BindableBase, INavigationAware
	{
        private Quote _quote;

        private string _quoteContent;
        public string QuoteContent
        {
            get { return _quoteContent; }
            set
            {
                SetProperty(ref _quoteContent, value);
            }
        }
        public QuoteDetailsPageViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            _quote = (Quote)parameters["quoteDetail"];
            QuoteContent = _quote.Content;
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }
    }
}
