using System;

namespace Sample_RPG
{
    class Program
    {
       static void Recover(ref int hp)
        {
            hp = 100;
        }
            
        static void Main(string[] args)
        {

            int hp = 30;
            Recover(ref hp);
            Console.WriteLine("HP=" + hp);









            /* Player player = new Player("ひろし",100);


             player.Hp -= 70;
             Console.WriteLine("HPは" + player.Hp);
            
            //値型
            int num1 = 35;
            int num2 = num1;
            Console.WriteLine(num2);
            num1 = 0;
            Console.WriteLine(num2);
            

            //参照型
            Player player1 = new Player("たかし", 35);
            Player player2 = new Player("ひろし", 100);

            player2 = player1;
            Console.WriteLine( player2.Hp);

            player1.Hp = 0;
            Console.WriteLine(player2.Hp);
            */









        }
       
        
           

        
    }
}
