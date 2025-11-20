using System;

class Program
{
    static void Main(string[] args)
    {
    
        GreetUser("User");
    }

    static void GreetUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
    
}