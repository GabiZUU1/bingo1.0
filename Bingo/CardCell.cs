using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Bingo
{
    public interface ICardCell
    {
        string Content { get; set; }
        bool Marked { get; set; }
    }

    public class AmericanCardCell : Label, ICardCell
    {
        public Card CParent { get; set; } = null;
        public string Content { get; set; } = string.Empty;
        public bool Marked { get; set; } = false;

        public AmericanCardCell(Card parent)
        {
            CParent = parent;
        }

        private void InitializeComponent()
        {

        }
    }
}
