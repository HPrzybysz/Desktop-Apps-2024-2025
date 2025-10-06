namespace PESELCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //55030101193
            string pesel = CheckInput();
            char[] peselArr = pesel.ToCharArray();
            if (isMaleOrFemale(peselArr) == 'K')
            {
                Console.WriteLine("Kobieta");
            }
            else
            {
                Console.WriteLine("Mężczyzna");
            }

            if (checkDigit(peselArr))
            {
                Console.WriteLine("Cyfra kontrolna zgodna");
            }
            else
            {
                Console.WriteLine("Cyfra kontrolna niezgodna");
            }
            
        }

        static string CheckInput()
        {
            while (true)
            {
                Console.WriteLine("Podaj numer PESEL: ");
                string pesel = Console.ReadLine();

                if (String.IsNullOrEmpty(pesel))
                {
                    Console.WriteLine("Proszę wypełnić pole!");
                }
                else if (pesel.All(Char.IsDigit) && pesel.Trim().Length == 11)
                {
                    return pesel;
                }
                else
                {
                    Console.WriteLine("Podaj poprawne dane");
                }
            }
        }
        /***********************************************
        nazwa funkcji: isMaleOrFemale
        opis funkcji: Funckja sprawdz płeć na podstawie 10 cyfry numeru pesel
        parametry: peselArr - tablica char-ów zawierająca kolejne numery podanego numeru PESEL w komórkach.
        zwracany typ i opis: funkcja zwraca char - 'K' gdy 10 cyfra jest parzysta i płeć to kobieta albo 'M' gdy 10 cyfra jest nieparzysta i płeć to mężczyzna
        autor: 00000002137
        ************************************************/
        static char isMaleOrFemale(char[] peselArr)
        {
            if (peselArr[9]%2 == 0)
            {
                return 'K';
            }
            else
            {
                return 'M';
            }
        }

        static bool checkDigit(char[] peselArr)
        {
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int[] peselIntArr = peselArr.Select(c => (int)char.GetNumericValue(c)).ToArray();
            int fromPESEL = peselIntArr[10];
            int R = 0;
            int S = 0;
            int M = 0;

            for (int i = 0; i < peselArr.Length - 1; i++)
            {
                S = S + (weights[i] * peselIntArr[i]);
               
            }

            M = S % 10;

            if(M == 0)
            {
                R = 0;
            }
            else
            {
                R = 10 - M;
            }

            if(R == fromPESEL)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
