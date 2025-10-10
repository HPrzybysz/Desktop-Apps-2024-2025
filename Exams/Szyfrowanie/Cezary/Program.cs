namespace Cezary
{
    public class Program
    {
        static void Main(string[] args)
        {
            string toCode = CheckInput("Podaj tekst do zaszyfrowania:\n", "toCode");
            string keyInput = CheckInput("Podaj klucz:\n", "keyInput");
            int key = int.Parse(keyInput);

            Console.WriteLine($"Encoded message: {Cezar(toCode, key)}");



        }

        static string CheckInput(string message, string var)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                if (!String.IsNullOrEmpty(input))
                {
                    return var = input.Trim();
                }
                else
                {
                    Console.WriteLine("Proszę wypełnić pole.");
                }

            }
        }

        public static string Cezar(string toCode, int key)
        {
            key = key % 26;
            if(key < 0)
            {
                key += 26;
            }

            char[] result = new char[toCode.Length];

                for(int i = 0; i < toCode.Length; i++)
                {
                    char currentChar = toCode[i];

                    if(currentChar == ' ')
                    {
                        result[i] = ' ';
                        continue;
                    }

                    if(currentChar >=97 && currentChar <= 122)
                    {
                        char shifted = (char)(((currentChar - 97 + key)%26)+97);
                        result[i] = shifted;
                    }
                    else
                    {
                        result[i] = currentChar;
                    }
                }

                return new string(result);

        }
    }
}
