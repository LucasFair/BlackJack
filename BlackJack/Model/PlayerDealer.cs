using System;

namespace BlackJack.Model
{
	public struct PersonInformation
	{
		public string GameName;
		public byte GameAge;
		public char GameGender;
	}
	/// <summary>
	/// Class <c>GameCharacter</c> contains information about the dealer and player, using information from the struct <c>PersonInformation</c>.
	/// </summary>
	public class GameCharacter
	{
		public void CardDealer()
		{
			PersonInformation dealA, dealB, dealC, dealD;
			dealA.GameName = "Kris";
			dealA.GameAge = 19;
			dealA.GameGender = 'M';

			dealB.GameName = "Mikkel";
			dealB.GameAge = 32;
			dealB.GameGender = 'M';

			dealC.GameName = "Carmilla";
			dealC.GameAge = 64;
			dealC.GameGender = 'F';

			dealD.GameName = "???";
			dealD.GameAge = 0;
			dealD.GameGender = '?';
			return;
		}

		public void CardPlayer()
		{
			PersonInformation playA, playB;
			playA.GameName = "John Doe";
			playA.GameAge = 28;
			playA.GameGender = 'M';

			playB.GameName = "Mary Sue";
			playB.GameAge = 29;
			playB.GameGender = 'F';
		}
	}
}