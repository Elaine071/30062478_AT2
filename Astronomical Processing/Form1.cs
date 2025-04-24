// Author        : Yi-Li CHEN
// Team          : 30062478_AT2
// Sprint Number : Two
// Date          : 16/04/2025
// Version       : 2.0
// Program       : Astronomical Processing
// Description   : 1. The application generates a 24-integer array with random numbers ranging from 10 to 90
//                    as astronomical data, and displays the data in a ListBox when the user clicks the Load button.
//                 2. Users can enter their request data in text boxes or select data from the ListBox for the
//                    application to perform and provide feedback on the following actions: sort, search, and edit,
//                    when the relevant buttons are clicked.
//                 3. Add a Linear Search algorithm to search the data when the Linear Search button is clicked.
//                 4. Add calculation functions to calculate the mid-extreme, mode, average, and range values of the data.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Astronomical_Processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LabelEdit.Text = string.Empty;
        }

        /* Astronomical data consist of hours (hourArray) and numbers (numberArray). */
        /* The values in indexArray represent the indexes of the data displayed in the ListBox.
           The indexes of indexArray correspond to the positions of the data in the numberArray,
           which can be sorted and stored in the background. By referencing the data in the 
           background (numberArray), their positions in the ListBox can be determined. */
        public static int arrayLength = 24;
        public int[] numberArray = new int[arrayLength];
        public string[] hourArray = new string[arrayLength];
        public int[] indexArray = new int[arrayLength];

        #region Arrays Generation
        // Fill astronomical data with random numbers between 10 and 90, and format the hours as "hh:00".
        private void FillArray()
        {
            Random rand = new Random();

            for (int i = 0; i < arrayLength; i++)
            {
                numberArray[i] = rand.Next(10, 90);
                hourArray[i] = $"{i:D2}:00";
                indexArray[i] = i;
            }
        }
        #endregion

        #region ListBox Items Display
        // Display astronomical data in the ListBox with the hours and numbers in the format "     hh:00    number".
        // Reset indexArray, as the background data (numberArray) will be displayed in the ListBox.
        private void ShowArray()
        {
            ListBox.Items.Clear();

            for (int i = 0; i < arrayLength; i++)
            {
                ListBox.Items.Add("     " + hourArray[i] + "    " + numberArray[i]);
                indexArray[i] = i;
            }
        }
        #endregion

        #region Load Button Event
        // Load astronomical data
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            TextBoxBinarySearch.Clear();
            TextBoxEdit.Clear();
            LabelEdit.Text = string.Empty;
            TextBoxLinearSearch.Clear();
            TextBoxMidExtreme.Clear();
            TextBoxMode.Clear();
            TextBoxAverage.Clear();
            TextBoxRange.Clear();
            TextBoxDetail.Clear();

            FillArray();
            ShowArray();
        }
        #endregion

        #region Sort Button Event
        // Sort astronomical data
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            TextBoxBinarySearch.Clear();
            TextBoxEdit.Clear();
            LabelEdit.Text = string.Empty;
            TextBoxLinearSearch.Clear();

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
        #endregion

        #region Bubble Sort Algorithm
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

                        // The values in indexArray will represent the indexes of the data displayed in the ListBox.
                        // The indexes of indexArray will directly correspond to the indexes of numberArray.
                        tempIndex = indexArray[inner + 1];
                        indexArray[inner + 1] = indexArray[inner];
                        indexArray[inner] = tempIndex;
                    }
                }
            }
        }
        #endregion

        #region Binary Search Button Event
        /* Binary Search Button Event:
         * Verify the existence of astronomical data.
         * Check if any data has been entered into the text box.
         * Ensure the entered data is an integer between 10 and 90.
         * If the entered data is found in numberArray, highlight it in the ListBox and
           display it in the Edit text box and label for the user's convenience when editing. */
        private void ButtonBinarySearch_Click(object sender, EventArgs e)
        {
            TextBoxLinearSearch.Clear();
            TextBoxEdit.Clear();
            LabelEdit.Text = string.Empty;
            ListBox.ClearSelected();

            if (numberArray.Sum() == 0)
            {
                MessageBox.Show("Please load the astronomical data first.");
            }
            else if (string.IsNullOrWhiteSpace(TextBoxBinarySearch.Text))
            {
                MessageBox.Show("Please enter a data to search.");
            }
            else if (!(Int32.TryParse(TextBoxBinarySearch.Text, out int searchTarget))
                     || searchTarget < 10 || searchTarget > 90)
            {
                MessageBox.Show("Please enter an integer between 10 and 90.");
            }
            else
            {
                int foundIndex = BinarySearch(searchTarget);

                if (foundIndex == -1)
                {
                    MessageBox.Show($"Data {searchTarget} is not found.");
                }
                else
                {
                    FillEditField(foundIndex);
                    MessageBox.Show($"At least one {searchTarget} is found. " +
                                    $"The {searchTarget} is at time {hourArray[foundIndex]}.");
                }
            }
        }
        #endregion

        #region Binary Search Algorithm
        /* Perform a binary search on the sorted numberArray to locate the index of the specified data.
         * If the data is found, return the index where it is located in the sorted numberArray;
           otherwise, return -1. */
        private int BinarySearch(int searchTarget)
        {
            BubbleSort();

            int mid;
            int foundIndex = -1;
            int lowBound = 0;
            int highBound = arrayLength - 1;

            while (lowBound <= highBound)
            {
                mid = (lowBound + highBound) / 2;

                if (numberArray[mid] == searchTarget)
                {
                    foundIndex = mid;
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
            return foundIndex;
        }
        #endregion

        #region Linear Search Algorithm
        /* Perform a linear search on the specified array to locate the index of the specified data.
         * If the data is found, return the index where it is located in the array; otherwise, return -1. */
        private int LinearSearch(int searchTarget, int[] searchArray)
        {
            int foundIndex = -1;

            for (int i = 0; i < searchArray.Length; i++)
            {
                if (searchArray[i] == searchTarget)
                {
                    foundIndex = i;
                    break;
                }
            }
            return foundIndex;
        }
        #endregion

        #region Edit Button Event
        /* Edit Button Event:
         * Verify the existence of astronomical data.
         * Check if data in the ListBox has been selected.
         * Check if any data has been entered into the text box.
         * Ensure the entered data is an integer between 10 and 90.
         * Modify the selected data in the ListBox and numberArray with the data entered by the user. */
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            TextBoxLinearSearch.Clear();
            TextBoxBinarySearch.Clear();

            if (numberArray.Sum() == 0)
            {
                MessageBox.Show("Please load the astronomical data first.");
            }
            else if (ListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please click on a data in the list first.");
            }
            else if (string.IsNullOrWhiteSpace(TextBoxEdit.Text))
            {
                MessageBox.Show("Please enter a data to edit.");
            }
            else if (!(int.TryParse(TextBoxEdit.Text, out int editTarget)) || editTarget < 10 || editTarget > 90)
            {
                MessageBox.Show("Please enter an integer between 10 and 90.");
            }
            else
            {
                string clickedListBoxItem = Convert.ToString(ListBox.SelectedItem);
                ListBox.Items[ListBox.SelectedIndex] = clickedListBoxItem.Substring(0, 14) + editTarget;

                int indexEdit = LinearSearch(ListBox.SelectedIndex, indexArray);
                numberArray[indexEdit] = editTarget;

                TextBoxMidExtreme.Clear();
                TextBoxMode.Clear();
                TextBoxAverage.Clear();
                TextBoxRange.Clear();
                TextBoxDetail.Clear();

                MessageBox.Show($"The data at {hourArray[indexEdit]} is changed to {editTarget}.");

            }
        }
        #endregion

        #region List Box Click Event
        /* List Box Click Event:
         * Verify the existence of astronomical data.
         * If the selection is pointed on a valid item, pass the selected
           item to the Edit text box and label for the user to edit it. */
        private void ListBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxLinearSearch.Clear();
            TextBoxBinarySearch.Clear();

            if (numberArray.Sum() == 0)
            {
                return;
            }
            if (ListBox.IndexFromPoint(e.Location) != ListBox.NoMatches)
            {
                string clickedListBoxItem = Convert.ToString(ListBox.SelectedItem);
                TextBoxEdit.Text = clickedListBoxItem.Substring(14);
                LabelEdit.Text = $"at {clickedListBoxItem.Substring(5, 5)}";
            }
        }
        #endregion

        #region Linear Search Button Event
        /* Linear Search Button Event:
         * Verify the existence of astronomical data.
         * Check if any data has been entered into the text box.
         * Ensure the entered data is an integer between 10 and 90.
         * If the entered data is found in numberArray, highlight it in the ListBox and
           display it in the Edit text box and label for the user's convenience when editing. */
        private void ButtonLinearSearch_Click(object sender, EventArgs e)
        {
            TextBoxBinarySearch.Clear();
            TextBoxEdit.Clear();
            LabelEdit.Text = string.Empty;
            ListBox.ClearSelected();

            if (numberArray.Sum() == 0)
            {
                MessageBox.Show("Please load the astronomical data first.");
            }
            else if (string.IsNullOrWhiteSpace(TextBoxLinearSearch.Text))
            {
                MessageBox.Show("Please enter a data to search.");
            }
            else if (!(Int32.TryParse(TextBoxLinearSearch.Text, out int searchTarget))
                     || searchTarget < 10 || searchTarget > 90)
            {
                MessageBox.Show("Please enter an integer between 10 and 90.");
            }
            else
            {
                int foundIndex = LinearSearch(searchTarget, numberArray);

                if (foundIndex == -1)
                {
                    MessageBox.Show($"Data {searchTarget} is not found.");
                }
                else
                {
                    FillEditField(foundIndex);
                    MessageBox.Show($"At least one {searchTarget} is found. " +
                                    $"The {searchTarget} is at time {hourArray[foundIndex]}.");
                }
            }
        }
        #endregion

        #region Mid-Extreme Button Event
        /* Mid-Extreme Button Event:
         * Verify the existence of astronomical data.
         * Calculate the mid-extreme value and display it in the text boxes. */
        private void ButtonMidExtreme_Click(object sender, EventArgs e)
        {
            if (numberArray.Sum() == 0)
            {
                MessageBox.Show("Please load the astronomical data first.");
            }
            else
            {
                float midExtreme = MidExtreme();
                TextBoxMidExtreme.Text = $"{midExtreme:F2}";
                TextBoxDetail.Text = $"The smallest value: {numberArray[0]}" + Environment.NewLine +
                            $"The largest value: {numberArray[arrayLength - 1]}" + Environment.NewLine +
                            $"The mid-extreme: ({numberArray[0]}+{numberArray[arrayLength - 1]})/2 = {midExtreme:F2}";
            }
        }
        #endregion

        #region Mid-Extreme Calculation
        // Calculate the mid-extreme value: return (smallest value + largest value) / 2
        // The numberArray must be sorted first.
        private float MidExtreme()
        {
            BubbleSort();
            float midExtreme = ((float)numberArray[0] + (float)numberArray[arrayLength - 1]) / 2;
            return midExtreme;
        }
        #endregion

        #region Mode Button Event
        /* Mode Button Event:
         * Verify the existence of astronomical data.
         * Calculate the mode and display it in the text boxes.
         * If the mode is unique, highlight it in the ListBox and display it in
           the Edit text box and label for the user's convenience when editing.
         * Display the modes and their occurrence to the relevant result text boxes */
        private void ButtonMode_Click(object sender, EventArgs e)
        {
            if (numberArray.Sum() == 0)
            {
                MessageBox.Show("Please load the astronomical data first.");
            }
            else
            {
                Mode(out List<int> modesList, out int maxCount);

                if (modesList.Count == 1)
                {
                    TextBoxMode.Text = $"{modesList[0]}";
                    TextBoxDetail.Text = $"The value {modesList[0]} appears {maxCount} times " +
                                         $"and is the mode, making the data set unimodal.";
                    TextBoxBinarySearch.Clear();
                    TextBoxLinearSearch.Clear();
                    FillEditField(LinearSearch(modesList[0], numberArray));
                }
                else
                {
                    TextBoxMode.Text = "Not unimodal";
                    TextBoxDetail.Text = "The modes are";

                    foreach (int mode in modesList)
                    {
                        TextBoxDetail.Text += $" {mode},";
                    }

                    TextBoxDetail.Text += $" each appearing {maxCount} time(s)." + Environment.NewLine +
                                           "There is no unimodal distribution in the data set.";
                }
            }
        }
        #endregion

        #region Mode Calculation
        // Find the mode of the sorted data set (unimodal): the value that appears most frequently.
        // Return all modes as a list and their occurrence count.
        private void Mode(out List<int> modesList, out int maxCount)
        {
            // The numberArray must be sorted first.
            BubbleSort();

            // The occurrence of a number.
            int count = 1;
            // The maximum occurrence of a number.
            maxCount = 1;
            // The list of modes (if the data set is not unimodal).
            modesList = new List<int>();

            for (int i = 0; i < arrayLength - 1; i++)
            {
                if (numberArray[i] == numberArray[i+1])
                {
                    // Count the occurrence of the same number.
                    count++;
                }
                else
                {
                    // If there is a greater occurrence, update the maximum occurrence, and clear
                    // the mode list to only include the number with the greater occurrence.
                    if (maxCount < count)
                    {
                        maxCount = count;
                        modesList.Clear();
                        modesList.Add(numberArray[i]);
                    }
                    // The mode list will contain all numbers with the same maximum occurrence.
                    else if (maxCount == count)
                    {
                        modesList.Add(numberArray[i]);
                    }
                    // Reset the occurrence count on number change.
                    count = 1;
                }
            }

            // Check the last number in the array
            if (maxCount < count)
            {
                maxCount = count;
                modesList.Clear();
                modesList.Add(numberArray[arrayLength - 1]);
            }
            else if (maxCount == count)
            {
                modesList.Add(numberArray[arrayLength - 1]);
            }
        }
        #endregion

        #region Average Button Event
        /* Average Button Event:
         * Verify the existence of astronomical data.
         * Calculate the average value and display it in the text boxes. */
        private void ButtonAverage_Click(object sender, EventArgs e)
        {
            if (numberArray.Sum() == 0)
            {
                MessageBox.Show("Please load the astronomical data first.");
            }
            else
            {
                Average(out float average, out float sum);
                TextBoxAverage.Text = $"{average:F2}";
                TextBoxDetail.Text = $"The sum of all values: {sum}" + Environment.NewLine +
                              $"The total number of the values: {arrayLength}" + Environment.NewLine +
                              $"The average: {sum} / {arrayLength} = {average:F2}";
            }
        }
        #endregion

        #region Average Calculation
        // Calculate the average value: return sum of all values / total number of values
        private void Average(out float average, out float sum)
        {
            sum = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                sum += numberArray[i];
            }
            average = sum / arrayLength;
        }
        #endregion

        #region Range Button Event
        /* Range Button Event:
         * Verify the existence of astronomical data.
         * Calculate the range and display it in the text boxes. */
        private void ButtonRange_Click(object sender, EventArgs e)
        {
            if (numberArray.Sum() == 0)
            {
                MessageBox.Show("Please load the astronomical data first.");
            }
            else
            {
                float range = Range();
                TextBoxRange.Text = $"{range:F2}";
                TextBoxDetail.Text = $"The largest value: {numberArray[arrayLength - 1]}" + Environment.NewLine +
                              $"The smallest value: {numberArray[0]}" + Environment.NewLine +
                              $"The range: {numberArray[arrayLength - 1]} - {numberArray[0]} = {range:F2}";
            }
        }
        #endregion

        #region Range Calculation
        // Calculate the range: return the result of largest value minus smallest value.
        // The numberArray must be sorted first.
        private float Range()
        {
            BubbleSort();
            float range = (float)numberArray[arrayLength - 1] - (float)numberArray[0];
            return range;
        }
        #endregion

        #region Prefill Edit Fields 
        private void FillEditField(int index)
        {
            ListBox.SelectedIndex = indexArray[index];
            TextBoxEdit.Text = $"{numberArray[index]}";
            LabelEdit.Text = $"at {hourArray[index]}";
        }
        #endregion
    }
}
