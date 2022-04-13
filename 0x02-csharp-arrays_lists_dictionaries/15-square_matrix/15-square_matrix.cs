using System;
using System.Collections.Generic;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int width = myMatrix.GetLength(0);
        int height = myMatrix.GetLength(1);
        int[,] squareMatrix = new int[width,height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                int squareValue = myMatrix[x,y] * myMatrix[x,y];
                squareMatrix[x,y] = squareValue;
            }
        }

        return squareMatrix;
    }
}
