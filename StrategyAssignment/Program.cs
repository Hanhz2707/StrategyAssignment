using StrategyAssignment.src;
using StrategyAssignment.src.Animals;
using StrategyAssignment.src.Behaviors;

namespace StrategyAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Bird> birdsList = new List<Bird>();
            Bird mallardDuck = new Bird("Mallard Duck", "white");
            Bird penguine = new Bird("Penguin", "white and black");
            Bird baldEagle = new Bird("Bald Eagle", "white and yellow and black");
            Bird ostrich = new Bird("Ostrich", "brown and black");
            Bird yellowRubberDuck = new Bird("Yellow Rubber Duck", "yellow and white");

            birdsList.Add(mallardDuck);
            birdsList.Add(penguine);
            birdsList.Add(baldEagle);
            birdsList.Add(ostrich);
            birdsList.Add(yellowRubberDuck);

            mallardDuck.setBehaviors(new CanFly());
            penguine.setBehaviors(new Sliding());
            baldEagle.setBehaviors(new CanFly());
            ostrich.setBehaviors(new CantFly());
            yellowRubberDuck.setBehaviors(new Floating());

            Console.WriteLine("Number of birds in the simulation: " + birdsList.Count() );
            foreach(Bird b in birdsList)
            {
                b.Fly();    
            }
        }
    }
}