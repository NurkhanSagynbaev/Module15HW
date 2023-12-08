// Задача 1
using System;
using System.Reflection;

class Program1
{
    static void Main()
    {
        Type consoleType = typeof(Console);
        MethodInfo[] methods = consoleType.GetMethods();

        Console.WriteLine("Методы класса Console:");
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}
