using System;
using System.Text;

namespace Builder {
    class program{
        static void Main(String[]args){
            int jumpCount = 10;
            string[] animals = {"goats","cats","pigs"};

            // create a StringBuilder 
            StringBuilder sb = new StringBuilder("Initial String.", 200);

            //To Print some basic stats about Stringbuilder
           Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

           // Add some Strings to the builder using append
           sb.Append("The quick brown fox ");
           sb.Append("jumped over the lazy dog.");


           //AppendLine can append a line ending
           sb.AppendLine();


           // AppendFormat can be used to append formatted strings
           sb.AppendFormat("He did this {0} times.",jumpCount);
                  sb.AppendLine();

        
           // Appendjoin can iterate over a set of values
           sb.Append("He also jumped over ");
           sb.AppendJoin(',', animals);

           // Modify the content at any index
           sb.Replace("Fox","cat");

           // Insert content at any index
           sb.Insert(0,"This is the ");

           // Convert to a single string
      Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");
      Console.WriteLine(sb.ToString());

 
        }
    }
}
