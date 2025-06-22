using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Bingo
{
    public class Game
    {
        private IContainer components = new Container();
        private Random rnd = new Random();
        private int GeneratedNumber;
        public List<int> GeneratedNumbers { get; set; } = new List<int>();
        public Control Parent { get; set; }
        public Timer NumberGeneratorTimer { get;set; }
        
        public Game(Control control)
        {
            Parent = control;

            NumberGeneratorTimer = new Timer(components);
            NumberGeneratorTimer.Interval = 4000;
            NumberGeneratorTimer.Tick += (se, ar) =>
            {
                do
                {
                    GeneratedNumber = rnd.Next(1, 76);
                } while (GeneratedNumbers.Contains(GeneratedNumber));
                GeneratedNumbers.Add(GeneratedNumber);
                (Parent as FrmMain).Setnr(GeneratedNumber);
            };
        }

        public void Start()
        {
            NumberGeneratorTimer.Start();
        }
    }
}
