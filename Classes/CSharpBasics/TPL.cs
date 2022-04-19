using System;
using System.Threading;
using System.Threading.Tasks;

public class TPL
{
    string[] names = { "Bishnu", "Nabin", "Ganesh", "Lalit", "Hari" };

    public void Do()
    {        
        Console.WriteLine("Sequential Loop:");
        foreach(var name in names)
        {            
            Thread.Sleep(1000);
            Console.WriteLine($"{name} has {name.Length} characters.");
        }
            
        Console.WriteLine("Parallel Loop:");
        Parallel.ForEach(names, 
            (name) => {
                Thread.Sleep(1000);
                Console.WriteLine($"{name} has {name.Length} characters.");
            });
    }
}
