using System;

namespace TheZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            string scorpion = null;
            Console.WriteLine("###################################################\n");
            Console.WriteLine("----------You are now using Zoo--------------\n");
            Console.WriteLine("###################################################\n");
            Console.WriteLine("**********Press any key to continue****************\n");
            Console.ReadLine();
            Console.WriteLine("Here are the list of animals that are available to see today: \n");
            Console.WriteLine("/////Animal/////         " + "/////Location/////         ");
            Console.WriteLine("1. scorpion              " + "Desert East Side           ");
            Console.WriteLine("2. lion                  " + "Plains West Side           ");
            Console.WriteLine("3. grizzly bear          " + "Forest South Side          ");
            Console.WriteLine("4. cheetah               " + "Plains East Side           ");
            Console.WriteLine("5. redback spider        " + "Gardens North Side         ");
            Console.WriteLine("6. snow leopard          " + "Arctic South Side          ");
            Console.WriteLine("7. anaconda              " + "Plains South Side          ");
            Console.WriteLine("8. alligator             " + "Lakes West Side            ");
            Console.WriteLine("9. polar bear            " + "Arctic North Side          ");
            Console.Write("\n");
            Console.WriteLine("Enter in the number of the animal to see the time of that animals exhibition (e.g. Enter in number1 if you wish to see the time for scorpion)");
            scorpion = Console.ReadLine();
            Console.WriteLine("\n");
            
            if (scorpion == "number1")
            {
                Console.WriteLine("The viewing time for scorpion today will be at 09:30 ");
            }
            else
            {
                Console.WriteLine("Please enter in a valid number");
            }

            Console.ReadLine();
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //bool num1 = true;
            //bool isLion = true;

            //string animal = Console.ReadLine();

            /*if (isScorpion)
            {
                Console.WriteLine("The viewing time for scorpion today will be at 09:30 ");
            }
            else if (!isScorpion)
            {
                Console.WriteLine("Please select from one of the animals in the list");
            }*/

            /*if (isLion)
            {
                Console.WriteLine("The viewing time for Lion today will be at 10:30 ");
            }
            else if (!isLion)
            {
                Console.WriteLine("Please select from one of the animals in the list");
            }*/

            //Console.WriteLine("Hello World!");
        }
    }
}
