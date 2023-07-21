using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Random random = new Random();
            num= random.Next(1,10);
            string choice;
            char again;
            string compChoice = "pp";


         

            Console.Write("Choose an action, ROCK, PAPER or SCISSORS: ");
            choice = Console.ReadLine(); 
            choice = choice.ToUpper();


            while(!(choice == "ROCK" || choice == "PAPER" || choice == "SCISSORS"))
            {
                Console.WriteLine("Invalid choice!");
                Console.Write("Choose an action, ROCK, PAPER or SCISSORS: ");
                choice = Console.ReadLine();
                choice = choice.ToUpper();
            }

           
            
            
                if (num >= 1 && num <= 3)
                {
                    compChoice = "ROCK";
                }
                else 
                    if(num >= 4 && num <= 6)
                {
                    compChoice = "PAPER";
                }
                else 
                    if(num >= 7 && num <= 9)
                {
                    compChoice = "SCISSORS";
                }
            if (compChoice == "ROCK" && choice == "ROCK")
                Console.WriteLine("It's a draw");
            else if (compChoice == "ROCK" && choice == "PAPER")
                Console.WriteLine("You won!, I chose {0}",compChoice);
            else if (compChoice == "ROCK" && choice == "SCISSORS")
                Console.WriteLine("I won, I chose {0}",compChoice);
            else if (compChoice == "PAPER" && choice == "ROCK")
                Console.WriteLine("I won, I chose {0}",compChoice);
            else if (compChoice == "PAPER" && choice == "PAPER")
                Console.WriteLine("It's a draw");
            else if (compChoice == "PAPER" && choice == "SCISSORS")
                Console.WriteLine("You won!, I chose {0}", compChoice);
            else if (compChoice == "SCISSORS" && choice == "ROCK")
                Console.WriteLine("You won!, I chose {0}",compChoice);
            else if (compChoice == "SCISSORS" && choice == "PAPER")
                Console.WriteLine("I won, I chose {0}",compChoice);
            else if (compChoice == "SCISSORS" && choice == "SCISSORS")
                Console.WriteLine("It's a draw");

            Console.Write("Play again? (Y/N): ");
            again = char.Parse(Console.ReadLine());
            again = char.ToUpper(again);

            while(again == 'Y')
            {
                num = random.Next(1, 10);
                Console.Write("Choose an action, ROCK, PAPER or SCISSORS: ");
                choice = Console.ReadLine();
                choice = choice.ToUpper();


                while (!(choice == "ROCK" || choice == "PAPER" || choice == "SCISSORS"))
                {
                    Console.WriteLine("Invalid choice!");
                    Console.Write("Choose an action, ROCK, PAPER or SCISSORS: ");
                    choice = Console.ReadLine();
                    choice = choice.ToUpper();
                }




                if (num >= 1 && num <= 3)
                {
                    compChoice = "ROCK";
                }
                else
                    if (num >= 4 && num <= 6)
                {
                    compChoice = "PAPER";
                }
                else
                    if (num >= 7 && num <= 9)
                {
                    compChoice = "SCISSORS";
                }
                if (compChoice == "ROCK" && choice == "ROCK")
                    Console.WriteLine("It's a draw");
                else if (compChoice == "ROCK" && choice == "PAPER")
                    Console.WriteLine("You won!, I chose {0}", compChoice);
                else if (compChoice == "ROCK" && choice == "SCISSORS")
                    Console.WriteLine("I won, I chose {0}", compChoice);
                else if (compChoice == "PAPER" && choice == "ROCK")
                    Console.WriteLine("I won, I chose {0}", compChoice);
                else if (compChoice == "PAPER" && choice == "PAPER")
                    Console.WriteLine("It's a draw");
                else if (compChoice == "PAPER" && choice == "SCISSORS")
                    Console.WriteLine("You won!, I chose {0}", compChoice);
                else if (compChoice == "SCISSORS" && choice == "ROCK")
                    Console.WriteLine("You won!, I chose {0}", compChoice);
                else if (compChoice == "SCISSORS" && choice == "PAPER")
                    Console.WriteLine("I won, I chose {0}", compChoice);
                else if (compChoice == "SCISSORS" && choice == "SCISSORS")
                    Console.WriteLine("It's a draw");

                Console.Write("Play again? (Y/N): ");
                again = char.Parse(Console.ReadLine());
                again = char.ToUpper(again);
            }
            Console.WriteLine("Goodbye! Thanks for playing.");
                
                
            
            

        }
    }
}
