using System;
using System.Collections.Generic;
using System.Text;

namespace Sample_RPG
{
    class Player
    {
     
            
           


        public string name;
        public int hp;

        public Player(string name,int hp) //引数を指定する
        {
            this.name = name;
            this.hp = hp;
        }





        public int Hp
        {
            set
            {


                this.hp = value;
                if (this.hp < 0)
                {
                    this.hp = 0;
                }
            }
            get
            {
                return this.hp;
            }
        }
        public int GetHp()
        {
            return this.hp;
        }

        public void Attack()
        {
            Console.WriteLine(this.name + "は攻撃した");

        }
        public void Defense()
        {
            Console.WriteLine(this.name + "は防御した");

        }
        
        
        

        




    }
}
