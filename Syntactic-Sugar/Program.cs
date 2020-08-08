using Syntactic_Sugar;
using System;
using System.Collections.Generic;

namespace SyntacticSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            var predsForBug1 = new List<string>()
            { 
                "Fox",
                "Badger",
                "Monkey",
            };

            var preyForBug1 = new List<string>()
            {
                "Mouse",
                "Lizard",
                "Snake",
            };

            var predsForBug2 = new List<string>()
            {
                "Bat",
                "Bird",
                "Frog",
            };

            var preyForBug2 = new List<string>()
            {
                "Grasshopper",
                "Cricket",
                "Moth",
            };

            var bug1 = new Bug("Tarantula", "Spider", predsForBug1, preyForBug1);

            Console.WriteLine($"My bug is {bug1.FormalName}.");
            Console.WriteLine($"The things that like to eat my bug are: {bug1.PredatorList()}.");
            Console.WriteLine($"The things that my bug likes to eat are: {bug1.PreyList()}.");
            Console.WriteLine($"The {bug1.Eat("Mouse")}");
            Console.WriteLine(bug1.Eat("Cow"));

            var bug2 = new Bug("Devil's Flower Mantis", "Mantis", predsForBug2, preyForBug2);

            Console.WriteLine($"My bug is {bug2.FormalName}.");
            Console.WriteLine($"The things that like to eat my bug are: {bug2.PredatorList()}.");
            Console.WriteLine($"The things that my bug likes to eat are: {bug2.PreyList()}.");
            Console.WriteLine($"The {bug2.Eat("Grasshopper")}");
            Console.WriteLine(bug2.Eat("Leaf"));
        }
    }
}
