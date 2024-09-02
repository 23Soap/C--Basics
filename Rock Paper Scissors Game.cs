using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            string answer;

            while (playAgain) 
            {
                player = "";
                computer = "";
                
                
                while (player != "ROCK" && player != "PAPER" && player !="SCISSORS")
                {
                    Console.WriteLine("Enter ROCK,PAPER or scissors: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                
                switch (random.Next(1,4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer );
                
                

                switch (player)
                {
                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("It is a Draw! ");
                        }else if(computer == "ROCK")
                        {
                            Console.WriteLine("You Win! ");
                        }
                        else
                        {
                            Console.WriteLine("You Lose ");
                        }
                            break;
                    case "ROCK":
                        if(computer == "ROCK")
                        {
                            Console.WriteLine("It is a Draw! ");
                        }else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Lose! ");
                        }
                        else
                        {
                            Console.WriteLine("You Win! ");
                        }
                        break;
                    case "SCISSORS":
                        if(computer == "SCISSORS")
                        {
                            Console.WriteLine("It is a Draw! ");
                        }else if(computer == "PAPER")
                        {
                            Console.WriteLine("You Win! ");

                        }
                        else
                        {
                            Console.WriteLine("You Lose! ");
                        }

                    break;
                }
                Console.WriteLine("Would you like to play again? (Y/N) ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                    Console.WriteLine("LETS GO");
                }
                else
                {
                    playAgain = false;
                }
                
            }


            Console.WriteLine("Thanks for playing");
            Console.ReadKey();
        }
    }
}
