using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Crashes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SentimentAnalysis
{
    public class App : Application
    {
        public App()
        {
            MainPage = new SentimentPage();
        }

        
    }
}
