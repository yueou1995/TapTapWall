using System;
using UIKit;

namespace TapTapWall
{
    public class BattleCell : UIButton
    {
        public BattleCell(Player player, int cellNr, CellStatus status) {
            Player = player;
            CellNr = cellNr;
            Status = status;
        }

        public Player Player { get; set; }
        public int CellNr { get; set; }
        public CellStatus Status { get; set; }

    }
}
