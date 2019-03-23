namespace Program3
{
    partial class Program3RegistrationForm
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
            this.freshButton = new System.Windows.Forms.RadioButton();
            this.sophButton = new System.Windows.Forms.RadioButton();
            this.junButton = new System.Windows.Forms.RadioButton();
            this.senButton = new System.Windows.Forms.RadioButton();
            this.yearPrompt = new System.Windows.Forms.Label();
            this.namePrompt = new System.Windows.Forms.Label();
            this.lastNameInputTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.timeDateOutput = new System.Windows.Forms.Label();
            this.yearRadioGroupBox = new System.Windows.Forms.GroupBox();
            this.regDateTimeButton = new System.Windows.Forms.Button();
            this.yearRadioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // freshButton
            // 
            this.freshButton.AutoSize = true;
            this.freshButton.Location = new System.Drawing.Point(22, 19);
            this.freshButton.Name = "freshButton";
            this.freshButton.Size = new System.Drawing.Size(71, 17);
            this.freshButton.TabIndex = 0;
            this.freshButton.TabStop = true;
            this.freshButton.Text = "Freshman";
            this.freshButton.UseVisualStyleBackColor = true;
            // 
            // sophButton
            // 
            this.sophButton.AutoSize = true;
            this.sophButton.Location = new System.Drawing.Point(22, 42);
            this.sophButton.Name = "sophButton";
            this.sophButton.Size = new System.Drawing.Size(79, 17);
            this.sophButton.TabIndex = 1;
            this.sophButton.TabStop = true;
            this.sophButton.Text = "Sophomore";
            this.sophButton.UseVisualStyleBackColor = true;
            // 
            // junButton
            // 
            this.junButton.AutoSize = true;
            this.junButton.Location = new System.Drawing.Point(22, 65);
            this.junButton.Name = "junButton";
            this.junButton.Size = new System.Drawing.Size(53, 17);
            this.junButton.TabIndex = 2;
            this.junButton.TabStop = true;
            this.junButton.Text = "Junior";
            this.junButton.UseVisualStyleBackColor = true;
            // 
            // senButton
            // 
            this.senButton.AutoSize = true;
            this.senButton.Location = new System.Drawing.Point(20, 88);
            this.senButton.Name = "senButton";
            this.senButton.Size = new System.Drawing.Size(55, 17);
            this.senButton.TabIndex = 3;
            this.senButton.TabStop = true;
            this.senButton.Text = "Senior";
            this.senButton.UseVisualStyleBackColor = true;
            // 
            // yearPrompt
            // 
            this.yearPrompt.AutoSize = true;
            this.yearPrompt.Location = new System.Drawing.Point(37, 18);
            this.yearPrompt.Name = "yearPrompt";
            this.yearPrompt.Size = new System.Drawing.Size(68, 13);
            this.yearPrompt.TabIndex = 4;
            this.yearPrompt.Text = "Choose Year";
            // 
            // namePrompt
            // 
            this.namePrompt.AutoSize = true;
            this.namePrompt.Location = new System.Drawing.Point(174, 70);
            this.namePrompt.Name = "namePrompt";
            this.namePrompt.Size = new System.Drawing.Size(86, 13);
            this.namePrompt.TabIndex = 5;
            this.namePrompt.Text = "Enter Last Name";
            // 
            // lastNameInputTextBox
            // 
            this.lastNameInputTextBox.Location = new System.Drawing.Point(163, 89);
            this.lastNameInputTextBox.Name = "lastNameInputTextBox";
            this.lastNameInputTextBox.Size = new System.Drawing.Size(109, 20);
            this.lastNameInputTextBox.TabIndex = 6;
            this.lastNameInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Location = new System.Drawing.Point(40, 237);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(206, 23);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeDateOutput
            // 
            this.timeDateOutput.AutoSize = true;
            this.timeDateOutput.Location = new System.Drawing.Point(51, 215);
            this.timeDateOutput.Name = "timeDateOutput";
            this.timeDateOutput.Size = new System.Drawing.Size(185, 13);
            this.timeDateOutput.TabIndex = 8;
            this.timeDateOutput.Text = "You can register at this date and time:";
            // 
            // yearRadioGroupBox
            // 
            this.yearRadioGroupBox.Controls.Add(this.freshButton);
            this.yearRadioGroupBox.Controls.Add(this.sophButton);
            this.yearRadioGroupBox.Controls.Add(this.junButton);
            this.yearRadioGroupBox.Controls.Add(this.senButton);
            this.yearRadioGroupBox.Location = new System.Drawing.Point(12, 44);
            this.yearRadioGroupBox.Name = "yearRadioGroupBox";
            this.yearRadioGroupBox.Size = new System.Drawing.Size(119, 120);
            this.yearRadioGroupBox.TabIndex = 9;
            this.yearRadioGroupBox.TabStop = false;
            // 
            // regDateTimeButton
            // 
            this.regDateTimeButton.Location = new System.Drawing.Point(69, 180);
            this.regDateTimeButton.Name = "regDateTimeButton";
            this.regDateTimeButton.Size = new System.Drawing.Size(154, 23);
            this.regDateTimeButton.TabIndex = 10;
            this.regDateTimeButton.Text = "Click To Fulfill Your Dreams";
            this.regDateTimeButton.UseVisualStyleBackColor = true;
            this.regDateTimeButton.Click += new System.EventHandler(this.regDateTimeButton_Click);
            // 
            // Program3RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 281);
            this.Controls.Add(this.regDateTimeButton);
            this.Controls.Add(this.yearRadioGroupBox);
            this.Controls.Add(this.timeDateOutput);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.lastNameInputTextBox);
            this.Controls.Add(this.namePrompt);
            this.Controls.Add(this.yearPrompt);
            this.Name = "Program3RegistrationForm";
            this.Text = "Find Out When You Register!";
            this.yearRadioGroupBox.ResumeLayout(false);
            this.yearRadioGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton freshButton;
        private System.Windows.Forms.RadioButton sophButton;
        private System.Windows.Forms.RadioButton junButton;
        private System.Windows.Forms.RadioButton senButton;
        private System.Windows.Forms.Label yearPrompt;
        private System.Windows.Forms.Label namePrompt;
        private System.Windows.Forms.TextBox lastNameInputTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label timeDateOutput;
        private System.Windows.Forms.GroupBox yearRadioGroupBox;
        private System.Windows.Forms.Button regDateTimeButton;
    }
}

