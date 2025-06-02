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
        public FrmMain()
        {
            InitializeComponent();

            this.Controls.Add(new AmericanCard());
        }
    }
}
