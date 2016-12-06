using System;
using digital.Helpers;
using digital.ViewModels;
using Xamarin.Forms;

namespace digital
{

	public static class ViewModelLocator
	{
		static BalanceItemsViewModel balanceVM;
		public static BalanceItemsViewModel BalanceItemsViewModel
		=> balanceVM ?? (balanceVM = new BalanceItemsViewModel());
	}

	public class App : Application
	{
		public App()
		{
			MainPage = new NavigationPage(new MainPage())
			{
				BarBackgroundColor = Color.FromHex("#022e7b"), 				BarTextColor = Color.White
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

