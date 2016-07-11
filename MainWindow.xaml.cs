using System.Windows;

namespace Puzzle2048
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            IPuzzle2048VM vm = new Puzzle2048VM();
            DataContext = vm;
        }

        private void ButtonBase_OnClickUp(object sender, RoutedEventArgs e)
        {
            var vm=DataContext as IPuzzle2048VM;            
            vm?.OnKey(Puzzle2048Key.Up);
        }

        private void ButtonBase_OnClickDown(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as IPuzzle2048VM;
            vm?.OnKey(Puzzle2048Key.Down);
        }

        private void ButtonBase_OnClickLeft(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as IPuzzle2048VM;
            vm?.OnKey(Puzzle2048Key.Left);
        }

        private void ButtonBase_OnClickRight(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as IPuzzle2048VM;
            vm?.OnKey(Puzzle2048Key.Right);
        }

        private void ButtonBase_OnClickStart(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as IPuzzle2048VM;
            vm?.OnKey(Puzzle2048Key.Start);
        }
        private void ButtonBase_OnClickStop(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as IPuzzle2048VM;
            vm?.OnKey(Puzzle2048Key.Stop);
        }

        private void ButtonBase_OnClickReset(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as IPuzzle2048VM;
            vm?.OnKey(Puzzle2048Key.Reset);
        }
    }

    public enum Puzzle2048Key { Up, Down, Left, Right, Start, Stop, Reset}
    public interface IPuzzle2048VM
    {
        string Label11Text { get; }
        string Label12Text { get; }
        string Label13Text { get; }
        string Label14Text { get; }
        string Label21Text { get; }
        string Label22Text { get; }
        string Label23Text { get; }
        string Label24Text { get; }
        string Label31Text { get; }
        string Label32Text { get; }
        string Label33Text { get; }
        string Label34Text { get; }
        string Label41Text { get; }
        string Label42Text { get; }
        string Label43Text { get; }
        string Label44Text { get; }
        int Prob4 { get; set; }
        int Score { get; }

        void OnKey(Puzzle2048Key key);
    }
}
