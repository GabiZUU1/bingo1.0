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
        public int PlayerScore { get; set; }
        public int GeneratedNumber { get; set; }
        public List<int> GeneratedNumbers { get; set; } = new List<int>();
        public Control Parent { get; set; }
        public Timer NumberGeneratorTimer { get;set; }
        public Timer NumberGeneratorPauseTimer { get; set; }
        
        public Game(Control control)
        {
            Parent = control;

            NumberGeneratorTimer = new Timer(components);
            NumberGeneratorPauseTimer = new Timer(components);

            NumberGeneratorTimer.Interval = 4000;
            NumberGeneratorPauseTimer.Interval = 1;

            int timp = 0;
            NumberGeneratorTimer.Tick += (se, ar) =>
            {
                NumberGeneratorPauseTimer?.Stop();
                timp = 0;

                do
                {
                    GeneratedNumber = rnd.Next(1, 76);
                } while (GeneratedNumbers.Contains(GeneratedNumber));
                GeneratedNumbers.Add(GeneratedNumber);
                (Parent as FrmMain).Setnr(GeneratedNumber);

                NumberGeneratorPauseTimer.Start();
                (Parent as FrmMain).Resetprogress();
            };

            NumberGeneratorPauseTimer.Tick += (se, ar) =>
            {
                timp += 10;
                if (timp % 10 == 0)
                {
                    (Parent as FrmMain).Setprogress();
                }
                if (timp == 8000)
                {
                    timp = 0;
                    NumberGeneratorPauseTimer.Stop();
                }  
            };
        }

        public void Start()
        {
            NumberGeneratorTimer.Start();
            NumberGeneratorPauseTimer.Start();
        }
    }
}
