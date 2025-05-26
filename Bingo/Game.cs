using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class Game
    {
        private List<Player> _players = new List<Player>();
        public List<Player> Players
        {
            get => _players;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value), "Player list cannot be null.");

                if (value.Count < 1 || value.Count > 4)
                    throw new ArgumentOutOfRangeException(nameof(value), "The player count must be between 1 and 4.");

                _players = value;
            }
        }
        private GameType _gameType { get; set; } = GameType.American;

        public Game()
        {
            InitializeComponent();
        }

        public Game(GameType gameType)
        {
            _gameType = gameType;

            InitializeComponent();
        }

        public Game(GameType gameType, List<Player> players)
        {
            _gameType = gameType;
            Players = players;

            InitializeComponent();
        }

        private void InitializeComponent()
        {

        }
    }

    public enum GameType
    {
        American,
        British
    }
}
