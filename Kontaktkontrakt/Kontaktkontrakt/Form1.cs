using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontaktkontrakt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Function to empty text from textboxes within a specified controller
        private void clearBoxes(Control controller)
        {
            // Loops all textboxes within controller
            foreach (TextBox txtBox in controller.Controls.OfType<TextBox>())
            {
                // Deletes content
                txtBox.Clear();
            }
        }

        // Function to toggle visibility of the addForm
        private void ToggleView()
        {
            // Boolean switch, if hidden -> show. If visible -> hide
            addForm.Visible = !addForm.Visible;
            
            if (addForm.Visible)
            {
                // If addForm was toggled to visible, focus first name field for easier input
                ActiveControl = addFormFName;
            }
            
        }

        // Called when New contact button is clicked
        private void addButton_Click(object sender, EventArgs e)
        {
            // Function to toggle the addform
            ToggleView();
        }

        // Called when Remove button is clicked
        private void removeButton_Click(object sender, EventArgs e)
        {
            // Loops through all selected items in contacts list
            foreach (ListViewItem i in contactsList.SelectedItems)
            {
                // Removes the items
                contactsList.Items.Remove(i);
            }
        }

        // Called when add contact button in addform is clicked
        private void addFormAccept_Click(object sender, EventArgs e)
        {
            // Boolean for empty check
            bool txtBoxEmpty = false; 
            // Loops through the textboxes within the addForm panel
            foreach (TextBox txtBox in addForm.Controls.OfType<TextBox>()) 
            {
                // Check if current textbox(within loop) is empty
                if (String.IsNullOrEmpty(txtBox.Text.Trim())) 
                {
                    // Found empty textbox
                    txtBoxEmpty = true; 
                }
            }

            // if no empty textboxes were found
            if (txtBoxEmpty == false) 
            {
                // Grabs the data from the textboxes and inserts into a ListViewItem
                ListViewItem item = new ListViewItem(new[] {addFormFName.Text, addFormLName.Text, addFormNumber.Text, addFormEmail.Text});
                // Adds the new row to thr ListView 
                contactsList.Items.Add(item);
                // Calls cleanup function
                clearBoxes(addForm);
            }
            else
            {
                // If any empty boxes were found, show a error message
                MessageBox.Show("Fyll I alla fält!");
            }
        }

        // Called when cancel the cancel button in addform is clicked
        private void addFormCancel_Click(object sender, EventArgs e)
        {
            // Closes the addform 
            ToggleView();
            // Calls cleanup function
            clearBoxes(addForm);
        }

        private void contactsList_ItemActivate(object sender, EventArgs e)
        {
            // preparation for edit function
        }
    }
}
