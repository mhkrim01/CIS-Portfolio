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

namespace LibraryItems
{
    class CopyrightYearDescending : Comparer<LibraryItem>
    {
        // Precondition:  None
        // Postcondition: sorts by copyright year in descending order
        //                When item1 < item2, method returns positive #
        //                When item1 == item2, method returns zero
        //                When item1 > item2, method returns negative #
        public override int Compare(LibraryItem item1, LibraryItem item2)
        {
            if (item1 == null && item2 == null)
                return 0;

            if (item1 == null)
                return -1;

            if (item2 == null)
                return 1;

            return -1*item1.CopyrightYear.CompareTo(item2.CopyrightYear);
        }
    }
}
