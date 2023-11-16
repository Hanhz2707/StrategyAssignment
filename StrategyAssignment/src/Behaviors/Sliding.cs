using StrategyAssignment.src.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment.src.Behaviors
{
    public class Sliding : IBehavior
    {
        public void Fly()
        {
            Console.WriteLine("*SLIDES BY ITS BELLY*");
        }
    }
}
