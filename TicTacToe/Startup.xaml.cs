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

        private Board board = new();
        private int games;
        private int xwins;
        private int ywins;
        public Startup(int games, int xwins, int ywins, PlayerEnum winner)
        {
            InitializeComponent();
            this.games = games;
            this.xwins = xwins;
            this.ywins = ywins;
            SWon.Text = $"Last Game was Won By: {winner}";
            SGamePlayed.Text = $"Game Played: {games}";
            SXWins.Text = $"X Wins: {xwins}, WinRatio: {(games > 0 ? ((double)xwins / games) * 100 : 0):F2} %";
            SOWins.Text = $"X Wins: {ywins}, WinRatio: {(games > 0 ? ((double)ywins / games * 100) : 0):F2}%";
        }

        public Startup()
        {
            InitializeComponent();
            this.games = 0;
            this.xwins = 0;
            this.ywins = 0;
            SGamePlayed.Text = $"Game Played: {games}";
            SXWins.Text = $"X Wins: {xwins}, WinRatio: {(games > 0 ? ((double)xwins / games) * 100 : 0):F2} %";
            SOWins.Text = $"O Wins: {ywins}, WinRatio: {(games > 0 ? ((double)ywins / games * 100) : 0):F2}%";
        }

        private void x_image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            board.setTurn(PlayerEnum.X);
            MainWindow mainWindow = new(board, games, xwins, ywins);
            mainWindow.Show();
            this.Close();
        }
        private void o_image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            board.setTurn(PlayerEnum.O);
            MainWindow mainWindow = new(board, games, xwins, ywins);
            mainWindow.Show();
            this.Close();
        }
    }
}
