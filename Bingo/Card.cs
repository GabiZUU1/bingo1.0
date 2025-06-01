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

    }

    public class AmericanCard : Card
    {
        AmericanCell[,] Cells { get; set; } = null;

        public AmericanCard()
        {

        }

        private void InitializeComponent()
        {

        }
    }
}
