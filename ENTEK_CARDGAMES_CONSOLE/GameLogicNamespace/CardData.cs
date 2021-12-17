using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTEK_CARDGAMES_CONSOLE.PlayerNamespace;

namespace ENTEK_CARDGAMES_CONSOLE.GameLogicNamespace
{
    class CardData
    {
        private List<Card> placedCardList = new List<Card>();
        private List<Card> drawCardList = new List<Card>();

        public CardData()
        {
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    drawCardList.Add(new Card(i + 1, (Card.Type)j));
                }
            }
        }

        public void shuffleDrawCard()
        {
            Random random = new Random();
            for (var i = drawCardList.Count - 1; i > 0; i--)
            {
                var j = random.Next(0, i + 1);
                var temp = drawCardList[i];
                drawCardList[i] = drawCardList[j];
                drawCardList[j] = temp;
            }
        }

        public Card drawCard()
        {
            Card t = drawCardList.First();
            drawCardList.Remove(t);
            return t;
        }

        public void printDrawCard()
        {
            foreach (Card card in drawCardList)
            {
                Console.Write(card + ",");
            }
            Console.WriteLine();
        }

        public void placeFirstCard()
        {
            placedCardList.Add(drawCard());
        }
    }
}
