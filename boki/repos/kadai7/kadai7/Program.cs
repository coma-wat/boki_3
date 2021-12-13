using System;

namespace kadai7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ransu = new int[100];
            Random ram = new Random();



            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(ransu[i] = ram.Next(0, 101));
            }
            Console.WriteLine("-----");
            int tem;
            for (int i = 0; i < 100; i++)
            {
                for (int j = i + 1; j < 100; j++)
                {

                    if (i < j)
                    {
                        tem = ransu[i];
                        ransu[i] = ransu[j];
                        ransu[j] = tem;

                    }
                }

            }
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(ransu[i]);
            }


        }
    
               



        
    }
}
