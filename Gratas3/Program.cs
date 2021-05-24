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

            List<double> numberlist = new List<double>();           // all randomly generated numbers are listed here
            double num;                                             // will be assigned to a random value between 0.0 and 1.0
            List<double> roundlist = new List<double>();            // to find and update item in decimallist using the same index value 
            List<double> decimallist = new List<double>();          // list of repeated decimals with same whole-number part
            List<double> largestFractions = new List<double>();     // list of values to show as output
            List<double> roundForPairs = new List<double>();        // to find and update item in largestFraction using the same index value 
            int matchcount = 0;

            for (int i = 0; i < n; i++)
            {
                double sayi = random.NextDouble();

                num = 10 * sayi;

                numberlist.Add(num);
                
                if (roundlist.Contains(Math.Floor(numberlist[i]))) //bu if içine düşen her sayı tekrar etmiştir.dolayısıyla büyük olanı decimal liste yazılmalı
                {
                    matchcount++;
                    Console.WriteLine("Toplamda "+matchcount+" eşleşme var");
                    //int index = i;
                    //Console.WriteLine(numberlist.IndexOf(Math.Floor(numberlist[i])));
                    int matchindex = roundlist.IndexOf(Math.Floor(numberlist[i]));

                    if (decimallist[matchindex]<numberlist[i])
                    {
                        decimallist[matchindex] = numberlist[i];/// burada olması ne kadar doğru? incelenmeli...//bu değer largestFraction'a yazılmalı..
                        if (!roundForPairs.Contains(Math.Floor(decimallist[matchindex])))//!largestFractions.Contains(decimallist[matchindex]))
                        {
                            if (!largestFractions.Contains(decimallist[matchindex]))//sorun burada!!!!
                            {
                                largestFractions.Add(decimallist[matchindex]); // burada tekrardan ekleme hatalı olabilir !!!
                                roundForPairs.Add(Math.Floor(decimallist[matchindex])); // this will help to eliminate recurrence of the same whole-number part in largestFractions
                            }


                            //if (!roundForPairs.Contains(Math.Floor(decimallist[matchindex])))
                            //{
                            //    largestFractions.Add(decimallist[matchindex]);
                            //    roundForPairs.Add(Math.Round(decimallist[matchindex])); // this will help to eliminate recurrence of the same whole-number part in largestFractions
                            //}
                            //else
                            //{
                            //    //smaller value with the same whole-number part is overwrited by decimallist[matchindex]
                            //    largestFractions[roundForPairs.IndexOf(Math.Floor(decimallist[matchindex]))] = decimallist[matchindex];
                            //}
                            
                        }
                        else // roundforPairs contains floor decimallist(index)
                        {

                            //largestFractions[largestFractions.IndexOf(largestFractions.FirstOrDefault(check => check.Equals(roundlist[matchindex])))] = decimallist[matchindex];
                            //largestFractions[largestFractions.IndexOf(largestFractions.Where(x => Math.Floor(x.CompareTo(roundlist[matchindex]))))] = decimallist[matchindex];

                            //smaller value with the same whole-number part is overwrited by decimallist[matchindex]
                            largestFractions[roundForPairs.IndexOf(Math.Floor(decimallist[matchindex]))] = decimallist[matchindex];
                            
                            
                            //yeni gelen random sayı eldekinden büyük olduğundalargestFraction daki ilgili index güncellenmeli..OK
                        }
                        
                    }
                    else//gelen sayı eldekinden küçükse, eldeki büyük olan alınmalı
                    {
                        if (!largestFractions.Contains(decimallist[matchindex]))//eldeki sayı listeye eklenmemişse ekle
                        {
                            largestFractions.Add(decimallist[matchindex]);
                            roundForPairs.Add(Math.Floor(decimallist[matchindex])); // this will help to eliminate recurrence of the same whole-number part in largestFractions
                        }
                        

                        //if (!roundForPairs.Contains(Math.Floor(decimallist[matchindex])))//!largestFractions.Contains(decimallist[matchindex]))
                        //{
                        //    //Do nothing?

                        //    //roundForPairs.Add(Math.Floor(decimallist[matchindex]));

                      

                        //}
                        //else//içeriyor
                        //{
                            
                        //    if (!largestFractions.Contains(numberlist[i]))//decimallist[matchindex]))
                        //    {
                        //        largestFractions.Add(decimallist[matchindex]);
                        //        roundForPairs.Add(Math.Round(decimallist[matchindex])); // this will help to eliminate recurrence of the same whole-number part in largestFractions
                        //    }


                        //    //if (!roundForPairs.Contains(Math.Floor(decimallist[matchindex])))
                        //    //{
                        //    //    largestFractions.Add(decimallist[matchindex]);
                        //    //    roundForPairs.Add(Math.Round(decimallist[matchindex])); // this will help to eliminate recurrence of the same whole-number part in largestFractions
                        //    //}
                        //}
                    }

                }
                else
                {
                    
                    Console.WriteLine("eşleşme yok, roundlist ve decimallist'e değerler eklendi.");
                    roundlist.Add(Math.Floor(numberlist[i]));
                    decimallist.Add(numberlist[i]);
                    

                }

                //Console.WriteLine(numberlist[i]);
                //Console.WriteLine(esassayi);
            }


            Console.WriteLine(matchcount + "toplam eşleşme");
            Console.WriteLine("/////LargestFractions/////");
            foreach (var item in largestFractions)
            {

                Console.WriteLine(item);

            }
            Console.WriteLine("/////numberlist/////");

            foreach (var item in numberlist)
            {

                Console.WriteLine(item);

            }

            Console.WriteLine("/////decimallist/////");
            foreach (var item in decimallist)
            {

                Console.WriteLine(item);

            }
            Console.WriteLine("/////roundlist/////");
            foreach (var item in roundlist)
            {

                Console.WriteLine(item);

            }
            Console.WriteLine("/////roundForPairs/////");
            foreach (var item in roundForPairs)
            {

                Console.WriteLine(item);

            }



        }
    }
}
