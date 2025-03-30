using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC2100_ICE8_RobertMacklem
{
    public partial class AddVictim : Form
    {
        // VARS
        // Binding list ref.
        BindingList<Victim> Victims;

        /// <summary>
        /// Constructor for the modal for 'AddVictim'
        /// </summary>
        public AddVictim(BindingList<Victim> victims)
        {
            InitializeComponent();
            Victims = victims;
        }

        /// <summary>
        /// Closes the modal form without processing.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Creates a new Victim instace using the name input in the
        /// modal form, and adds it to the victim list.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbxAddVictimName.Text;

            // Validate name is not empty.
            if (name == "")
            {
                MessageBox.Show("You must name your new victim!");
            }

            // Add the victim.
            else
            {
                Victims.Add(new Victim(name));
                Close();
            }

        }
    }
}
