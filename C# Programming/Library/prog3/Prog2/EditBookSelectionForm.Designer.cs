namespace LibraryItems
{
    partial class EditBookSelectionForm
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
            this.components = new System.ComponentModel.Container();
            this.bookComboBox = new System.Windows.Forms.ComboBox();
            this.editPrompt = new System.Windows.Forms.Label();
            this.cnclBtn = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookComboBox
            // 
            this.bookComboBox.FormattingEnabled = true;
            this.bookComboBox.Location = new System.Drawing.Point(46, 48);
            this.bookComboBox.Name = "bookComboBox";
            this.bookComboBox.Size = new System.Drawing.Size(186, 21);
            this.bookComboBox.TabIndex = 0;
            this.bookComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookComboBox_Validating);
            // 
            // editPrompt
            // 
            this.editPrompt.AutoSize = true;
            this.editPrompt.Location = new System.Drawing.Point(57, 20);
            this.editPrompt.Name = "editPrompt";
            this.editPrompt.Size = new System.Drawing.Size(165, 13);
            this.editPrompt.TabIndex = 1;
            this.editPrompt.Text = "Choose a Book You Wish to Edit:";
            // 
            // cnclBtn
            // 
            this.cnclBtn.Location = new System.Drawing.Point(60, 75);
            this.cnclBtn.Name = "cnclBtn";
            this.cnclBtn.Size = new System.Drawing.Size(75, 23);
            this.cnclBtn.TabIndex = 2;
            this.cnclBtn.Text = "Cancel";
            this.cnclBtn.UseVisualStyleBackColor = true;
            this.cnclBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cnclBtn_MouseDown);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(147, 75);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditBookSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 106);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.cnclBtn);
            this.Controls.Add(this.editPrompt);
            this.Controls.Add(this.bookComboBox);
            this.Name = "EditBookSelectionForm";
            this.Text = "EditBookSelectionForm";
            this.Load += new System.EventHandler(this.EditBookSelectionForm_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.bookComboBox_Validating);
            this.Validated += new System.EventHandler(this.bookComboBox_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bookComboBox;
        private System.Windows.Forms.Label editPrompt;
        private System.Windows.Forms.Button cnclBtn;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}