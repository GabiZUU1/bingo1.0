using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class FrmMain: Form
    {
        private Game g;
        public FrmMain()
        {
            InitializeComponent();
            this.components = new Container();

            this.Click += (se, ar) => { };

            g = new Game(this);

            AmericanCard c1 = new AmericanCard(g);
            AmericanCard c2 = new AmericanCard(g);
            AmericanCard c3 = new AmericanCard(g);
            AmericanCard c4 = new AmericanCard(g);
            c1.Location = new Point(0, lblScore.Height + nrales.Height + 5);
            c2.Location = new Point(c1.Location.X + c1.Width + 10, c1.Location.Y);
            c3.Location = new Point(c2.Location.X + c2.Width + 10, c2.Location.Y);
            c4.Location = new Point(c3.Location.X + c3.Width + 10, c3.Location.Y);
            c1.BackColor = c2.BackColor = c3.BackColor = c4.BackColor = Color.LightCyan;
            this.Controls.Add(c1);
            this.Controls.Add(c2);
            this.Controls.Add(c3);
            this.Controls.Add(c4);
        }

        public void Setnr(int nr)
        {
            nrales.Text = nr.ToString();
        }

        public void Setprogress()
        {
            prg1.PerformStep();
        }

        public void Resetprogress()
        {
            prg1.Value = 0;
        }

        public void SetText(string txt)
        {
            lblScore.Text = "Your score: " + txt;
        }

        private void nrales_Click(object sender, EventArgs e)
        {
            nrales.BackColor = Color.LightGreen;
            g.Start();
        }
    }
}
