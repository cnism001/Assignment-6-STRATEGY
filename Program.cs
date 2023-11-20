using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_STRATEGY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list of test birbs
            var birds = new List<Bird>
            {
                new MallardDuck(),
                new EmperorPenguin(),
                new BaldEagle(),
                new Ostrich(),
                new YellowRubberDuck()
            };
            //counts and prints total amount of birds in "birds" list
            Console.WriteLine($"Number of birds in the simulation: {birds.Count}");
            foreach (var bird in birds)
            {
                //loops until for every bird in the list it types its type and flight ability
                Console.WriteLine($"Here is the {bird.GetType().Name}'s movement behavior: {bird.PerformFly()}");
            }

        }
    }




























}

