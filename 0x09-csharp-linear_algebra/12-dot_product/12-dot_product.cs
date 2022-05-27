using System;

class VectorMath
{

    ///<sumary>
    /// Calculates dot product of either two 2D or two 3D vectors
    ///<sumary/>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        int vector1Dimension = vector1.Length;
        int vector2Dimension = vector2.Length;

        if (vector1Dimension != vector2Dimension ||
            (vector1Dimension != 2 && vector1Dimension !=3))
            return -1;

        double dotProduct = 0;

        for ( int i = 0; i < vector1Dimension; i++)
        {
            dotProduct += vector1[i] * vector2[i];
        }

        return Math.Round(dotProduct, 2);
    }
}
