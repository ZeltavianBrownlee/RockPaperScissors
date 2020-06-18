using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {

        static string PlayGame(string one, string two)//(comp, me)
        {
            //comp choices
            if (one == "rock" && two == "paper")
            {
                return "a";
            }
            else if (one == "rock" && two == "scissors")
            {
                return "b";
            }
            else if (one == "paper" && two == "scissors")
            {
                return "a";
            }
            else if (one == "paper" && two == "rock")
            {
                return "b";
            }
            else if (one == "scissors" && two == "paper")
            {
                return "b";
            }
            else if (one == "scissors" && two == "rock")
            {
                return "a";
            }

            //player choices

            else if (two == "rock" && one == "paper")
            {
                return "a";
            }
            else if (two == "rock" && one == "scissors")
            {
                return "b";
            }
            else if (two == "paper" && one == "scissors")
            {
                return "a";
            }
            else if (two == "paper" && one == "rock")
            {

                return "b";
            }
            else if (two == "scissors" && one == "paper")
            {

                return "b";
            }
            else if (two == "scissors" && one == "rock")
            {

                return "a";
            }
            else if (one == "rock" && two == "rock")
            {
                return "c";
            }
            else if (one == "scissors" && two == "scissors")
            {
                return "c";
            }
            else if (one == "paper" && two == "paper")
            {
                return "c";
            }
            else
                return "d";
        }

        static void Main(string[] args)
        {
            //declare and intialize variables
            Random rnd = new Random();
            string compChoice = "";
            string playerChoice = "";

            //do while loop to continue until there is a winner
            do
            {
                //generate random number
                int compNum = rnd.Next(1, 4);



                //Prompt for and get player choice
                Console.WriteLine("Please enter your choice of rock, paper, or scissors");

                playerChoice = Console.ReadLine();

                if (compNum == 1)
                {
                    compChoice = "rock";
                }
                else if (compNum == 2)
                {
                    compChoice = "paper";
                }
                else
                {
                    compChoice = "scissors";
                }//end if


                //display computer random choice
                Console.WriteLine("The computer's choice is: {0} ", compChoice);

                //Call play function for game
                PlayGame(compChoice, playerChoice);


                //if statements for game message
                if (PlayGame(compChoice, playerChoice) == "a")
                {
                    Console.WriteLine("You are the winner");
                }
                if (PlayGame(compChoice, playerChoice) == "b")
                {
                    Console.WriteLine("Computer is the winner");
                }
                
            } while (PlayGame(compChoice, playerChoice) == "c");//end do while loop

                Console.ReadKey();
        }

    }
}


