using MedievalGame.Engine.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalGame.Engine.CommandTaker
{
    public class InputTaker : IObserver
    {
        public void Update()
        {
            if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.WriteLine("Game paused enter command!");
                string s = Console.ReadLine();
                Console.WriteLine(s);
            }
        }
    }
}
