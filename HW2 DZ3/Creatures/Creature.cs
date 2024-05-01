using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW2_DZ3.Creatures
{
    public abstract class Creature
    {
        protected static readonly List<Creature> allSpecies = new List<Creature>();

        public string FirstName { get; set; }

        public int Age { get; init; }

        public Gender Gender { get; set; }

        public void Print()
        {
            Console.WriteLine(this);
        }

        public static void PrintAllCreatures()
        {
            foreach (Creature creature in allSpecies)
            {
                creature.Print();
                Console.WriteLine(creature.GetType());
                Console.WriteLine("\n");
            }
        }
    }
}
