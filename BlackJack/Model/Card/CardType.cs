using System;
using System.Threading;

namespace BlackJack.Model.Card
{
    /// <summary>
    /// Class <c>CardType</c> contains the data about the cards, their numbers, values and types.
    /// </summary>
    public class CardType
    {

        // The first Ace is counted as 11, more Aces afterwards will be counted as 1.
        // Jack, Queen and King, as well as 10, equals to 10.
        Random rnd = new Random();
        byte rndNum;

        /*
		Dictionary<int, string> cardValName = new Dictionary<int, string>() {
			{1, "One" }, {2, "Two" }, {3, "Three" } 
		};
		*/

        List<byte> cardVal = new List<byte>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        List<string> cardSuit = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };
        List<string> cardName = new List<string>() { "Ace", "Jack", "Queen", "King" };



    }
}
