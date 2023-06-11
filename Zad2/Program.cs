namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long longestChain = 0;
            long longestChainValue = 0;
            long tmp;

            for (int i = 1; i < 1_000_000; i++)
            {
                tmp = CountCollatzProblem(i);

                if (tmp > longestChain)
                {

                    longestChain = tmp;
                    longestChainValue = i;
                }
            }

            Console.WriteLine("Longest chain = {0} for value = {1}", longestChain, longestChainValue);
        }

        static long CountCollatzProblem(long value)
        {
            long i = 1;

            while (true) 
            {
                if (i % 10_000 == 0)
                {
                    Console.WriteLine(i);
                }


                if (value == 1)
                {
                    return i;
                }

                i++;

                if (value % 2 == 0)
                {
                    value /= 2;
                }
                else
                {
                    value = 3 * value + 1;
                }
            }
        }
    }
}