using System;
using System.Collections.Generic;
using System.Reflection;


/// <sumary>
/// Class obj
/// </sumary>

class Obj
{
    /// <sumary>
    /// Prints the names of the available properties and methods of an object
    /// </sumary>

    public static void Print(object myObj)
    {
        // To obtain the type info of myObj
        TypeInfo typeObj = myObj.GetType().GetTypeInfo();

        // Print all properties
        Console.WriteLine(typeObj.Name + " Properties:");
        foreach (PropertyInfo p in typeObj.GetProperties())
        {
            Console.WriteLine(p.Name);
        }

        // Print all methods
        Console.WriteLine(typeObj.Name + " Methods:");
        foreach (MethodInfo m in typeObj.GetMethods())
        {
            Console.WriteLine(m.Name);
        }
    }
}
