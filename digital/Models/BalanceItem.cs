using System;

namespace digital.Models
{
    public class BalanceItem
    {
		public string TransactionNumber { get; set; }
		public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
		public string TransactionValue { get; set; }
		public string Balance { get; set; }
		public DateTime Date { get; set; }
        public string Image { get; set; }		       
    }
}

