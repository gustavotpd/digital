using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using digital.ViewModels;
using digital.Helpers;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace digital
{
	public partial class App : Application
	{

		public static class ViewModelLocator
		{
			static MonkeysViewModel monkeysVM;
			public static MonkeysViewModel MonkeysViewModel
			=> monkeysVM ?? (monkeysVM = new MonkeysViewModel());

			static DetailsViewModel detailsVM;
			public static DetailsViewModel DetailsViewModel
			=> detailsVM ?? (detailsVM = new DetailsViewModel(MonkeyHelper.Monkeys[0]));
		}


		public App()
		{
			InitializeComponent();
			MainPage = new NavigationPage(new MainPage())
			{
				BarBackgroundColor = Color.FromHex("#022e7b"),
				BarTextColor = Color.White
			};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}