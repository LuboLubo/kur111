namespace _03Headphones
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Headphones
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}",
                new string('-', N / 2),
                new string('*', N + 2));

            int topDots = N;
            for (int i = 0; i < topDots; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('-', N / 2),
                    new string('*', 1),
                    new string('-', N));

            }

            int topRows = N / 2 - 1;
            int nexRows = 3;
            int topTops = N - 2;
            int nexDots = N / 2;

            for (int i = 0; i < nexDots; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('-', topRows),
                    new string('*', nexRows),
                    new string('-', topTops));

                topRows--;
                nexRows += 2;
                topTops -= 2;
            }
            int toppRows = 1;
            int nexxRows = N - 2;
            int toppTops = 3;
            int nexxDots = N / 2;
            for (int i = 0; i < nexxDots; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                        new string('-', toppRows),
                        new string('*', nexxRows),
                        new string('-', toppTops));

                toppRows++;
                nexxRows -= 2;
                toppTops += 2;
            }
        }
    }
}
