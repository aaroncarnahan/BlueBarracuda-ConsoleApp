using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBarracudas
{
	public class DrawAssets
	{
		
		public int startComputerPositionHorizontal = 37;
		public int startComputerPositionVertical = 4;

		public void ComputerSquare1(int color)
		{
			int x = startComputerPositionHorizontal + 0;
			int y = startComputerPositionVertical + 0;

			if (color == 0)
			{
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.ForegroundColor = ConsoleColor.Black;
			}
			else if (color == 1)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.White;
			}

			SetPosition(x, y);
			ClearLine(x, y);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 1);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 2);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 3);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 4);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 5);
			Console.WriteLine("           1  ");
			ClearLine(x, y);
			SetPosition(x, y + 6);
			Console.WriteLine("              ");
			SetPosition(0, 0);
		}

		public void ComputerSquare2(int color)
		{


			int x = startComputerPositionHorizontal + 16;
			int y = startComputerPositionVertical + 0;

			if (color == 0)
			{
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.ForegroundColor = ConsoleColor.Black;
			}
			else if (color == 1)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.White;
			}

			SetPosition(x, y);
			ClearLine(x, y);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 1);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 2);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 3);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 4);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 5);
			Console.WriteLine("           2  ");
			ClearLine(x, y);
			SetPosition(x, y + 6);
			Console.WriteLine("              ");
			SetPosition(0, 0);
		}

		public void ComputerSquare3(int color)
		{
			int x = startComputerPositionHorizontal + 32;
			int y = startComputerPositionVertical + 0;

			if (color == 0)
			{
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.ForegroundColor = ConsoleColor.Black;
			}
			else if (color == 1)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.White;
			}

			SetPosition(x, y);
			ClearLine(x, y);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 1);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 2);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 3);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 4);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 5);
			Console.WriteLine("           3  ");
			ClearLine(x, y);
			SetPosition(x, y + 6);
			Console.WriteLine("              ");
			SetPosition(0, 0);
		}

		public void ComputerSquare4(int color)
		{
			int x = startComputerPositionHorizontal + 0;
			int y = startComputerPositionVertical + 8;

			if (color == 0)
			{
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.ForegroundColor = ConsoleColor.Black;
			}
			else if (color == 1)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.White;
			}

			SetPosition(x, y);
			ClearLine(x, y);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 1);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 2);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 3);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 4);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 5);
			Console.WriteLine("           4  ");
			ClearLine(x, y);
			SetPosition(x, y + 6);
			Console.WriteLine("              ");
			SetPosition(0, 0);
		}

		public void ComputerSquare5(int color)
		{
			int x = startComputerPositionHorizontal + 16;
			int y = startComputerPositionVertical + 8;

			if (color == 0)
			{
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.ForegroundColor = ConsoleColor.Black;
			}
			else if (color == 1)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.White;
			}

			SetPosition(x, y);
			ClearLine(x, y);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 1);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 2);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 3);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 4);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 5);
			Console.WriteLine("           5  ");
			ClearLine(x, y);
			SetPosition(x, y + 6);
			Console.WriteLine("              ");
			SetPosition(0, 0);
		}

		public void ComputerSquare6(int color)
		{
			int x = startComputerPositionHorizontal + 32;
			int y = startComputerPositionVertical + 8;

			if (color == 0)
			{
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.ForegroundColor = ConsoleColor.Black;
			}
			else if (color == 1)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.White;
			}

			SetPosition(x, y);
			ClearLine(x, y);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 1);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 2);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 3);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 4);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 5);
			Console.WriteLine("           6  ");
			ClearLine(x, y);
			SetPosition(x, y + 6);
			Console.WriteLine("              ");
			SetPosition(0, 0);
		}

		public void ComputerSquare7(int color)
		{
			int x = startComputerPositionHorizontal + 0;
			int y = startComputerPositionVertical + 16;

			if (color == 0)
			{
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.ForegroundColor = ConsoleColor.Black;
			}
			else if (color == 1)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.White;
			}

			SetPosition(x, y);
			ClearLine(x, y);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 1);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 2);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 3);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 4);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 5);
			Console.WriteLine("           7  ");
			ClearLine(x, y);
			SetPosition(x, y + 6);
			Console.WriteLine("              ");
			SetPosition(0, 0);
		}

		public void ComputerSquare8(int color)
		{
			int x = startComputerPositionHorizontal + 16;
			int y = startComputerPositionVertical + 16;

			if (color == 0)
			{
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.ForegroundColor = ConsoleColor.Black;
			}
			else if (color == 1)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.White;
			}

			SetPosition(x, y);
			ClearLine(x, y);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 1);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 2);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 3);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 4);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 5);
			Console.WriteLine("           8  ");
			ClearLine(x, y);
			SetPosition(x, y + 6);
			Console.WriteLine("              ");
			SetPosition(0, 0);
		}

		public void ComputerSquare9(int color)
		{
			int x = startComputerPositionHorizontal + 32;
			int y = startComputerPositionVertical + 16;

			if (color == 0)
			{
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.ForegroundColor = ConsoleColor.Black;
			}
			else if (color == 1)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.White;
			}

			SetPosition(x, y);
			ClearLine(x, y);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 1);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 2);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 3);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 4);
			Console.WriteLine("              ");
			ClearLine(x, y);
			SetPosition(x, y + 5);
			Console.WriteLine("           9  ");
			ClearLine(x, y);
			SetPosition(x, y + 6);
			Console.WriteLine("              ");
			SetPosition(0, 0);
		}

		// Draws objects at a certain position
		public void SetPosition(int x, int y)
		{
			Console.SetCursorPosition(x, y);
		}

		// Clear current line

		public void ClearLine(int x, int y)
		{
			int currentLineCursor = Console.CursorTop;
			Console.SetCursorPosition(x, Console.CursorTop);
			Console.Write(new string(' ', 14));
			Console.SetCursorPosition(x, currentLineCursor);
		}

	}
}
