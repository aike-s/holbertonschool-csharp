using System;

class MatrixMath
{

    ///<sumary>
    /// Multiplies two matrices and returns the resulting matrix
    ///</sumary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int matrix1Cols = matrix1.GetLength(1);
        int matrix2Rows = matrix2.GetLength(0);

        // The number of columns in Matrix1 must be equal
        // to the number of rows in Matrix2 in order to be multiplied
        if (matrix1Cols != matrix2Rows)
        {
            double[,] errorMatrix = { { -1 } };
            return errorMatrix;
        }

        // To know the dimensions of the new matrix
        int nmRows = matrix1.GetLength(0); // Matrix1 rows
        int nmCols = matrix2.GetLength(1); // Matrix2 columns
        double[,] newMatrix = new double[nmRows,nmCols];

        for (int i = 0; i < nmRows; i++)
        {
            for (int j = 0; j < nmCols; j++)
            {
                for (int commonNum = 0; commonNum < matrix2Rows; commonNum++)
                {
                    // It is necessary to traverse matrix1 horizontally and matrix2 vertically,
                    // for this we use commonNum which is the number used by both matrices:
                    // matrix1 in its columns and matrix2 in its rows
                    newMatrix[i, j] += matrix1[i, commonNum] * matrix2[commonNum, j];
                }
            }
        }

        return newMatrix;
    }

}
