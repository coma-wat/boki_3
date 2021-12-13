using System;
using System.Collections.Generic;
using System.Text;

namespace KartGame
{
    class TurboKart:Kart
    {
        
       
        public void Turbo()
        {
            Console.WriteLine("ブースト");
                
        }
        public override void Horn()
        {
            Console.WriteLine("ビービー");
        }
    }
}
