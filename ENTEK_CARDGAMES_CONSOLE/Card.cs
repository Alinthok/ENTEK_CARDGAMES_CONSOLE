using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTEK_CARDGAMES_CONSOLE
{
    class Card
    {
        public enum Type
        {
            DIAMOND, HEART, CLOVER, SPADE
        }

        private int number;
        private Type type;

        public Card(int number, Type type)
        {
            this.number = number;
            this.type = type;
        }

        public override string ToString()
        {
            return "|" + number + "-" + type + "|";
        }
    }
}
