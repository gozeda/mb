using System;

class HelloWorld
{
    static void Main()
    {
#if DebugConfig
        Console.WriteLine("WE ARE IN THE DEBUG CONFIGURATION NOW");
#endif

        Console.WriteLine("Hello, world!");
    }
}