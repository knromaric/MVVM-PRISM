using Prism;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;
using QuoteAppPrism.Views;
using QuoteAppPrism.Services;
using QuoteAppPrism.Interfaces;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace QuoteAppPrism
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            //await NavigationService.NavigateAsync("NavigationPage/WelcomePage");
            await NavigationService.NavigateAsync("NavigationPage/QuotesPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<QuotesPage>();
            containerRegistry.RegisterForNavigation<QuoteDetailsPage>();

            containerRegistry.RegisterSingleton<IQuotes, QuotesApi>();
        }
    }
}
