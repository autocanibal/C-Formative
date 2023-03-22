using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome!!");
        Console.WriteLine("This application will help you, whether buying or renting.");
        Console.WriteLine("Firstly please enter your monthly gross income before deductions");
        int grossIncome = int.Parse(Console.ReadLine());
        Console.WriteLine(grossIncome);
    }
}