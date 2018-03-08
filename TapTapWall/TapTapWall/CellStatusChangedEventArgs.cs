using System;
using UIKit;

namespace TapTapWall
{
    public class CellStatusChangedEventArgs : EventArgs
    {
        public CellStatusChangedEventArgs(Player player, int cellNr, CellStatus newStatus)
        {
            Player = player;
            CellNr = cellNr;
            NewStatus = newStatus;
        }

        public Player Player { get; }

        public int CellNr { get; }

        public CellStatus NewStatus { get; }

    }
}
