using System;
using System.Collections.Generic;
using digital.ViewModels;
using Xamarin.Forms;
using XFGloss;
using digital.Models;
using System.Globalization;

namespace digital
{
	public partial class BalancePage : ContentPage
	{
		private DropDownPicker _DropdownContainer;
		private Customer _customerData;

		public BalancePage(Customer customerData)
		{
			InitializeComponent();
			BindingContext = new BalanceItemsViewModel();
			Title = "Extrato de Conta Corrente";
			_customerData = customerData;
			CurrentBalance.Text = string.Format(CultureInfo.CurrentCulture, "{0:C}", _customerData.CurrentBalance);

			this._DropdownContainer = new DropDownPicker
			{
				WidthRequest = Device.OnPlatform(300,300,300),
				HeightRequest = 30,
				DropDownHeight = 150,
				SelectedText = "Boston",
				FontSize = Device.OnPlatform(10, 14, 10),
				CellHeight = 20,
				SelectedBackgroundColor = Color.White,
				SelectedTextColor = Color.Black,
				TextColor = Color.Black,
				BorderColor = Color.Black,
				ArrowColor = Color.Blue,
				iOSHeaderText = "Locations",
				iOSHeaderFontSize = 20,
				iOSHeaderHeight = 40,
				BackgroundColor = Color.White,
				Title = "Últimos 5 dias",



			};

			var data = new List<string>();
			data.Add("Últimos 5 dias");
			data.Add("Últimos 15 dias");
			data.Add("Últimos 30 dias");
			data.Add("Últimos 60 dias");

			this._DropdownContainer.Source = data;

			DropDownContent.Children.Add(
				new Label
				{
					Text = "Selecione o período",
					TextColor = Color.Silver,
					HorizontalTextAlignment = TextAlignment.Start
				}
			);

			DropDownContent.Children.Add(
				this._DropdownContainer
			);
		}

		private void OnTapFrom(object sender, DropDownTapArgs e)
		{
			this._DropdownContainer.DoHideDropDownOnTap(e);
		}

		private void Drop1Selected(object sender, string e)
		{
			TransactionItems.ItemsSource = null;

			switch (e) 
			{
				case "Últimos 5 dias":
					(BindingContext as BalanceItemsViewModel).Filter(5);
					break;

				case "Últimos 15 dias":
					(BindingContext as BalanceItemsViewModel).Filter(15);
					break;

				case "Últimos 30 dias":
					(BindingContext as BalanceItemsViewModel).Filter(30);
					break;

				case "Últimos 60 dias":
				(BindingContext as BalanceItemsViewModel).Filter(60);
				break;

				default: 
					(BindingContext as BalanceItemsViewModel).Filter(5);
					break;
			}

			TransactionItems.ItemsSource = (BindingContext as BalanceItemsViewModel).BalanceItems;

			
			System.Diagnostics.Debug.WriteLine("selected text change Drop1: " + e);
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			this._DropdownContainer.OnSelected += Drop1Selected;

		}

		protected override void OnDisappearing()
		{
			this._DropdownContainer.OnSelected -= Drop1Selected;
			base.OnDisappearing();
		}


	}
}
