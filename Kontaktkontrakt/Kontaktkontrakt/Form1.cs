using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontaktkontrakt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearBoxes(Control controller)
        {
            foreach (TextBox txtBox in controller.Controls.OfType<TextBox>())
                {
                txtBox.Clear();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addForm.Visible = true;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void addFormAccept_Click(object sender, EventArgs e)
        {

            bool txtBoxEmpty = false;
            foreach (TextBox txtBox in addForm.Controls.OfType<TextBox>())
            {
                if (String.IsNullOrEmpty(txtBox.Text.Trim()))
                {
                    txtBoxEmpty = true;
                }
            }
            if (txtBoxEmpty == false)
            {
                ListViewItem item = new ListViewItem(new[] {addFormFName.Text, addFormLName.Text, addFormNumber.Text, addFormEmail.Text});
                listView1.Items.Add(item);
                clearBoxes(addForm);
            }
            else
            {
                MessageBox.Show("Fyll I alla fält!");
            }
        }

        private void addFormCancel_Click(object sender, EventArgs e)
        {
            addForm.Visible = false;
            clearBoxes(addForm);
        }
    }
}
