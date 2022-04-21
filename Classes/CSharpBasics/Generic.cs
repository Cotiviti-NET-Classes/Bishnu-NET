using System;

class Generic
{
    public void Sum<T>(T a, T b)
    {
        Console.Write(a.ToString());
    }
}