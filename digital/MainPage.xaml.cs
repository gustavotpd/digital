using System;
using System.Globalization;
using Xamarin.Forms;
using XFGloss;

namespace digital
{
	public partial class MainPage : ContentPage
	{
		Customer _customerData;

		public MainPage()
		{
			InitializeComponent();
			BindingContext = this;
			 _customerData = new Customer()
			{
				Name = "Maria João de Souza",
				AccountNumber = "12342-2",
				AgencyNumber = "9872",
				BirthDate = new DateTime(1970, 10, 21),
				CurrentBalance = 5400.0f
			};

			CustomerName.Text = _customerData.Name;
			BankDetais.Text = string.Format("Agência {0} | Conta {1}", _customerData.AgencyNumber, _customerData.AccountNumber);
			CurrentBalance.Text = string.Format(CultureInfo.CurrentCulture, "{0:C}", _customerData.CurrentBalance);

			if (Device.OS == TargetPlatform.Android) 
			{
				ToolbarItems.Add(new ToolbarItem("Sair", "filter.png", async () =>
				{
					DependencyService.Get<IAndroidMethods>().CloseApp();

				}));
				
			}
		}

		public async void BalanceButtonTapped(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new BalancePage(_customerData));
		}

		public async void CardButtonTapped(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new BalancePage(_customerData));
		}

		public async void TransferencesButtonTapped(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new BalancePage(_customerData));
		}

		public async void LoanButtonTapped(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new BalancePage(_customerData));
		}

		public async void PaymentButtonTapped(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new BalancePage(_customerData));
		}

		public async void AttendanceButtonTapped(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new BalancePage(_customerData));
		}
	}
}