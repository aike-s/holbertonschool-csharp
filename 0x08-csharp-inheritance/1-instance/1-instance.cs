using System;

/// <sumary>
/// Class obj
/// </sumary>
class Obj
{
    /// <sumary> Verify if the object is an instance of, or if the object
    /// is an instance of a class that inherited from, Array </sumary>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
