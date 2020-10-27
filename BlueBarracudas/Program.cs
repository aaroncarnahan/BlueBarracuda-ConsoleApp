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
	
			DrawAssets draw = new DrawAssets();
			Console.Clear();
			Console.WriteLine(" --------------------------------------------------- BLUE BARRACUDA ----- by Aaron Carnahan, Stasi Higgins, & Evan Lacy");
			draw.ComputerSquare1(0);
			draw.ComputerSquare2(0);
			draw.ComputerSquare3(0);
			draw.ComputerSquare4(0);
			draw.ComputerSquare5(0);
			draw.ComputerSquare6(0);
			draw.ComputerSquare7(0);
			draw.ComputerSquare8(0);
			draw.ComputerSquare9(0);


			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(' ');
			Console.WriteLine(' ');
			Console.WriteLine(' ');
			Console.WriteLine(' ');
			Console.WriteLine("     Welcome to BLUE BARRACUDA");
			Console.WriteLine(' ');
			Console.WriteLine("     In this game the computer");
			Console.WriteLine("     will display a random sequence");
			Console.WriteLine("     on the game board.");
			Console.WriteLine(' ');
			Console.WriteLine("     It's your job to remember");
			Console.WriteLine("     the sequence and repeat it.");
			Console.WriteLine(' ');
			Console.WriteLine("     Enter the sequence with the");
			Console.WriteLine("     NUMPAD or number keys.");
			Console.WriteLine(' ');
			Console.WriteLine("     PRESS ENTER TO START THE GAME");

			Console.ReadLine();


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
