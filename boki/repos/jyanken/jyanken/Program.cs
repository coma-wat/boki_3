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
            Console.WriteLine("お名前入力");
            string anata= Console.ReadLine();

            Player player1 = new Player("りんご",9);
            
            Console.WriteLine(player1.name+"さんが相手です年齢は"+ player1.age+"才");
            
            Random a= new Random();
            int aite;
        
            aite = a.Next(1, 4);
            

            int jibu;
            Console.WriteLine(anata + "さんじゃんけんぽい グーは1　チョキは2　パーは3を入力");
            jibu = int.Parse(Console.ReadLine());

            string kome;
            if (aite == jibu)
            {
                kome = "あいこ";
            }
            else if (aite == 1 && jibu == 2 || aite == 2 && jibu == 3 || aite == 3 && jibu == 1)
            {
                kome = player1.name + "さんの勝ち";
            }
            else if (aite == 1 && jibu == 3 || aite == 2 && jibu == 1 || aite == 3 && jibu == 2)
            {
                kome = anata+ "さんの勝ち";
            }
            else
            {
                kome = "正しい値を入力してください";
            }
            Console.WriteLine("判定は「{0}」です", kome);

            
            if(aite==1)
            {
                player1.Gu();

            }
           else if(aite==2)
            {
                player1.Tyoki();
            }
            else if (aite ==3)
            {
                player1.Pa();
            }
            if(jibu==1)
            {
                Console.WriteLine(anata+"さんグーを出した");
            }
            else if (jibu == 2)
            {
                Console.WriteLine(anata + "さんチョキを出した");
            }
            else if (jibu ==3)
            {
                Console.WriteLine(anata + "さんパーを出した");
            }
            
        }
    }
}
