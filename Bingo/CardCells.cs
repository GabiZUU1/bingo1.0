using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Bingo
{
    public class Cell : Panel
    {
        protected Label lblText { get; set; } = null;
        private object _content;
        public object Content
        {
            get => _content;
            set
            {
                _content = value;
                if(lblText != null)
                {
                    lblText.Text = value as string;
                }
            }
        }
    }

    public class AmericanCell : Cell
    {
        public AmericanCell(Control parent)
        {
            this.Parent = parent;

            InitializeComponent();
        }

        public AmericanCell(Control parent, string Content)
        {
            this.Parent = parent;
            this.Content = Content;

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(this.Parent.Width / 5, this.Parent.Height / 5);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.Beige;

            lblText = new Label();
            this.Controls.Add(lblText);
            lblText.Dock = DockStyle.Fill;
            lblText.Font = new Font(lblText.Font.FontFamily, 12f);
            lblText.Text = this.Content as string;
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            lblText.AutoSize = false;
            //lblText.Location = new Point(0, 0);
        }
    }
}
