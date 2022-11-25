using System;

namespace StringInterplation{
    class Program{
        static void Main(String[] args){
            int a=100;
             float b = 250.0f;
            string c = "csharp";

            Console.WriteLine("The values are {0},{1},{2}",a, b, c);

            Console.WriteLine($"The values are {a},{b},{c}");
             Console.WriteLine($"(a+b)/b is {(a+b)/b }");
             Console.WriteLine($"{c} in upper case is {c.ToUpper()}");
             DateTime now = DateTime.Now;
             Console.WriteLine($"Today is {now}");
            
        }
    }
}