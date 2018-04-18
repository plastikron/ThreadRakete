using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationThreadRakete
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleObjects consObjects = new ConsoleObjects();
            Object lockObject = new Object();
            Console.WindowHeight = 40;
            Rakete r1 = new Rakete { Speedx = 1, Speedy = 1, MyColor = ConsoleColor.Red, X = 20, Y = Console.WindowHeight, Lockobject = lockObject };
            Rakete r2 = new Rakete { Speedx = 2, Speedy = 2, MyColor = ConsoleColor.Green, X = 40, Y = Console.WindowHeight, Lockobject = lockObject };
            Rakete r3 = new Rakete { Speedx = 3, Speedy = 5, MyColor = ConsoleColor.Yellow, X = 60, Y = Console.WindowHeight, Lockobject = lockObject };
            Superman s1 = new Superman { Speedx = 6, Speedy = 6, MyColor = ConsoleColor.White, X = 80, Y = Console.WindowHeight, Lockobject = lockObject };

            consObjects.AddObject(r1);
            consObjects.AddObject(r2);
            consObjects.AddObject(r3);
            consObjects.AddObject(s1);
            consObjects.DisplayAll();

            Console.ReadLine();
            consObjects.MoveAllUp();
            Console.ReadLine();
        }
    }
}
