﻿namespace My_first_project_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei, hva heter du?");
            var userInput = Console.ReadLine();
            Console.WriteLine($"Velkommen {userInput}!");
        
        }
    }
}