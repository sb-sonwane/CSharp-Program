using System;
namespace breakContinue{
    class Program{
        static void Main(string[]args){
            int[] values= {15,7,12,23,41,9,17,36};
            
            Console.WriteLine("Using Break and Continue :");
            foreach(int val in values){
                
                //Continue statement skips the rest of the loops entierly
                //and jump to the next iteration(if there is one)
                 
                  Console.WriteLine($"val Currently {val}");
                if(val>=20&&val<=29){
                    continue;
                }

                //break statement stop the loop and exist
               
               Console.WriteLine($"val Currently {val}");
                 if(val>=40){
                    break;
                 }
            }
        }
    }
}

