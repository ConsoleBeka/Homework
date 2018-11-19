using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz3
{
    class Program
    {
        static void Main(string[] args)
        {
            Three();
            Console.Read();
        }

        static void One()
        {
            int count = 0;
            string a;
            do
            {
                a = Console.ReadLine();
                foreach (char b in a) { if (b == ' ') { count++; } }
            } while (a != ".");
            Console.Write(count);
        }

        static void Two() {
            int[] number=new int [6];
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < number.Length; i++)
            {
                if (i < 3)
                {
                    sum1 = sum1 + number[i];
                }
               else if (i>2 && i<6){
                    sum2 = sum2 + number[i];
                }
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Lucky");
            }
            else
            {
                Console.WriteLine("Not lucky");

            }
            Console.Read();

        }
        static void Three()
        {
            char sym = ' ';
            while (true)
            {
                var symbol = Console.Read();

                if (symbol >= 65 && symbol <= 90)
                {
                    symbol += 32;
                }
                else if (symbol >= 97 && symbol <= 122)
                {
                    symbol -= 32;
                }
                sym = Convert.ToChar(symbol);
                Console.Write(sym);
            }

        }

        static void Four()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (; a <=b; a++)
            {
                for (int i = 0; i < a; i++)
                    Console.Write(a);
                Console.WriteLine();
            }
            
            Console.Read();

        }

        static void Five()
        {
            
            int num = int.Parse(Console.ReadLine());
            string str = "";

            while (num >= 10)
            {
                str += (num % 10).ToString();
                num = num / 10;
            }

            str += num.ToString();
            Console.WriteLine(str);
        }
    }
}
