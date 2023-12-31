﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class Board
    {
        private readonly Piece[,] pieces = new Piece[8, 8];

        public Piece this[int row, int column]
        {
            get => pieces[row, column];
            set => pieces[row, column] = value;
        }

        public Piece this[Position position]
        {
            get => pieces[position.Row, position.Column];
            set => pieces[position.Row, position.Column] = value;
        }

        public static Board Initial()
        {
            Board board = new Board();
            board.AddStartPieces();
            return board;

        }

        private void AddStartPieces()
        {
            // Pieces black
            this[0, 0] = new Rook(Player.Black);
            this[0, 1] = new Knight(Player.Black);
            this[0, 2] = new Bishop(Player.Black);
            this[0, 3] = new Queen(Player.Black);
            this[0, 4] = new King(Player.Black);
            this[0, 5] = new Bishop(Player.Black);
            this[0, 6] = new Knight(Player.Black);
            this[0, 7] = new Rook(Player.Black);

            //Pieces white
            this[7, 0] = new Rook(Player.White);
            this[7, 1] = new Knight(Player.White);
            this[7, 2] = new Bishop(Player.White);
            this[7, 3] = new Queen(Player.White);
            this[7, 4] = new King(Player.White);
            this[7, 5] = new Bishop(Player.White);
            this[7, 6] = new Knight(Player.White);
            this[7, 7] = new Rook(Player.White);


            // Pawns black and white
            for (int column = 0; column < 8; column++)
            {
                this[1, column] = new Pawn(Player.Black);
                this[6, column] = new Pawn(Player.White);
            }

        }

        public static bool IsInside(Position position)
        {
            return position.Row >= 0 && position.Row < 8 && position.Column >= 0 && position.Column < 8;
        }

        public bool IsEmpty(Position position)
        {
            return this[position] == null;
        }
    }
}
