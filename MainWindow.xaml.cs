using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tank_Tactics.Logic.Context;

namespace Tank_Tactics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HashSet<Key> pressedKeys = new HashSet<Key>();
        public MainWindow()
        {
            this.DataContext = new GameContext();
           // this.InitializeComponent();
            this.KeyDown += OnKeyDown;
            this.KeyUp += OnKeyUp;
        }
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            pressedKeys.Add(e.Key);
            GameContext gameContext = this.DataContext as GameContext;

            // Example: Check if the combination of "A" and "B" is pressed in sequence
            if (pressedKeys.Contains(Key.A) && pressedKeys.Contains(Key.B))
            {
                MessageBox.Show("Keys A and B pressed in sequence!");
                // Optionally, clear the set or take other actions as needed
            }
            if (pressedKeys.Contains(Key.A))
            {
                gameContext.Map.Players[0].ChosenTank.MoveLeft();
                gameContext.OnPropertyChanged("Player1TankPositionLeft");
            }
            if (pressedKeys.Contains(Key.D))
            {
                gameContext.Map.Players[0].ChosenTank.MoveRight();
                gameContext.OnPropertyChanged("Player1TankPositionLeft");
            }
            if (pressedKeys.Contains(Key.W))
            {
                gameContext.Map.Players[0].ChosenTank.MoveUp();
                gameContext.OnPropertyChanged("Player1TankPositionTop");
            }
            if (pressedKeys.Contains(Key.S))
            {
                gameContext.Map.Players[0].ChosenTank.MoveDown();
                gameContext.OnPropertyChanged("Player1TankPositionTop");
            }
            if (pressedKeys.Contains(Key.I))
            {
                gameContext.Map.Players[1].ChosenTank.MoveUp();
                gameContext.OnPropertyChanged("Player2TankPositionTop");
            }
            if (pressedKeys.Contains(Key.J))
            {
                gameContext.Map.Players[1].ChosenTank.MoveLeft();
                gameContext.OnPropertyChanged("Player2TankPositionLeft");
            }
            if (pressedKeys.Contains(Key.K))
            {
                gameContext.Map.Players[1].ChosenTank.MoveDown();
                gameContext.OnPropertyChanged("Player2TankPositionTop");
            }
            if (pressedKeys.Contains(Key.L))
            {
                gameContext.Map.Players[1].ChosenTank.MoveRight();
                gameContext.OnPropertyChanged("Player2TankPositionLeft");
            }
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            pressedKeys.Remove(e.Key);
        }
    }
}