using System;

class MatrixMath
{
    ///<sumary>
    /// Calculates the determinant of a matrix
    ///</sumary>
    public static double Determinant(double[,] matrix)
    {
        int matrixRows = matrix.GetLength(0);
        int matrixCols = matrix.GetLength(1);
        double determinant = 0, firstNum = 0, secondNum = 0;

        // The determinant can only be found in square matrices
        if (matrixCols != matrixRows ||
            matrixRows != 2 && matrixRows !=3)
        {
            return -1;
        }


        if (matrixRows == 2)
        {
            firstNum = matrix[0,0] * matrix[1,1];
            secondNum = matrix[0,1] * matrix[1,0];
        }

        else if (matrixRows == 3)
        {
            double[,] detMatrix = ModifyMatrix(matrix, matrixRows);

            for (int j = 0; j < matrixCols; j += 2)
            {
                for (int i = 0; i < matrixRows; i++)
                {
                    if (j == 0)
                    {
                        // Diagonal from right to left
                        firstNum += detMatrix[i,j] * detMatrix[i+1,j+1] * detMatrix[i+2,j+2];
                    }
                    else if (j == 2)
                    {
                        // Diagonal from left to right
                        secondNum += detMatrix[i,j] * detMatrix[i+1,j-1] * detMatrix[i+2,j-2];
                    }
                }
            }
        }

        determinant = firstNum - secondNum;

        return (Math.Round(determinant, 2));
    }

    private static double[,] ModifyMatrix(double[,] matrix, int dimension)
    {
        int matrixRows = 5, row = 0;

        double[,] modifiedMatrix = new double[matrixRows,dimension];

        for (int i = 0; i < matrixRows; i++)
        {
            for (int j = 0; j < dimension; j++)
            {
                row = i;
                if (i > 2)
                    row -= 3;
                modifiedMatrix[i,j] = matrix[row,j];
            }
        }

        return modifiedMatrix;
    }
}
