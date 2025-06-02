using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Size = new Size(300, 400);
            this.BackColor = Color.DarkRed;
            this.Location = new Point(0, 0);

            Label lblTitle = new Label();
            this.Controls.Add(lblTitle);


            Cells = new AmericanCell[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Cells[i, j] = new AmericanCell(this);
                    Cell c = Cells[i, j];
                    this.Controls.Add(c);
                    c.Location = new Point(c.Width * i, c.Height * j);
                    c.Content = $"{i} {j}";
                }
            }
        }
    }
}
