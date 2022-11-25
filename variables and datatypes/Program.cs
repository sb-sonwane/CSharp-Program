using System;
namespace VarandData
{
    class Program{
        static void Main(String[] args){
            int i=10;
            float f=2.0f;
            decimal d=10.0m;
            bool b=true;
            char c= 'c';

            String str="A String";

            var x=10;
            var y= "Hello";

            

            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}",i,f,d,b,c,str,x,y);

            long bignum;
            bignum=i;
             float i_to_f=(float)i;
             Console.WriteLine("{0}",i_to_f);
             int f_to_i=(int)f;
             Console.WriteLine("{0}",f_to_i);

        }
    }
}