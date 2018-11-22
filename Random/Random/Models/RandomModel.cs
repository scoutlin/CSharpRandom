using System;
using System.Collections.Generic;
using System.Text;

namespace Random.Models
{
    class RandomModel
    {
        private System.Random gRandom;
        private List<int> gRandomResulList;
        private string gOutputString;

        private int[] gIndexSortArray;
        private int[] gContendArray;
        private string gOutputString2;

        public void Test()
        {
            Console.WriteLine("Press Enter to Start");
            Console.ReadLine();

            gRandomResulList = new List<int>();
            gIndexSortArray = new int[100];
            gContendArray = new int[100];

            gRandom = new System.Random();

            for(int i = 0; i < 100; i++)
            {
                //Repeat
                int randomResult = gRandom.Next(0, 101);
                gRandomResulList.Add(randomResult);

                //No Repeat
                gIndexSortArray[i] = gRandom.Next();
                gContendArray[i] = i;
            }

            //Repeat
            Console.WriteLine("=============================== Repeat ===============================");
            gRandomResulList.Sort();

            foreach(var i in gRandomResulList)
            {
                gOutputString += i.ToString() + ", ";
            }
            
            Console.WriteLine(gOutputString);

            Console.WriteLine("\n");

            //No Repeat
            Console.WriteLine("=============================== No Repeat ===============================");
            Console.WriteLine("------------------------------- By Sequence -------------------------------");
            foreach (var i in gContendArray)
            {
                gOutputString2 += i.ToString() + ", ";
            }
            Console.WriteLine(gOutputString2);
            gOutputString2 = string.Empty;

            Console.WriteLine("------------------------------- By Random Order -------------------------------");
            Array.Sort(gIndexSortArray, gContendArray);
            foreach (var i in gContendArray)
            {
                gOutputString2 += i.ToString() + ", ";
            }
            
            Console.WriteLine(gOutputString2);

            Console.ReadLine();
        }
    }
}
