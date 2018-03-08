using System;

using UIKit;

namespace TapTapWall
{
    public partial class ViewController : UIViewController
    {
        private Game _game;
        private GameHistory _gameHistory;
        private GameMode _currentGameMode;
        private UIButton[] _topButtons;
        private UIButton[] _bottomButtons;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            _currentGameMode = GameMode.KidsMode;
            _gameHistory = GameHistory.Instance;
            _gameHistory.ToggleGameMode += (sender, e) => { _currentGameMode = GameMode.TrumpMode; };
            NewGame();
        }

        public void NewGame()
        {
            _game = new Game(24, 6);
            UpdateText();
            TopGameOverImage.Image = null;
            BottomGameOverImage.Image = null;
            TopGameOverImage.BackgroundColor = UIColor.Clear;
            BottomGameOverImage.BackgroundColor = UIColor.Clear;
            _topButtons = new UIButton[24] { Button_T0, Button_T1, Button_T2, Button_T3, Button_T4, Button_T5, Button_T6, Button_T7, Button_T8, Button_T9, Button_T10, Button_T11, Button_T12, Button_T13, Button_T14, Button_T15, Button_T16, Button_T17, Button_T18, Button_T19, Button_T20, Button_T21, Button_T22, Button_T23 };
            _bottomButtons = new UIButton[24] { Button_B0, Button_B1, Button_B2, Button_B3, Button_B4, Button_B5, Button_B6, Button_B7, Button_B8, Button_B9, Button_B10, Button_B11, Button_B12, Button_B13, Button_B14, Button_B15, Button_B16, Button_B17, Button_B18, Button_B19, Button_B20, Button_B21, Button_B22, Button_B23 };

            foreach (UIButton button in _topButtons)
            {
                button.BackgroundColor = UIColor.Clear;
                DisplayAliveCell(button, true);
            }
            foreach (UIButton button in _bottomButtons)
            {
                button.BackgroundColor = UIColor.Clear;
                DisplayAliveCell(button, false);
            }

            _game.ChangeCellStatus += CellLookUpdate;
            _game.GameIsOver += EndGame;
        }

        private void UpdateText() {
            TitleLabel.Text = _gameHistory.ToString();
        }

        public void EndGame(GameOverEventArgs args)
        {
            var alert = UIAlertController.Create("GAME OVER", null, UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("NEW GAME", UIAlertActionStyle.Default, (UIAlertAction obj) => NewGame()));
            PresentViewController(alert, true, null);
            TopGameOverImage.BackgroundColor = UIColor.LightTextColor;
            BottomGameOverImage.BackgroundColor = UIColor.LightTextColor;
            if (args.Winner.Equals(Player.Top))
            {
                _gameHistory.TopWon();
                TopGameOverImage.Image = UIImage.FromBundle("TopWon.png");
                BottomGameOverImage.Image = UIImage.FromBundle("BottomLost.png");
            }
            else
            {
                _gameHistory.BottomWon();
                TopGameOverImage.Image = UIImage.FromBundle("TopLost.png");
                BottomGameOverImage.Image = UIImage.FromBundle("BottomWon.png");
            }
        }

        private void CellLookUpdate(CellStatusChangedEventArgs args)
        {
            UIButton button;
            bool isTop = args.Player == Player.Top;
            if (isTop)
            {
                button = _topButtons[args.CellNr];
            }
            else
            {
                button = _bottomButtons[args.CellNr];
            }

            if (args.NewStatus.Equals(CellStatus.Alive))
            {
                DisplayAliveCell(button, isTop);
            }
            else
            {
                DisplayDeadCell(button, isTop);
            }
        }

        /// <summary>
        /// Make the button appear alive.
        /// </summary>
        /// <param name="button">Button.</param>
        /// <param name="isTop">If the button belongs to the TOP player.</param>
        private void DisplayAliveCell(UIButton button, bool isTop)
        {
            switch (_currentGameMode)
            {
                case GameMode.KidsMode:
                    button.BackgroundColor = UIColor.Green;
                    break;
                case GameMode.TrumpMode:
                    if (isTop) {
                        button.SetBackgroundImage(UIImage.FromBundle("TopObama.png"), UIControlState.Normal);   
                    } else {
                        button.SetBackgroundImage(UIImage.FromBundle("BottomObama.png"), UIControlState.Normal);   
                    }
                    break;
                default: break;
            }
        }

        private void DisplayDeadCell(UIButton button, bool isTop)
        {
            switch (_currentGameMode)
            {
                case GameMode.KidsMode:
                    button.BackgroundColor = UIColor.Gray;
                    break;
                case GameMode.TrumpMode:
                    if (isTop) {
                        button.SetBackgroundImage(UIImage.FromBundle("TopTrump.jpg"), UIControlState.Normal);
                    } else {
                        button.SetBackgroundImage(UIImage.FromBundle("BottomTrump.jpg"), UIControlState.Normal);
                    }
                    break;
                default: break;
            }
        }

        //private string GameOverMessage(GameOverEventArgs args)
        //{
        //    switch (_currentGameMode)
        //    {
        //        case GameMode.KidsMode:
        //            return args.Winner + " Player won!";
        //        case GameMode.TrumpMode:
        //            return "Trump invaded " + args.Loser.ToString().ToUpper();
        //        default:
        //            return "";
        //    }
        //}

        #region ButtonEvents
        partial void Button_T0_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 0);
        }

        partial void Button_T1_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 1);
        }

        partial void Button_T2_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 2);
        }


        partial void Button_T3_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 3);
        }

        partial void Button_T4_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 4);
        }

        partial void Button_T5_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 5);
        }

        partial void Button_T6_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 6);
        }

        partial void Button_T7_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 7);
        }

        partial void Button_T8_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 8);
        }

        partial void Button_T9_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 9);
        }

        partial void Button_T10_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 10);
        }

        partial void Button_T11_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 11);
        }

        partial void Button_T12_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 12);
        }

        partial void Button_T13_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 13);
        }

        partial void Button_T14_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 14);
        }

        partial void Button_T15_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 15);
        }

        partial void Button_T16_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 16);
        }

        partial void Button_T17_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 17);
        }

        partial void Button_T18_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 18);
        }

        partial void Button_T19_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 19);
        }

        partial void Button_T20_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 20);
        }

        partial void Button_T21_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 21);
        }

        partial void Button_T22_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 22);
        }

        partial void Button_T23_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Top, 23);
        }

        partial void Button_B0_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 0);
        }

        partial void Button_B1_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 1);
        }

        partial void Button_B2_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 2);
        }

        partial void Button_B3_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 3);
        }

        partial void Button_B4_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 4);
        }

        partial void Button_B5_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 5);
        }

        partial void Button_B6_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 6);
        }

        partial void Button_B7_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 7);
        }

        partial void Button_B8_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 8);
        }

        partial void Button_B9_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 9);
        }

        partial void Button_B10_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 10);
        }

        partial void Button_B11_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 11);
        }

        partial void Button_B12_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 12);
        }

        partial void Button_B13_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 13);
        }

        partial void Button_B14_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 14);
        }

        partial void Button_B15_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 15);
        }

        partial void Button_B16_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 16);
        }

        partial void Button_B17_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 17);
        }

        partial void Button_B18_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 18);
        }

        partial void Button_B19_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 19);
        }

        partial void Button_B20_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 20);
        }

        partial void Button_B21_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 21);
        }

        partial void Button_B22_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 22);
        }

        partial void Button_B23_TouchUpInside(UIButton sender)
        {
            _game.ButtonPressed(Player.Bottom, 23);
        }

        #endregion

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
