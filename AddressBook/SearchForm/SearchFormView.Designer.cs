namespace AddressBook.SearchForm
{
    partial class SearchFormView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbBoth = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numLowRange = new System.Windows.Forms.NumericUpDown();
            this.numHighRange = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLowRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHighRange)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Entry :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search By :";
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(86, 142);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(150, 20);
            this.txtEntry.TabIndex = 2;
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(74, 22);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(140, 21);
            this.cmbSearch.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender :";
            // 
            // rbBoth
            // 
            this.rbBoth.AutoSize = true;
            this.rbBoth.Location = new System.Drawing.Point(60, 55);
            this.rbBoth.Name = "rbBoth";
            this.rbBoth.Size = new System.Drawing.Size(47, 17);
            this.rbBoth.TabIndex = 5;
            this.rbBoth.TabStop = true;
            this.rbBoth.Text = "Both";
            this.rbBoth.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(167, 55);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(107, 55);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(242, 45);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(242, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numHighRange);
            this.groupBox1.Controls.Add(this.numLowRange);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbBoth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.cmbSearch);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 123);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(242, 139);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Default";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Age Range :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "-";
            // 
            // numLowRange
            // 
            this.numLowRange.Location = new System.Drawing.Point(72, 87);
            this.numLowRange.Name = "numLowRange";
            this.numLowRange.Size = new System.Drawing.Size(50, 20);
            this.numLowRange.TabIndex = 12;
            // 
            // numHighRange
            // 
            this.numHighRange.Location = new System.Drawing.Point(142, 86);
            this.numHighRange.Name = "numHighRange";
            this.numHighRange.Size = new System.Drawing.Size(50, 20);
            this.numHighRange.TabIndex = 13;
            // 
            // SearchFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 174);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SearchFormView";
            this.Text = "Search Person";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLowRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHighRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbBoth;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown numHighRange;
        private System.Windows.Forms.NumericUpDown numLowRange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}