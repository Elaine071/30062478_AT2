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
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.TextBoxEdit = new System.Windows.Forms.TextBox();
            this.LabelHeading = new System.Windows.Forms.Label();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.LabelEdit = new System.Windows.Forms.Label();
            this.LabelListBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(171, 59);
            this.ButtonSort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(100, 27);
            this.ButtonSort.TabIndex = 1;
            this.ButtonSort.Text = "Sort";
            this.ButtonSort.UseVisualStyleBackColor = true;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(44, 106);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(100, 27);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(44, 150);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(100, 27);
            this.ButtonEdit.TabIndex = 4;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            // 
            // ListBox
            // 
            this.ListBox.ColumnWidth = 80;
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 15;
            this.ListBox.Location = new System.Drawing.Point(45, 228);
            this.ListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListBox.MultiColumn = true;
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(226, 184);
            this.ListBox.TabIndex = 6;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(171, 110);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(100, 25);
            this.TextBoxSearch.TabIndex = 3;
            // 
            // TextBoxEdit
            // 
            this.TextBoxEdit.Font = new System.Drawing.Font("PMingLiU", 9F);
            this.TextBoxEdit.Location = new System.Drawing.Point(171, 155);
            this.TextBoxEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxEdit.Name = "TextBoxEdit";
            this.TextBoxEdit.Size = new System.Drawing.Size(100, 25);
            this.TextBoxEdit.TabIndex = 5;
            // 
            // LabelHeading
            // 
            this.LabelHeading.AutoSize = true;
            this.LabelHeading.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeading.Location = new System.Drawing.Point(77, 19);
            this.LabelHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelHeading.Name = "LabelHeading";
            this.LabelHeading.Size = new System.Drawing.Size(153, 19);
            this.LabelHeading.TabIndex = 6;
            this.LabelHeading.Text = "Astronomical Data";
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(44, 59);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(100, 27);
            this.ButtonLoad.TabIndex = 0;
            this.ButtonLoad.Text = "Load";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            // 
            // LabelEdit
            // 
            this.LabelEdit.AutoSize = true;
            this.LabelEdit.Location = new System.Drawing.Point(274, 161);
            this.LabelEdit.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelEdit.Name = "LabelEdit";
            this.LabelEdit.Size = new System.Drawing.Size(32, 15);
            this.LabelEdit.TabIndex = 7;
            this.LabelEdit.Text = "time";
            // 
            // LabelListBox
            // 
            this.LabelListBox.AutoSize = true;
            this.LabelListBox.Location = new System.Drawing.Point(43, 210);
            this.LabelListBox.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LabelListBox.Name = "LabelListBox";
            this.LabelListBox.Size = new System.Drawing.Size(185, 15);
            this.LabelListBox.TabIndex = 8;
            this.LabelListBox.Text = " Hour    Data        Hour    Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 431);
            this.Controls.Add(this.LabelListBox);
            this.Controls.Add(this.LabelEdit);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.LabelHeading);
            this.Controls.Add(this.TextBoxEdit);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonSort);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astronomical Processing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.TextBox TextBoxEdit;
        private System.Windows.Forms.Label LabelHeading;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Label LabelEdit;
        private System.Windows.Forms.Label LabelListBox;
    }
}

