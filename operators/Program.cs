using System;
namespace opretors{

    class Program{
        private const string V = "New String";
        private static string? hello;

        static void Main(String[] args){
            int x=10;
            int y=5;
            string a="Hii",b="TCsers";

            Console.WriteLine("--------Basic Math--------");
            Console.WriteLine((x/y)*x);
            Console.WriteLine(a+b);
            //To increment and Decrement
            x++;
            y--;
            Console.WriteLine(x);
             Console.WriteLine(y);

             //Short Key a=a+b;
             a+=b;
              Console.WriteLine(a);

              //Logocal operators && and ||
               Console.WriteLine(x>y && y>=4);
               Console.WriteLine(x>y || y>=5);

               string? str = hello;
               Console.WriteLine(str?? "Unknown sting");
               string ??= "New String";
                Console.WriteLine(str);


        }
    }
}
