using System;

namespace SpaceQuest
{
    class SpaceAdventure
    {
        private string playerName;
        public void Start()
        {
            AskPlayerName();
            GreetPlayer();
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
