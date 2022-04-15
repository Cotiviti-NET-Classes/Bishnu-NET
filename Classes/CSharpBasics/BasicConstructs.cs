using System;

namespace LearningBasics;
class Basic
{
    void LearnBasics()
    {
        // Numbers: Integers and Floating point

        byte a = 239;
        // 8 bits, 1 bit sign bit (MSB)
        short b = -32423;
        ushort bb = 2342;

        int c = 234242234;
        uint cc = 234242234;

        long d = 3242424242424;
        ulong dd = 3242424242424;

        float e = 23423.455676767677897987f;
        double f = 323424.3423423342423334546;
        decimal g = 32423.4535353453423424242223552m;

        bool h = true;

        char i = 'r';
        string j = "sdfs";
        object o = "453";

        // Nullabel types
        int? population = null;

        // use of var
        var name = "Bishnu";
        // Arrays

        // One dimensional
        float[] points = new float[10];
        float[] pointss = { 2.3f, 4.5f };

        // Multi dimensional
        string[,] names = new string[2, 3];

        // Jagged array
        int[][] ages = new int[3][];
        ages[0] = new int[4];
        ages[1] = new int[2];
        ages[2] = new int[6];

        // Branching
        bool isValid = 5 == 5;
        bool isValid1 = 4 == 5;

        if (isValid)
        {
            Console.Write("");
        }
        else if (isValid1)
        {
            Console.Write("");
            Console.Write("");
        }
        else
        {

        }

        var s = 'r';
        switch (s)
        {
            case 'A':

                break;
            case 'B':

                break;

            default:

                break;
        }

        // Loops
        for(byte loopVariable = 5; i < 15; loopVariable++)
        {
            Console.WriteLine(loopVariable);
        }

        while(5 == 4)
        {
            Console.Write("");
        }

        foreach(var p in points)
        {
            Console.WriteLine(p);
        }

        // Operators
        var val1 = isValid ? "Y" : "X";
        var val2 = name ?? "Hari";  //Null Coalescing
        var val3 = name?.Length;    //Null propagation operator
        var val4 = name!;           //Null supressing/forgiving
    }
}
