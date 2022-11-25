using System;
namespace StringOperation
{
    class Program{
        static void Main(string[]args){
        string outstr;
        string str1 = "The quick brown fox jumps over the lazy god.";
        string str2 = "This is a string.";
        string str3 = "THIS is a STRING";
        string[]str = {"one","two","three","four"};

        //Length of the string
        Console.WriteLine(str1.Length);

        //Indiviual character
        Console.WriteLine(str1[14]);

        foreach(char ch in str1){
            Console.Write(ch);
            if(ch=='b'){
                Console.WriteLine();
                break;
            }
        }
        // //String Concatention
        outstr = String.Concat(str);
        Console.WriteLine(outstr);

        // //joining the string 
         outstr=String.Join('.',str);
        Console.WriteLine(outstr);

        outstr = String.Join("---",str);
        Console.WriteLine(outstr);


        //String Comparison
        //compare will perform an ordinal comparison and return;
        //<0:first and second strings are same position in sort order
        //0:first and second strings are sanme Position in sort order
        //>0;first string comes after the second in sort order

         int result = String.Compare(str2,"This is a string");
        //Console.WriteLine()
         //Equals just returns a regular Boolean
          bool isEqual = str2.Equals(str3);
            Console.WriteLine(isEqual);

            //string searching
              Console.WriteLine(str1.IndexOf('e'));
              Console.WriteLine(str1.IndexOf("fox"));

              Console.WriteLine(str1.LastIndexOf('e'));
              Console.WriteLine(str1.IndexOf("the"));

              outstr = str1.Replace("fox","cat");
              Console.WriteLine(outstr);
              Console.WriteLine(str1.IndexOf("fox"));

    }
  }
}