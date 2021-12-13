using System;

namespace kadai6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]hairetu = new int[22];
            hairetu[1] = 0;
            hairetu[2] = 1;
            Console.WriteLine(hairetu[1]);
            Console.WriteLine(hairetu[2]);
            for (int i=3;i<=22;i++)
            {
                hairetu[i] = hairetu[i - 1] + hairetu[i - 2];
                Console.WriteLine(hairetu[i]);
            }
           
            

        }
    }
}
