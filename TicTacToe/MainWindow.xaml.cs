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
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void All_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Board board = new Board();
            Image img = (Image)sender;
            int y=Grid.GetColumn(img);
            int x=Grid.GetRow(img);
            board.Turn(x, y);
            
            if (board.getTurn())
            {
                img.Source = new BitmapImage(new Uri(@"Images/tic-tac-toe_o.png", UriKind.Relative));
            }
            else
            {
                img.Source = new BitmapImage(new Uri(@"Images/tic-tac-toe_x.png", UriKind.Relative));
            }
            
            

        }
    }
}