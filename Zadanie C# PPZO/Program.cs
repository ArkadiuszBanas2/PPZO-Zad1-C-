using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_C__PPZO // Komentarz dla brancha Arek
{
    internal class Program
    {
        static void Calculate()
        {
            Console.WriteLine("Podaj pierwsza liczbe: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj numer dzialania ktore chcesz wykonac: \n1. Dodawanie / 2. Odejmowanie / 3. Mnozenie / 4. Dzielenie");
            int action = int.Parse(Console.ReadLine());
            if (action == 1)
            {
                Console.WriteLine("Wynik dodawania to: " + (a + b));
            }
            else if (action == 2)
            {
                Console.WriteLine("Wynik odejmowania to: " + (a - b));
            }
            else if (action == 3)
            {
                Console.WriteLine("Wynik mnozenia to: " + (a * b));
            }
            else if (action == 4)
            {
                if (b == 0)
                {
                    Console.WriteLine("Nie mozna dzielic przez 0!");
                    return;
                }
                Console.WriteLine("Wynik dzielenia to: " + Math.Round((a / b), 4));
            }
            else
            {
                Console.WriteLine("Nie ma takiego dzialania");
            }
        }
        static void Temperature()
        {
            Console.WriteLine("Podaj jakiej konwersji temperatury chcesz dokonac: \n1. Celsjusz -> Fahrenheit / 2. Fahrenheit -> Celsjusz");
            int conversion = int.Parse(Console.ReadLine());
            if (conversion == 1)
            {
                Console.WriteLine("Podaj temperature w stopniach Celsjusza: ");
                double celsjusz = double.Parse(Console.ReadLine());
                double fahrenheit = (celsjusz * 1.8) + 32;
                Console.WriteLine("Temperatura w stopniach Fahrenheit'a to: " + Math.Round(fahrenheit, 2));
            }
            else if (conversion == 2)
            {
                Console.WriteLine("Podaj temperature w stopniach Fahrenheit'a: ");
                double fahrenheit = double.Parse(Console.ReadLine());
                double celsjusz = (fahrenheit - 32) / 1.8;
                Console.WriteLine("Temperatura w stopniach Celsjusza to: " + Math.Round(celsjusz, 2));
            }
            else
            {
                Console.WriteLine("Blad wyboru konwersji!");
            }
        }
        static void Average() //Dodano w tej funkcji dodatkowe zabezpieczenie TryParse czy uzytkownik nie wpisal litery zamiast liczby.
        {
            Console.WriteLine("Podaj liczbe ocen: ");
            if (!int.TryParse(Console.ReadLine(), out int amount))
            {
                Console.WriteLine("Podano zla wartosc");
                return;
            }
            double sum = 0;
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Podaj ocene z zakresu (1-6): ");
                if (!double.TryParse(Console.ReadLine(), out double grade) || grade < 1 || grade > 6)
                {
                    Console.WriteLine("Podano zla ocene!");
                    i--;
                    continue;
                }
                else
                {
                    sum += grade;
                }
            }
            double average = sum / amount;
            Console.WriteLine("Srednia ocen ucznia to: " + Math.Round(average, 2));
            Console.WriteLine(average >= 3.0 ? "Uczen zdal" : "Uczen nie zdal");
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Podaj numer zadania ktore chcesz wykonac: " +
                    "\n1. Prosty kalkulator dwoch liczb \n2. Konwenter temperatur (Celsjusz <-> Fahrenheit) \n3. Srednia ocen ucznia");
                int number = int.Parse(Console.ReadLine());
                if (number == 1)
                {
                    Calculate();
                }
                else if (number == 2)
                {
                    Temperature();
                }
                else if (number == 3)
                {
                    Average();
                }
                else
                {
                    Console.WriteLine("Nie ma takiego zadania");
                }
            }
        }
    }
}