using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pet properties
            string petName = "";
            int hunger = 5;
            int happiness = 5;
            int health = 5;
            string petType = "";

            // Print initial greeting and choose pet type
            Console.WriteLine("Greetings and welcome to the Virtual Pet Experience!");
            Console.WriteLine("Please choose your pet type:");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");

            string petChoice = Console.ReadLine();

            switch (petChoice)
            {
                case "1":
                    petType = "Cat";
                    break;
                case "2":
                    petType = "Dog";
                    break;
                case "3":
                    petType = "Rabbit";
                    break;
                default:
                    Console.WriteLine("Invalid choice, setting default pet type to Dog.");
                    petType = "Dog";
                    break;
            }

            Console.WriteLine($"You have selected a {petType}.");
            Console.WriteLine("Now, give your pet a name: ");
            petName = Console.ReadLine();

            // Print initial pet details
            Console.WriteLine($"\nYour pet's name is {petName}.");
            Console.WriteLine($"Your pet is a {petType}.");
            Console.WriteLine($"Initial stats: Hunger: {hunger}, Happiness: {happiness}, Health: {health}\n");


            bool gameRunning = true;

            while (gameRunning)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Feed the pet");
                Console.WriteLine("2. Play with the pet");
                Console.WriteLine("3. Let the pet rest");
                Console.WriteLine("4. Check pet status");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        hunger = Math.Max(1, hunger - 2);
                        health = Math.Min(10, health + 1);
                        Console.WriteLine(string.Format("{0} has been fed. Hunger decreased and increased Health", petName));
                        break;

                    case "2":
                        if (hunger <= 2)
                        {
                            Console.WriteLine(string.Format("{0} is too hungry to play!", petName));
                        }
                        else
                        {
                            happiness = Math.Min(10, happiness + 2);
                            hunger = Math.Min(10, hunger + 1);
                            Console.WriteLine(string.Format("{0} had fun playing Happiness increased, increased Hunger", petName));
                        }
                        break;

                    case "3":
                        happiness = Math.Max(1, happiness - 1);
                        health = Math.Min(10, health + 2);
                        Console.WriteLine(string.Format("{0} is relaxing. Happiness decreased slightly and Health improved", petName));
                        break;

                    case "4":
                        Console.WriteLine(string.Format("Pet Status: Hunger: {0}/10, Happiness: {1}/10, Health: {2}/10", hunger, happiness, health));

                        if (hunger <= 2)
                            Console.WriteLine("Warning: Hunger has reached to low level!");
                        if (happiness <= 2)
                            Console.WriteLine("Warning: happieness has reached to low level!");
                        if (health <= 2)
                            Console.WriteLine("Warning: Health has reached to  low!");
                        break;

                    case "5":
                        gameRunning = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
