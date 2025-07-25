using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public class Card : Panel
    {
        public Game GameHost { get; set; }
        public Panel pnlTitle { get; set; } = new Panel();
        public Panel pnlCells { get; set; } = new Panel();

        public Card()
        {
            this.Size = new Size(300, 400);

            pnlTitle.Location = new Point(5, 5);
            pnlTitle.Size = new Size(290, 45);

            int i = 0;
            foreach(char c in "BINGO")
            {
                Label chr = new Label();
                chr.Size = new Size(pnlTitle.Width / 5, pnlTitle.Height);
                chr.Font = new Font("Arial Black", 20f);
                chr.Text = c.ToString();
                chr.TextAlign = ContentAlignment.MiddleCenter;
                chr.Location = new Point(i, 0);
                i = i + pnlTitle.Width / 5;
                pnlTitle.Controls.Add(chr);
            }

            pnlCells.Location = new Point(5, pnlTitle.Location.Y + pnlTitle.Height);
            pnlCells.Size = new Size(290, 345);

            this.Controls.Add(pnlCells);
            this.Controls.Add(pnlTitle);
        }
    }

    public class AmericanCard : Card
    {
        private Random rnd = new Random();
        private List<int> GeneratedNumbers { get; set; } = new List<int>();
        NumericalCell[,] Cells { get; set; } = null;

        public AmericanCard(Game host)
        {
            GameHost = host;

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Cells = new NumericalCell[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Cells[i, j] = new NumericalCell(pnlCells);
                    Cell c = Cells[i, j];
                    c.Location = new Point(c.Width * i, c.Height * j);
                    c.Click += NumericalCell_Click;
                    //c.Content = $"{i} {j}";
                    int nr;
                    switch (i)
                    {
                        case 0:
                            do
                            {
                                nr = rnd.Next(1, 16);
                            } while (GeneratedNumbers.Contains(nr));
                            GeneratedNumbers.Add(nr);
                            c.Content = nr;
                            break;
                        case 1:
                            do
                            {
                                nr = rnd.Next(16, 31);
                            } while (GeneratedNumbers.Contains(nr));
                            GeneratedNumbers.Add(nr);
                            c.Content = nr;
                            break;
                        case 2:
                            do
                            {
                                nr = rnd.Next(31, 46);
                            } while (GeneratedNumbers.Contains(nr));
                            GeneratedNumbers.Add(nr);
                            c.Content = nr;
                            break;
                        case 3:
                            do
                            {
                                nr = rnd.Next(46, 61);
                            } while (GeneratedNumbers.Contains(nr));
                            GeneratedNumbers.Add(nr);
                            c.Content = nr;
                            break;
                        case 4:
                            do
                            {
                                nr = rnd.Next(61, 76);
                            } while (GeneratedNumbers.Contains(nr));
                            GeneratedNumbers.Add(nr);
                            c.Content = nr;
                            break;
                    }

                    if (i == 2 && j == 2)
                    {
                        GeneratedNumbers.Remove(Convert.ToInt32(c.Content));
                        c.Content = "free";
                    }
                }
            }
        }

        private void NumericalCell_Click(object sender, EventArgs e)
        {
            if (GameHost == null) return;

            NumericalCell c = sender as NumericalCell;
            if(c.Content is int && Convert.ToInt32(c.Content) == GameHost.GeneratedNumber)
            {
                GameHost.PlayerScore += 2;
                c.BackColor = Color.OrangeRed;
                c.Checked = true;
            }
            else
            {
                if(c.Content is int && GameHost.GeneratedNumbers.Contains(Convert.ToInt32(c.Content)))
                {
                    GameHost.PlayerScore++;
                    c.BackColor = Color.ForestGreen;
                    c.Checked = true;
                }
            }
        }
    }
}
