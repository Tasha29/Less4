using System;

namespace Less4
{
    class Program
    {
        static void Main(string[] args)
        {
            test10();
            test16();
            test17();

        }

        private static void test10()

        {
            double c = 26.38; //course


            Console.WriteLine($"Course:{c} USD");

            {
                for (double i = 1; i <= 20; i++)


                    Console.WriteLine($"Эквивалент {i} USD равен:{c * i} UAH");
            }
        }

        private static void test16()

        {
            for (double r=1; r <= 9; r++)

                Console.WriteLine($"{r}*{9} = {r * 9}");

        }

        private static void test17()

        {
            double u1, p1 = 5, p2=5, p3=6, p4=7;
            double u2, r1 = 5, r2 = 5, r3 = 6, r4 = 7;

            u1 = (p1 + p2 + p3 + p4) / 4;
            u2 = (r1 + r2 + r3 + r4) / 4;

            if (u1>u2)
            
            {
                Console.WriteLine($"Первый ученик учится лучше второго");
            }

            else if (u1<u2)
            {
                Console.WriteLine($"Второй ученик учится лучше первоого");
            }
            else
            {
                Console.WriteLine($"Оба ученика учятся одинаково");
            }
        }
    }
}
