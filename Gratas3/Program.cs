//3)    Design an algorithm for the following problem:
//      You are given a random list of decimals between 0 and 10.
//      [ 3.2 ; 1.1 ; 2.8 ; 2.4 ; 1.4 ; 6.7 ; 3.0 ; 2.5 ; 1.1 ; 4.4 ……. ]
//      Your algorithm should print out each decimal with the largest fraction among decimals that has the same whole-number part.
//      Eg: [ 4.1 ; 4.6 ; 3.9 ; 4.0 ; 3.7 ; 2.1] should print[4.6 ; 3.9; 2.1]
//          a.Design an algorithm that runs at O(n).
//          b. (Bonus: Design a single C#/LINQ query that outputs the same result.)

using System;
using System.Collections.Generic;
//using System.Linq;

namespace Gratas3
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            Console.WriteLine("listenin boyutunu verin...");
            int n = int.Parse(Console.ReadLine());

            double num;                                             // will be assigned to a random value between 0.0 and 1.0

            List<double> numberlist = new List<double>();           // all randomly generated numbers are listed here
            List<double> roundlist = new List<double>();            // to find and update item in decimallist using the same index value 
            List<double> decimallist = new List<double>();          // list of repeated decimals with same whole-number part
            List<double> largestFractions = new List<double>();     // list of values to show as output
            List<double> roundForPairs = new List<double>();        // to find and update item in largestFraction using the same index value 
            //int matchcount = 0;                                   // self explanatory

            for (int i = 0; i < n; i++)
            {
                double numRatio = random.NextDouble();

                num = 10 * numRatio;

                numberlist.Add(num);
                
                if (roundlist.Contains(Math.Floor(numberlist[i]))) 
                {
                    //optional feature for counting matched items
                    //matchcount++;
                    //Console.WriteLine("Tekrarlananların sayısı: " + matchcount);
                    
                    int matchindex = roundlist.IndexOf(Math.Floor(numberlist[i]));

                    if (decimallist[matchindex]<numberlist[i])
                    {
                        decimallist[matchindex] = numberlist[i]; // numberlist[i], the bigger value, assigned as new decimallist[matchindex]
                        if (!roundForPairs.Contains(Math.Floor(decimallist[matchindex])))
                        {
                            if (!largestFractions.Contains(decimallist[matchindex]))
                            {
                                largestFractions.Add(decimallist[matchindex]); 
                                roundForPairs.Add(Math.Floor(decimallist[matchindex])); // this will help to eliminate recurrence of the same whole-number part in largestFractions
                            }
                        }

                        else // if roundforPairs contains that item, then fractional item in largestFractions list must be updated
                        {
                            //smaller value with the same whole-number part is overwrited by decimallist[matchindex]
                            largestFractions[roundForPairs.IndexOf(Math.Floor(decimallist[matchindex]))] = decimallist[matchindex];
                        }
                        
                    }
                    else    // decimallist[matchindex]>numberlist[i] for this case
                    {
                        if (!largestFractions.Contains(decimallist[matchindex]))    // Add item item if non-existent 
                        {
                            largestFractions.Add(decimallist[matchindex]);
                            roundForPairs.Add(Math.Floor(decimallist[matchindex])); // this will help to eliminate recurrence of the same whole-number part in largestFractions
                        }
                    }

                }
                else  //  No match => add values to roundlist and decimallist
                {
                    roundlist.Add(Math.Floor(numberlist[i]));
                    decimallist.Add(numberlist[i]);
                }
            }


            //Console.WriteLine("Toplam eşleşme: "+matchcount);
            Console.WriteLine("/////    LargestFractions    /////");
            foreach (var item in largestFractions)
            {
                Console.WriteLine(Math.Round(item,2));
            }
            
            //Console.WriteLine("/////    All generated numbers in numberlist     /////");
            //foreach (var item in numberlist)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("/////     decimallist     /////");
            //foreach (var item in decimallist)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("/////      roundlist       /////");
            //foreach (var item in roundlist)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("/////      roundForPairs      /////");
            //foreach (var item in roundForPairs)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
