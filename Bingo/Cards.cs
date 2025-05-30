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
        private bool _completed;
        public bool Completed
        {
            get => _completed;
            set
            {
                _completed = value;
                this.Enabled = !value;
            }
        }

        private Type _cardType;
        public Type CardType
        {
            get => _cardType;
            set;
        }
    }

    public class AmercianCard : Card
    {

    }

    public class BritishCard : Card
    {

    }
}
