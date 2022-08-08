using System;

namespace HOME4
{
    class Program
    {
        static void Main(string[] args)
        {
            //first
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            
            void MaxN(int x, int y)
            {
                Console.WriteLine(Math.Max(x, y));
            }
            MaxN(a, b);

            //second
           

            void MinN(int x, int y)
            {
                Console.WriteLine(Math.Min(x, y));
            }
            MinN(a, b);

            //third
            static bool TrySumIfOdd(int x, int y)
            {
                int p = (x + y) % 2;
                if (p == 0)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            bool Num = TrySumIfOdd(a, b);

        }
    }
}

//Просмотрено
