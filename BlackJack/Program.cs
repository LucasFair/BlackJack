using BlackJack.Controller;
using BlackJack.Model;
using BlackJack.View;
using System;

namespace BlackJack
{
	public class Program
	{
		public void Main(string[] args)
		{
			CardController cardCtrl = new CardController();
			//cardCtrl.Start();

			Character character = new Character();
			CardGUI cardGUI = new CardGUI();
			cardGUI.PlayerMenu();

            Console.WriteLine(typeof(Character));
            Console.WriteLine(character.CardPlayerDealer);


        }
	}
}
