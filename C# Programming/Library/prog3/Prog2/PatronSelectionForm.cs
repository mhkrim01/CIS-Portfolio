// Program 3
// CIS 200-01
// Due Date: 4/5/2018
// Grading ID: Z8856
// This form allows a user to choose a patron they wish to edit, refer to main form for more information
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
    public partial class PatronSelectionForm : Form
    {
        private List<LibraryPatron> _patrons; // patron list

        internal int SelectedPatronIndex
        {
            // Precondition: none
            // Postconditon: selected index is returned
            get { return patronComboBox.SelectedIndex; }

            // Precondition: user made valid selectiion
            // Postcondition: selected index is set to value
            set { patronComboBox.SelectedIndex = value; }
        }

        // Precondition:  form is passed a list of patrons
        // Postcondition: The form's GUI is prepared for display. Patron list is filled with patron data
        public PatronSelectionForm(List<LibraryPatron> patronList)
        {
            InitializeComponent();

            _patrons = patronList;
        }

        // Precondition: form is initialized
        // Postcondition: combo box is loaded with patrons
        private void PatronSelectionForm_Load(object sender, EventArgs e)
        {
            foreach (LibraryPatron patron in _patrons)
                patronComboBox.Items.Add($"{patron.PatronName}, {patron.PatronID}");
        }

        // Precondition:  Focus is shifting from patron combo box
        // Postcondition: If selection is invalid, focus remains and error provider
        //                highlights the field
        private void patronComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (patronComboBox.SelectedIndex == -1) // Nothing selected
            {
                e.Cancel = true;
                errorProvider1.SetError(patronComboBox, "Must select Patron");
            }
        }

        // Precondition:  Validating of patron combo box not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void patronComboBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(patronComboBox, "");
        }

        // Precondition: user clicked ok button
        // Postcondition: dialog result is set to ok and form is dismissed
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        // Precondition: user clicked cancel button
        // Postcondition: dialog result is set to cancel and form is dismissed
        private void cnclBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
