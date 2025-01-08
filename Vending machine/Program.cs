using System;

class VendingMachine
{
    static void Main()
    {
        int balance = 0;

        Console.WriteLine("Pret produs: 20 bani");
        Console.WriteLine("Introdu o moneda (N pt. Nickel, D pt. Dime, Q pt. Quarter).'exit' pt. a opri programul.");

        while (true)
        {
            Console.WriteLine($"Sold: {balance} bani");
            Console.Write("Introdu o moneda: ");
            string input = Console.ReadLine()?.ToUpper();

            if (input == "EXIT") break;

            switch (input)
            {
                case "N":
                    balance += 5;  
                    break;
                case "D":
                    balance += 10; 
                    break;
                case "Q":
                    balance += 25; 
                    break;
                default:
                    Console.WriteLine("Input invalid!");
                    continue; 
            }

           
            if (balance >= 20)
            {
                Dispense(balance);
                balance = 0;  
            }
        }

    }

    static void Dispense(int totalBalance)
    {
        const int productCost = 20;
        if (totalBalance >= productCost)
        {
            Console.WriteLine("Dat produs");
            int change = totalBalance - productCost;
            if (change > 0)
                Console.WriteLine($"Rest: {change} bani");
        }
        else
        {
            Console.WriteLine("Fonduri insuficiente.");
        }
    }
}
