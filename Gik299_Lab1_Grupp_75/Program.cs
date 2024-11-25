// See https://aka.ms/new-console-template for more information
using System;
using System.Net.NetworkInformation;

internal class Program
{
    public static void Main(string[] args)
    {

        // Vi deklarerar och initierar variabler för att kunna räkna på flygtider och tidsskillnader.
        // Flygtid
        int timeHours = 7;
        int timeMinutes = 25;
        // Avresa Stockholm
        int sthlmToNyHours = 14;
        int sthlmToNyMinutes = 03;
        // Avresa New York
        int nyToSthlmHours = 10;
        int nyToSthlmMinutes = 10;
        // Tidsskillnad       
        int timeDifference = 6;

        // Deklarerar och initierar en bool som villkor för while-loopen.
        bool isRunning = true;
        // Skapar en while-loop till menyn vi har i programmet.
        while (isRunning)
        {
            Console.WriteLine();
            Console.WriteLine("*************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Välkommen till flygtidsberäknaren!");
            Console.WriteLine("\nVilket flyg vill du se detaljerad information om? (svara med en siffra)");
            Console.WriteLine("1. Stockholm - New York");
            Console.WriteLine("2. New York - Stockholm");
            Console.WriteLine("3. Avsluta programmet");
            Console.Write("Skriv ditt val här: ");
            string input = Console.ReadLine();
            

            if (int.TryParse(input, out int userChoice))
            {
                if (userChoice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("*************************************************************************");
                    Console.WriteLine("\nAvgångstid från Stockholm: " + sthlmToNyHours + ":" + sthlmToNyMinutes.ToString("00"));
                    Console.WriteLine("Ankomsttid till New York: " + (sthlmToNyHours + timeHours - timeDifference) + ":" + (sthlmToNyMinutes + timeMinutes));
                    Console.WriteLine("\n*************************************************************************");
                    isRunning = false;
                }
                else if (userChoice == 2)
                    
                {
                    Console.Clear();
                    Console.WriteLine("*************************************************************************");
                    Console.WriteLine("\nAvgångstid från New York: " + nyToSthlmHours + ":" + nyToSthlmMinutes.ToString("00"));
                    Console.WriteLine("Ankomsttid till Stockholm: " + (nyToSthlmHours + timeHours + timeDifference) + ":" + (nyToSthlmMinutes + timeMinutes));
                    Console.WriteLine("\n*************************************************************************");
                    isRunning = false;
                }
                else if (userChoice == 3)
                {
                    Console.Clear();
                    Console.WriteLine("*************************************************************************");
                    Console.WriteLine("\nDu har valt att avsluta programmet");
                    Console.WriteLine("\n*************************************************************************");
                    isRunning = false;
                }
                else
                {
                    
                    Console.WriteLine("\nOgiltig inmatning, välj mellan alternativ 1-3!");
                }
            }
            else
            {
                
                Console.WriteLine("\nOgiltig inmatning, välj mellan alternativ 1-3!");
            }
        }
    }
}
    
