// Program 3
// CIS 200-01
// Due: 4/5/2018
// By: Z8856

// This program saves and opens a library object to and from a file using a binary formatter and object serialization
// Also, it allows for choosing either a library book object and patron object to edit, and allows for editing

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace LibraryItems
{
    public partial class Prog2Form : Form
    {
        private Library _lib; // The library
        private BinaryFormatter formatter = new BinaryFormatter(); // object for serializing library
        private FileStream libraryFile; // stream for writing to file


        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display.
        public Prog2Form()
        {
            InitializeComponent();

            _lib = new Library(); // Create the library


        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // NewLine shortcut

            MessageBox.Show($"Program 3{NL}By: Z8856{NL}CIS 200-01{NL}Spring 2018",
                "Program 3 allows a user to save and open to and from a file" +
                " using object serialization and a binary formatter. It also" +
                " allows for a user to choose a book or patron they wish to edit " +
                "and edit their data.");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Report, Patron List menu item activated
        // Postcondition: The list of patrons is displayed in the reportTxt
        //                text box
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryPatron> patrons;                // List of patrons
            string NL = Environment.NewLine;            // NewLine shortcut

            patrons = _lib.GetPatronsList();

            result.Append($"Patron List - {patrons.Count} patrons{NL}{NL}");

            foreach (LibraryPatron p in patrons)
                result.Append($"{p}{NL}{NL}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Item List menu item activated
        // Postcondition: The list of items is displayed in the reportTxt
        //                text box
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryItem> items;                    // List of library items
            string NL = Environment.NewLine;            // NewLine shortcut

            items = _lib.GetItemsList();

            result.Append($"Item List - {items.Count} items{NL}{NL}");

            foreach (LibraryItem item in items)
                result.Append($"{item}{NL}{NL}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Checked Out Items menu item activated
        // Postcondition: The list of checked out items is displayed in the
        //                reportTxt text box
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryItem> items;                    // List of library items
            string NL = Environment.NewLine;            // NewLine shortcut

            items = _lib.GetItemsList();

            // LINQ: selects checked out items
            var checkedOutItems =
                from item in items
                where item.IsCheckedOut()
                select item;

            result.Append($"Checked Out Items - {checkedOutItems.Count()} items{NL}{NL}");

            foreach (LibraryItem item in checkedOutItems)
                result.Append($"{item}{NL}{NL}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Insert, Patron menu item activated
        // Postcondition: The Patron dialog box is displayed. If data entered
        //                are OK, a LibraryPatron is created and added to the library
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronForm patronForm = new PatronForm(); // The patron dialog box form

            DialogResult result = patronForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                // Use form's properties to get patron info to send to library
                _lib.AddPatron(patronForm.PatronName, patronForm.PatronID);
            }

            patronForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Insert, Book menu item activated
        // Postcondition: The Book dialog box is displayed. If data entered
        //                are OK, a LibraryBook is created and added to the library
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(); // The book dialog box form

            DialogResult result = bookForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    // Use form's properties to get book info to send to library
                    _lib.AddLibraryBook(bookForm.ItemTitle, bookForm.ItemPublisher, int.Parse(bookForm.ItemCopyrightYear),
                        int.Parse(bookForm.ItemLoanPeriod), bookForm.ItemCallNumber, bookForm.BookAuthor);
                }

                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Book Validation!", "Validation Error");
                }
            }

            bookForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Item, Check Out menu item activated
        // Postcondition: The Checkout dialog box is displayed. If data entered
        //                are OK, an item is checked out from the library by a patron
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;     // List of library items
            List<LibraryPatron> patrons; // List of patrons

            items = _lib.GetItemsList();
            patrons = _lib.GetPatronsList();

            if (((items.Count - _lib.GetCheckedOutCount()) == 0) || (patrons.Count() == 0)) // Must have items and patrons
                MessageBox.Show("Must have items and patrons to check out!", "Check Out Error");
            else
            {
                CheckoutForm checkoutForm = new CheckoutForm(items, patrons); // The check out dialog box form

                DialogResult result = checkoutForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    _lib.CheckOut(checkoutForm.ItemIndex, checkoutForm.PatronIndex);
                }

                checkoutForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition:  Item, Return menu item activated
        // Postcondition: The Return dialog box is displayed. If data entered
        //                are OK, an item is returned to the library
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;     // List of library items

            items = _lib.GetItemsList();

            if ((_lib.GetCheckedOutCount() == 0) ) // Must have items to return
                MessageBox.Show("Must have items to return!", "Return Error");
            else
            {
                ReturnForm returnForm = new ReturnForm(items); // The return dialog box form

                DialogResult result = returnForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    _lib.ReturnToShelf(returnForm.ItemIndex);
                }

                returnForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition: none
        // Postcondition: library object is serialized and saved to a file
        private void saveLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result; // result of dialog box
            string fileName; // file name

            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false;

                result = fileChooser.ShowDialog(); // show save file dialog box
                fileName = fileChooser.FileName; // file to save to
            }

                if(string.IsNullOrEmpty(fileName)) // is file name empty?
                {
                    MessageBox.Show("Invalid file name");
                }
                else
                {
                    try
                    {
                        libraryFile = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite); // file stream
                        formatter.Serialize(libraryFile, _lib); // serialization magic
                    } // exceptions to catch
                    catch (ArgumentNullException)
                    {
                        MessageBox.Show("Choose a file or create a valid file name");
                    }
                    catch (SerializationException)
                    {
                        MessageBox.Show("Error writing to file");
                    }

                    catch (IOException)
                    {
                        MessageBox.Show("Error saving file, check your devices");
                    }
                    finally
                    {
                        libraryFile?.Close(); // closing file stream after everything from library is saved
                    }
                }
        }

        // Precondition: have a file to choose from, serialization succeeded
        // Postcondition: file with library object is opened and able to be accessed
        private void openLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result; // result for dialog box
            string fileName; // file name

            using (OpenFileDialog fileChooser = new OpenFileDialog()) 
            {
                result = fileChooser.ShowDialog(); // show open file dialog box
                fileName = fileChooser.FileName; // file name equals chosen file name
            }

            if (string.IsNullOrEmpty(fileName)) // did they pick a file?
            {
                MessageBox.Show("Invalid file name. Choose valid file.");
            }
            else
            {
                try
                {
                    libraryFile = new FileStream(fileName, FileMode.Open, FileAccess.Read); // filestream
                    _lib = (Library) formatter.Deserialize(libraryFile); // deserializing binary data
                }
                catch (IOException)
                {
                    MessageBox.Show("There was an IO Exception, check your devices");
                }
                catch //general catch to catch any potential exceptions
                {
                    MessageBox.Show("There was an error somewhere");
                }
                finally
                {
                    libraryFile?.Close(); // close file stream
                }
            }
        }

        // Precondition: clicked on edit patron on menu
        // Postcondition: dialog box will appear to choose patron that is going to be edited
        //                user will make selection, then patron form will appear that is populated
        //                with patron data that is to be edited
        private void patronToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PatronSelectionForm editPatronForm = new PatronSelectionForm(_lib.GetPatronsList()); // form to choose patron
            DialogResult result = editPatronForm.ShowDialog(); // result from patron selection form
            int patronIndex; // selected patron index

            if(result == DialogResult.OK) // did they click ok?
            {
                patronIndex = editPatronForm.SelectedPatronIndex;
                LibraryPatron patron = _lib._patrons[patronIndex]; // selected library patron
                PatronForm patronForm = new PatronForm(); // patron form to edit data with

                // passing object data to form
                patronForm.PatronID = patron.PatronID;
                patronForm.PatronName = patron.PatronName;

                DialogResult result2 = patronForm.ShowDialog(); // patron form with data loaded into it
                if(result2 == DialogResult.OK) // did they click ok?
                {
                    // get edited data from form and update object data
                    patron.PatronID = patronForm.PatronID;
                    patron.PatronName = patronForm.PatronName;
                }
            }
        }

        // Precondition: clicked on edit book item on menu
        // Postcondition: dialog box will appear to choose item that is going to be edited
        //                user will make selection, then book form will appear that is populated 
        //                with book data that will be edited
        private void itemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditBookSelectionForm editBookForm = new EditBookSelectionForm(_lib.GetItemsList()); // form to choose book that is going to be edited
            DialogResult result = editBookForm.ShowDialog(); // result from edit book form
            int bookIndex; // selected book index

            if (result == DialogResult.OK)
            {
                LibraryBook book;
                bookIndex = editBookForm.SelectedBookIndex; // selected index
                book = (LibraryBook) _lib._items[bookIndex];
                BookForm bookForm = new BookForm(); // book form to edit book object

                // passing book object data to book form
                bookForm.BookAuthor = book.Author;
                bookForm.ItemCallNumber = book.CallNumber;
                bookForm.ItemCopyrightYear = book.CopyrightYear.ToString();
                bookForm.ItemLoanPeriod = book.LoanPeriod.ToString();
                bookForm.ItemPublisher = book.Publisher;
                bookForm.ItemTitle = book.Title;


                DialogResult result2 = bookForm.ShowDialog(); // show book form
                if(result2 == DialogResult.OK) // result ok? then the book now has edited values
                {
                    //get data back from form and update book object
                    book.Author = bookForm.BookAuthor;
                    book.CallNumber = bookForm.ItemCallNumber;
                    book.Title = bookForm.ItemTitle;
                    book.Publisher = bookForm.ItemPublisher;
                    book.CopyrightYear = int.Parse(bookForm.ItemCopyrightYear);
                    book.LoanPeriod = int.Parse(bookForm.ItemLoanPeriod);
                }

            }
        }
    }
}
