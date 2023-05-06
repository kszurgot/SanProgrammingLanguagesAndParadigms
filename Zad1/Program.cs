namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? input;

            while (true)
            {
                Console.WriteLine("Podaj liczbę:");
                input = Console.ReadLine();

                if (!int.TryParse(input, out _) || input.Length > 4)
                {
                    Console.WriteLine("Nieprawidłowa liczba\n");
                    continue;
                }

                break;
            };

            input = input.PadLeft(4, '0');

            var inputResult = GetNumberInWrittenForm(input);

            Console.WriteLine();
            Console.WriteLine($"Liczba zapisana słownie: {inputResult}");
            Console.WriteLine($"Liczba znaków: {inputResult.Replace(" ", string.Empty).Length}");

            int result = 0;
            for(int i = 1; i <= 1000;  i++)
            {
                result += GetNumberInWrittenForm(i.ToString())
                    .Replace(" ", string.Empty)
                    .Length;
            }

            Console.WriteLine();
            Console.WriteLine($"Liczba znaków do zapisania liczb od 1 do 1000: {result}");
        }

        private static string GetNumberInWrittenForm(string number)
        {
            string result = "";
            string value;

            number = number.PadLeft(4, '0');

            var (thousands, hundreds, tens, units, _) = number.Select(n => n - '0');

            if (NumberDictionary.Thousands.TryGetValue(thousands, out value))
            {
                if (thousands > 1) {
                    result += $" {NumberDictionary.Units[thousands]}";
                }

                result += $" {value}";
            }

            if (NumberDictionary.Hundred.TryGetValue(hundreds, out value))
            {
                result += $" {value}";
            }

            if (tens == 1 && units != 0)
            {
                if (NumberDictionary.Teen.TryGetValue(tens, out value))
                {
                    result += $" {value}";
                }

            }
            else
            {
                if (NumberDictionary.Tens.TryGetValue(tens, out value))
                {
                    result += $" {value}";
                }

                if (NumberDictionary.Units.TryGetValue(units, out value))
                {
                    result += $" {value}";
                }
            }

            //Console.WriteLine($"{thousands} {hundreds} {tens} {units}");

            return result.Substring(1);
        }
    }

  
}