﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        public static bool turn;
        private static PlayerEnum[,] board = new PlayerEnum[3, 3];
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

        public void Turn(int x, int y)
        {

            if (turn)
            {
                board[x, y] = PlayerEnum.X;
                turn = false;
            }
            else if (turn == false)
            {
                board[x, y] = PlayerEnum.O;
                turn = true;
            }
        }
        public bool getTurn()
        {
            return turn;
        }
        public void setTurn(bool turnNow)
        {
            turn = turnNow;
        }
    }
}
