using System;

class MatrixMath
{
    ///<sumary>
    /// Transpose a matrix and return the resulting matrix
    ///</sumary>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.Length == 0)
        {
            double[,] emptyMatrix = {};
            return emptyMatrix;
        }

        int matrixTRows = matrix.GetLength(1);
        int matrixTCols = matrix.GetLength(0);
        double [,] matrixT = new double[matrixTRows,matrixTCols];

        for (int i = 0; i < matrixTRows; i++)
        {
            for (int j = 0; j < matrixTCols; j++)
            {
                // Traverse matrixT horizontally and the original matrix vertically
                matrixT[i,j] = matrix[j,i];
            }
        }

        return matrixT;
    }
}
