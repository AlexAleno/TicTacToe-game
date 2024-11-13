using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for Startup.xaml
    /// </summary>
    public partial class Startup : Window
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void x_image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Board board = new Board();
            board.setTurn(true);
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        private void o_image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Board board = new Board();
            board.setTurn(false);
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
