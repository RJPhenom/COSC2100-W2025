using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC2100_Lab3_RobertMacklem
{
    public partial class AddExpense : Form
    {
        // VARS
        frmMain main;

        // CONSTRUCTOR
        public AddExpense(frmMain main)
        {
            InitializeComponent();

            // Init vars
            this.main = main;
        }

        /// <summary>
        /// Closes the modal form if cancel button is clicked.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Constructs and expense instance with provided input data from
        /// controls and appends it to the expense list in the main form, 
        /// then closes the modal form.
        /// </summary>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Validates input is not blank
            if (tbxDescription.Text == "" || nudAmount.Value == 0)
            {
                MessageBox.Show("Description and amount are both required." +
                    "\nPlease ensure you provided a description and the amount is set above zero.", "Invalid Expense Data");
            }

            // If input is good
            else
            {
                // Constructs expense and appends it to the list in the main form
                Expense expense = new Expense(dtpDate.Value, tbxDescription.Text, (double)nudAmount.Value);
                main.AddExpense(expense);

                Close();
            }

        }
    }
}
