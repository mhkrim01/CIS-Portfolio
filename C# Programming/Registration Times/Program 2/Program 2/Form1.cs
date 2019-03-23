//Grading ID: A8284
//Program 2
//Due Date: Oct, 19 2017
//CIS 199-01
//This program determines the earliest date and time a student can register for classes based
//on their year standing (freshman, sophomore, etc...) and the first letter of their last name.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        // click event handler that, when clicked, tells the user their registration date and time.
        private void magicButton_Click(object sender, EventArgs e)
        {
            string freshDate1 = "November 9th", freshDate2 = "November 10th", sophDate1 = "November 7th",
                    sophDate2 = "November 8th", junDate = "November 6th", senDate = "November 3rd"; // various registration dates for the varying grade levels
            string time1 = "8:30 am", time2 = "10:00 am", time3 = "11:30 am", time4 = "2:00 pm",
                   time5 = "4:00 pm"; // various registration times decided by last names first letter
            string regTime, regDate;  // used for displaying output in labels, displays time and date
            string lastName = lastNameTextBox.Text;// variable holds the last name entered by user
            char firstLast = lastName[0];//variable takes the first letter of the last name variable and casts it as char data type.
            firstLast = Char.ToUpper(firstLast);//takes a the character and makes it uppercase if its lowercase to ensure the program works.

            if (seniorRadio.Checked || juniorRadio.Checked)
            {
                if (seniorRadio.Checked)
                    regDate = senDate;
                else
                    regDate = junDate;
                if (firstLast <= 'D')
                    regTime = time2;
                else if (firstLast <= 'I')
                    regTime = time3;
                else if (firstLast <= 'O')
                    regTime = time4;
                else if (firstLast <= 'S')
                    regTime = time5;
                else
                    regTime = time1;
            }
            else if (sophomoreRadio.Checked)
            {
                if (firstLast >= 'G' && firstLast <= 'S')
                    regDate = sophDate2;
                else
                    regDate = sophDate1;
                if (firstLast <= 'B')
                    regTime = time3;
                else if (firstLast <= 'D')
                    regTime = time4;
                else if (firstLast <= 'F')
                    regTime = time5;
                else if (firstLast <= 'I')
                    regTime = time1;
                else if (firstLast <= 'L')
                    regTime = time2;
                else if (firstLast <= 'O')
                    regTime = time3;
                else if (firstLast <= 'Q')
                    regTime = time4;
                else if (firstLast <= 'S')
                    regTime = time5;
                else if (firstLast <= 'V')
                    regTime = time1;
                else
                    regTime = time2;
            }
            else
            {
                if (firstLast >= 'G' && firstLast <= 'S')
                    regDate = freshDate2;
                else
                    regDate = freshDate1;
                if (firstLast <= 'B')
                    regTime = time3;
                else if (firstLast <= 'D')
                    regTime = time4;
                else if (firstLast <= 'F')
                    regTime = time5;
                else if (firstLast <= 'I')
                    regTime = time1;
                else if (firstLast <= 'L')
                    regTime = time2;
                else if (firstLast <= 'O')
                    regTime = time3;
                else if (firstLast <= 'Q')
                    regTime = time4;
                else if (firstLast <= 'S')
                    regTime = time5;
                else if (firstLast <= 'V')
                    regTime = time1;
                else
                    regTime = time2;
            }
            registrationDateLabel.Text = $"{regDate}";
            registrationTimeLabel.Text = $"{regTime}";
        }
    }
}
