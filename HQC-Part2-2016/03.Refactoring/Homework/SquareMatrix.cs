using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace RotatingWalkInMatrix
{
    internal class SquareMatrix
    {
        private int[,] matrix;
        private int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        private int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

        public SquareMatrix(int n)
        {
            this.matrix = new int[n, n];
        }

        public void FillWithZeroes()
        {
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    this.matrix[j, i] = 0;
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3}", this.matrix[j, i]);
                }

                Console.WriteLine();
            }
        }

        public bool IsFull()
        {
            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    if (this.matrix[i, j] == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsZero(int x, int y)
        {
            if (this.matrix[x, y] == 0)
            {
                return true;
            }

            return false;
        }

        public Coordinates NextField(Direction dir, Coordinates coord)
        {
            int size = this.matrix.GetLength(0);

            if (coord.Col + dirX[(int)dir] < size &&
                coord.Col + dirX[(int)dir] >= 0 &&
                coord.Row + dirY[(int)dir] < size &&
                coord.Row + dirY[(int)dir] >= 0)
            {
                coord.Col += dirX[(int)dir];
                coord.Row += dirY[(int)dir];
            }
            else
            {
                int rounds = 0;
                int currentDir = (int)dir;

                while (rounds < 7)
                {
                    Console.WriteLine(currentDir);
                    Console.WriteLine(dir);

                    if (currentDir + 1 > 7)
                    {
                        dir = Direction.DownRight;
                        currentDir = 0;
                    }
                    else
                    {
                        dir += 1;
                    }

                    if (coord.Col + dirX[(int)dir] < size &&
                                    coord.Col + dirX[(int)dir] >= 0 &&
                                    coord.Row + dirY[(int)dir] < size &&
                                    coord.Row + dirY[(int)dir] >= 0 &&
                                    this.IsZero(coord.Col + dirX[(int)dir],coord.Col + dirX[(int)dir]))
                    {
                        coord.Col += dirX[(int)dir];
                        coord.Row += dirY[(int)dir];
                        Console.WriteLine("success"+coord.Col + ", "+ coord.Row);
                        return coord;
                    }

                    rounds++;
                    currentDir++;
                }
            }

            return coord;
        }

        public void GetNewStart()
        {

        }

        public void FillWithRotatingWalk()
        {
            Direction dir = Direction.DownRight;

            int counter = 1;

            Coordinates coord = new Coordinates(0, 0);

            while (!this.IsFull())
            {
                if (IsZero(coord.Col, coord.Row))
                {
                    this.matrix[coord.Col, coord.Row] = counter;
                    counter++;
                }
                else
                {
                    coord = this.NextField(dir, coord);
                    this.matrix[coord.Col, coord.Row] = counter;
                    counter++;
                }
                

                this.Print();
                Console.WriteLine();

            }
        }
    }
}
