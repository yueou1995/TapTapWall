using System;

namespace TapTapWall
{
    public class GameHistory
    {
        private static GameHistory _instance;

        private int _topWonTimes;

        private int _bottomWonTimes;

        private int _totalMatchesCount;

        private GameHistory()
        {
            _topWonTimes = _bottomWonTimes = _totalMatchesCount = 0;
            HistoryChanged += (sender, e) => { _totalMatchesCount++; };
            HistoryChanged += (sender, e) =>
            {
                if (_totalMatchesCount >= 2)
                {
                    ToggleGameMode.Invoke(sender, e);
                }
            };
        }

        public static GameHistory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance =  new GameHistory();
                }
                return _instance;
            }
        }

        public void TopWon()
        {
            _topWonTimes++;
            HistoryChanged.Invoke(this, null);
        }

        public void BottomWon()
        {
            _bottomWonTimes++;
            HistoryChanged.Invoke(this, null);
        }

        public event EventHandler HistoryChanged;
        public event EventHandler ToggleGameMode;

        public override string ToString()
        {
            if (_totalMatchesCount < 1)
            {
                return "Tap Tap Tap";
            }
            return "Top vs Bottom" + Environment.NewLine + _topWonTimes + " : " + _bottomWonTimes;
        }
    }
}
