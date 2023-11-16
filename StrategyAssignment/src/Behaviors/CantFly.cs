using StrategyAssignment.src.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment.src.Behaviors
{
    public class CantFly : IBehavior
    {
        public void Fly()
        {
            Console.WriteLine("*HIDES HEAD IN THE SAND AS IT CANNOT FLY*");
        }
    }
}
