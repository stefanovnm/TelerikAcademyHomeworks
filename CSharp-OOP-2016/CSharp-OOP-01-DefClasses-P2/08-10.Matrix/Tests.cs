namespace _08_10.Matrix
{
    using System;

    public class Tests
    {
        public static void Main()
        {
            Matrix<int> matrix = new Matrix<int>(5, 5);
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    matrix[i, j] = i + j;
                }
            }

            Matrix<int> secondMatrix = new Matrix<int>(5, 5);

            for (int i = 0; i < secondMatrix.Rows; i++)
            {
                for (int j = 0; j < secondMatrix.Cols; j++)
                {
                    secondMatrix[i, j] =  2*secondMatrix.Rows -2 - i - j;
                }
            }


            Console.WriteLine(matrix);
            Console.WriteLine(secondMatrix);

            Console.WriteLine("\nAdd of the 2 matrices");
            Matrix<int> sumMatrix = new Matrix<int>(5, 5);
            sumMatrix = matrix + secondMatrix;
            Console.WriteLine(sumMatrix);

            Console.WriteLine("\nSubtraction of the 2 matrices");
            Matrix<int> subtrMatrix = new Matrix<int>(5, 5);
            subtrMatrix = matrix - secondMatrix;
            Console.WriteLine(subtrMatrix);

            Console.WriteLine("\nMultiplication of 2 matrices");
            Matrix<int> multMatrix = new Matrix<int>(5, 5);
            multMatrix = matrix * secondMatrix;
            Console.WriteLine(multMatrix);
            //http://matrix.reshish.com/multCalculation.php - to check if it is right

            Console.WriteLine("Is first matrix all zeroes:\n{0}",matrix);
            Console.WriteLine(matrix ? "True" : "False");

            Matrix<int> zeroMatrix = new Matrix<int>(5, 5);
            for (int i = 0; i < zeroMatrix.Rows; i++)
            {
                for (int j = 0; j < zeroMatrix.Cols; j++)
                {
                    zeroMatrix[i, j] = 0;
                }
            }

            Console.WriteLine("\nIs zero matrix all zeroes:\n{0}", zeroMatrix);
            Console.WriteLine(zeroMatrix ? "True" : "False");

        }
    }
}
