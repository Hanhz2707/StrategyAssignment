using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment.src.Animals
{
    public class Bird 
    {
        private string _birdName;
        private string _birdColor;
        private IBehavior _behavior;

        public Bird (string name, string color)
        {
            this._birdName = name;
            this._birdColor = color;
        }

        public void setBehaviors (IBehavior behavior)
        {
            this._behavior = behavior;
        }

        public void Fly()
        {
            Console.Write("Here is the " + _birdName + " movement behavior: " );
            _behavior.Fly();


        }




    }
}
