using System.Collections.Generic;
using XYZ;

class Collections
{
    List<string> a = new();
    Stack<string> b = new();
    Queue<double> c = new();
    Dictionary<string, int> d = new();
    HashSet<Person> people =  new(); 

    void Learn()
    {        
        a.Add("sdfsf");
        a.Remove("sdfsf");

        b.Push("sdfsf");
        b.Pop();

        c.Enqueue(45.6);
        c.Dequeue();

        d.Add("a", 45);
        //d["a"] = 45;
        d.Add("b", 453);
        d.Remove("b");

    }
}