using System;

class BankAccountData
{
    static void Main()
    {
        Random randomGenerator = new Random();

        string firstName = "Ivan";
        string middleName = "Ivanov";
        string lastName = "Todorov";

        string holderName = firstName + " " + middleName + " " + lastName;
        int availableAmmount = 100;

        string bankName = "BNB";
        string iban = "BG80 BNBG";
        string[] creditCards = new string[3];

        for (int i = 0; i < creditCards.Length; i++)
        {
            for (int k = 0; k < 16; k++)
            {
                creditCards[i] += Convert.ToString(randomGenerator.Next(10));
                
                if ((k + 1) % 4 == 0)
                {
                    creditCards[i] += " ";
                }
            }
        }

        for (int j = 0; j < 14; j++)
        {
            if (j % 4 == 0)
            {
                iban += " ";
            }

            iban += Convert.ToString(randomGenerator.Next(10));
        }

        Console.WriteLine("Holder name: {0}", holderName);
        Console.WriteLine("Available ammount: {0}", availableAmmount);
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("Credit cards:");

        for (int i = 0; i < creditCards.Length; i++)
        {
            Console.WriteLine("\tCredit card[{0}]: {1}", i + 1, creditCards[i]);
        }
    }
}