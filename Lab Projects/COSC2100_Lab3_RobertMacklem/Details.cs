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
    public partial class Details : Form
    {
        /// <summary>
        ///  CONSTRUCTOR
        /// </summary>
        public Details(string mostExpensive, string leastExpensive, string mostDate, string leastDate)
        {
            InitializeComponent();

            // Set tbx outputs
            tbxMostAmount.Text = mostExpensive;
            tbxLeastAmount.Text = leastExpensive;
            tbxMostDate.Text = mostDate;
            tbxLeastDate.Text = leastDate;
        }

        /// <summary>
        /// Closes the window on button click
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
