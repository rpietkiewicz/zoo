﻿using System;

namespace TheZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###################################################\n");
            Console.WriteLine("----------You are now using Zoo--------------\n");
            Console.WriteLine("###################################################\n");
            Console.WriteLine("**********Press any key to continue****************\n");
            Console.ReadLine();
            Console.WriteLine("Here are the list of animals that are available to see today: \n");
            Console.WriteLine("/////Animal/////         " + "/////Location/////         ");
            Console.WriteLine("1. Scorpion              " + "Desert East Side           ");
            Console.WriteLine("2. Lion                  " + "Plains West Side           ");
            Console.WriteLine("3. Grizzly Bear          " + "Forest South Side          ");
            Console.WriteLine("4. Cheetah               " + "Plains East Side           ");
            Console.WriteLine("5. Redback Spider        " + "Gardens North Side         ");
            Console.WriteLine("6. Snow Leopard          " + "Arctic South Side          ");
            Console.WriteLine("7. Anaconda              " + "Plains South Side          ");
            Console.WriteLine("8. Alligator             " + "Lakes West Side            ");
            Console.WriteLine("9. Polar Bear            " + "Arctic North Side          ");
            Console.Write("\n");
            Console.WriteLine("Enter in a animal to see the time of that animals exhibition");
            Console.ReadLine();
            string animal = Console.ReadLine();
            //Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
