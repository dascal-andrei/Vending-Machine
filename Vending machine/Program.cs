using System;

class VendingMachine
{
    static void Main()
    {
        int balance = 0;

        Console.WriteLine("Pret produs: 20 bani");
        Console.WriteLine("Introdu o moneda (N pt. Nickel, D pt. Dime, Q pt. Quarter).0 pt a iesi din program.");

        while (true)
        {
            Console.WriteLine($"Sold: {balance} bani");
            Console.Write("Introdu o moneda: ");
            string input = Console.ReadLine()?.ToUpper();

            if (input == "0") break;

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
                Console.WriteLine(change == 5 ? "Rest 1 N" : change == 10 ? "Rest 1 D" : change == 15 ? "Rest 1 N, 1 D" : "");
        }
        else
        {
            Console.WriteLine("Fonduri insuficiente.");
        }
    }
    
}
