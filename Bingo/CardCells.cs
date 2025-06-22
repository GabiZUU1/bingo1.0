using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Markup;

namespace Bingo
{
    public class Cell : Panel
    {
        public bool Checked = false;
        protected Label lblText { get; set; } = null;
        private object _content = null;
        public object Content
        {
            get => _content;
            set
            {
                //if (value.GetType() != typeof(string))
                //{
                //    MessageBox.Show("jdfsiujd");
                //}
                if (value is int) _content = value;
                else if (value is string && value == "free") _content = "FREE";
                if (lblText != null)
                {
                    lblText.Text = value.ToString();
                }
            }
        }
    }

    public class NumericalCell : Cell
    {
        public NumericalCell(Control parent)
        {
            this.Parent = parent;

            InitializeComponent();
        }

        public NumericalCell(Control parent, int Content)
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

            //this.Click += NumericalCell_Click;
            

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
