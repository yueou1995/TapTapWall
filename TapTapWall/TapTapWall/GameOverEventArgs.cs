using System;
namespace TapTapWall
{
    public class GameOverEventArgs : EventArgs
    {
        public Player Winner { get; set; }

        public Player Loser
        {
            get
            {
                if (Winner.Equals(Player.Top))
                {
                    return Player.Bottom;
                }
                else
                {
                    return Player.Top;
                }
            }
        }
    }
}
