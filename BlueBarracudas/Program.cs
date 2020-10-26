using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBarracudas
{
	class Program
	{
		static void Main(string[] args)
		{
			bool whileRunning = true;

			while (whileRunning)
			{
				//Console.Clear();
				Console.BackgroundColor = ConsoleColor.Black;
				Console.ForegroundColor = ConsoleColor.White;

				//Console.WriteLine(" --------------------------------------------------- BLUE BARRACUDA ----- by Aaron Carnahan, Stasi Higgins, & Evan Lacy");
				//Console.WriteLine("                                                     BLUE BARRACUDA       by Aaron Carnahan, Stasi Higgins, & Evan Lacy");

			

				//PlaySounds playSounds = new PlaySounds();
				//playSounds.Mary();
				GameLogic runGame = new GameLogic();
				
				runGame.RunGame();

				Console.WriteLine("Do you want to play again? YES or NO");
				string yesNo = Console.ReadLine().ToLower();

				

				if (yesNo == "yes" || yesNo == "y")
				{
					Console.Clear();
					Console.WriteLine("Wow, I can't believe you want to keep playing this crap.");
					Console.WriteLine("Press ENTER to keep playing, you bored weirdo.");
					Console.ReadLine();
					whileRunning = true;
				}
				else if (yesNo == "no" || yesNo == "n")
				{
					Console.Clear();
					Console.WriteLine("You suck because you don't want to play anymore. I hate you.");
					Console.WriteLine("Press ENTER to exit, you wimp.");
					Console.ReadLine();
					whileRunning = false;
				}
				else
				{
					Console.Clear();
					Console.WriteLine("I didn't understand");
				}
			}


		}
	}
}
