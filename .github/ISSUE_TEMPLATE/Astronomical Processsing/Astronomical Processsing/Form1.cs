

/* Andrei Diamante, Harvey1, Sprint Number 1
// Date: 23/11/2023
// Version: 17.70
// Astronomical Processing Sprint 1
// the program generates a random 24 number which is stored in array and is able to be sorted using bubble sort and it can be 
   searched with binary searched method it also has an edit button to edit existing items in the listbox by selecting and using the textbox.
*/



namespace Astronomical_Processsing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void genBtn_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }

        private void sortBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
    }
}