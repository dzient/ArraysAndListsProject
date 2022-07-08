using System;
using System.Collections;
using System.Collections.Generic;

//-----------------------------------------------------------------
//ArraysAndLists
//
// Name: David Zientara
// Date: 7-8-2022
// Comments: An exercise in arrays and lists
// Added methods per the instructions
//-----------------------------------------------------------------

namespace ArraysAndLists
{
    class Program
    {
        //PopulateListwithOddsandEvens 
        //Given two empty lists, iterate from 1 to 10;
        //add the odd #s to one list and add even #s to 
        //another list
        //PARAMS: odds, evens (Lists of integers)
        //RETURNS: Nothing
        static void PopulateListwithOddsandEvens(List<int> odds, List<int> evens)
        {
            int i;
            //Declare a const
            const int MAX = 10;
            //Populate the lists
            for (i = 0; i <= MAX; i += 2)
                evens.Add(i);
            for (i = 1; i <= MAX; i += 2)
                odds.Add(i);

        }
        //CheckIfOdddorEven
        //Given a populated list and two empty list, iterate through the list
        //add the odd #s to one list and add even #s to another list
        //PARAMS: origlist, odd, even (lists of integers)
        //RETURNS: Nothing
        static void CheckIfOddorEven(List<int> origlist, List<int> odds, List<int> evens)
        {
            //Iterate through list, populating the other lists
            foreach (int i in origlist)
            {
                if ((i % 2) == 0)
                    evens.Add(i);
                else
                    odds.Add(i);
            }
        }
        //DisplayList
        //Given two lists, display the lists, one for odd
        //and one for even, display them
        //PARAMS: odds, evens (Lists of integers)
        //RETURNS: Nothing
        static void DisplayList(List<int> odds, List<int> evens)
        {
            //Write the header
            Console.WriteLine("Odds\tEvens");
            Console.WriteLine("=======================");
            //Get the maximum list length
            int len = odds.Count; 
            if (evens.Count > len) 
                len = evens.Count; 
            for (int i = 0; i < len; i++)
            {
                // If i is less than odd and even list length, print both
                //else print only odd or even
                if (i < odds.Count && i < evens.Count)
                    Console.WriteLine($"{odds[i]}\t{evens[i]}");
                else if (i < odds.Count)
                    Console.WriteLine($"{odds[i]}\t");
                else if (i < evens.Count)
                    Console.WriteLine($"\t{evens[i]}");
            }
            
        }
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> odds = new List<int>();
            List<int> evens = new List<int>();
            PopulateListwithOddsandEvens(odds,evens);
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            List<int> odds2 = new List<int>();
            List<int> evens2 = new List<int>();
            List<int> origlist = new List<int>();
            Random rnd = new Random();
            int s1 = rnd.Next(10,25);
            for (int i = 0; i < s1; i++)
                origlist.Add(rnd.Next(1000));
            CheckIfOddorEven(origlist, odds2, evens2);

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            DisplayList(odds2, evens2);
        }
    }
}
