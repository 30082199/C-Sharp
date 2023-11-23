using System;
using System.Windows.Forms;

namespace Astronomical_Processing
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check if any item is selected in the listBox
            if (listBox1.SelectedIndex != -1)
            {
                //display the value of the selected item to the textBox
                textBox1.Text = listBox1.SelectedItem.ToString();
            }
            else
            {
                //if there is no item selected, clea the textBox
                textBox1.Text = "";
            }
        }


        private void editBtn_Click(object sender, EventArgs e)
        {
            //check if an item is slected in the listBox
            if (listBox1.SelectedIndex != -1 && !string.IsNullOrEmpty(textBox1.Text))
            {
                //updates the selected item in the listBox using Textbox
                listBox1.Items[listBox1.SelectedIndex] = textBox1.Text;
            }
            textBox1.Text = "";
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            // Bubble Sort algorithm to sort the ListBox items
            // get the number of items in the listbox
            int n = listBox1.Items.Count;
            // flags to track if element were swapped during a pass
            bool swapped;

            do
            {
                //resets the swapped flag at the start of each pass
                swapped = false;

                //iterate through the listbox items
                for (int i = 1; i < n; i++)
                {
                    // Compare adjacent elements and swap if necessary
                    if (Convert.ToInt32(listBox1.Items[i - 1]) > Convert.ToInt32(listBox1.Items[i]))
                    {
                        // Swap the items in the ListBox
                        //store the current item in the temporary variable
                        object temp = listBox1.Items[i - 1];
                        //overwrites the previous items with the current one
                        listBox1.Items[i - 1] = listBox1.Items[i];
                        //place the stored item in the current position
                        listBox1.Items[i] = temp;
                        //set swapped to true as swap occured
                        swapped = true;
                    }
                }

                // Reduce the comparison range in each iteration
                n--;
            }
            //continues the loop as long as elemenets were swapped in the previous pass
            while (swapped);
            textBox1.Text = "";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //declares a variable to store the search value
            int searchValue;
            //try parsing the text from textbox1 into a interger
            if (int.TryParse(textBox1.Text, out searchValue))
            {
                //if successful, perform binary search on the listbox items
                int resultIndex = BinarySearch(searchValue);


                if (resultIndex != -1)
                {
                    //set the selected index of the listBox to the found index
                    listBox1.SelectedIndex = resultIndex;
                    //shows messagebox that it has found the value along with its index
                    MessageBox.Show($"Value {searchValue} found at index {resultIndex}", "Value Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //clears selected items in the listbox
                    listBox1.ClearSelected();
                    //shows messagebox that it has not found the value
                    MessageBox.Show($"Value {searchValue} not found, *Make sure to sort the listbox first before searching*", "Value Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //message box indicating that the text box is empty
                MessageBox.Show("Error - Text Box is empty", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            textBox1.Text = "";
        }
        private int BinarySearch(int value)
        {
            //initialise the left pointer of the search range to start of list which is index 0
            int left = 0;
            //initialise the right pointer of the search range to the end of the list
            int right = listBox1.Items.Count - 1;

            //continue the search while the left pointer is less than or equal to the right pointer
            while (left <= right)
            {
                //calculate the middle index between left and right pointers
                int mid = (left + right) / 2;
                //get the value at the middle index
                int midValue = Convert.ToInt32(listBox1.Items[mid]);

                //if the middle value matches the search value
                if (midValue == value)
                {
                    //return the index fo the middle value
                    return mid;
                }
                //if the middle value is less than the search value
                else if (midValue < value)
                {
                    //move the left pointer to the right of the middle element
                    left = mid + 1;
                }
                //if the middle value is greater than the search value
                else
                {
                    //move the right pointer to the left of the middle element
                    right = mid - 1;
                }
            }
            // Return -1 if value not found
            return -1;
        }

        private void genBtn_Click(object sender, EventArgs e)
        {

            //clears the listbox
            listBox1.Items.Clear();
            //creates an instance of random class
            Random random = new Random();

            //sets the array size
            int hours = 24;

            //creates the array to hold random numbers
            int[] randomNumbers = new int[hours];

            //generates random numbers and add them to array
            for (int i = 0; i < hours; i++)
            {
                //sets the random numbers between 10 - 99
                randomNumbers[i] = random.Next(10, 99);
            }

            //display random numbers in listBox
            foreach (int number in randomNumbers)
            {
                //adds item to the listbox
                listBox1.Items.Add(number);
            }
        }

        //calculation for Mode button
        private (int value, int frequency) CalculateMode(ListBox listBox)
        {
            //dictonary ti store counts of each number
            Dictionary<int, int> count = new Dictionary<int, int>();

            //iterate through each item in the list box
            foreach (int item in listBox.Items)
            {
                //check if the number is already in the dictionary
                if (count.ContainsKey(item))
                    //add if the number exist
                    count[item]++;

                else
                    //add the number to the dictionary if the count is 1
                    count[item] = 1;
            }

            //variables declarations to store mode value and maximum count
            int modeValue = 0;
            int maxCount = 0;

            //find the number with the highest count
            foreach (var pair in count)
            {
                if (pair.Value > maxCount)
                {
                    //update modeValue with the number
                    modeValue = pair.Key;
                    //update maxCount with its count
                    maxCount = pair.Value;
                }
            }
            //return the mode value and its frequcency
            return (modeValue, maxCount);
        }
        //method for mode button onced clicked
        private void modeBtn_Click(object sender, EventArgs e)
        {
            //checks the listBox is not empty
            if (listBox1.Items.Count > 0)
            {
                //calculate moveValue and frequency using the CalculateMode function
                (int modeValue, int frequency) = CalculateMode(listBox1);

                // Display the mode value and its frequency in a message box
                MessageBox.Show($"The number that appeared the most is: {modeValue} (appears {frequency} times)", "Mode Calculation Result");
            }
            else
            {
                //display an error message if the listbox is empty
                MessageBox.Show("The ListBox is empty. Please add items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //clears the textbox at the end.
            textBox1.Text = "";
        }
        //function to calculate the range
        private (int, int, int) CalculateRange(ListBox listBox)
        {
            //check if the listbbox is empty
            if (listBox.Items.Count == 0)
            {
                //display a messagebox if listbox is empty
                MessageBox.Show("ListBox is empty.");
                //return default values for an empty listbox
                return (0, 0, 0);
            }
            //set minValue and maxValue with the first item in the listbox
            int minValue = (int)listBox.Items[0];
            int maxValue = (int)listBox.Items[0];

            //find the minumum and maximum values in the listBox
            foreach (int item in listBox.Items)
            {
                //update minValue if the current item is smaller
                if (item < minValue)
                    minValue = item;
                //update maxValue if the current item is larger
                else if (item > maxValue)
                    maxValue = item;
            }

            //calcuate the range as the difference between maxValue and minValue
            int range = maxValue - minValue;

            //return the minValue, maxValue and range
            return (minValue, maxValue, range);
        }
        //event handler for the range button
        private void ranBtn_Click(object sender, EventArgs e)
        {
            //check if the listbox contains items
            if (listBox1.Items.Count > 0)
            {
                //calculate minValue,maxValue and range using the calculateRange function
                (int minValue, int maxValue, int range) = CalculateRange(listBox1);

                // Display the results in a message box
                MessageBox.Show($"Highest number: {maxValue}\nLowest number: {minValue}\nRange: {range}", "Range Calculation Result");
            }
            else
            {
                //diplay error message if the box is empty
                MessageBox.Show("ListBox is empty. Please add items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //clears the textbox
            textBox1.Text = "";
        }
        //function to calculate the average
        private double CalculateAverage(ListBox listBox)
        {
            //check if the listbox is empty
            if (listBox.Items.Count == 0)
            {
                //display warning message box
                MessageBox.Show("ListBox is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return 0 for an empty listBox
                return 0;
            }

            //sets the sum to 0
            double sum = 0;

            //calculate the sum of all numbers in the listbox
            foreach (int item in listBox.Items)
            {
                //add each item to the sum
                sum += item;
            }

            //calculate and return the average by getting sum result and dividing it by listbox item count
            return sum / listBox.Items.Count;
        }
        //event handler for average button onced clicked
        private void aveBtn_Click(object sender, EventArgs e)
        {
            //check if the listbox contains items
            if (listBox1.Items.Count > 0)
            {
                //calcualtes the average using the calculateAverage function and using the double statement for decimal numbers
                double average = CalculateAverage(listBox1);

                // Display the average in a message box
                MessageBox.Show($"The average is: {average}", "Average Calculation Result");
            }
            else
            {
                //display message error if the list box is emepty
                MessageBox.Show("ListBox is empty. Please add items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //clears the textbox once done
            textBox1.Text = "";
        }
        //function to calculate the mean 
        private double CalculateMidExtreme(ListBox listBox)
        {
            //check if the listbox is empty
            if (listBox.Items.Count == 0)
            {
                //display a message box if the listbox is empty
                MessageBox.Show("ListBox is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return 0 for an empty listbo
                return 0;
            }

            //sets the minValue and maxValue with the first item in the listbox
            int minValue = (int)listBox.Items[0];
            int maxValue = (int)listBox.Items[0];

            //find the minimum and maximum values in the listBox
            foreach (int item in listBox.Items)
            {
                //update minValue if the current item is smaller
                if (item < minValue)
                    minValue = item;
                //update maxValue if the current item is larger
                else if (item > maxValue)
                    maxValue = item;
            }

            //calculate and return the mean as the average of minValue and maxValue
            return (minValue + maxValue) / 2.0;
        }
        //event handler for mix-extreme button once clicked
        private void midBtn_Click(object sender, EventArgs e)
        {
            //check if listbox contains items
            if (listBox1.Items.Count > 0)
            {
                //calculate the midExtreme by using the calculateMidExtreme function
                double midExtreme = CalculateMidExtreme(listBox1);

                // Display the mid-extreme in a message box
                MessageBox.Show($"The mid-extreme is: {midExtreme}", "Mid-Extreme Calculation Result");
            }
            else
            {
                //display error message if the listbox is empty
                MessageBox.Show("ListBox is empty. Please add items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //clears the textbox 
            textBox1.Text = "";
        }
        private int BinarySearch(ListBox listBox, int target)
        {
            //set the left pointer to the start of the ListBox
            int left = 0;
            //set the right pointer to the end of the ListBox
            int right = listBox.Items.Count - 1;

            //perform binary search until left pointer is less than or equal to the right pointer
            while (left <= right)
            {
                //calcualte the mid pointer
                int mid = left + (right - left) / 2;
                //get the value at the mid index
                int midValue = (int)listBox.Items[mid];

                //if the mid value equals to the target, return the index
                if (midValue == target)
                {
                    // Found the target at index mid
                    return mid;
                }
                //if the mid value is less than the targer, search in the right half
                else if (midValue < target)
                {
                    // Search in the right half
                    left = mid + 1;
                }
                //if the mid value is greater than the target, search in the left half
                else
                {
                    // update right pointer to search in the left half
                    right = mid - 1;
                }
            }
            // Target not found
            return -1;
        }
        //event handler for binary search button onced clicked
        private void binSearchBtn_Click(object sender, EventArgs e)
        {
            //try parsing the text in textbox to an inter (target value)
            if (int.TryParse(textBox1.Text, out int targetValue))
            {
                //perform binary search using the BinarySearch function
                int index = BinarySearch(listBox1, targetValue);

                //display search result in a message box
                if (index != -1)
                {
                    //display message box if found
                    MessageBox.Show($"The value {targetValue} is found at index {index} in the ListBox.", "Binary Search Result");
                }
                else
                {
                    //display message box if not found
                    MessageBox.Show($"The value {targetValue} is not found in the ListBox.", "Binary Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //display message box if the text box is empty
                MessageBox.Show("Error - Text Box is empty", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //clears the textbox
            textBox1.Text = "";
        }

        private void midTip_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}