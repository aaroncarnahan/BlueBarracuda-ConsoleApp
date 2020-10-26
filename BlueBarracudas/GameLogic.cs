using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BlueBarracudas
{
	public class GameLogic
	{
		private int[] _RandomGameSequence;
		private int[] _UserGameSequence;

		public void RunGame()
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

			int amount;

			Console.WriteLine("How long would you like this to run?");
			amount = Convert.ToInt32(Console.ReadLine());
			SetPosition(0, 0);
			ClearLine(0, 36);
			SetPosition(0, 1);
			ClearLine(0, 36);

			RandomGameSequence(amount);
			UserInput(amount);

			DoTheyMatch();


		}

		public void RandomGameSequence(int numberOfNotes)
		{
			int Min = 1;
			int Max = 10;

			DrawAssets drawTwo = new DrawAssets();
			// this declares an integer array with 5 elements
			// and initializes all of them to their default value
			// which is zero
			//int[] RandomSequenceArray = new int[numberOfNotes];

			//int[] RandomSequenceArray = new int[numberOfNotes];
			_RandomGameSequence = new int[numberOfNotes];
			Random randNum = new Random();

			for (int i = 0; i < _RandomGameSequence.Length; i++)
			{
				_RandomGameSequence[i] = randNum.Next(Min, Max);



				int beepDuraction = 500;
				int sleepOne = 500;
				int sleepTwo = 200;

				switch (_RandomGameSequence[i])
				{
					case 1:
						drawTwo.ComputerSquare1(1);
						Console.Beep(262, beepDuraction);
						Thread.Sleep(sleepOne);
						drawTwo.ComputerSquare1(0);
						Thread.Sleep(sleepTwo);
						break;
					case 2:
						drawTwo.ComputerSquare2(1);
						Console.Beep(294, beepDuraction);
						Thread.Sleep(sleepOne);
						drawTwo.ComputerSquare2(0);
						Thread.Sleep(sleepTwo);
						break;
					case 3:
						drawTwo.ComputerSquare3(1);
						Console.Beep(330, beepDuraction);
						Thread.Sleep(sleepOne);
						drawTwo.ComputerSquare3(0);
						Thread.Sleep(sleepTwo);
						break;
					case 4:
						drawTwo.ComputerSquare4(1);
						Console.Beep(350, beepDuraction);
						Thread.Sleep(sleepOne);
						drawTwo.ComputerSquare4(0);
						Thread.Sleep(sleepTwo);
						break;
					case 5:
						drawTwo.ComputerSquare5(1);
						Console.Beep(392, beepDuraction);
						Thread.Sleep(sleepOne);
						drawTwo.ComputerSquare5(0);
						Thread.Sleep(sleepTwo);
						break;
					case 6:
						drawTwo.ComputerSquare6(1);
						Console.Beep(440, beepDuraction);
						Thread.Sleep(sleepOne);
						drawTwo.ComputerSquare6(0);
						Thread.Sleep(sleepTwo);
						break;
					case 7:
						drawTwo.ComputerSquare7(1);
						Console.Beep(494, beepDuraction);
						Thread.Sleep(sleepOne);
						drawTwo.ComputerSquare7(0);
						Thread.Sleep(sleepTwo);
						break;
					case 8:
						drawTwo.ComputerSquare8(1);
						Console.Beep(523, beepDuraction);
						Thread.Sleep(sleepOne);
						drawTwo.ComputerSquare8(0);
						Thread.Sleep(sleepTwo);
						break;
					case 9:
						drawTwo.ComputerSquare9(1);
						Console.Beep(587, beepDuraction);
						Thread.Sleep(sleepOne);
						drawTwo.ComputerSquare9(0);
						Thread.Sleep(sleepTwo);
						break;
					default:
						Console.WriteLine("Default case");
						break;

				}

				//Console.WriteLine(_RandomGameSequence[i]);

			}
		}


			public void UserInput(int numberOfNotes)
			{
				_UserGameSequence = new int[numberOfNotes];

			DrawAssets drawTwo = new DrawAssets();

			for (int i = 0; i < _UserGameSequence.Length; i++)
				{
					//input the flashing number to populate the array
					//_UserGameSequence[i] = (int)(Console.ReadKey().KeyChar);
					_UserGameSequence[i] = int.Parse(Console.ReadKey().KeyChar.ToString());

				int beepDuraction = 500;
				int sleepOne = 500;
				int sleepTwo = 0;

				switch (_UserGameSequence[i])
				{
					case 1:
						drawTwo.ComputerSquare1(1);
						Console.Beep(262, beepDuraction);
						Thread.Sleep(sleepOne);
						drawTwo.ComputerSquare1(0);
						Thread.Sleep(sleepTwo);
						break;
					case 2:
						drawTwo.ComputerSquare2(1);
						Console.Beep(294, beepDuraction);
						Thread.Sleep(sleepOne);
						drawTwo.ComputerSquare2(0);
						Thread.Sleep(sleepTwo);
						break;
					case 3:
						drawTwo.ComputerSquare3(1);
						Console.Beep(330, beepDuraction);
						Thread.Sleep(sleepOne);
						drawTwo.ComputerSquare3(0);
						Thread.Sleep(sleepTwo);
						break;
					case 4:
						drawTwo.ComputerSquare4(1);
						Console.Beep(350, beepDuraction);
						Thread.Sleep(sleepOne);
						drawTwo.ComputerSquare4(0);
						Thread.Sleep(sleepTwo);
						break;
					case 5:
						drawTwo.ComputerSquare5(1);
						Console.Beep(392, beepDuraction);
						Thread.Sleep(sleepOne);
						drawTwo.ComputerSquare5(0);
						Thread.Sleep(sleepTwo);
						break;
					case 6:
						drawTwo.ComputerSquare6(1);
						Console.Beep(440, beepDuraction);
						Thread.Sleep(sleepOne);
						drawTwo.ComputerSquare6(0);
						Thread.Sleep(sleepTwo);
						break;
					case 7:
						drawTwo.ComputerSquare7(1);
						Console.Beep(494, beepDuraction);
						Thread.Sleep(sleepOne);
						drawTwo.ComputerSquare7(0);
						Thread.Sleep(sleepTwo);
						break;
					case 8:
						drawTwo.ComputerSquare8(1);
						Console.Beep(523, beepDuraction);
						Thread.Sleep(sleepOne);
						drawTwo.ComputerSquare8(0);
						Thread.Sleep(sleepTwo);
						break;
					case 9:
						drawTwo.ComputerSquare9(1);
						Console.Beep(587, beepDuraction);
						Thread.Sleep(sleepOne);
						drawTwo.ComputerSquare9(0);
						Thread.Sleep(sleepTwo);
						break;
					default:
						Console.WriteLine("Default case");
						break;

				}

				Console.WriteLine(_UserGameSequence[i]);
				}
			}


			public void DoTheyMatch()
			{
				//string userInput = Console.ReadLine();

				//for loop

				int x = 0;

				foreach (var item1 in _UserGameSequence)
				{
					if (item1 != _RandomGameSequence[x])
					{
					
					Console.BackgroundColor = ConsoleColor.Black;
					Console.ForegroundColor = ConsoleColor.White;
					Console.Clear();
						Console.WriteLine("FAIL");
				
						x = x + 1;
					}
					else if (item1 == _RandomGameSequence[x])
					{
					Console.BackgroundColor = ConsoleColor.Black;
					Console.ForegroundColor = ConsoleColor.White;
					Console.Clear();
						Console.WriteLine("SUCCESS");
						x = x + 1;
					}

				}

			}

		//new class to read in whatever the user inputs and assign to a variable

		// Draws objects at a certain position
		public void SetPosition(int x, int y)
		{
			Console.SetCursorPosition(x, y);
		}

		// Clear current line

		public void ClearLine(int x, int y)
		{
			Console.BackgroundColor = ConsoleColor.Black;
			int currentLineCursor = Console.CursorTop;
			Console.SetCursorPosition(x, Console.CursorTop);
			Console.Write(new string(' ', y));
			Console.SetCursorPosition(x, currentLineCursor);
		}



	}
}
