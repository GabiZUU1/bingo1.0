using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public class CardCell : Panel
    {
        public string Content { get; set; } = "ok";
    }

    public class AmericanCell : CardCell
    {

    }
}
