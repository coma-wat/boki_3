using System;

namespace saikoro
{
    class Program
    {
        static void Main(string[] args)
        {
            
         int seed = Environment.TickCount;
            Random r = new Random(seed);

            int idaice = r.Next(1, 7);
            int count1=0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;
            for(int i=0; i<99;i++)
            if (idaice==1)
            {
                    i++;
                count1++;
            }
            else if(idaice==2)
            {
                    i++;
                count2++;
            }
            else if (idaice == 3)
            {
                    i++;
                count3++;
            }
            else if (idaice == 4)
            {
                    i++;
                count4++;
            }
            else if (idaice == 5)
            {
                    i++;
                count5++;
            }
            else  if(idaice==6)
            {
                    i++;
                count6++;
            }
            Console.WriteLine("1" + count1);
            Console.WriteLine("2" + count2);
            Console.WriteLine("3" + count3);
            Console.WriteLine("4" + count4);
            Console.WriteLine("5" + count5);
            Console.WriteLine("6" + count6);
        }
    }
}
