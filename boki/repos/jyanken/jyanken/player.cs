using System;
using System.Collections.Generic;
using System.Text;

namespace jyanken
{
    class Player
    {
        public string name;
        public int age;


        public Player(string name,int age)
        {
            this.name = name;
            this.age = age;

        }
        public void Gu()
        {
            Console.WriteLine(this.name + "さんグーを出した");
        }
        public void Tyoki()
        {
            Console.WriteLine(this.name + "さんチョキを出した");
        }
        public void Pa()
        {
            Console.WriteLine(this.name + "さんパーを出した");
        }
    } 
}
