using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Puzzle2048.Annotations;

namespace Puzzle2048
{
    public class Puzzle2048VM : IPuzzle2048VM, INotifyPropertyChanged
    {
        private readonly int[,] _label={{1,1,1,1},{1,0,0,0},{1,1,0,0},{1,1,1,0}};
        private int _prob4=5;
        private int _score;

        private string Label(int i, int j)
        {
            var v = _label[i-1, j-1];
            return v == 0 ? "" : v.ToString();
        }

        public string Label11Text=> Label(1, 1);
        public string Label12Text=> Label(1, 2);
        public string Label13Text=> Label(1, 3);
        public string Label14Text=> Label(1, 4);
        public string Label21Text=> Label(2, 1);
        public string Label22Text=> Label(2, 2);
        public string Label23Text=> Label(2, 3);
        public string Label24Text=> Label(2, 4);
        public string Label31Text=> Label(3, 1);
        public string Label32Text=> Label(3, 2);
        public string Label33Text=> Label(3, 3);
        public string Label34Text=> Label(3, 4);
        public string Label41Text=> Label(4, 1);
        public string Label42Text=> Label(4, 2);
        public string Label43Text=> Label(4, 3);
        public string Label44Text=> Label(4, 4);

        public int Prob4
        {
            get { return _prob4; }
            set { _prob4 = value; OnPropertyChanged(); }
        }

        public int Score
        {
            get { return _score; }
            set
            {
                _score = value;
                OnPropertyChanged();
            }
        }

        public void OnKey(Puzzle2048Key key)
        {
            int i, j;
            switch (key)
            {
                case Puzzle2048Key.Up:
                    for (i=0;i<4;i++) for (j=0;j<3;j++)
                        _label[j, i] = _label[j+1, i];
                    for (i = 0; i < 4; i++)
                        _label[3, i] = _score+2;
                    OnPropertyChangedForLabels();
                    Score += 1;
                    break;
                case Puzzle2048Key.Down:
                    break;
                case Puzzle2048Key.Left:
                    break;
                case Puzzle2048Key.Right:
                    break;
                case Puzzle2048Key.Start:
                    break;
                case Puzzle2048Key.Stop:
                    break;
                case Puzzle2048Key.Reset:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(key), key, null);
            }
        }

        private void OnPropertyChangedForLabels()
        {
            OnPropertyChanged(nameof(Label11Text));
            OnPropertyChanged(nameof(Label12Text));
            OnPropertyChanged(nameof(Label13Text));
            OnPropertyChanged(nameof(Label14Text));
            OnPropertyChanged(nameof(Label21Text));
            OnPropertyChanged(nameof(Label22Text));
            OnPropertyChanged(nameof(Label23Text));
            OnPropertyChanged(nameof(Label24Text));
            OnPropertyChanged(nameof(Label31Text));
            OnPropertyChanged(nameof(Label32Text));
            OnPropertyChanged(nameof(Label33Text));
            OnPropertyChanged(nameof(Label34Text));
            OnPropertyChanged(nameof(Label41Text));
            OnPropertyChanged(nameof(Label42Text));
            OnPropertyChanged(nameof(Label43Text));
            OnPropertyChanged(nameof(Label44Text));

        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}