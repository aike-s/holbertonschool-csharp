using System;

class VectorMath
{

    ///<sumary>
    /// Adds two vectors and returns the resulting vector
    ///</sumary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (ProperVectors(vector1, vector2))
        {
            double[] vectorSum = new double[vector2.Length];

            for (int i = 0; i < vector1.Length; i++)
            {
                vectorSum[i] = vector1[i] + vector2[i];
            }

            return (vectorSum);
        }

        double[] errorVector = {-1};
        return errorVector;
    }

    ///<sumary>
    /// Verifies that both vectors satisfy the conditions for being added together
    ///</sumary>
    private static bool ProperVectors(double[] vector1, double[] vector2)
    {
        int vector1Dimension = vector1.Length;
        int vector2Dimension = vector2.Length;

        if (vector1Dimension == vector2Dimension)
        {
            if (vector1Dimension == 2 || vector1Dimension == 3)
                return true;
        }

        return false;
    }
}
