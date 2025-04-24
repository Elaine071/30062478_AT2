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
            this.components = new System.ComponentModel.Container();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.ButtonBinarySearch = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.TextBoxBinarySearch = new System.Windows.Forms.TextBox();
            this.TextBoxEdit = new System.Windows.Forms.TextBox();
            this.LabelHeading = new System.Windows.Forms.Label();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.LabelEdit = new System.Windows.Forms.Label();
            this.LabelListBox = new System.Windows.Forms.Label();
            this.GrpBoxDataProcessing = new System.Windows.Forms.GroupBox();
            this.TextBoxLinearSearch = new System.Windows.Forms.TextBox();
            this.ButtonLinearSearch = new System.Windows.Forms.Button();
            this.ButtonAverage = new System.Windows.Forms.Button();
            this.TextBoxMode = new System.Windows.Forms.TextBox();
            this.ButtonMidExtreme = new System.Windows.Forms.Button();
            this.ButtonMode = new System.Windows.Forms.Button();
            this.ButtonRange = new System.Windows.Forms.Button();
            this.TextBoxMidExtreme = new System.Windows.Forms.TextBox();
            this.TextBoxAverage = new System.Windows.Forms.TextBox();
            this.TextBoxRange = new System.Windows.Forms.TextBox();
            this.TextBoxDetail = new System.Windows.Forms.TextBox();
            this.GrpBoxCalculation = new System.Windows.Forms.GroupBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.ToolTipLoadBtn = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipSortBtn = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipBinarySrchBtn = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipBinarySrchTxtB = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipLinearSrchBtn = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipLinearSrchTxtB = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipEditBtn = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipEditTxtB = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipListBox = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipMidExtremeBtn = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipMidExtremeTxtB = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipModeBtn = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipModeTxtB = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipAverageBtn = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipAverageTxtB = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipRangeBtn = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipRangeTxtB = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipDetailTxtB = new System.Windows.Forms.ToolTip(this.components);
            this.GrpBoxDataProcessing.SuspendLayout();
            this.GrpBoxCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(131, 35);
            this.ButtonSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(83, 24);
            this.ButtonSort.TabIndex = 1;
            this.ButtonSort.Text = "Sort";
            this.ToolTipSortBtn.SetToolTip(this.ButtonSort, "Sort data in ascending order.");
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // ButtonBinarySearch
            // 
            this.ButtonBinarySearch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBinarySearch.Location = new System.Drawing.Point(27, 76);
            this.ButtonBinarySearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonBinarySearch.Name = "ButtonBinarySearch";
            this.ButtonBinarySearch.Size = new System.Drawing.Size(88, 24);
            this.ButtonBinarySearch.TabIndex = 2;
            this.ButtonBinarySearch.Text = "Binary Search";
            this.ToolTipBinarySrchBtn.SetToolTip(this.ButtonBinarySearch, "Search the data using Binary Search algorithm.");
            this.ButtonBinarySearch.UseVisualStyleBackColor = true;
            this.ButtonBinarySearch.Click += new System.EventHandler(this.ButtonBinarySearch_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(27, 158);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(88, 24);
            this.ButtonEdit.TabIndex = 4;
            this.ButtonEdit.Text = "Edit";
            this.ToolTipEditBtn.SetToolTip(this.ButtonEdit, "Edit the data in the list box");
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // TextBoxBinarySearch
            // 
            this.TextBoxBinarySearch.Location = new System.Drawing.Point(131, 76);
            this.TextBoxBinarySearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxBinarySearch.Name = "TextBoxBinarySearch";
            this.TextBoxBinarySearch.Size = new System.Drawing.Size(83, 20);
            this.TextBoxBinarySearch.TabIndex = 3;
            this.ToolTipBinarySrchTxtB.SetToolTip(this.TextBoxBinarySearch, "Please enter an integer between 10 and 90.");
            // 
            // TextBoxEdit
            // 
            this.TextBoxEdit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEdit.Location = new System.Drawing.Point(131, 158);
            this.TextBoxEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxEdit.Name = "TextBoxEdit";
            this.TextBoxEdit.Size = new System.Drawing.Size(83, 20);
            this.TextBoxEdit.TabIndex = 5;
            this.ToolTipEditTxtB.SetToolTip(this.TextBoxEdit, "Please click a data in the list box or enter an integer between 10 and 90.");
            // 
            // LabelHeading
            // 
            this.LabelHeading.AutoSize = true;
            this.LabelHeading.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeading.Location = new System.Drawing.Point(201, 21);
            this.LabelHeading.Name = "LabelHeading";
            this.LabelHeading.Size = new System.Drawing.Size(133, 16);
            this.LabelHeading.TabIndex = 6;
            this.LabelHeading.Text = "Astronomical Data";
            this.LabelHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(27, 35);
            this.ButtonLoad.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(88, 24);
            this.ButtonLoad.TabIndex = 0;
            this.ButtonLoad.Text = "Load";
            this.ToolTipLoadBtn.SetToolTip(this.ButtonLoad, "Load data into the list box below.");
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // LabelEdit
            // 
            this.LabelEdit.AutoSize = true;
            this.LabelEdit.Location = new System.Drawing.Point(217, 161);
            this.LabelEdit.Margin = new System.Windows.Forms.Padding(0);
            this.LabelEdit.Name = "LabelEdit";
            this.LabelEdit.Size = new System.Drawing.Size(38, 14);
            this.LabelEdit.TabIndex = 7;
            this.LabelEdit.Text = "at time";
            // 
            // LabelListBox
            // 
            this.LabelListBox.AutoSize = true;
            this.LabelListBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelListBox.Location = new System.Drawing.Point(26, 262);
            this.LabelListBox.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelListBox.Name = "LabelListBox";
            this.LabelListBox.Size = new System.Drawing.Size(247, 14);
            this.LabelListBox.TabIndex = 8;
            this.LabelListBox.Text = "      Hour    Data        Hour    Data         Hour    Data";
            // 
            // GrpBoxDataProcessing
            // 
            this.GrpBoxDataProcessing.Controls.Add(this.ButtonSort);
            this.GrpBoxDataProcessing.Controls.Add(this.TextBoxLinearSearch);
            this.GrpBoxDataProcessing.Controls.Add(this.ButtonLinearSearch);
            this.GrpBoxDataProcessing.Controls.Add(this.LabelEdit);
            this.GrpBoxDataProcessing.Controls.Add(this.ButtonBinarySearch);
            this.GrpBoxDataProcessing.Controls.Add(this.ButtonLoad);
            this.GrpBoxDataProcessing.Controls.Add(this.ButtonEdit);
            this.GrpBoxDataProcessing.Controls.Add(this.TextBoxBinarySearch);
            this.GrpBoxDataProcessing.Controls.Add(this.TextBoxEdit);
            this.GrpBoxDataProcessing.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBoxDataProcessing.Location = new System.Drawing.Point(28, 56);
            this.GrpBoxDataProcessing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GrpBoxDataProcessing.Name = "GrpBoxDataProcessing";
            this.GrpBoxDataProcessing.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GrpBoxDataProcessing.Size = new System.Drawing.Size(264, 202);
            this.GrpBoxDataProcessing.TabIndex = 9;
            this.GrpBoxDataProcessing.TabStop = false;
            this.GrpBoxDataProcessing.Text = "Data Processing";
            // 
            // TextBoxLinearSearch
            // 
            this.TextBoxLinearSearch.Location = new System.Drawing.Point(131, 117);
            this.TextBoxLinearSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxLinearSearch.Name = "TextBoxLinearSearch";
            this.TextBoxLinearSearch.Size = new System.Drawing.Size(83, 20);
            this.TextBoxLinearSearch.TabIndex = 1;
            this.ToolTipLinearSrchTxtB.SetToolTip(this.TextBoxLinearSearch, "Please enter an integer between 10 and 90.");
            // 
            // ButtonLinearSearch
            // 
            this.ButtonLinearSearch.Location = new System.Drawing.Point(27, 117);
            this.ButtonLinearSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonLinearSearch.Name = "ButtonLinearSearch";
            this.ButtonLinearSearch.Size = new System.Drawing.Size(88, 24);
            this.ButtonLinearSearch.TabIndex = 4;
            this.ButtonLinearSearch.Text = "Linear Search";
            this.ToolTipLinearSrchBtn.SetToolTip(this.ButtonLinearSearch, "Search the data using Linear Search algorithm.");
            this.ButtonLinearSearch.UseVisualStyleBackColor = true;
            this.ButtonLinearSearch.Click += new System.EventHandler(this.ButtonLinearSearch_Click);
            // 
            // ButtonAverage
            // 
            this.ButtonAverage.Location = new System.Drawing.Point(27, 117);
            this.ButtonAverage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAverage.Name = "ButtonAverage";
            this.ButtonAverage.Size = new System.Drawing.Size(83, 24);
            this.ButtonAverage.TabIndex = 7;
            this.ButtonAverage.Text = "Average";
            this.ToolTipAverageBtn.SetToolTip(this.ButtonAverage, "The average of all values in the list box.");
            this.ButtonAverage.UseVisualStyleBackColor = true;
            this.ButtonAverage.Click += new System.EventHandler(this.ButtonAverage_Click);
            // 
            // TextBoxMode
            // 
            this.TextBoxMode.Location = new System.Drawing.Point(126, 76);
            this.TextBoxMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxMode.Name = "TextBoxMode";
            this.TextBoxMode.ReadOnly = true;
            this.TextBoxMode.Size = new System.Drawing.Size(83, 20);
            this.TextBoxMode.TabIndex = 9;
            this.ToolTipModeTxtB.SetToolTip(this.TextBoxMode, "The mode is displayed here.");
            // 
            // ButtonMidExtreme
            // 
            this.ButtonMidExtreme.Location = new System.Drawing.Point(27, 35);
            this.ButtonMidExtreme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonMidExtreme.Name = "ButtonMidExtreme";
            this.ButtonMidExtreme.Size = new System.Drawing.Size(83, 24);
            this.ButtonMidExtreme.TabIndex = 5;
            this.ButtonMidExtreme.Text = "Mid-Extreme";
            this.ToolTipMidExtremeBtn.SetToolTip(this.ButtonMidExtreme, "The average of the smallest and largest values in the list box.");
            this.ButtonMidExtreme.UseVisualStyleBackColor = true;
            this.ButtonMidExtreme.Click += new System.EventHandler(this.ButtonMidExtreme_Click);
            // 
            // ButtonMode
            // 
            this.ButtonMode.Location = new System.Drawing.Point(27, 76);
            this.ButtonMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonMode.Name = "ButtonMode";
            this.ButtonMode.Size = new System.Drawing.Size(83, 24);
            this.ButtonMode.TabIndex = 6;
            this.ButtonMode.Text = "Mode";
            this.ToolTipModeBtn.SetToolTip(this.ButtonMode, "The data that appears most often in the list box.");
            this.ButtonMode.UseVisualStyleBackColor = true;
            this.ButtonMode.Click += new System.EventHandler(this.ButtonMode_Click);
            // 
            // ButtonRange
            // 
            this.ButtonRange.Location = new System.Drawing.Point(27, 158);
            this.ButtonRange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonRange.Name = "ButtonRange";
            this.ButtonRange.Size = new System.Drawing.Size(83, 24);
            this.ButtonRange.TabIndex = 8;
            this.ButtonRange.Text = "Range";
            this.ToolTipRangeBtn.SetToolTip(this.ButtonRange, "The difference between the largest and smallest values in the list box.");
            this.ButtonRange.UseVisualStyleBackColor = true;
            this.ButtonRange.Click += new System.EventHandler(this.ButtonRange_Click);
            // 
            // TextBoxMidExtreme
            // 
            this.TextBoxMidExtreme.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxMidExtreme.Location = new System.Drawing.Point(126, 35);
            this.TextBoxMidExtreme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxMidExtreme.Name = "TextBoxMidExtreme";
            this.TextBoxMidExtreme.ReadOnly = true;
            this.TextBoxMidExtreme.Size = new System.Drawing.Size(83, 20);
            this.TextBoxMidExtreme.TabIndex = 3;
            this.ToolTipMidExtremeTxtB.SetToolTip(this.TextBoxMidExtreme, "The mid-extreme is displayed here.");
            // 
            // TextBoxAverage
            // 
            this.TextBoxAverage.Location = new System.Drawing.Point(126, 117);
            this.TextBoxAverage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxAverage.Name = "TextBoxAverage";
            this.TextBoxAverage.ReadOnly = true;
            this.TextBoxAverage.Size = new System.Drawing.Size(83, 20);
            this.TextBoxAverage.TabIndex = 11;
            this.ToolTipAverageTxtB.SetToolTip(this.TextBoxAverage, "The average is displayed here.");
            // 
            // TextBoxRange
            // 
            this.TextBoxRange.Location = new System.Drawing.Point(126, 158);
            this.TextBoxRange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxRange.Name = "TextBoxRange";
            this.TextBoxRange.ReadOnly = true;
            this.TextBoxRange.Size = new System.Drawing.Size(83, 20);
            this.TextBoxRange.TabIndex = 12;
            this.ToolTipRangeTxtB.SetToolTip(this.TextBoxRange, "The range is displayed here.");
            // 
            // TextBoxDetail
            // 
            this.TextBoxDetail.Location = new System.Drawing.Point(27, 206);
            this.TextBoxDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxDetail.Multiline = true;
            this.TextBoxDetail.Name = "TextBoxDetail";
            this.TextBoxDetail.ReadOnly = true;
            this.TextBoxDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxDetail.Size = new System.Drawing.Size(182, 114);
            this.TextBoxDetail.TabIndex = 13;
            this.ToolTipDetailTxtB.SetToolTip(this.TextBoxDetail, "Details of the caculations");
            // 
            // GrpBoxCalculation
            // 
            this.GrpBoxCalculation.Controls.Add(this.TextBoxDetail);
            this.GrpBoxCalculation.Controls.Add(this.TextBoxRange);
            this.GrpBoxCalculation.Controls.Add(this.TextBoxMidExtreme);
            this.GrpBoxCalculation.Controls.Add(this.TextBoxMode);
            this.GrpBoxCalculation.Controls.Add(this.TextBoxAverage);
            this.GrpBoxCalculation.Controls.Add(this.ButtonMidExtreme);
            this.GrpBoxCalculation.Controls.Add(this.ButtonMode);
            this.GrpBoxCalculation.Controls.Add(this.ButtonRange);
            this.GrpBoxCalculation.Controls.Add(this.ButtonAverage);
            this.GrpBoxCalculation.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpBoxCalculation.Location = new System.Drawing.Point(298, 56);
            this.GrpBoxCalculation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GrpBoxCalculation.Name = "GrpBoxCalculation";
            this.GrpBoxCalculation.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GrpBoxCalculation.Size = new System.Drawing.Size(247, 338);
            this.GrpBoxCalculation.TabIndex = 10;
            this.GrpBoxCalculation.TabStop = false;
            this.GrpBoxCalculation.Text = "Calculation";
            // 
            // ListBox
            // 
            this.ListBox.ColumnWidth = 82;
            this.ListBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 14;
            this.ListBox.Location = new System.Drawing.Point(28, 278);
            this.ListBox.Margin = new System.Windows.Forms.Padding(0);
            this.ListBox.MultiColumn = true;
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(264, 116);
            this.ListBox.TabIndex = 6;
            this.ToolTipListBox.SetToolTip(this.ListBox, "Astronomical data is displayed here.");
            this.ListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseClick);
            // 
            // ToolTipLinearSrchBtn
            // 
            this.ToolTipLinearSrchBtn.AutoPopDelay = 5000;
            this.ToolTipLinearSrchBtn.InitialDelay = 500;
            this.ToolTipLinearSrchBtn.ReshowDelay = 100;
            // 
            // ToolTipLinearSrchTxtB
            // 
            this.ToolTipLinearSrchTxtB.AutoPopDelay = 5000;
            this.ToolTipLinearSrchTxtB.InitialDelay = 500;
            this.ToolTipLinearSrchTxtB.ReshowDelay = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(572, 423);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.GrpBoxCalculation);
            this.Controls.Add(this.LabelListBox);
            this.Controls.Add(this.GrpBoxDataProcessing);
            this.Controls.Add(this.LabelHeading);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astronomical Processing";
            this.GrpBoxDataProcessing.ResumeLayout(false);
            this.GrpBoxDataProcessing.PerformLayout();
            this.GrpBoxCalculation.ResumeLayout(false);
            this.GrpBoxCalculation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.Button ButtonBinarySearch;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.TextBox TextBoxBinarySearch;
        private System.Windows.Forms.TextBox TextBoxEdit;
        private System.Windows.Forms.Label LabelHeading;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Label LabelEdit;
        private System.Windows.Forms.Label LabelListBox;
        private System.Windows.Forms.GroupBox GrpBoxDataProcessing;
        private System.Windows.Forms.Button ButtonLinearSearch;
        private System.Windows.Forms.TextBox TextBoxLinearSearch;
        private System.Windows.Forms.Button ButtonAverage;
        private System.Windows.Forms.TextBox TextBoxMode;
        private System.Windows.Forms.Button ButtonMidExtreme;
        private System.Windows.Forms.Button ButtonMode;
        private System.Windows.Forms.Button ButtonRange;
        private System.Windows.Forms.TextBox TextBoxMidExtreme;
        private System.Windows.Forms.TextBox TextBoxAverage;
        private System.Windows.Forms.TextBox TextBoxRange;
        private System.Windows.Forms.TextBox TextBoxDetail;
        private System.Windows.Forms.GroupBox GrpBoxCalculation;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.ToolTip ToolTipLoadBtn;
        private System.Windows.Forms.ToolTip ToolTipSortBtn;
        private System.Windows.Forms.ToolTip ToolTipBinarySrchBtn;
        private System.Windows.Forms.ToolTip ToolTipBinarySrchTxtB;
        private System.Windows.Forms.ToolTip ToolTipLinearSrchBtn;
        private System.Windows.Forms.ToolTip ToolTipLinearSrchTxtB;
        private System.Windows.Forms.ToolTip ToolTipEditBtn;
        private System.Windows.Forms.ToolTip ToolTipEditTxtB;
        private System.Windows.Forms.ToolTip ToolTipListBox;
        private System.Windows.Forms.ToolTip ToolTipMidExtremeBtn;
        private System.Windows.Forms.ToolTip ToolTipMidExtremeTxtB;
        private System.Windows.Forms.ToolTip ToolTipModeBtn;
        private System.Windows.Forms.ToolTip ToolTipModeTxtB;
        private System.Windows.Forms.ToolTip ToolTipAverageBtn;
        private System.Windows.Forms.ToolTip ToolTipAverageTxtB;
        private System.Windows.Forms.ToolTip ToolTipRangeBtn;
        private System.Windows.Forms.ToolTip ToolTipRangeTxtB;
        private System.Windows.Forms.ToolTip ToolTipDetailTxtB;
    }
}

