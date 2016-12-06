using digital.Helpers;
using digital.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System;

namespace digital.ViewModels
{
    public class BalanceItemsViewModel
    {
        public ObservableCollection<BalanceItem> BalanceItems { get; set; }
		public ObservableCollection<BalanceItem> AllBalanceItems { get; set; }


		public BalanceItemsViewModel()
        {
			AllBalanceItems = BalanceItemHelper.Monkeys;
			BalanceItems = AllBalanceItems;
        }

		public void Filter(int days)
		{
			var result = new ObservableCollection<BalanceItem>();

			result = new ObservableCollection<BalanceItem>(AllBalanceItems.Where(m => m.Date >= DateTime.Today.AddDays(-days)));

			BalanceItems = result;
		}
    }
}
