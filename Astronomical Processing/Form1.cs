// Author        : Yi-Li CHEN
// Team          : 30062478_AT2
// Sprint Number : One
// Date          : 31/03/2025
// Version       : 1.0
// Program       : Astronomical Processing
// Description   : The application generates a 24-integer array with random numbers ranging from 10 to 90
//                 as astronomical data. 
//                 It displays the data in a list box and allows users to sort, search, and edit it. 
//                 Users can enter their request data in text boxes, and the application provides
//                 feedback messages based on the actions performed.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astronomical_Processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LabelEdit.Text = string.Empty;
        }

        // Astronomical data consist of hours (hourArray) and numbers (numberArray).
        public static int arrayLength = 24;
        public int[] numberArray = new int[arrayLength];
        public string[] hourArray = new string[arrayLength];
        public int[] indexArray = new int[arrayLength];

        // Fill astronomical data with random numbers
        private void FillArray()
        {
            // Create a random number
            Random rand = new Random();

            for (int i = 0; i < arrayLength; i++)
            {
                // Random number 10...90
                numberArray[i] = rand.Next(10, 90);

                // hourArray format is 24-hour clock (hh:00)
                hourArray[i] = $"{i:D2}:00";
            }
        }

        // Display astronomical data
        private void ShowArray()
        {
            // Clear ListBox
            ListBox.Items.Clear();

            for (int i = 0; i < arrayLength; i++)
            {
                // ListBox format is "hh:00" + spaces + an integer
                ListBox.Items.Add(hourArray[i] + "    " + numberArray[i]);

                // Initialization for Load and Sort events, as the background data (numberArray)
                // will be displayed in the ListBox.
                indexArray[i] = i;
            }
        }

        // Load astronomical data
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            // Initialize user interface components
            TextBoxSearch.Clear();
            TextBoxEdit.Clear();
            LabelEdit.Text = string.Empty;

            FillArray();
            ShowArray();
        }

        // Sort astronomical data
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            // Initialize user interface components
            TextBoxSearch.Clear();
            TextBoxEdit.Clear();
            LabelEdit.Text = string.Empty;

            // Existing astronomical data need to be processed.
            if (numberArray.Sum() == 0)
            {
                MessageBox.Show("Please load the astronomical data first.");
            }
            else
            {
                BubbleSort();
                ShowArray();
            }
        }

        // Sort ascending
        private void BubbleSort()
        {
            int tempNumber;
            string tempHour;
            int tempIndex;

            for (int outer = 0; outer < arrayLength; outer++)
            {
                for (int inner = 0; inner < arrayLength - 1; inner++)
                {
                    if (numberArray[inner] > numberArray[inner + 1])
                    {
                        tempNumber = numberArray[inner + 1];
                        numberArray[inner + 1] = numberArray[inner];
                        numberArray[inner] = tempNumber;

                        tempHour = hourArray[inner + 1];
                        hourArray[inner + 1] = hourArray[inner];
                        hourArray[inner] = tempHour;

                        // The values in indexArray represent the indexes of the data in the ListBox before sorting.
                        // The indexes of indexArray represent the positions of the newly sorted data, which is stored
                        // in the background.
                        // By locating the sorted data in the background, we can determine their positions
                        // in the ListBox.
                        tempIndex = indexArray[inner + 1];
                        indexArray[inner + 1] = indexArray[inner];
                        indexArray[inner] = tempIndex;
                    }
                }
            }
        }

        // Search astronomical data
        private void ButtonBinarySearch_Click(object sender, EventArgs e)
        {
            // Initialize user interface components
            TextBoxEdit.Clear();
            LabelEdit.Text = string.Empty;

            // Existing astronomical data need to be processed.
            if (numberArray.Sum() == 0)
            {
                MessageBox.Show("Please load the astronomical data first.");
            }
            // Check if search data has been entered into the text box.
            else if (string.IsNullOrWhiteSpace(TextBoxSearch.Text))
            {
                MessageBox.Show("Please enter a data to search.");
            }
            // Verify if the entered data is an integer between 10 and 90.
            else if (!(Int32.TryParse(TextBoxSearch.Text, out int searchTarget))
                     || searchTarget < 10 || searchTarget > 90)
            {
                MessageBox.Show("Please enter an integer between 10 and 90.");
            }
            else
            {
                ListBox.ClearSelected();

                // Sort the astronomical data in ascending order without syncing the result to the ListBox.
                BubbleSort();

                // If the data is found, retrieve the index associated with its hour and number,
                // as well as its position in the ListBox from the sorted data.
                // If the data is not found, return the value '-1'.
                int found = BinarySearch(searchTarget);
                if (found == -1)
                {
                    MessageBox.Show($"Data {searchTarget} is not found.");
                }
                else
                {
                    // Point out the data in the ListBox.
                    ListBox.SelectedIndex = indexArray[found];

                    // Display the searched data in the text box and label for the user's convenience when editing.
                    TextBoxEdit.Text = $"{numberArray[found]}";
                    LabelEdit.Text = $"at {hourArray[found]}";

                    MessageBox.Show($"At least one {searchTarget} is found. " +
                                    $"The {searchTarget} is at time {hourArray[found]}.");
                }
            }
        }

        // If the data is not found, return the value '-1'.
        // Otherwise, return the index where the data is located in the sorted data.
        private int BinarySearch(int searchTarget)
        {
            int mid;
            int found = -1;
            int lowBound = 0;
            int highBound = arrayLength - 1;

            while (lowBound <= highBound)
            {
                // Find the mid-point 
                mid = (lowBound + highBound) / 2;

                if (numberArray[mid] == searchTarget)
                {
                    found = mid;
                    break;
                }
                else if (numberArray[mid] > searchTarget)
                {
                    highBound = mid - 1;
                }
                else
                {
                    lowBound = mid + 1;
                }
            }
            return found;
        }

        private int LinearSearch(int searchTarget, int[] searchArray)
        {
            int indexEdit = -1;

            for (int i = 0; i < searchArray.Length; i++)
            {
                if (searchArray[i] == searchTarget)
                {
                    indexEdit = i;
                }
            }
            return indexEdit;
        }

        // The current astronomical data selected in the ListBox.
        string clickedListBoxItem;

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            // Initialize user interface components
            TextBoxSearch.Clear();

            // Existing astronomical data need to be processed.
            if (numberArray.Sum() == 0)
            {
                MessageBox.Show("Please load the astronomical data first.");
            }
            // Check if data in the ListBox has been selected.
            else if (ListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please click on a data in the list first.");
            }
            // Check if edit data has been entered into the text box.
            else if (string.IsNullOrWhiteSpace(TextBoxEdit.Text))
            {
                MessageBox.Show("Please enter a data to edit.");
            }
            // Verify if the entered data is an integer between 10 and 90.
            else if (!(Int32.TryParse(TextBoxEdit.Text, out int editTarget)) || editTarget < 10 || editTarget > 90)
            {
                MessageBox.Show("Please enter an integer between 10 and 90.");
            }
            else
            {
                // Retrieve the currently selected data from the ListBox, and replace the number
                // with the value entered by the user.
                clickedListBoxItem = Convert.ToString(ListBox.SelectedItem);
                ListBox.Items[ListBox.SelectedIndex] = clickedListBoxItem.Substring(0, 9) + editTarget;

                // Locate the selected ListBox data in the sorted data using indexArray,
                // and update the sorted data accordingly.
                int indexEdit = LinearSearch(ListBox.SelectedIndex, indexArray);
                numberArray[indexEdit] = editTarget;

                MessageBox.Show($"The data at {hourArray[indexEdit]} is changed to {editTarget}.");
            }
        }

        private void ListBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxSearch.Clear();

            if (numberArray.Sum() == 0)
            {
                return;
            }

            // Get the index of the item under the mouse pointer
            // Ensure the click is on a valid item
            if (ListBox.IndexFromPoint(e.Location) != ListBox.NoMatches)
            {
                // Get the item from the ListBox
                clickedListBoxItem = Convert.ToString(ListBox.SelectedItem);

                // Pass the item selected to the text box and label for the user to edit it.
                TextBoxEdit.Text = clickedListBoxItem.Substring(9);
                LabelEdit.Text = $"at {clickedListBoxItem.Substring(0, 5)}";
            }
        }
    }
}
