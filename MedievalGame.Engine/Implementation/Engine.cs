using MedievalGame.Engine.CommandTaker;
using MedievalGame.Engine.Economy;
using MedievalGame.Engine.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedievalGame.Engine.Implementation
{
    public class Engine : IObservable
    {
        public int PlaySpeed { get; set; } = 1000;
        public List<IObserver> Observers { get; set; } = new List<IObserver>();

        public void InitEngine()
        {
            Observers.Add(new PassiveIncome());
            Observers.Add(new InputTaker());
        }

        public void Notify()
        {
            foreach (var item in Observers)
            {
                item.Update();
            }
        }

        public void Start()
        {
            while (true)
            {
                Notify();
                Thread.Sleep(PlaySpeed);
            }
        }

    }
}
