using System;

class MatrixMath
{

    ///<sumary>
    /// Adds two matrix and returns the resulting matrix
    ///</sumary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (ProperMatrix(matrix1, matrix2))
        {
            int matrixRows = matrix1.GetLength(0);
            int matrixCols = matrix1.GetLength(1);

            double[,] new_matrix = new double[matrixRows,matrixCols];

            for (int i = 0; i < matrixRows; i++)
            {
                for (int j = 0; j < matrixCols; j++)
                {
                    new_matrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return new_matrix;
        }

        double[,] errorMatrix = { { -1 } };
        return errorMatrix;
    }

    ///<sumary>
    /// Verifies that both matrix satisfy the conditions for being added together
    ///</sumary>
    private static bool ProperMatrix(double[,] matrix1, double[,] matrix2)
    {
        int matrix1Rows = matrix2.GetLength(0);
        int matrix1Cols = matrix1.GetLength(1);

        int matrix2Rows = matrix1.GetLength(0);
        int matrix2Cols = matrix2.GetLength(1);

        if (matrix1.Length == matrix2.Length)
        {
            if (matrix2Rows == 2 || matrix2Rows == 3 ||
                matrix2Cols == 2 || matrix2Cols == 3 ||
                matrix1Rows == 2 || matrix1Rows == 3 ||
                matrix1Cols == 2 || matrix1Cols == 3)
                return true;
        }

        return false;
    }
}
