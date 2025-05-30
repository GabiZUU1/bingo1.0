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
        public string Content { get; set; } = string.Empty;
        public bool Marked { get; set; } = false;

        public AmericanCardCell(Card parent)
        {
            this.Parent = parent;

            InitializeComponent();
        }

        public AmericanCardCell(Card parent, string content)
        {
            this.Parent = parent;
            Content = content;

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(this.Parent.Width / 5, this.Parent.Height / 5);

        }
    }
}
