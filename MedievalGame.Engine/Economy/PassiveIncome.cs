using MedievalGame.Engine.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalGame.Engine.Economy
{
    public class PassiveIncome : IObserver
    {
        public int Balance { get; set; }
        public void Update()
        {
            Balance += 50;
            Console.WriteLine($"New balance is {Balance}");
        }
    }
}
