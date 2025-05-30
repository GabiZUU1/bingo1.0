using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public class Game
    {
        #region todo
        //private List<Player> _players = new List<Player>();
        //public List<Player> Players
        //{
        //    get => _players;
        //    set
        //    {
        //        if (value == null)
        //            throw new ArgumentNullException(nameof(value), "Player list cannot be null.");

        //        if (value.Count < 1 || value.Count > 4)
        //            throw new ArgumentOutOfRangeException(nameof(value), "The player count must be between 1 and 4.");

        //        _players = value;
        //    }
        //} 
        #endregion

        private Card _playerCard;
        public Card PlayerCard
        {
            get => _playerCard;
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException(nameof(value), "PlayerCard cannot be null!");
                }

                _playerCard = value;
            }
        }

        private Type _cardType;
        public Type CardType
        {
            get => _cardType;
            set
            {

            }
        }

        public Game(Type CardType)
        {
            

            InitializeComponent();
        }

        //public Game(Type gameType, List<Player> players)
        //{
        //    _gameType = gameType;
        //    Players = players;

        //    InitializeComponent();
        //}

        private void InitializeComponent()
        {
            switch(PlayerCard.CardType)
            {

            }
        }
    }

    public enum Type
    {
        None,
        American,
        British
    }
}
