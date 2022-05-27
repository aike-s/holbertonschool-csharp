using System;

class VectorMath
{
    ///<sumary>
    /// Calculates the cross product of two 3D vectors and returns the resulting vector
    ///</sumary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[] crossVector = new double[3];
        int left = 1, right = 2, mult = 1;

        if (vector1.Length != 3 || vector2.Length != 3)
        {
            double[] error = {-1};
            return error;
        }

        for (int i = 0; i < 3; i++)
        {
            if (i == 1)
            {
                left--;
                mult = -1;
            }
            else if (i == 2)
            {
                right--;
            }

            // Find the cross product and round each element to the nearest hundredth
            crossVector[i] = (vector1[left] * vector2[right]) - (vector1[right] * vector2[left]);
            crossVector[i] = (Math.Round(crossVector[i] * mult, 2));
        }

        return crossVector;
    }
}
