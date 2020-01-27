using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RELOAD_METHODS_OPERAT_TYPES_NAM;

namespace TEAM_PLAYER_NAM
{
   public class Team_Player
    {
        public class Player
        {
            public string Name { get; set; } // имя
            public int Number { get; set; } // номер
        }
        public class Team
        {
            Player[] players = new Player[11];

            public Player this[int index]
            {
                get { return players[index]; }
                set { players[index] = value; }
            }
        }
    }
}
