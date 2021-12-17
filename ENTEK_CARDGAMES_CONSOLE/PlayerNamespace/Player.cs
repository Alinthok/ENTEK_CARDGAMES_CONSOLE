using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTEK_CARDGAMES_CONSOLE.PlayerNamespace
{
    class Player
    {
        private List<Card> cardList = new List<Card>();

        public void play()
        {

        }

        public void addCard(Card card)
        {
            cardList.Add(card);
        }

        public void printCard()
        {
            foreach (Card card in cardList)
            {
                Console.Write(card + ",");
            }
            Console.WriteLine();
        }
    }
}
