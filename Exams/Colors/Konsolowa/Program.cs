using System;

namespace Konsolowa
{
    internal class Program
    {

        /**********************************************
        nazwa funkcji: Main
        opis funkcji: Główna funkcja programu koordynująca działanie całej aplikacji - pobiera dane, generuje zestawy i wyświetla wyniki
        parametry: args - tablica stringów zawierająca argumenty wiersza poleceń
        zwracany typ i opis: brak
        autor: 2137
        ***********************************************/
        static void Main(string[] args)
        {
            int spins = GetNumberOfSpinsFromUser();
            int[,] lotterySets = GenerateLotterySets(spins);

            DisplayLotterySets(lotterySets);
            DisplayNumberStats(lotterySets);

        }

        /**********************************************
        nazwa funkcji: GetNumberOfSpinsFromUser
        opis funkcji: Pobiera od użytkownika liczbę losowań do wygenerowania z walidacją danych wejściowych
        parametry: brak
        zwracany typ i opis: int - liczba losowań wprowadzona przez użytkownika
        autor: 000
        ***********************************************/

        static int GetNumberOfSpinsFromUser()
        {
            int spins;
            while (true)
            {
                Console.WriteLine("\nIle wygenerować losowań?");
                string input = Console.ReadLine();

                if(int.TryParse(input, out spins) && spins > 0)
                {
                    return spins;
                }
                else
                {
                    Console.WriteLine("Podaj całkowitą liczbę dodatnią");
                }
            }

        }
        /**********************************************
        nazwa funkcji: GenerateLotterySets
        opis funkcji: Generuje zestawy liczb loterii - dwuwymiarową tablicę zawierającą podaną liczbę zestawów po 6 unikalnych liczb z zakresu 1-49
        parametry: spins - liczba całkowita określająca ilość zestawów do wygenerowania
        zwracany typ i opis: int[,] - dwuwymiarowa tablica liczb całkowitych o wymiarach[spins, 6] zawierająca wygenerowane zestawy liczb
        autor: 000
        ***********************************************/
        static int[,] GenerateLotterySets(int spins)
        {
            int[,] lotterySets = new int[spins, 6];
            Random random = new Random();

            for(int i = 0; i < spins; i++)
            {
                int[] currentSet = new int[6];
                int numbersAdded = 0;

                while(numbersAdded < 6)
                {
                    int randomNumber = random.Next(1,50);
                    if(!isNumberInArray(currentSet, randomNumber, numbersAdded))
                    {
                        currentSet[numbersAdded] = randomNumber;
                        numbersAdded++;
                    }
                }

                Array.Sort(currentSet);

                for(int j=0; j < 6; j++)
                {
                    lotterySets[i, j] = currentSet[j];
                }
            }

            return lotterySets;
        }

        /**********************************************
        nazwa funkcji: isNumberInArray
        opis funkcji: Sprawdza czy podana liczba znajduje się już w tablicy(zapobiega powtarzaniu się liczb w zestawie)
        parametry: array - tablica liczb całkowitych do sprawdzenia
                   number - liczba całkowita do znalezienia w tablicy
                   count - liczba całkowita określająca ile elementów tablicy należy sprawdzić
        zwracany typ i opis: bool - true jeśli liczba znajduje się w tablicy, false w przeciwnym przypadku
        autor: 000
        ***********************************************/

        static bool isNumberInArray(int[] array, int number, int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i] == number)
                {
                    return true;
                }
            }
            return false;
        }

        /**********************************************
        nazwa funkcji: DisplayLotterySets
        opis funkcji: Wyświetla na ekranie wszystkie wygenerowane zestawy liczb loterii w sformatowany sposób
        parametry: lotterySets - dwuwymiarowa tablica liczb całkowitych zawierająca zestawy do wyświetlenia
        zwracany typ i opis: brak
        autor: 000
        ***********************************************/
        static void DisplayLotterySets(int[,] lotterySets)
        {
            int numberOfSets = lotterySets.GetLength(0);


            for (int setIndex = 0; setIndex < numberOfSets; setIndex++)
            {
                Console.Write($"Losowanie {setIndex + 1,3}: ");

                for (int numberIndex = 0; numberIndex < 6; numberIndex++)
                {
                    Console.Write($"{lotterySets[setIndex, numberIndex],2} ");
                }
                Console.WriteLine();
            }
        }

       /**********************************************
        nazwa funkcji: DisplayNumberStats
        opis funkcji: Oblicza i wyświetla statystyki wystąpień każdej liczby we wszystkich zestawach
        parametry: lotterySets - dwuwymiarowa tablica liczb całkowitych zawierająca zestawy do analizy
        zwracany typ i opis: brak
        autor: 111
        ***********************************************/
        static void DisplayNumberStats(int[,] lotterySets)
        {
            int numberOfSets = lotterySets.GetLength(0);
            int[] numberCounts = new int[50];

            for (int setIndex = 0; setIndex < numberOfSets; setIndex++)
            {
                for (int numberIndex = 0; numberIndex < 6; numberIndex++)
                {
                    int number = lotterySets[setIndex, numberIndex];
                    numberCounts[number]++;
                }
            }

            for (int number = 1; number <= 49; number++)
            {
                if (numberCounts[number] > 0)
                {
                    Console.WriteLine($"Wystąpienia liczby {number,6}: {numberCounts[number],3}");
                }
            }

        }

    }
}
