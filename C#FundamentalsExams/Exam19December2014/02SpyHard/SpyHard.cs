namespace _02SpyHard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SpyHard
    {
        static void Main(string[] args)
        {
            long key = long.Parse(Console.ReadLine());
            string massage = Console.ReadLine().ToLower();
            int lenghtMassage = massage.Length;

            long sum = 0;

            for (int i = 0; i < massage.Length; i++)
            {
                char letter = massage[i];
                if (letter >= 'a' && letter <= 'z')
                {
                    sum += letter - 'a' + 1;
                }
                else
                {
                    sum += letter;
                }
            }
            StringBuilder sb = new StringBuilder();
            while (sum > 0)
            {
                sb.Insert(0, sum % key);
                sum /= key;
            }
            sb.Insert(0, lenghtMassage);
            sb.Insert(0, key);
            Console.WriteLine(sb);
        }
    }
}
