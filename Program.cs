using System;


//  For Loops | C# | Tutorial 20

namespace CSharpExercises_20
{
    class Program
    {
        static void Main(string[] args)
        {

            //int i = 1;
            //// the loop gaurd 
            //while (i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            // the for loop does the same but in a cleaner way

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            for (int i = 0; i < luckyNumbers.Length; i++)
                //for (int i = 1; i <= 5; i++)
            {
                //Console.WriteLine(i);
                Console.WriteLine(luckyNumbers[i]);
            }



            Console.ReadLine();
        }
    }
}
