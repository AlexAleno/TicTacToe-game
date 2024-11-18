using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace TicTacToe
{
    public class Board
    {
        private PlayerEnum turn;
        private PlayerEnum[,] board = new PlayerEnum[3, 3];
        public Board()
        {

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    board[x, y] = PlayerEnum.NONE;
                }

            }
        }

        public bool Turn(int x, int y, out PlayerEnum win)
        {
            board[x, y] = turn;
            PlayerEnum winner;
            if (isOver(turn, x, y, out winner))
            {
                win = winner;
                return true;
            }

            win = PlayerEnum.NONE;
            if (turn == PlayerEnum.X)
                turn = PlayerEnum.O;
            else if (turn == PlayerEnum.O)
                turn = PlayerEnum.X;
            return false;
        }

        public bool isNotSet(int x, int y)
        {
            return board[x, y] == PlayerEnum.NONE;
        }

        public bool isOver(PlayerEnum player, int x, int y, out PlayerEnum winner)
        {
            winner = player;
            for (int i = 0; i < 3; i++)
            {
                if (board[x, i] != player)
                    break;
                if (i == 2 && board[x, 2] == player)
                    return true;
            }

            for (int i = 0; i < 3; i++)
            {
                if (board[i, y] != player)
                    break;
                if (i == 2 && board[2, y] == player)
                    return true;
            }

            if ((board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) || (board[2, 0] == player && board[1, 1] == player && board[0, 2] == player))
                return true;

            winner = PlayerEnum.NONE;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == PlayerEnum.NONE)
                        return false;
                    if (i == 2 && j == 2)
                        return true;
                }
            }
            return false;
        }

        public PlayerEnum getTurn()
        {
            return turn;
        }
        public void setTurn(PlayerEnum turnNow)
        {
            turn = turnNow;
        }
    }
}
