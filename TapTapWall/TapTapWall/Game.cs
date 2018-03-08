using System;
using UIKit;

namespace TapTapWall
{
    public class Game
    {
        private int _cellNumber;
        private ScoreBoard _scoreBoard;

        public int GameOverMark { get; }
        public BattleCell[] TopPlayerCells { get; }
        public BattleCell[] BottomPlayerCells { get; }

        public delegate void CellStatusChangedHandler(CellStatusChangedEventArgs args);
        public delegate void GameOverHandler(GameOverEventArgs args);
        public event CellStatusChangedHandler ChangeCellStatus;
        public event EventHandler ChangeGameStatus;
        public event GameOverHandler GameIsOver;


        public Game(int cellNumber, int gameOverMark)
        {
            _scoreBoard = new ScoreBoard(this);
            _cellNumber = cellNumber;
            GameOverMark = gameOverMark;
            TopPlayerCells = new BattleCell[cellNumber];
            BottomPlayerCells = new BattleCell[cellNumber];

            for (int i = 0; i < cellNumber; i++) {
                TopPlayerCells[i] = new BattleCell(Player.Top, i, CellStatus.Alive);
                BottomPlayerCells[i] = new BattleCell(Player.Bottom, i, CellStatus.Alive);
            }
            ChangeCellStatus += CellStatusUpdate;
            _scoreBoard.GameOverMarkReached += (GameOverEventArgs args) => {GameIsOver.Invoke(args);};

        }

        public void ButtonPressed(Player player, int CellNr)
        {
            if (player.Equals(Player.Top))
            {
                this.ButtonPressed(TopPlayerCells[CellNr]);
            }
            else
            {
                this.ButtonPressed(BottomPlayerCells[CellNr]);
            }
            ChangeGameStatus.Invoke(this, null);
        }

        private void ButtonPressed(BattleCell battleCell)
        {
            if (battleCell.Status.Equals(CellStatus.Dead))
            {
                ChangeCellStatus.Invoke(new CellStatusChangedEventArgs(battleCell.Player, battleCell.CellNr, CellStatus.Alive));
            }
            else
            {
                BattleCell oppositeBattleCell = OppositeBattleCell(battleCell);
                ChangeCellStatus.Invoke(new CellStatusChangedEventArgs(oppositeBattleCell.Player, oppositeBattleCell.CellNr, CellStatus.Dead));
            }
        }


        private void CellStatusUpdate(CellStatusChangedEventArgs args)
        {
            if (args.Player.Equals(Player.Top))
            {
                TopPlayerCells[args.CellNr].Status = args.NewStatus;
            }
            else
            {
                BottomPlayerCells[args.CellNr].Status = args.NewStatus;
            }
        }

        private BattleCell OppositeBattleCell(BattleCell battleCell)
        {
            if (battleCell.Player.Equals(Player.Top))
            {
                return BottomPlayerCells[battleCell.CellNr];
            }
            else
            {
                return TopPlayerCells[battleCell.CellNr];
            }
        }

        private Player OtherPlayer(Player player)
        {
            if (player.Equals(Player.Top))
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
