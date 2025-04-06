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
        }

        // Astronomical data consist of hours (hourArray) and numbers (numberArray).
        public static int arrayLength = 24;
        public int[] numberArray = new int[arrayLength];
        public string[] hourArray = new string[arrayLength];

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
            }
        }

        // Load astronomical data
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            FillArray();
            ShowArray();
        }

        // Sort astronomical data
        private void ButtonSort_Click(object sender, EventArgs e)
        {
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
                    }
                }
            }
        }
    }
}
