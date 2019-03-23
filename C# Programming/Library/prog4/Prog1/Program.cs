// Grading ID: Z8856
// CIS 200-01
// Due Date: Wednesday, April 14, 2018
// Program 4
// In this program we were tasked with implementing two interfaces, IComparable and IComparer
// to compare and sort a list of LibraryItem objects. Through the use of IComparables CompareTo
// and IComparer's Compare method, LibraryItems could be compared by their title, copyright year, 
// and even their type. They were sorted in ascending order by title, descending by copyright year,
// or in a multi level sort by object type and title.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryItems;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryItem hierarchy has been tested using LINQ, demonstrating polymorphism
    public static void Main(string[] args)
    {
        string NL = Environment.NewLine; // Newline shortcut

        List<LibraryItem> items = new List<LibraryItem>();       // List of library items


        // Test data - Magic numbers allowed here
        items.Add(new LibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
            "ZZ25 3G", "Andrew Wright"));
        items.Add(new LibraryBook("Harriet Pooter", "Stealer Books", 2000, 21,
            "AB73 ZF", "IP Thief"));
        items.Add(new LibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
            "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
            LibraryMovie.MPAARatings.PG));
        items.Add(new LibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
            "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G));
        items.Add(new LibraryMusic("C# - The Album", "UofL Music", 2014, 14,
            "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10));
        items.Add(new LibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
            "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12));
        items.Add(new LibraryJournal("Journal of C# Goodness", "UofL Journals", 2000, 14,
            "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright"));
        items.Add(new LibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
            "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams"));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            "MA53 9A", 16, 7));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            "MA53 9B", 16, 8));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            "MA53 9C", 16, 9));
        items.Add(new LibraryMagazine("     VB Magazine    ", "    UofL Mags   ", 2018, 14,
            "MA21 5V", 1, 1));

        Console.Out.WriteLine("Orginal list:");
        foreach (LibraryItem item in items)
            Console.WriteLine(item + NL);
        Pause();

        items.Sort(); // Sort - uses title
        Console.Out.WriteLine("Sorted list (by title):" + NL);
        foreach (LibraryItem item in items)
            Console.WriteLine(item.Title + NL);
        Pause();

        items.Sort(new CopyrightYearDescending()); // Sort - uses specified Comparer class

        Console.Out.WriteLine("Sorted list (by copyright year descending) using Comparer:" + NL);
        foreach (LibraryItem item in items)
            Console.WriteLine(item.CopyrightYear + NL + item.Title + NL);
        Pause();

        items.Sort(new AscendingClassTitle()); // Sort - uses specified Comparer class

        Console.Out.WriteLine("Sorted list (by object type then title natural order) using Comparer:" + NL);
        foreach (LibraryItem item in items)
            Console.WriteLine(item.GetType() + NL + item.Title + NL);
        Pause();

    }

    // Precondition:  None
    // Postcondition: Pauses program execution until user presses Enter and
    //                then clears the screen
    public static void Pause()
    {
        Console.WriteLine("Press Enter to Continue...");
        Console.ReadLine();

        Console.Clear(); // Clear screen
    }
}