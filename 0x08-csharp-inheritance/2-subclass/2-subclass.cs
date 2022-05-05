using System;

/// <sumary>
/// Class obj
/// </sumary>
class Obj
{
    /// <sumary>
    /// Verify if the object is an instance of a class that inherits
    /// from the specified class
    /// </sumary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
