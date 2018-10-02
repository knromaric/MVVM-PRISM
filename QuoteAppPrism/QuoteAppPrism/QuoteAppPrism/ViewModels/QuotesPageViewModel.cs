using Prism.Mvvm;
using Prism.Navigation;
using QuoteAppPrism.Interfaces;
using QuoteAppPrism.Models;
using System.Collections.ObjectModel;

namespace QuoteAppPrism.ViewModels
{
    public class QuotesPageViewModel : BindableBase
	{
        public ObservableCollection<Quote> QuotesCollection { get; set; }
        public INavigationService NavigationService { get; set; }
        private readonly IQuotes _quotes;
        public QuotesPageViewModel(IQuotes quotes, INavigationService navigationService)
        {
            _quotes = quotes;
            QuotesCollection = new ObservableCollection<Quote>();
            NavigationService = navigationService;
            LoadQuotes();
        }

        private async void LoadQuotes()
        {
            var quotes = await _quotes.GetQuotes();

            foreach (var quote in quotes)
            {
                QuotesCollection.Add(quote);
            }
        }

        private Quote _selectedQuote;
        public Quote SelectedQuote
        {
            get { return _selectedQuote; }
            set
            {
                SetProperty( ref _selectedQuote , value);

                if (_selectedQuote != null)
                {
                    NavigateToQuoteDetails();
                }
            }
        }

        private void NavigateToQuoteDetails()
        {
            var navigationParameters = new NavigationParameters();
            navigationParameters.Add("quoteDetail", _selectedQuote);
            NavigationService.NavigateAsync("QuoteDetailsPage", navigationParameters);
        }
    }
}
