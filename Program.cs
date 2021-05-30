using System;

namespace grafica
{
    class Program
    {
        static void Main(string[] args)
        {
             using (Game game = new Game(800,600,"Escenario Oswaldo"))
             {
                 game.Run(60.0);
             }
            Console.WriteLine("Hello World!");
        }
    }
}
