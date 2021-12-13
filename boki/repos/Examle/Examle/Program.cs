using System;
using System.Collections.Generic;
using System.Linq;

namespace Examle
{
    class Program
    {
        
       /* static int Shop(string itemeName)
       {
            Console.WriteLine("いらっしゃいませ");
            int price = 0;
            if (itemeName == "薬草")
            {
                Console.WriteLine(itemeName + "は100円です");
                price = 100;
            }

            else if (itemeName == "こんぼう")

            {
                Console.WriteLine(itemeName + "は1500円です");
                price = 1500;
            }

            else
            {
                Console.WriteLine(itemeName + "売り切れです");
                price = 0;

            }

            return price;


        }
        static void Tankyou()
        {
            Console.WriteLine("ありがとうございました");
       }
       */
    

        static void Main(string[] args)
        {
            /* Dictionary<string, float> weights = new Dictionary<string, float>();

             weights.Add("2016/12/10",41.2f);
             weights.Add("2016/12/11",42.5f);
             weights.Add("2016/12/12",44.9f); 
             weights.Add("2016/12/13",43.2f);
             weights.Add("2016/12/14",43.2f);
             weights.Add("2016/12/15",42.7f);
             weights.Add("2016/12/17",41.7f);

             Console.WriteLine(weights["2016/12/13"]+"ｋｇ");

             //練習問題5-3
             Dictionary<string, string> denwatyo = new Dictionary<string, string>();
             denwatyo.Add("山田","000-123-4563");
             denwatyo.Add("小山田", "000-469-2488");
             denwatyo.Add("山本", "000-312-7721");

             Console.WriteLine(denwatyo["山田"] );
             foreach(string a in denwatyo.Keys)
             {
                 Console.WriteLine(a+"は"+denwatyo[a]);
             }
            */




            /*    int[] hp = { 420, 120, 600, 0, 1200 };
                List<int> newHP= new List<int>();

                for (int i = 0; i < hp.Length; i++)
                {
                    if (hp[i] >= 500)
                    {
                        newHP.Add(hp[i]);
                    }

                }  

                foreach(int n in newHP)
                {
                    Console.WriteLine(n);

                }


                /*    List <int>hp= new List<int>();
                    hp.Add(420);
                    hp.Add(120);
                    hp.Add(600);
                    hp.Add(0);
                    hp.Add (600);
                */


            /*     int[] hp = { 420, 120, 600, 0, 1200 };

                 var newHP = hp.Where(n => n >= 500);
                 foreach(int n in newHP)
                 {
                     Console.WriteLine(n);
                 }
            
            int[] hp = { 550, 420, 600, 800, 220 };

            for (int i = 0; i < hp.Length; i++)
            {
                hp[i] -= 100;

            }
            


            int[] hp = { 550, 420, 600, 800, 220 };

            var newHP=hp.Select(n => n - 100 );
            foreach(int n in newHP)
            {
                Console.WriteLine(n); 
            }
            



            int[] hp = { 550, 0, 600, 0, 220 };
            int num = 0;

            for(int i=0;i<hp.Length;i++)
            {
                if (hp[i] == 0) 
                {
                    num++;
                }
            }

            Console.WriteLine(num);
            

            int[] hp = { 550, 0, 600, 0, 220 };

            int num = hp.Where(n => n == 0).Count();

            Console.WriteLine(num);
            */

            int[] a = { -1,-10,-5,-40,-15 };
            var newa = a.Select(n => n + 10);
            
            int num = newa.Where(n => n >= 0).Count();
            Console.WriteLine(num+"個です");









            /*   List<float> weights = new List<float>();

               weights.Add(41.2f);
               weights.Add(42.5f);
               weights.Add(3.2f); //おかしなデータ削除
               weights.Add(44.9f);
               weights.Add(43.2f);
               weights.Add(43.2f);
               weights.Add(42.7f);
               weights.Add(41.7f);
               weights.Add(12.2f);

               weights.RemoveAt(2);　　//配列番号を削除
               weights.Remove(12.2f); //要素を削除
               weights.Sort();        //並べ替え



               for (int i = weights.Count-1; i>=4; i--)
               {
                   Console.WriteLine(weights[i]+"ｋｇ");

               }


           /*    //練習問題5-1

               List<string> name = new List<string>();
               name.Add("さとう");
               name.Add("たかはし");
               name.Add("たなか");
               name.Add("すずき");
               name.Add("こばやし");
               name.Add("さいとう");
               name.Add("わたなべ");


               for(int i=0; i<name.Count; i++)
               {
                   Console.WriteLine(i+1+"人目は"+name[i]);
               }
               */
























        }

    }
            /*   int money = 2500;
               Console.WriteLine("所持金は"+money+"円です");
               Console.WriteLine("購入したいものは？ ");
               String itemeName=Console.ReadLine();
               int price = Shop("こんぼう");
               money -= price;
               Console.WriteLine("所持金は"+money + "円になります");
               Tankyou();



               /*  int answer;   //計算結果
                 string msg;
               */



            /*                    //足し算
                                 answer = 3 + 4;
                                 Console.WriteLine(answer);

                                 //引き算
                                 answer = 12 - 18;
                                 Console.WriteLine(answer);

                                 //掛け算
                                 answer = 2 * 7;
                                 Console.WriteLine(answer);

                                 //割り算
                                 answer = 18 / 3;
                                 Console.WriteLine(answer);

                                 //剰余
                                 answer = 21 % 5;
                                Console.WriteLine(answer);
            */

