using System;

namespace BlackJack.View
{
	/// <summary>
	/// Class <c>CardGUI</c> controls the outputs to the console window.
	/// </summary>
	public class CardGUI
	{
		public void Introduction()
		{
			Console.Clear();
            Console.WriteLine("Welcome to Black Jack!\n\nIn this game, you have to pick blah blah blah FINISH WRITING THIS LATER\n" +
				"\nPress ENTER to start the game!\n");
        }
		public void Shuffling()
		{
            Console.WriteLine("The dealer is shuffling the deck...");
        }
		public void YouWin()
		{
            Console.WriteLine("You win!");
        }
		public void YouLose()
		{
            Console.WriteLine("You have no money left. You lose!");
        }
		public void Bust()
		{
            Console.WriteLine("That's a bust! Too bad!");
        }
		public void PlayerMenu()
		{
			Console.Clear();
			Console.WriteLine("Pick an option:\n\n1) Hit\n2) Stand\n3) Double Down\n4) Split\n0) Surrender\n");
		}
	}
}
