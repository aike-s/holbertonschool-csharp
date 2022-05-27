using System;

class MatrixMath
{

    ///<sumary>
    /// Multiplies a matrix and a scalar and returns the resulting matrix
    ///<sumary/>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int matrixRows = matrix.GetLength(0);
        int matrixCols = matrix.GetLength(1);

        // Verify the matrix is 2D or 3D
        if (matrixRows != 2 && matrixRows != 3 ||
            matrixCols != 2 && matrixCols != 3 )
        {
            double[,] errorMatrix = { { -1 } };
            return errorMatrix;
        }

        double[,] new_matrix = new double[matrixRows,matrixCols];

        for (int i = 0; i < matrixRows; i++)
        {
            for (int j = 0; j < matrixCols; j++)
            {
                // Multiply each number in matrix by the scalar
                // and round it to the nearest hundredth
                new_matrix[i, j] = (Math.Round(matrix[i, j] * scalar, 2));
            }
        }
        return new_matrix;
    }

}
