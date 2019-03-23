namespace Program_2
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lastNamePrompt = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.freshmanRadio = new System.Windows.Forms.RadioButton();
            this.sophomoreRadio = new System.Windows.Forms.RadioButton();
            this.juniorRadio = new System.Windows.Forms.RadioButton();
            this.seniorRadio = new System.Windows.Forms.RadioButton();
            this.schoolYearLabel = new System.Windows.Forms.Label();
            this.registrationDateLabel = new System.Windows.Forms.Label();
            this.magicButton = new System.Windows.Forms.Button();
            this.yearButtonPanel = new System.Windows.Forms.Panel();
            this.registrationTimeLabel = new System.Windows.Forms.Label();
            this.promptDateLabel = new System.Windows.Forms.Label();
            this.promptTimeLabel = new System.Windows.Forms.Label();
            this.yearButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastNamePrompt
            // 
            this.lastNamePrompt.AutoSize = true;
            this.lastNamePrompt.Location = new System.Drawing.Point(12, 44);
            this.lastNamePrompt.Name = "lastNamePrompt";
            this.lastNamePrompt.Size = new System.Drawing.Size(111, 13);
            this.lastNamePrompt.TabIndex = 0;
            this.lastNamePrompt.Text = "Enter Your Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(15, 71);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(107, 20);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // freshmanRadio
            // 
            this.freshmanRadio.AutoSize = true;
            this.freshmanRadio.Location = new System.Drawing.Point(29, 3);
            this.freshmanRadio.Name = "freshmanRadio";
            this.freshmanRadio.Size = new System.Drawing.Size(71, 17);
            this.freshmanRadio.TabIndex = 2;
            this.freshmanRadio.TabStop = true;
            this.freshmanRadio.Text = "Freshman";
            this.freshmanRadio.UseVisualStyleBackColor = true;
            // 
            // sophomoreRadio
            // 
            this.sophomoreRadio.AutoSize = true;
            this.sophomoreRadio.Location = new System.Drawing.Point(29, 25);
            this.sophomoreRadio.Name = "sophomoreRadio";
            this.sophomoreRadio.Size = new System.Drawing.Size(79, 17);
            this.sophomoreRadio.TabIndex = 3;
            this.sophomoreRadio.TabStop = true;
            this.sophomoreRadio.Text = "Sophomore";
            this.sophomoreRadio.UseVisualStyleBackColor = true;
            // 
            // juniorRadio
            // 
            this.juniorRadio.AutoSize = true;
            this.juniorRadio.Location = new System.Drawing.Point(29, 48);
            this.juniorRadio.Name = "juniorRadio";
            this.juniorRadio.Size = new System.Drawing.Size(53, 17);
            this.juniorRadio.TabIndex = 4;
            this.juniorRadio.TabStop = true;
            this.juniorRadio.Text = "Junior";
            this.juniorRadio.UseVisualStyleBackColor = true;
            // 
            // seniorRadio
            // 
            this.seniorRadio.AutoSize = true;
            this.seniorRadio.Location = new System.Drawing.Point(29, 71);
            this.seniorRadio.Name = "seniorRadio";
            this.seniorRadio.Size = new System.Drawing.Size(55, 17);
            this.seniorRadio.TabIndex = 5;
            this.seniorRadio.TabStop = true;
            this.seniorRadio.Text = "Senior";
            this.seniorRadio.UseVisualStyleBackColor = true;
            // 
            // schoolYearLabel
            // 
            this.schoolYearLabel.AutoSize = true;
            this.schoolYearLabel.Location = new System.Drawing.Point(229, 9);
            this.schoolYearLabel.Name = "schoolYearLabel";
            this.schoolYearLabel.Size = new System.Drawing.Size(68, 13);
            this.schoolYearLabel.TabIndex = 6;
            this.schoolYearLabel.Text = "Choose Year";
            // 
            // registrationDateLabel
            // 
            this.registrationDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.registrationDateLabel.Location = new System.Drawing.Point(202, 205);
            this.registrationDateLabel.Name = "registrationDateLabel";
            this.registrationDateLabel.Size = new System.Drawing.Size(112, 23);
            this.registrationDateLabel.TabIndex = 7;
            this.registrationDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // magicButton
            // 
            this.magicButton.Location = new System.Drawing.Point(111, 159);
            this.magicButton.Name = "magicButton";
            this.magicButton.Size = new System.Drawing.Size(153, 23);
            this.magicButton.TabIndex = 8;
            this.magicButton.Text = "Make the Magic Happen";
            this.magicButton.UseVisualStyleBackColor = true;
            this.magicButton.Click += new System.EventHandler(this.magicButton_Click);
            // 
            // yearButtonPanel
            // 
            this.yearButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearButtonPanel.Controls.Add(this.seniorRadio);
            this.yearButtonPanel.Controls.Add(this.juniorRadio);
            this.yearButtonPanel.Controls.Add(this.sophomoreRadio);
            this.yearButtonPanel.Controls.Add(this.freshmanRadio);
            this.yearButtonPanel.Location = new System.Drawing.Point(202, 36);
            this.yearButtonPanel.Name = "yearButtonPanel";
            this.yearButtonPanel.Size = new System.Drawing.Size(132, 100);
            this.yearButtonPanel.TabIndex = 9;
            // 
            // registrationTimeLabel
            // 
            this.registrationTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.registrationTimeLabel.Location = new System.Drawing.Point(202, 241);
            this.registrationTimeLabel.Name = "registrationTimeLabel";
            this.registrationTimeLabel.Size = new System.Drawing.Size(112, 23);
            this.registrationTimeLabel.TabIndex = 10;
            this.registrationTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // promptDateLabel
            // 
            this.promptDateLabel.AutoSize = true;
            this.promptDateLabel.Location = new System.Drawing.Point(47, 210);
            this.promptDateLabel.Name = "promptDateLabel";
            this.promptDateLabel.Size = new System.Drawing.Size(145, 13);
            this.promptDateLabel.TabIndex = 11;
            this.promptDateLabel.Text = "You can register on this date:";
            // 
            // promptTimeLabel
            // 
            this.promptTimeLabel.AutoSize = true;
            this.promptTimeLabel.Location = new System.Drawing.Point(12, 246);
            this.promptTimeLabel.Name = "promptTimeLabel";
            this.promptTimeLabel.Size = new System.Drawing.Size(180, 13);
            this.promptTimeLabel.TabIndex = 12;
            this.promptTimeLabel.Text = "You can start registration at this time:";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 293);
            this.Controls.Add(this.promptTimeLabel);
            this.Controls.Add(this.promptDateLabel);
            this.Controls.Add(this.registrationTimeLabel);
            this.Controls.Add(this.yearButtonPanel);
            this.Controls.Add(this.magicButton);
            this.Controls.Add(this.registrationDateLabel);
            this.Controls.Add(this.schoolYearLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNamePrompt);
            this.Name = "RegistrationForm";
            this.Text = "Registration Day";
            this.yearButtonPanel.ResumeLayout(false);
            this.yearButtonPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastNamePrompt;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.RadioButton freshmanRadio;
        private System.Windows.Forms.RadioButton sophomoreRadio;
        private System.Windows.Forms.RadioButton juniorRadio;
        private System.Windows.Forms.RadioButton seniorRadio;
        private System.Windows.Forms.Label schoolYearLabel;
        private System.Windows.Forms.Label registrationDateLabel;
        private System.Windows.Forms.Button magicButton;
        private System.Windows.Forms.Panel yearButtonPanel;
        private System.Windows.Forms.Label registrationTimeLabel;
        private System.Windows.Forms.Label promptDateLabel;
        private System.Windows.Forms.Label promptTimeLabel;
    }
}

