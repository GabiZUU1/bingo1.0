using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public class Card : Panel
    {
        CardCell[,] CardCells { get; set; }
        bool Completed { get; set; }
    }

    public class AmercianCard : Card
    {

    }

    public class BritishCard : Card
    {

    }
}
