using System;
using System.Collections.Generic;
using System.Text;

namespace KartGame
{
    class Kart
    {
        public int weight;
        public int speed;
        public void Force()
        {
            Console.WriteLine("加速");

        }
        public virtual void Horn()
        {
            Console.WriteLine("ブッブー");
        }
    }
}
