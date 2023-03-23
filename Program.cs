using C_Formative;
using System;

class Program
{
    static void Main(string[] args)
    {
        Money current = new Money();
        Console.WriteLine("Welcome!!");
        Console.WriteLine("This application will help you, whether buying or renting.");
        Console.WriteLine("");
        Console.WriteLine("Firstly, please enter your monthly gross income before deductions: ");
        double grossIncome = double.Parse(Console.ReadLine());
        Console.WriteLine("\nSecondly, please enter your monthly tax deductions: ");
        double monthlyDeductions = double.Parse(Console.ReadLine());
        Console.WriteLine("\nThirdly, please enter your monthly living expenses: ");
        double monthlyExpense = double.Parse(Console.ReadLine());
        Console.WriteLine("\nNow please choose whether you are renting or buying (0 for renting, 1 for buying)");
        int type = int.Parse(Console.ReadLine());
        
        current.setType(type);


    }
}