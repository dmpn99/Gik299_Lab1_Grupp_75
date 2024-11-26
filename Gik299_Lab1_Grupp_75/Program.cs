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
        // Avresa från Stockholm
        int sthlmToNyHours = 14;
        int sthlmToNyMinutes = 03;
        // Avresa från New York
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
            Console.WriteLine("\nVilket flyg vill du se detaljerad information om? (svara med siffra)");
            Console.WriteLine("1. Stockholm - New York");
            Console.WriteLine("2. New York - Stockholm");
            Console.WriteLine("3. Avsluta programmet");
            Console.Write("Skriv ditt val här: ");
            string input = Console.ReadLine();
            
            /* 
            Använder metoden TryParse för att dels konvertera variabeln "input" till en int ("userChoice"),
            men också för att använda den som ett villkor (bool - true/false) i if-satsen. Det är felhantering.
            */ 
            if (int.TryParse(input, out int userChoice))
            {
                if (userChoice == 1)
                {
                    // Använder metoden Clear för att rensa konsolfönstret. För snyggare utskrift.
                    Console.Clear();
                    // Skriver ut till användaren. Räknar och använder formateringsmetoden ToString.
                    Console.WriteLine("*************************************************************************");
                    Console.WriteLine("\nAvgångstid från Stockholm: " + sthlmToNyHours + ":" + sthlmToNyMinutes.ToString("00"));
                    Console.WriteLine("Ankomsttid till New York: " + (sthlmToNyHours + timeHours - timeDifference) + ":" + (sthlmToNyMinutes + timeMinutes));
                    Console.WriteLine("\n*************************************************************************");
                    // Tilldelelar boolen isRunning false för att bryta loopen = avsluta programmet.
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
                    // Om användaren väljer att avsluta programmet. 
                    Console.Clear();
                    Console.WriteLine("*************************************************************************");
                    Console.WriteLine("\nDu har valt att avsluta programmet");
                    Console.WriteLine("\n*************************************************************************");
                    isRunning = false;
                }
                else
                {
                    /*
                    Felhantering. Användaren har skrivit in fel siffra.
                    Loopas tillbaka till menyn.
                    Visar utskrift i 1.2 sek innan konsollen rensas
                    */
                    Console.WriteLine("\nOgiltig inmatning, välj mellan alternativ 1-3!");
                    Thread.Sleep(1200);
                    Console.Clear();
                }
            }
            else
            {
                // Lika som else ovanför, felhantering.
                Console.WriteLine("\nOgiltig inmatning, välj mellan alternativ 1-3!");
                Thread.Sleep(1200);
                Console.Clear();
            }  
        }
    }
}
    
