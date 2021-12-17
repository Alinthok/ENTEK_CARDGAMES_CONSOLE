using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTEK_CARDGAMES_CONSOLE.PlayerNamespace;

namespace ENTEK_CARDGAMES_CONSOLE.GameLogicNamespace
{
    class GameLogic
    {
        private CardData cardData = new CardData();
        private List<Player> playerList = new List<Player>();

        private Player turn;

        public GameLogic()
        {
            cardData.printDrawCard();
            Console.WriteLine("---------------SHUFFLE--------------");
            cardData.shuffleDrawCard();
            cardData.printDrawCard();

            Console.WriteLine("---------------GIVE CARD--------------");
            addPlayer();
            addPlayer();
            giveCardtoPlayer(5);
            foreach (Player p in playerList)
            {
                p.printCard();
            }
            Console.WriteLine("---------------PLACE FIRST CARD--------------");
            cardData.placeFirstCard();

            turn = whoFirstTurn();
        }

        public void gameLoop()
        {
            turn.play();

        }

        public void addPlayer()
        {
            playerList.Add(new Player());
        }

        public void giveCardtoPlayer(int n)
        { 
            for (int i = 0; i < n; i++)
            {
                foreach (Player player in playerList)
                {
                    player.addCard(cardData.drawCard());
                }             
            }
        }

        public Player whoFirstTurn()
        {
            return playerList[new Random().Next(0, playerList.Count() - 1)];
        }
    }
}
