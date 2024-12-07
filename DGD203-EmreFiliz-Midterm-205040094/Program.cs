﻿using System;

namespace SpaceQuest
{
    class SpaceAdventure
    {
        private string playerName;

        public void Start()
        {
            AskPlayerName();
            GreetPlayer();
            AskFirstQuestion();
            WaitForNextStep();
        }

        private void AskPlayerName()
        {
            Console.WriteLine("Greetings, space traveler! What's your name?");
            playerName = Console.ReadLine();
        }

        private void GreetPlayer()
        {
            Console.WriteLine($"Welcome, Captain {playerName}! Prepare for your journey across the stars.");
        }

        private void AskFirstQuestion()
        {
            Console.WriteLine($"\n{playerName}, you are flying through space when you suddenly find yourself in the middle of an asteroid field. What do you do?");
            Console.WriteLine("1. Attempt to fly through the field at high speed.");
            Console.WriteLine("2. Slow down and try to navigate carefully through the asteroids.");
            Console.WriteLine("3. Activate shields and hope for the best.");
            Console.Write("Enter the number of your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"{playerName}, you speed through the asteroid field, that was a close call!");
                    break;
                case "2":
                    Console.WriteLine($"{playerName}, you slow down and carefully navigate the field, finding a safe path through the rocks.");
                    break;
                case "3":
                    Console.WriteLine($"{playerName}, you activate your shields, but the asteroids still cause significant damage to your ship.");
                    break;
                default:
                    Console.WriteLine("That's not a valid choice. The asteroid field is getting closer!");
                    break;
            }
        }
        private void WaitForNextStep()
        {
            Console.WriteLine("Press any key to launch...");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SpaceAdventure game = new SpaceAdventure();
            game.Start();
        }
    }
}
