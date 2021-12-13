using System;

namespace KartGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Kart[] Karts = new Kart[2];
           
            Karts[0] = new SkyKart();
            Karts[1] = new TurboKart();
            for(int i=0; i<Karts.Length;i++)
            {
                Karts[i].Horn();
            }
        }
    }
}
