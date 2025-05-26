using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class Player
    {
        public string UserName { get; set; }
        public string Email { get; set; }

        public Player()
        {
            UserName = Email = string.Empty;
        }

        public Player(string username, string email)
        {
            UserName = username;
            Email = email;
        }

        public void Clear()
        {
            if (this != null)
            {
                this.UserName = this.Email = string.Empty;
            }
        }
    }
}
