//Program 3
//CIS 200-01
//Due Date: 4/5/2018
//Grading ID: Z8856
// This form allows user to choose a book they wish to edit, refer to main form for more information
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class EditBookSelectionForm : Form
    {
        private List<LibraryItem> _items; //item list
        private List<int> bookIndices; // index of books

        // Precondition:  the form is passed a list of library items
        // Postcondition: The form's GUI is prepared for display. Item lists and indice lists are made

        public EditBookSelectionForm(List<LibraryItem> itemList)
        {
            InitializeComponent();

            _items = itemList;
            bookIndices = new List<int>(); // list to keep track of library item objects that are library books
        }

        internal int SelectedBookIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected item combo box has been returned
            get
            {
                return bookIndices[bookComboBox.SelectedIndex];
            }
        }

        // Precondition: user clicked ok button and made selection
        // Postcondition: if user made selection, selected index is passed on and dialog box is closed
        private void OK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Precondition: trying to change focus from combobox selection or press okay preemptively
        // Postcondition: if user did not make a selection an error provider will appear
        private void bookComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (bookComboBox.SelectedIndex < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(bookComboBox, "Choose an item");
            }
        }

        // Precondition: if validating succeeded
        // Postcondition: errorprovider is cleared and user can press ok
        private void bookComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(bookComboBox, "");
        }

        // Precondition: user clicked on cancel button
        // Postcondition: dialog result set to cancel, dialog box will be cancelled
        private void cnclBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }

        // Precondition: form is initialized
        // Postcondition: form is loaded with book items
        private void EditBookSelectionForm_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < _items.Count; ++i)
            {
                if (_items[i] is LibraryBook)
                {
                    bookComboBox.Items.Add($"{_items[i].Title},{_items[i].CallNumber}");
                    bookIndices.Add(i);
                }
            }
        }
    }
}
