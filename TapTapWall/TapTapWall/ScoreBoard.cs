using System;

namespace TapTapWall
{
    public class ScoreBoard
    {
        private Game _game;
        private BattleCell[] _topPlayerCells;
        private BattleCell[] _bottomPlayerCells;
        private int _topPlayerAliveNr;
        private int _bottomPlayerAliveNr;

        public delegate void GameOverHandler(GameOverEventArgs args);
        public event GameOverHandler GameOverMarkReached;

        public ScoreBoard(Game game)
        {
            _game = game;
            _game.ChangeGameStatus += (sender, e) => UpdateScore();
        }

        private void UpdateScore()
        {
            _topPlayerCells = _game.TopPlayerCells;
            _bottomPlayerCells = _game.BottomPlayerCells;
            _topPlayerAliveNr = CountPlayerAliveNr(_topPlayerCells);
            _bottomPlayerAliveNr = CountPlayerAliveNr(_bottomPlayerCells);

            if (Difference >= _game.GameOverMark)
            {
                GameOverMarkReached.Invoke(new GameOverEventArgs() { Winner = LeadingPlayer });
            }
        }

        private int CountPlayerAliveNr(BattleCell[] cells)
        {
            int count = 0;
            foreach (BattleCell cell in cells)
            {
                if (cell.Status.Equals(CellStatus.Alive))
                {
                    count++;
                }
            }
            return count;
        }

        public int Difference
        {
            get
            {
                return Math.Abs(_topPlayerAliveNr - _bottomPlayerAliveNr);
            }
        }

        private Player LeadingPlayer
        {
            get
            {
                return _topPlayerAliveNr > _bottomPlayerAliveNr ? Player.Top : Player.Bottom;
            }
        }

    }
}
