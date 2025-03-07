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
    public partial class AddBurgerForm : Form
    {
        // VARS
        private BindingList<Burger> burgerList;

        /// <summary>
        /// Constructor takes ina  burger list, so it can be added to
        /// </summary>
        public AddBurgerForm(BindingList<Burger> burgerList)
        {
            InitializeComponent();

            // Init fields
            this.burgerList = burgerList;
        }


        /// <summary>
        /// Closes the modal window.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Takes input from the form and constructs a burger, then appends
        /// it to the burger list (then closes).
        /// </summary>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string inName = tbxBurgerName.Text;
            double inPrice = (double)nudBurgerPrice.Value;

            if (inName == "" || inPrice == 0)
            {
                MessageBox.Show("Invalid name and price inputs:\nValues cannot be empty!");
                return;
            }

            burgerList.Add(new Burger(inName, inPrice));

            Close();
        }
    }
}
