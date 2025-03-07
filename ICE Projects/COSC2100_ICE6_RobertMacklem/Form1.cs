using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC2100_ICE6_RobertMacklem
{
    public partial class frmMain : Form
    {
        // Default burger list VAR
        BindingList<Burger> burgerList = new BindingList<Burger>()
        {
            new Burger("RJ's Big Smash", 6.99),
            new Burger("RJ's Smash Burger", 4.99),
            new Burger("RJ's Jr Smash", 1.99),
            new Burger("RJ's Southern Chicken Sandwich", 4.99),
            new Burger("Mama Car's Fish n' Chips", 5.99)
        };

        public frmMain()
        {
            InitializeComponent();

            // Bind list to table
            dgvBurgers.DataSource = burgerList;
        }

        /// <summary>
        /// Open the Add Burger window
        /// </summary>
        private void btnAddBurger_Click(object sender, EventArgs e)
        {
            AddBurgerForm addBurgerForm = new AddBurgerForm(burgerList);
            addBurgerForm.ShowDialog();
        }


        /// <summary>
        /// Removes the selected burger from the list.
        /// </summary>
        private void btnRemoveBurger_Click(object sender, EventArgs e)
        {
            if (burgerList.Count == 0)
            {
                MessageBox.Show("List is already empty.", "List Empty");
            }

            else if (dgvBurgers.CurrentRow.Index != -1)
            {
                burgerList.RemoveAt(dgvBurgers.CurrentRow.Index);
            }

            else
            {
                MessageBox.Show("Please select a row to remove it.", "Select a row.");
            }
        }

        /// <summary>
        /// Updates the ID columns to have unique, ascending index IDs.
        /// </summary>
        private void UpdateIDs()
        {
            int id = 1;
            foreach (DataGridViewRow row in dgvBurgers.Rows)
            {
                row.Cells[0].Value = id++;
            }
        }

        /// <summary>
        /// Events call UpdateIDs() on remove rows to the DGV table.
        /// </summary>
        private void dgvBurgers_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateIDs();
        }

        /// <summary>
        /// Events call UpdateIDs() on add rows to the DGV table.
        /// </summary>
        private void dgvBurgers_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateIDs();
        }
    }
}
