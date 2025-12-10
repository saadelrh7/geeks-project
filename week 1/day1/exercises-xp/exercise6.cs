using System;

class Exercise6
{
    public static void Run()
    {
        SayHello("Saad");
        SayHello("Riad");
        SayHello("Haitam");
    }

    private static void SayHello(string name)
    {
        Console.WriteLine(name);
    }
}