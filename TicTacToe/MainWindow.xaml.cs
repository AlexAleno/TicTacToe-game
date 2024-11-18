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


namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Board board;
        private int games;
        private int xwins;
        private int ywins;
        public MainWindow(Board board, int games, int xwins, int ywins)
        {
            InitializeComponent();
            this.board = board;
            this.games = games;
            this.xwins = xwins;
            this.ywins = ywins;
            GamePlayed.Text = $"Game Played: {games}";
            XWins.Text = $"X Wins: {xwins}, WinRatio: {(games > 0 ? ((double) xwins / games) * 100 : 0):F2} %";
            OWins.Text = $"O Wins: {ywins}, WinRatio: {(games > 0 ? ((double)ywins / games * 100) : 0):F2}%";
            PlayerTurn.Text = $"Turn: {board.getTurn()}";
        }

        private void All_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image img = (Image)sender;
            int y = Grid.GetColumn(img);
            int x = Grid.GetRow(img);
            PlayerEnum winner;
            if (board.isNotSet(x, y)){
                if(board.Turn(x, y, out winner))
                {
                    if (winner == PlayerEnum.X)
                        xwins++;
                    else if (winner == PlayerEnum.O)
                        ywins++;

                    Startup startup = new(++games, xwins, ywins, winner);
                    startup.Show();
                    this.Close();
                }
                PlayerTurn.Text = $"Turn: {board.getTurn()}";
                if (board.getTurn() == PlayerEnum.X)
                {
                    img.Source = new BitmapImage(new Uri(@"Images/tic-tac-toe_o.png", UriKind.Relative));
                }
                else if (board.getTurn() == PlayerEnum.O)
                {
                    img.Source = new BitmapImage(new Uri(@"Images/tic-tac-toe_x.png", UriKind.Relative));
                }
            }
        }
    }
}