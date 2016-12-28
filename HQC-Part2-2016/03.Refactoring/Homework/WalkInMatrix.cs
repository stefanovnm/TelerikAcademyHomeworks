using System;

namespace RotatingWalkInMatrix
{
    public class WalkInMatrix
    {
        public static void Main()
        {
            // Console.WriteLine( "Enter a positive number " );
            // string input = Console.ReadLine(  );
            // int n = 0;
            // while ( !int.TryParse( input, out n ) || n < 0 || n > 100 )
            // {
            //    Console.WriteLine( "You haven't entered a correct positive number" );
            //    input = Console.ReadLine(  );
            // }
            int n = 6;

            var matrix1 = new SquareMatrix(n);
            
            matrix1.FillWithZeroes();
            matrix1.Print();
            matrix1.FillWithRotatingWalk();


            // malko e kofti tova uslovie, no break-a raboti 100% : )

            
            var matrix = new int[n,n];
            int step = n;
            int k = 1;
            int i = 0;
            int j = 0;
            int dx = 1;
            int dy = 1;


            while (true)
            {
                matrix[i, j] = k;

                // prekusvame ako sme se zadunili
                if (!Check(matrix, i, j))
                {
                    break;
                }

                if (i + dx >= n || i + dx < 0 || j + dy >= n || j + dy < 0 || matrix[i + dx, j + dy] != 0)
                {
                    while ((i + dx >= n) || (i + dx < 0) || (j + dy >= n) || (j + dy < 0) || (matrix[i + dx, j + dy] != 0))
                    {
                        Change(dx, dy);
                    }
                }

                i += dx;
                j += dy;
                k++;
            }

            for (int p = 0; p < n; p++)
            {
                for (int q = 0; q < n; q++)
                {
                    Console.Write("{0,3}", matrix[p, q]);
                }

                Console.WriteLine();
            }

            FindCell(matrix, out i, out j);

            // taka go napravih, zashtoto funkciqta ne mi davashe da ne si definiram out parametrite
            if (i != 0 && j != 0)
            {
                dx = 1;
                dy = 1;

                // malko e kofti tova uslovie, no break-a raboti 100% : )
                while (true)
                {
                    matrix[i, j] = k;

                    // prekusvame ako sme se zadunili
                    if (!Check(matrix, i, j))
                    {
                        break;
                    }

                    if (i + dx >= n || i + dx < 0 || j + dy >= n || j + dy < 0 || matrix[i + dx, j + dy] != 0)
                    {
                        while ((i + dx >= n) || (i + dx < 0) || (j + dy >= n) || (j + dy < 0) || (matrix[i + dx, j + dy] != 0))
                        {
                            Change(dx, dy);
                        }
                    }

                    i += dx;
                    j += dy;
                    k++;
                }
            }

            for (int pp = 0; pp < n; pp++)
            {
                for (int qq = 0; qq < n; qq++)
                {
                    Console.Write("{0,3}", matrix[pp, qq]);
                }

                Console.WriteLine();
            }
        }

        private static void Change(int dx, int dy)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int cd = 0;
            for (int count = 0; count < 8; count++)
            {
                if (dirX[count] == dx && dirY[count] == dy)
                {
                    cd = count;
                }
            }

            if (cd == 7)
            {
                dx = dirX[0];
                dy = dirY[0];
            }

            dx = dirX[cd + 1];
            dy = dirY[cd + 1];
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

        private static void FindCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            { 
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        x = i;
                        y = j;
                        return;
                    }
                }
            }
        }
    }
}
