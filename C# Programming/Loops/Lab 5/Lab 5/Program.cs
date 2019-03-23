//Grade ID: A8284
//Lab5
//Due Date: October 22, 2017
//Lab that explores the use of loops and nested loops to display various shapes
//composed of spaces and stars(*).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_ROWS = 10;// represents the maximum number of rows/height of triangle
            const int MIN_ROWS = 1; // represents the minimum number of rows used in space calculation
            int space; //loop control variable for loop that determines number of spaces

            WriteLine("Pattern A");
            WriteLine("");

            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int star = 1; star <= row; star++)//loop control variable that determines number of stars
                                                       //row variable represents the number of rows in triangle shapes
                    Write("*");
                WriteLine();
            }
            WriteLine("");
            WriteLine("Pattern B");
            WriteLine("");
            for (int row = 10; row >= MIN_ROWS ; row--)
            {
                for (int star = 1; star <= row; star++)
                    Write("*");
                WriteLine();
            }
            WriteLine("");
            WriteLine("Pattern C");
            WriteLine("");
            for (int row = MAX_ROWS; row >= MIN_ROWS; row--)
            {
                for (space = 0; space < MAX_ROWS - row ; space++)
                    Write(" ");
                for (int star = 1; star <= row; star++)
                    Write("*");
                WriteLine();   
            }
            WriteLine("");
            WriteLine("Pattern D");
            WriteLine("");
            for (int row = MIN_ROWS; row <= MAX_ROWS; row++)
            {
                for (space = 1; space <= MAX_ROWS - row; space++)
                    Write(" ");
                for (int star = 1; star <= row; star++)
                    Write("*");
                WriteLine();
            }

        }
    }
}
