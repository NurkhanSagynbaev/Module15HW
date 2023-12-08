// Задача 2
using System;

class MyClass
{
    public int MyProperty1 { get; set; }
    public string MyProperty2 { get; set; }
}

class Program2
{
    static void Main()
    {
        MyClass myObject = new MyClass
        {
            MyProperty1 = 42,
            MyProperty2 = "Hello, Reflection!"
        };

        Type myType = myObject.GetType();
        var properties = myType.GetProperties();

        Console.WriteLine("Свойства и их значения:");
        foreach (var property in properties)
        {
            object value = property.GetValue(myObject);
            Console.WriteLine($"{property.Name}: {value}");
        }
    }
}
