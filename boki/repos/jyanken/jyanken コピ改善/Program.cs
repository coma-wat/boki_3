using System;

namespace jyanken
{
    class Program
    {
        static void shop()
        {
            Console.WriteLine("ようこそじゃんけんルームへ");

        }
       

        

        static void Main(string[] args)
        {
            shop();

            int aite;
            Console.WriteLine("相手がじゃんけんぽい グーは1　チョキは2　パーは3を入力");
            aite = int.Parse(Console.ReadLine());
            Console.Clear();

            int jibu;

            Console.WriteLine("あなたがじゃんけんぽい グーは1　チョキは2　パーは3を入力");
            jibu = int.Parse(Console.ReadLine());

            string kome;
            if (aite == jibu)
            {

                kome = "あいこ";
            }
            else if (aite == 1 && jibu == 2 || aite == 2 && jibu == 3 || aite == 3 && jibu == 1)
            {
                kome = "相手の勝ち";
            }
            else if (aite == 1 && jibu == 3 || aite == 2 && jibu == 1 || aite == 3 && jibu == 2)
            {
                kome = "あなたの勝ち";
            }

            else
            {
                kome = "正しい値を入力してください";
            }
            Console.WriteLine("判定は「{0}」です", kome);
           
        }
    }
}
