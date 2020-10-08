using HomeWork01102020_2.Common.AbstractHandler;
using System;
using System.Collections.Generic;

namespace HomeWork01102020_2.Common
{
    public class Money
    {
        private decimal amount;
        public Money()
        {
            ChangedList = new List<IBanknote>();
        }

        public decimal Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Para negatif değer olamaz");
                }
                amount = value;
            }
        }
        public List<IBanknote> ChangedList { get; set; }
    }
}