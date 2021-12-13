using System;

namespace kayoubi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*         int tyokei;
                     int hankei;
                     float ennsyu;


                     tyokei = int.Parse(Console.ReadLine());

                     hankei = tyokei / 2;
                     ennsyu = 3.14f;


                     int anser1 =hankei * hankei ;
                     float anser2 = anser1 * ennsyu;
                     Console.WriteLine(anser2);
            
           

            double t;
            double tt;
            double w;
           
            Console.WriteLine("身長を入力");
            t = double.Parse(Console.ReadLine());
            tt = t * 0.01;
            Console.WriteLine("体重をを入力");
            w = double.Parse(Console.ReadLine());


           double bmi = w / (tt*tt) ;
            

            
             

           
            Console.WriteLine("BMIは"+bmi);

            if (bmi<18.5)
                {
                Console.WriteLine("やせ型");
            }
            else if(bmi<25)
            {
                Console.WriteLine("普通体重");
            }
            else if(bmi<30)
            {
                Console.WriteLine("肥満1度");
            }
            else if (bmi < 35)
            {
                Console.WriteLine("肥満2度");
            }

            else if (bmi < 40)
            {
                Console.WriteLine("肥満3度");

            }
            else if (bmi >=40)
            {
                Console.WriteLine("肥満4度");
            }
            


            int min ;
            string stmp;
            int hou ;

            Console.WriteLine("分を入力");
            stmp = (Console.ReadLine());

            bool bl;
            bl = false;
            hou = 0;
            if(!int.TryParse(stmp, out min))
                 
                    {
                        Console.WriteLine("分は正の整数を入力してください。");
                        Console.WriteLine("再入力");
                bl = true;
                
                    }
            if (min < 0)
            {


                Console.WriteLine("分は正の整数を入力してください。");
                Console.WriteLine("再入力");
                bl = true;
            }
            else
                bl = false;



            if (min<60)
            {
                Console.WriteLine("0時間"+min+"分");
                

            }
            while(min>=60)
            {
                min=min-60;
                hou++;
             
            }
            
            Console.WriteLine(hou + "時間" + min + "分");
            


            int n = 2;
            
            try
            {
                n = n / 0;
                Console.WriteLine(n );
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("0ではわれません");
            }
            */

           




        }

    }
}
