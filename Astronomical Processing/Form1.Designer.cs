namespace Astronomical_Processing
{
    partial class Form1
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
            this.ButtonSort = new System.Windows.Forms.Button();
            this.ButtonBinarySearch = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.TextBoxEdit = new System.Windows.Forms.TextBox();
            this.LabelHeading = new System.Windows.Forms.Label();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.LabelEdit = new System.Windows.Forms.Label();
            this.LabelListBox = new System.Windows.Forms.Label();
            this.GroupBoxSprint1 = new System.Windows.Forms.GroupBox();
            this.GroupBoxSprint2 = new System.Windows.Forms.GroupBox();
            this.GroupBoxCalculator = new System.Windows.Forms.GroupBox();
            this.TextBoxMidExtreme = new System.Windows.Forms.TextBox();
            this.ButtonMidExtreme = new System.Windows.Forms.Button();
            this.TextBoxMode = new System.Windows.Forms.TextBox();
            this.ButtonMode = new System.Windows.Forms.Button();
            this.ButtonRange = new System.Windows.Forms.Button();
            this.ButtonAverage = new System.Windows.Forms.Button();
            this.ButtonLinearSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextBoxAverage = new System.Windows.Forms.TextBox();
            this.TextBoxRange = new System.Windows.Forms.TextBox();
            this.TextBoxDetail = new System.Windows.Forms.TextBox();
            this.GroupBoxSprint1.SuspendLayout();
            this.GroupBoxSprint2.SuspendLayout();
            this.GroupBoxCalculator.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(121, 35);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(83, 23);
            this.ButtonSort.TabIndex = 1;
            this.ButtonSort.Text = "Sort";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // ButtonBinarySearch
            // 
            this.ButtonBinarySearch.Location = new System.Drawing.Point(27, 76);
            this.ButtonBinarySearch.Name = "ButtonBinarySearch";
            this.ButtonBinarySearch.Size = new System.Drawing.Size(83, 23);
            this.ButtonBinarySearch.TabIndex = 2;
            this.ButtonBinarySearch.Text = "Binary Search";
            this.ButtonBinarySearch.UseVisualStyleBackColor = true;
            this.ButtonBinarySearch.Click += new System.EventHandler(this.ButtonBinarySearch_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(27, 114);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(83, 23);
            this.ButtonEdit.TabIndex = 4;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ListBox
            // 
            this.ListBox.ColumnWidth = 80;
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(27, 177);
            this.ListBox.MultiColumn = true;
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(177, 160);
            this.ListBox.TabIndex = 6;
            this.ListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(121, 78);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(83, 20);
            this.TextBoxSearch.TabIndex = 3;
            // 
            // TextBoxEdit
            // 
            this.TextBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TextBoxEdit.Location = new System.Drawing.Point(121, 114);
            this.TextBoxEdit.Name = "TextBoxEdit";
            this.TextBoxEdit.Size = new System.Drawing.Size(83, 21);
            this.TextBoxEdit.TabIndex = 5;
            // 
            // LabelHeading
            // 
            this.LabelHeading.AutoSize = true;
            this.LabelHeading.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeading.Location = new System.Drawing.Point(201, 20);
            this.LabelHeading.Name = "LabelHeading";
            this.LabelHeading.Size = new System.Drawing.Size(133, 16);
            this.LabelHeading.TabIndex = 6;
            this.LabelHeading.Text = "Astronomical Data";
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(27, 35);
            this.ButtonLoad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(83, 23);
            this.ButtonLoad.TabIndex = 0;
            this.ButtonLoad.Text = "Load";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // LabelEdit
            // 
            this.LabelEdit.AutoSize = true;
            this.LabelEdit.Location = new System.Drawing.Point(208, 124);
            this.LabelEdit.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelEdit.Name = "LabelEdit";
            this.LabelEdit.Size = new System.Drawing.Size(26, 13);
            this.LabelEdit.TabIndex = 7;
            this.LabelEdit.Text = "time";
            // 
            // LabelListBox
            // 
            this.LabelListBox.AutoSize = true;
            this.LabelListBox.Location = new System.Drawing.Point(25, 161);
            this.LabelListBox.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelListBox.Name = "LabelListBox";
            this.LabelListBox.Size = new System.Drawing.Size(150, 13);
            this.LabelListBox.TabIndex = 8;
            this.LabelListBox.Text = " Hour    Data        Hour    Data";
            // 
            // GroupBoxSprint1
            // 
            this.GroupBoxSprint1.Controls.Add(this.ListBox);
            this.GroupBoxSprint1.Controls.Add(this.LabelListBox);
            this.GroupBoxSprint1.Controls.Add(this.ButtonSort);
            this.GroupBoxSprint1.Controls.Add(this.LabelEdit);
            this.GroupBoxSprint1.Controls.Add(this.ButtonBinarySearch);
            this.GroupBoxSprint1.Controls.Add(this.ButtonLoad);
            this.GroupBoxSprint1.Controls.Add(this.ButtonEdit);
            this.GroupBoxSprint1.Controls.Add(this.TextBoxSearch);
            this.GroupBoxSprint1.Controls.Add(this.TextBoxEdit);
            this.GroupBoxSprint1.Location = new System.Drawing.Point(28, 53);
            this.GroupBoxSprint1.Name = "GroupBoxSprint1";
            this.GroupBoxSprint1.Size = new System.Drawing.Size(264, 358);
            this.GroupBoxSprint1.TabIndex = 9;
            this.GroupBoxSprint1.TabStop = false;
            this.GroupBoxSprint1.Text = "Sprint One";
            // 
            // GroupBoxSprint2
            // 
            this.GroupBoxSprint2.Controls.Add(this.GroupBoxCalculator);
            this.GroupBoxSprint2.Controls.Add(this.ButtonLinearSearch);
            this.GroupBoxSprint2.Controls.Add(this.textBox1);
            this.GroupBoxSprint2.Location = new System.Drawing.Point(298, 53);
            this.GroupBoxSprint2.Name = "GroupBoxSprint2";
            this.GroupBoxSprint2.Size = new System.Drawing.Size(247, 358);
            this.GroupBoxSprint2.TabIndex = 10;
            this.GroupBoxSprint2.TabStop = false;
            this.GroupBoxSprint2.Text = "Sprint Two";
            // 
            // GroupBoxCalculator
            // 
            this.GroupBoxCalculator.Controls.Add(this.TextBoxDetail);
            this.GroupBoxCalculator.Controls.Add(this.TextBoxRange);
            this.GroupBoxCalculator.Controls.Add(this.TextBoxAverage);
            this.GroupBoxCalculator.Controls.Add(this.TextBoxMidExtreme);
            this.GroupBoxCalculator.Controls.Add(this.ButtonRange);
            this.GroupBoxCalculator.Controls.Add(this.ButtonMode);
            this.GroupBoxCalculator.Controls.Add(this.ButtonMidExtreme);
            this.GroupBoxCalculator.Controls.Add(this.TextBoxMode);
            this.GroupBoxCalculator.Controls.Add(this.ButtonAverage);
            this.GroupBoxCalculator.Location = new System.Drawing.Point(16, 76);
            this.GroupBoxCalculator.Name = "GroupBoxCalculator";
            this.GroupBoxCalculator.Size = new System.Drawing.Size(214, 276);
            this.GroupBoxCalculator.TabIndex = 11;
            this.GroupBoxCalculator.TabStop = false;
            this.GroupBoxCalculator.Text = "Calculator";
            // 
            // TextBoxMidExtreme
            // 
            this.TextBoxMidExtreme.Location = new System.Drawing.Point(110, 38);
            this.TextBoxMidExtreme.Name = "TextBoxMidExtreme";
            this.TextBoxMidExtreme.ReadOnly = true;
            this.TextBoxMidExtreme.Size = new System.Drawing.Size(83, 20);
            this.TextBoxMidExtreme.TabIndex = 3;
            // 
            // ButtonMidExtreme
            // 
            this.ButtonMidExtreme.Location = new System.Drawing.Point(11, 38);
            this.ButtonMidExtreme.Name = "ButtonMidExtreme";
            this.ButtonMidExtreme.Size = new System.Drawing.Size(83, 23);
            this.ButtonMidExtreme.TabIndex = 5;
            this.ButtonMidExtreme.Text = "Mid-Extreme";
            this.ButtonMidExtreme.UseVisualStyleBackColor = true;
            // 
            // TextBoxMode
            // 
            this.TextBoxMode.Location = new System.Drawing.Point(110, 77);
            this.TextBoxMode.Name = "TextBoxMode";
            this.TextBoxMode.ReadOnly = true;
            this.TextBoxMode.Size = new System.Drawing.Size(83, 20);
            this.TextBoxMode.TabIndex = 9;
            // 
            // ButtonMode
            // 
            this.ButtonMode.Location = new System.Drawing.Point(11, 75);
            this.ButtonMode.Name = "ButtonMode";
            this.ButtonMode.Size = new System.Drawing.Size(83, 23);
            this.ButtonMode.TabIndex = 6;
            this.ButtonMode.Text = "Mode";
            this.ButtonMode.UseVisualStyleBackColor = true;
            // 
            // ButtonRange
            // 
            this.ButtonRange.Location = new System.Drawing.Point(11, 153);
            this.ButtonRange.Name = "ButtonRange";
            this.ButtonRange.Size = new System.Drawing.Size(83, 23);
            this.ButtonRange.TabIndex = 8;
            this.ButtonRange.Text = "Range";
            this.ButtonRange.UseVisualStyleBackColor = true;
            // 
            // ButtonAverage
            // 
            this.ButtonAverage.Location = new System.Drawing.Point(11, 115);
            this.ButtonAverage.Name = "ButtonAverage";
            this.ButtonAverage.Size = new System.Drawing.Size(83, 23);
            this.ButtonAverage.TabIndex = 7;
            this.ButtonAverage.Text = "Average";
            this.ButtonAverage.UseVisualStyleBackColor = true;
            // 
            // ButtonLinearSearch
            // 
            this.ButtonLinearSearch.Location = new System.Drawing.Point(27, 35);
            this.ButtonLinearSearch.Name = "ButtonLinearSearch";
            this.ButtonLinearSearch.Size = new System.Drawing.Size(83, 23);
            this.ButtonLinearSearch.TabIndex = 4;
            this.ButtonLinearSearch.Text = "Linear Search";
            this.ButtonLinearSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 1;
            // 
            // TextBoxAverage
            // 
            this.TextBoxAverage.Location = new System.Drawing.Point(110, 117);
            this.TextBoxAverage.Name = "TextBoxAverage";
            this.TextBoxAverage.ReadOnly = true;
            this.TextBoxAverage.Size = new System.Drawing.Size(83, 20);
            this.TextBoxAverage.TabIndex = 11;
            // 
            // TextBoxRange
            // 
            this.TextBoxRange.Location = new System.Drawing.Point(110, 155);
            this.TextBoxRange.Name = "TextBoxRange";
            this.TextBoxRange.ReadOnly = true;
            this.TextBoxRange.Size = new System.Drawing.Size(83, 20);
            this.TextBoxRange.TabIndex = 12;
            // 
            // TextBoxDetail
            // 
            this.TextBoxDetail.Location = new System.Drawing.Point(11, 195);
            this.TextBoxDetail.Multiline = true;
            this.TextBoxDetail.Name = "TextBoxDetail";
            this.TextBoxDetail.ReadOnly = true;
            this.TextBoxDetail.Size = new System.Drawing.Size(182, 66);
            this.TextBoxDetail.TabIndex = 13;
            this.TextBoxDetail.Text = "Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 434);
            this.Controls.Add(this.GroupBoxSprint2);
            this.Controls.Add(this.GroupBoxSprint1);
            this.Controls.Add(this.LabelHeading);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astronomical Processing";
            this.GroupBoxSprint1.ResumeLayout(false);
            this.GroupBoxSprint1.PerformLayout();
            this.GroupBoxSprint2.ResumeLayout(false);
            this.GroupBoxSprint2.PerformLayout();
            this.GroupBoxCalculator.ResumeLayout(false);
            this.GroupBoxCalculator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.Button ButtonBinarySearch;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.TextBox TextBoxEdit;
        private System.Windows.Forms.Label LabelHeading;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Label LabelEdit;
        private System.Windows.Forms.Label LabelListBox;
        private System.Windows.Forms.GroupBox GroupBoxSprint1;
        private System.Windows.Forms.GroupBox GroupBoxSprint2;
        private System.Windows.Forms.Button ButtonAverage;
        private System.Windows.Forms.Button ButtonMode;
        private System.Windows.Forms.Button ButtonMidExtreme;
        private System.Windows.Forms.Button ButtonLinearSearch;
        private System.Windows.Forms.TextBox TextBoxMidExtreme;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TextBoxMode;
        private System.Windows.Forms.Button ButtonRange;
        private System.Windows.Forms.GroupBox GroupBoxCalculator;
        private System.Windows.Forms.TextBox TextBoxAverage;
        private System.Windows.Forms.TextBox TextBoxRange;
        private System.Windows.Forms.TextBox TextBoxDetail;
    }
}

