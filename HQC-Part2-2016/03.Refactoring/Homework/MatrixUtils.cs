using System;

namespace RotatingWalkInMatrix
{
    public class MatrixUtils
    {
        public Direction NextDirection(Direction dir, int[,] matrix, Coordinates coords)
        {
            Direction result = dir;
            int maxRow = matrix.GetLength(0);
            int maxCol = matrix.GetLength(1);

            //if (matrix[coords.Row, coords.Col])
            //{
                
            //}

            return result;
        }

        

        public void FillMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[j, i] = 0;
                }
            }
        }

        private static bool Check(int[,] arr, int x, int y)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (x + dirX[i] >= arr.GetLength(0) || x + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (y + dirY[i] >= arr.GetLength(0) || y + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (arr[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
