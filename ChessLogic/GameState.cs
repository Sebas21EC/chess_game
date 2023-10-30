using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class GameState
    {
        public Board Board { get; set; }
        public Player CurrentPalyer { get; private set; }
        
        public GameState(Player player, Board board)
        {
         
            CurrentPalyer = player;
            Board = board;
        }

    }
}
