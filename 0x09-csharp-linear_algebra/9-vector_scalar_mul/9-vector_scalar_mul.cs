using System;

class VectorMath
{
    ///<sumary>
    /// Multiplies a vector and a scalar and returns the resulting vector.
    ///<sumary/>
    public static double[] Multiply(double[] vector, double scalar)
    {
        int vectorDimension = vector.Length;

        // Verifies that the vector is 2D or 3D
        if (vectorDimension != 2 && vectorDimension != 3)
        {
            double[] errorVector = {-1};
            return errorVector;
        }

        double[] newVector = new double[vectorDimension];

        for (int i = 0; i < vectorDimension; i++)
        {
            newVector[i] = vector[i] * scalar;
        }

        return newVector;
    }
}
