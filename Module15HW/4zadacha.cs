// Задача 4
using System;
using System.Collections.Generic;
using System.Reflection;

class Program4
{
    static void Main()
    {
        Type listType = typeof(List<>);
        ConstructorInfo[] constructors = listType.GetConstructors();

        Console.WriteLine("Конструкторы класса List<T>:");
        foreach (ConstructorInfo constructor in constructors)
        {
            Console.WriteLine(constructor);
        }
    }
}
