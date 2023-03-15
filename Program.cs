using System;


class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int randomNum = rnd.Next();
        Console.WriteLine(randomNum);
        Thread.Sleep(1000);
        for(int i = 0; ; i++) { Console.WriteLine(i); if (i == randomNum) break; }
    }
}
