using System;

namespace Task_17._6._6
{
    internal class Account
    {
        // свойство начинает носить чисто информативный характер
        public string Type { get; set; }
        public double Balance { get; set; }

        // базавая ставка годовых
        public double Interest { get; set; }

        public Account(string type, double balance, double interest)
        {
            Type = type;
            Balance = balance;
            Interest = interest;
        }

        public double GetInterest(IСalculateInterest calculateInterest)
        {
           return calculateInterest.CalculateInterest(Balance, Interest);
        }
    }
}
