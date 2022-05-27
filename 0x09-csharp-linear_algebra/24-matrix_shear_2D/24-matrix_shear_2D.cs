using System;

class MatrixMath
{

    ///<sumary>
    /// Shears a square 2D matrix by a given shear factor and returns the resulting matrix
    ///</sumary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int matrixCols = matrix.GetLength(1);
        int matrixRows = matrix.GetLength(0);

        if ((matrixCols != 2 || matrixRows != 2) || (direction != 'x' && direction != 'y'))
        {
            double[,] errorMatrix = { { -1 } };
            return errorMatrix;
        }

        double [,] newMatrix = new double[2,2];

        // If direction is 'x'
        int axis = 0, oppositeAxis = 1;

        if (direction == 'y')
        {
            axis = 1;
            oppositeAxis = 0;
        }

        for (int i = 0; i < matrixRows; i++)
        {
            for (int j = 0; j < matrixCols; j++)
            {
                if (axis == j)
                    newMatrix[i,axis] = matrix[i,axis] + (factor * matrix[i,oppositeAxis]);

                else
                    newMatrix[i,j] = matrix[i,j];
            }
        }

        return newMatrix;
    }
}
