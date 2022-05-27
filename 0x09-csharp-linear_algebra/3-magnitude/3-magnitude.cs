using System;

class VectorMath
{
    ///<sumary>
    /// Calculates and returns the length of a given vector
    ///</sumary>
    public static double Magnitude(double[] vector)
    {
        int vectorDimension = vector.Length;
        double lenghtVector = 0;

        if (vectorDimension < 2 || vectorDimension > 3)
            return -1;

        foreach (double num in vector)
        {
            lenghtVector += num * num;
        }

        // Take square root of the final number
        lenghtVector = Math.Sqrt(lenghtVector);

        // Value rounded to the nearest hundredth
        return (Math.Round(lenghtVector, 2));
    }
}
