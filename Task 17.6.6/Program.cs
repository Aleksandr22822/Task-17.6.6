namespace Task_17._6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account accountOrdinary = new Account("обычный", 100000, 0.1);
            double finishIntersectOrdinary = accountOrdinary.GetInterest(new СalculateInterestOrdinary());
            Console.WriteLine($"Вам открыт {accountOrdinary.Type} счет, " +
                $"Ваш баланс {accountOrdinary.Balance} рублей," +
                $" Ваша депозитная ставка {finishIntersectOrdinary} % годовых");


            Account accountSelery = new Account("зарплатный", 100000, 0.2);
            double finishIntersectSelery = accountSelery.GetInterest(new СalculateInterestSelery());
            Console.WriteLine($"Вам открыт {accountSelery.Type} счет, " +
               $"Ваш баланс {accountSelery.Balance} рублей," +
               $" Ваша депозитная ставка {finishIntersectSelery} % годовых");
        }
    }
}
