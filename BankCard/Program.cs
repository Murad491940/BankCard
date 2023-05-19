using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BankCard
{
    class BankCard
    {
        public string CardName { get; set; }

        public int CardCode { get; set; }

        public int CVV { get; private set; }

        public int ExpirationDate { get; set; }

        public string OwnerName { get; set; }

        public string OwnerSurname { get; set; }

        public double Money { get; set; }

        public void inCome( double inCome)
        {
            if (inCome > 0)
            {
                Console.WriteLine(Money + inCome);
            }
        }
        public void Expense( double expense)
        {
            if (expense > 0)
            {
                Console.WriteLine(Money - expense);
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {

                BankCard myCard = new BankCard();

                myCard.CardName = "PashaBank";
                myCard.CardCode = 0502110001;
                myCard.CVV = 101;
                myCard.ExpirationDate = 2024;
                myCard.OwnerName = "John";
                myCard.OwnerSurname = "Doe";
                myCard.Money = 500.0;

                Console.WriteLine(myCard.CardName);
                Console.WriteLine(myCard.CardCode);
                Console.WriteLine(myCard.CVV);
                Console.WriteLine(myCard.ExpirationDate);
                Console.WriteLine(myCard.OwnerName);
                Console.WriteLine(myCard.OwnerSurname);

                myCard.inCome(100.0);
                myCard.Expense(50.50);

            }
        }
    }
}