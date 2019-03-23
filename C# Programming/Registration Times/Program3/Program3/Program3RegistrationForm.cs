using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    public partial class Program3RegistrationForm : Form
    {
        public Program3RegistrationForm()
        {
            InitializeComponent();
        }

        private void regDateTimeButton_Click(object sender, EventArgs e)
        {
            string[] regDays = { "November 3", "November 6", "November 7", "November 8", "November 9", "November 10" };//registration days
            string[] upperRegTimes = { "10:00 AM", "11:30 AM", "2:00 PM", "4:00 PM", "8:30 AM" };//upperclassmen registration times to match
                                                                                                 //their letter ranges
            char[] upperClassFirstLetters = { 'A', 'E', 'J', 'P', 'T' };//upperclass first letter of last name
            char[] lowerClass = { 'A', 'C', 'E', 'G', 'J', 'M', 'P', 'R', 'T', 'W' };//letter ranges for fresh and sophs who register on earlier days
            string[] freshSophTimes = { "11:30 AM", "2:00 AM", "4:00 AM", "8:30 AM", "10:00 AM", "11:30 AM", "2:00 PM", "4:00 PM", "8:30 AM", "10:00 AM" };//times to match letter ranges for
                                                                                                                                                                //underclassmen who register on later days
            string lastNameStr;       // Entered last name
            char lastNameLetterCh;    // First letter of last name, as char
            string dateStr = "Error"; // Holds date of registration
            string timeStr = "Error"; // Holds time of registration
            bool isUpperClass;        // Upperclass or not?


            lastNameStr = lastNameInputTextBox.Text;
            if (lastNameStr.Length > 0) // Empty string?
            {
                lastNameLetterCh = lastNameStr[0];   // First char of last name
                lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                {
                    isUpperClass = (senButton.Checked || junButton.Checked);

                    // Juniors and Seniors share same schedule but different days
                    if (isUpperClass)
                    {
                        if (senButton.Checked)
                            dateStr = regDays[0];
                        else // Must be juniors
                            dateStr = regDays[1];
                        int index = upperClassFirstLetters.Length - 1;// index value to step through array in reverse order for upperclassmen
                        bool found = false;//is the letter found to match a certain range?
                        while (index >= 0 && !found)
                        {
                            if (lastNameLetterCh >= upperClassFirstLetters[index])
                                found = true;
                            else
                                index--;
                        }
                        if (found)
                            timeStr = upperRegTimes[index];
                    }
                    // Sophomores and Freshmen
                    else // Must be soph/fresh
                    {
                        if (sophButton.Checked)
                        {
                            // G-S on one day
                            if ((lastNameLetterCh >= 'G') && // >= G and
                                (lastNameLetterCh <= 'S'))   // <= S
                                dateStr = regDays[3];
                            else // All other letters on previous day
                                dateStr = regDays[2];
                        }
                        else // must be freshman
                        {
                            // G-S on one day
                            if ((lastNameLetterCh >= 'G') && // >= G and
                                (lastNameLetterCh <= 'S'))   // <= S
                                dateStr = regDays[5];
                            else // All other letters on previous day
                                dateStr = regDays[4];

                        }
                        int index = lowerClass.Length - 1;//steps through array in reverse order to test lower limits
                        bool found = false;//is the letter found within a certain range?
                        while (index >= 0 && !found)
                        {
                            if (lastNameLetterCh >= lowerClass[index])
                                found = true;
                            else
                                index--;
                        }
                        if (found)
                            timeStr = freshSophTimes[index];
                    }

                    // Output results
                    outputLabel.Text = dateStr + " at " + timeStr;
                }
                else // First char not a letter
                    MessageBox.Show("Make sure last name starts with a letter");
            }
            else // Empty textbox
                MessageBox.Show("Enter a last name!");
        }
    }
}
