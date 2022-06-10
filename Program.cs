using System;
using System.IO;

namespace LegoDB
{
public class Program
{
        static void Main(string[] args)
    {
        string? input;
        string? input2;

        MiniLogic d = new MiniLogic();
        miniFigDel handler = d.Logic;

        do
    {
            Console.WriteLine("Enter name of minifigure: ");
            input = Console.ReadLine();
        
        if (!input.Equals("exit"))
        {
            Console.WriteLine("Enter item name: ");
            input2 = Console.ReadLine();

        if (!input2.Equals("exit"))
        {
            handler(input, input2);
        }
        }
    }
        while (input != "exit");  
    }
}
}