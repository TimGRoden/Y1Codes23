using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W109___Lists
{
    internal class W109
    {
        static void Main(string[] args)
        {
        }
    }
}

/*
0.  Basics
        In main, create a list of integers called myList
        Use myList.Add to add 5 different integers
        Use a for loop to print out each number in the list
            Extension: Use a for loop to calculate the sum of all numbers in the list, and print this out
1.  List printer
        Create a procedure called printList, which should take as parameter a String list. It should use a For loop to print out the contents of the list, separated by commas. Test that your program works.

2.  Array to List and List to Array convertors
        Create a program which auto-initialises an integer array (choose some numbers to populate the array). 
        Then create an empty integer list and add all of the elements of the array to the list using a For loop. 
        Then print the contents of the list using your answer to question 1.
        Create a program which makes an Integer list. Add 5 elements to it. 
        Then create an Integer array of size 5. 
        Using a for loop, copy the values from the list into the array. 
        Then print the contents of the array using another For loop.

3.  Remove duplicates
        Create a new String list called names. 
        Using a conditional loop, repeatedly ask the user to enter a name. 
        Add this name to the list only if the list does not already contain that item. 
        Keep asking until the user enters “done”. 
        The program should then output the total number of unique names, along with the contents of the list itself.

4.  Split a string into a list
        Create a program which asks the user to enter a string of words with spaces in between. 
        Use the .Split() built-in function on the string variable to convert it into a String array, split by the ‘ ‘ character. 
        Then, use your code from 2.(a) to convert the data into a String list. Print out the list using your code from 1.

5.  List Difference
        Use your code from 4. to get two different string lists from user input. 
        Using .Remove(), modify the first list so that it contains all of the words that appear in the first list but do not appear 
        in the second list. Print the contents of diffList.

6.  List Addition
        Similar to question 5, except the resulting list should contain all of the items which are present in both input lists.
*/