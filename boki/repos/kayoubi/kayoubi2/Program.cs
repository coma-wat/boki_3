using System;

namespace kayoubi2
{
    class Program
    {
        static void seisu()
        {
            Console.WriteLine("分は正の整数を入力してください");
        }
        static void sai()
        {
            Console.WriteLine("再入力");
        }
        static void Main(string[] args)
        {
            int min;
            string stmp;
            int hou;
            bool bl;
            do
            {
                bl = false;
                Console.WriteLine("分を入力");
                stmp = (Console.ReadLine());
                if (!int.TryParse(stmp, out min))

                {
                    seisu();
                    sai();
                    bl = true;

                }
                if (min < 0)
                {
                    seisu();
                    sai();
                    bl = true;
                }
            } while (bl);

            long hour = 0;
            string same;
            
            if (min >= 60)
            {
                min = min - 60;
                hour++;

            }

            same = string.Format("{0}分は{1}時間{2}分です", stmp, hour, min);
            Console.WriteLine(same);
        }
        
        
    }
}
