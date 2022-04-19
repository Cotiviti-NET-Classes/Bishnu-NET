using System;

namespace XYZ;
public class Person
{
    public Person()
    {
        IsLivingBeing3 = true;
    }

    // Properties
    public int Age { get; set; }

    public string Name { get; internal set; }

    private string Phone { get; set; }

    public char Gender { get; set; } = 'M';

    //Constants
    public const string IsLivingBeing1 = "sdfsf";
    public readonly bool IsLivingBeing3 = true;

    public static bool IsLivingBeing2 = true;

    public static void SayHello()
    {
        Console.Write("Hello!");
    }
}
