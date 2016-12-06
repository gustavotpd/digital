using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using digital.Models;
using System.Linq;

namespace digital.Helpers
{
    public static class BalanceItemHelper
    {
		
        public static ObservableCollection<BalanceItem> Monkeys { get; set; }

        static BalanceItemHelper()
        {
            Monkeys = new ObservableCollection<BalanceItem>();
            Monkeys.Add(new BalanceItem
            {
				Image = "out.png",
				TransactionNumber = "000000",
                Name = "UNIMEDBH",                
				Location = "Belo Horizonte",
				TransactionValue = "-R$40,00",
				Balance = "R$8.200,00",
				Date = new DateTime(2016, 11, 11)
            });

            Monkeys.Add(new BalanceItem
			{
				Image = "out.png",
				TransactionNumber = "000000",
				Name = "CEMIG",
				Location = "Belo Horizonte",
				TransactionValue = "-R$40,00",
				Balance = "R$8.200,00",
				Date = new DateTime(2016, 11, 23)
			});


			Monkeys.Add(new BalanceItem
			{
				Image = "in.png",
				TransactionNumber = "000000",
				Name = "APOSENTADORIA",
				Location = "Belo Horizonte",
				TransactionValue = "-R$40,00",
				Balance = "R$8.200,00",
				Date = new DateTime(2016, 10, 30)
		   });


            Monkeys.Add(new BalanceItem
			{
				Image = "out.png",
				TransactionNumber = "000000",
				Name = "DEPÓSITO PARA ELIANA",
				Location = "Belo Horizonte",
				TransactionValue = "-R$40,00",
				Balance = "R$8.200,00",
				Date = new DateTime(2016, 12, 04)
			});
			    			           
        }


    }
}
