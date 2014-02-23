using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Refer to the question on Game of Master Mind from 
// moderate section in Crack the coding interview. 
// Q 17.5
namespace GameOfMasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            string actual1 = "RGBY";
            string guess1 = "GGRR";

            Console.WriteLine("Test case 1");
            ComputeResult(guess1, actual1);

            string actual2 = "RGGB";
            string guess2 = "YRGB";

            Console.WriteLine("Test case 2");
            ComputeResult(guess2, actual2);
        }

        static void ComputeResult(string guess, string actual)
        {
           HashSet<char> hits = new HashSet<char>();
 
           HashSet<char> psuedoHits = new HashSet<char>();

           int numOfHits = 0;
           int numOfPsuedoHits = 0;

           for(int i = 0; i < guess.Length; i++)
           {
              if (guess[i] == actual[i])
              {
                  numOfHits++;
                  hits.Add(guess[i]);
              }
           }

           for(int i = 0; i < guess.Length; i++)
           {
               if (
                   (guess[i] != actual[i]) && 
                   (!hits.Contains(guess[i])) && 
                   actual.Contains(guess[i]) &&
                   (!psuedoHits.Contains(guess[i]))
                  )
               {
                   psuedoHits.Add(guess[i]);
                   numOfPsuedoHits++;
               }
           }

           Console.WriteLine("Number of hits are {0}", numOfHits);

           Console.WriteLine("Number of psuedo hits are {0}", numOfPsuedoHits); 
        }
    }
}
