using System;

namespace SpaceQuest
{
    class SpaceAdventure
    {
        private string playerName;
        private string asteroidChoice;
        private string resourceChoice;

        public void Start()
        {
            AskPlayerName();
            GreetPlayer();
            AskFirstQuestion();
            AskSecondQuestion();
            AskThirdQuestion();
            AskForthQuestion();
            AskFinalResult();
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

            asteroidChoice = Console.ReadLine();

            switch (asteroidChoice)
            {
                case "1":
                    Console.WriteLine($"{playerName}, you speed through the asteroid field, narrowly avoiding collisions. That was a close call!");
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

            WaitForNextStep();
        }

        private void AskSecondQuestion()
        {
            if (asteroidChoice == "1")
            {
                Console.WriteLine($"\n{playerName}, after your close call with the asteroids, you encounter an alien ship! What do you do?");
                Console.WriteLine("1. Attempt to communicate with the alien ship.");
                Console.WriteLine("2. Prepare for a defensive stance, just in case.");
                Console.WriteLine("3. Ignore the ship and continue your journey.");
                Console.Write("Enter the number of your choice: ");

                string alienChoice = Console.ReadLine();

                switch (alienChoice)
                {
                    case "1":
                        Console.WriteLine($"{playerName}, you attempt communication, and the aliens warn you of an upcoming space storm.");
                        break;
                    case "2":
                        Console.WriteLine($"{playerName}, you prepare for battle, but the alien ship disengages and leaves.");
                        break;
                    case "3":
                        Console.WriteLine($"{playerName}, you ignore the alien ship, but you feel uneasy about your decision.");
                        break;
                    default:
                        Console.WriteLine("That's not a valid choice. The alien ship is still there.");
                        break;
                }
            }
            else if (asteroidChoice == "2")
            {
                Console.WriteLine($"\n{playerName}, after navigating the asteroid field, you come across a derelict space station. What do you do?");
                Console.WriteLine("1. Dock at the station to explore.");
                Console.WriteLine("2. Leave the station and continue on your way.");
                Console.WriteLine("3. Attempt to hail the station for information.");
                Console.Write("Enter the number of your choice: ");

                string stationChoice = Console.ReadLine();

                switch (stationChoice)
                {
                    case "1":
                        Console.WriteLine($"{playerName}, you dock at the station and discover advanced technology left behind by an ancient civilization.");
                        break;
                    case "2":
                        Console.WriteLine($"{playerName}, you leave the station, but wonder if you missed out on something valuable.");
                        break;
                    case "3":
                        Console.WriteLine($"{playerName}, you attempt communication and receive a cryptic message about a hidden treasure.");
                        break;
                    default:
                        Console.WriteLine("That's not a valid choice. The station is still there.");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"\n{playerName}, you activate your shields, but the asteroids still cause significant damage to your ship. After repairing the damage, you encounter a peaceful alien race. What do you do?");
                Console.WriteLine("1. Trade resources with the alien race.");
                Console.WriteLine("2. Engage in friendly communication and exchange knowledge.");
                Console.WriteLine("3. Politely refuse and continue your journey.");
                Console.Write("Enter the number of your choice: ");

                string alienRaceChoice = Console.ReadLine();

                switch (alienRaceChoice)
                {
                    case "1":
                        Console.WriteLine($"{playerName}, you trade resources and receive valuable technology in return.");
                        break;
                    case "2":
                        Console.WriteLine($"{playerName}, you engage in communication and gain insights into deep space navigation.");
                        break;
                    case "3":
                        Console.WriteLine($"{playerName}, you politely refuse, and the alien race respects your decision.");
                        break;
                    default:
                        Console.WriteLine("That's not a valid choice. The aliens await your response.");
                        break;
                }
            }

            WaitForNextStep();
        }

        private void AskThirdQuestion()
        {
            Console.WriteLine($"\n{playerName}, you are now faced with a difficult choice. You are running low on fuel, but you have a valuable resource. What will you do?");
            Console.WriteLine("1. Use the resource to recharge your fuel tank.");
            Console.WriteLine("2. Save the resource for a more critical situation later.");
            Console.WriteLine("3. Attempt to find another source of fuel without using the resource.");
            Console.Write("Enter the number of your choice: ");

            resourceChoice = Console.ReadLine();

            switch (resourceChoice)
            {
                case "1":
                    Console.WriteLine($"{playerName}, you use the resource to recharge your fuel tank, ensuring a safe journey ahead.");
                    break;
                case "2":
                    Console.WriteLine($"{playerName}, you decide to save the resource for a more critical situation. It could come in handy later.");
                    break;
                case "3":
                    Console.WriteLine($"{playerName}, you search for another fuel source, but it takes much longer and the journey becomes riskier.");
                    break;
                default:
                    Console.WriteLine("That's not a valid choice. You need to make a decision.");
                    break;
            }

            WaitForNextStep();
        }

        private void AskForthQuestion()
        {
            Console.WriteLine($"\n{playerName}, you now face a new challenge: your fuel tank is almost empty, and you're near a mysterious planet. What do you do?");
            Console.WriteLine("1. Land on the planet and explore it in search of fuel.");
            Console.WriteLine("2. Attempt to bypass the planet and find another fuel source.");
            Console.WriteLine("3. Try to communicate with the planet's inhabitants for help.");
            Console.Write("Enter the number of your choice: ");

            string forthChoice = Console.ReadLine();

            switch (forthChoice)
            {
                case "1":
                    Console.WriteLine($"{playerName}, you land on the planet, and you find an advanced civilization that provides you with enough fuel to continue your journey.");
                    break;
                case "2":
                    Console.WriteLine($"{playerName}, you bypass the planet, but the journey becomes much harder as you run low on resources.");
                    break;
                case "3":
                    Console.WriteLine($"{playerName}, you communicate with the inhabitants, and they give you valuable information about hidden resources in space.");
                    break;
                default:
                    Console.WriteLine("That's not a valid choice. The planet awaits your decision.");
                    break;
            }

            WaitForNextStep();
        }

        private void AskFinalResult()
        {
            Console.WriteLine($"\n{playerName}, your journey is coming to an end, and your final fate is now sealed based on your decisions.");

            switch (resourceChoice)
            {
                case "1":
                    Console.WriteLine("By using the resource to recharge, you are now in a stronger position to face the remaining challenges ahead.");
                    break;
                case "2":
                    Console.WriteLine("By saving your resource, you find yourself in a critical situation but with a chance to use it later.");
                    break;
                case "3":
                    Console.WriteLine("Your decision to search for another fuel source has been risky, but you made it through with a new set of skills.");
                    break;
                default:
                    Console.WriteLine("Your choices have shaped your journey, and the stars continue to call you.");
                    break;
            }

            WaitForNextStep();
        }

        private void WaitForNextStep()
        {
            Console.WriteLine("Press any key to continue...");
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

