using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class Card
    {
        public CardCell[,] Cells { get; set; }
    }

    public enum CardType
    {
        AmericanCard,
        BritishCard
    }
}
