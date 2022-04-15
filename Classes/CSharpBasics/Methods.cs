
using System;

namespace LearningBasics;
class MethodLearner
{
    void DoSomething()
    {
        Console.WriteLine("Doing something...");
    }

    string GetName()
    {
        Add(4, 5);
        Add(c: 6, a: 4,b: 5);   // Named arguments

        AddMulti(2, 3, 4, 5, 6, 7, 8, 6, 3);
        return GetName1();
    }

    string GetName1() => "Bishnu";
    (string name1, string name2) GetNames() => ("Bishnu", "Hari");

    int Add(int a, int b, int c = 0) => a + b + c;          //Optional parameters
    int AddMulti(params int[] values) => values.Length;     // Multiple parameters

}