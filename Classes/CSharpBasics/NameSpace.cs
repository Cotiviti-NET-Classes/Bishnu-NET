using System;
using XYZ;
class A
{
    Person p = new();

    void Test()
    {
        //p.IsLivingBeing3 = false;
        var x = Person.IsLivingBeing1;
        Person.SayHello();

        p.Name = "";
        Console.Write(p.Name);
    }
}