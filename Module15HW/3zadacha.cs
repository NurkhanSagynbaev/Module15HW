// Задача 3
using System;
using System.Reflection;

class Program3
{
    static void Main()
    {
        string myString = "Hello, Reflection!";
        Type stringType = typeof(string);
        MethodInfo substringMethod = stringType.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });

        object[] parameters = { 7, 5 }; // начальный индекс и длина подстроки
        object result = substringMethod.Invoke(myString, parameters);

        Console.WriteLine("Подстрока: " + result);
    }
}
