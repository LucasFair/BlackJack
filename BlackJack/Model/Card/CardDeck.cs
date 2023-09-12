using System;

namespace BlackJack.Model.Card
{
    /// <summary>
    /// Class <c>CardDeck</c> contains the data about the deck, as well as the math that goes into it.
    /// </summary>
    public class CardDeck
    {
        // No Jokers. 13 x 4 = 52.
        // If player gets above 21, it's a bust.
        //
        // Hit = Draw a card.
        // Stand = End turn.
        // Double Down = Draw another card .
        // Split = If holding two of the same card, the value can be split.
        // Surrender = Quit.

        public const byte MAX_CARDS = 52;

    }
}
