﻿namespace ChessLogic
{
    public class King: Piece
    {
        public override PieceType Type => PieceType.King;
        public override Player Color { get; }

        private static readonly Direction[] directions = new Direction[]
            {
                Direction.North,
                Direction.South,
                Direction.West,
                Direction.East,
                Direction.NorthWest,
                Direction.NorthEast,
                Direction.SouthWest,
                Direction.SouthEast


            };

        public King(Player color)
        {
            Color = color;
        }

        public override Piece Copy()
        {
            King copy = new King(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }

        private IEnumerable<Position> MovePositions(Position from, Board board)
        {
            foreach (Direction direction in directions)
            {
                Position to = from + direction;
                if (!Board.IsInside(to)) {
                    continue;
                }

                if(board.IsEmpty(to) || board[to].Color != Color)
                {
                    yield return to;
                }
            }
        }

        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositions(from, board).Select(to => new NormalMove(from, to));
        }
    }
}