            /*           int answer;
                       string msg;

                       //3-1練習 1-5の和
                       msg = "1-5の和";
                       answer = 1 + 2 + 3 + 4 + 5;
                       Console.WriteLine(msg);
                       Console.WriteLine(answer);



                       //3-2練習　30を7で割った剰余
                       msg = "30を7で割った剰余";
                       answer = 30 % 7;
                       Console.WriteLine("(3-2練習)");
                       Console.WriteLine(msg);
                       Console.WriteLine(answer);
            
                       int money = 15000;
                       int salary = 1000;
                       int hour = 5;
           
            
           

                       int sum = money + salary * hour;
                       Console.WriteLine("(所持金の合計)");
                       Console.WriteLine(sum);
            /*

            


            /*         
             *         int sum = money + (salary+150)* hour;
                      Console.WriteLine("(所持金の合計)");
                      Console.WriteLine(sum);
            */

            /*          //練習問題3-4
                       int money = 5000;
                       int salary = 800;
                       int hour = 2;
                       int sum = money + salary * hour;
                       Console.WriteLine("<練習問題3-4>");
                       Console.WriteLine("(所持金の合計)");
                       Console.WriteLine(sum+"円");
            */

            /*           int math =80;
                       int english = 66;
                       int history = 95;

                       float average = (math + english + history) / 3.0f;
                       Console.WriteLine("(テスト科目の平均)");
                       Console.WriteLine("平均は" + average+"点");
            */

            /*          int english = 260;

                      int history = 0;

                      float anser=english / (float)history;
                      Console.WriteLine(anser);
            */

            /*           int life = 92;
                       life++;

                       Console.WriteLine("ライフの個数");

                       Console.WriteLine(life+"個");


                       int a = 10;
                       a--;
                       a--;
                       Console.WriteLine(a);
                       a /= 4;
                       Console.WriteLine(a);
           

            int playerposk = 5;
            int enemposk = 10;
            if (playerposk == enemposk)
            {
                Console.WriteLine("敵と遭遇");
            }
            

            int num= 2;
            if (num<3)
            {
                Console.WriteLine("練習3-7");
                Console.WriteLine("勝ち");
            }
            

            int player1posk = 6;

            int player2posk = 2;

               
            //プレイヤー1の位置が［2］ANDプレイヤー2の位置が「6」の場合に仕掛け解除
            if (player1posk == 2 && player2posk == 6  ||   player1posk ==6&& player2posk == 2) 
            {
                
                
                    Console.WriteLine("仕掛けを解除");

                
            }
            
            int playerposy = 0;
            if(playerposy >= 0)
            {
                Console.WriteLine("走る");

            }
            else
            {
                Console.WriteLine("泳ぐ");
            }
            

            int num = 2;
            if (num >= 3)
            {
                Console.WriteLine("勝ち");
            }
            else 
            {
                Console.WriteLine("負け");
            }

           
            int hp=100;
            int maptipe = 2;
            if(maptipe == 1)
            {
                hp += 10;
            }
            else if(maptipe == 2)
            {
                hp -= 5;
            }
            else if(maptipe == 3)
            {
                hp = 0;
            }
            else
            {
                Console.WriteLine("HPの変化なし");
            }

            Console.WriteLine("HP="+hp);
            

            　//攻撃を5回繰り返す
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("攻撃" );

            }

            //逃走を3回繰り返す練習3-12
             for(int i=0; i<3; i++)
            {

                Console.WriteLine("逃走");

            }
            //参加者を点呼する
            for (int i = 1; i <5; i++)
            {
                Console.WriteLine(i+1+"番!");
            }
            //練習3-14
            for(int i=0; i<10; i=i+3)
            {
                Console.WriteLine(i );
            }
            

            //カウントダウン
            for(int i=3; i>0; i--)
            {
                Console.WriteLine(i);

            }

            Console.WriteLine("スタート！");

            //練習3-15
            for(int i=10; i>-1; i--)
            {
                Console.WriteLine(i);
            }

            int playerPosk = 5;
            int missilPosk = 15;

            while(true)
            {
                if(playerPosk== missilPosk)
                {
                    break;

                }

                    Console.WriteLine("missil at"+ missilPosk);
                missilPosk--;
            }

            Console.WriteLine("HIT" );

            //練習3-16

            int kaisu = 0;
            int b = 10000;
            while(b>100)
            {
                b /= 2;
                kaisu++; 

            }

            Console.WriteLine(kaisu+"回");
            

            //練習3-17
            int goke = 0;
            int tasu = 1;
            int kaisu = 0;
            while(true)
            {
           if(goke>500)
                {
                    break;

                }
                tasu++;
                goke++;
                kaisu++;
            }
            Console.WriteLine(kaisu+ "おつかれ");
            
            float[] weigths;
            weigths = new float[7];
            weigths[0] = 41.2f;
            weigths[1] = 42.5f;
            weigths[2] = 44.9f;
            weigths[3] = 43.2f;
            weigths[4] = 45.1f;
            weigths[5] = 43.2f;
            weigths[6] = 42.7f;

            for(int i=0; i<7; i++)
            {
                Console.WriteLine(weigths[i]+"kg");
            }


            float[] weigths={41.2f,42.5f, 44.9f,43.2f,45.1f,43.2f,42.7f};
            float sum = 0.0f;
            for (int i = 0; i<weigths.Length; i++)
            {
                sum += weigths[i];


            }
            float average = sum / weigths.Length;
            Console.WriteLine(average + "kg");
            
            //練習問題3-18
            float[] weigths = { 41.2f, 42.5f, 44.9f, 43.2f, 45.1f, 43.2f, 42.7f };
            for (int i = 0; i < weigths.Length; i++)
            {
                if (weigths[i] <= 43.0f)
                {

                    Console.WriteLine(weigths[i] + "kg");
                }
            }
            */












        }
   
