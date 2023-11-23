/* Jexther Padua, Harvey1, Sprint Number 1
// Date: 23/11/2023
// Version: 17.70
// Astronomical Processing Sprint 1
// the program generates a random 24 number which is stored in array and is able to be sorted using bubble sort and it can be 
   searched with binary searched method it also has an edit button to edit existing items in the listbox by selecting and using the textbox.
*/


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

        //method when you load the program
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            //check if an item is slected in the listBox
            if (listBox1.SelectedIndex != -1 && !string.IsNullOrEmpty(textBox1.Text))
            {
                //updates the selected item in the listBox using Textbox
                listBox1.Items[listBox1.SelectedIndex] = textBox1.Text;
            }
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
    }
}