using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC2100_ICE1_RobertMacklem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets the input data from the four provides controls
        /// and generates the student's registration info displayed
        /// in a MessageBox.
        /// </summary>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            int studentNum = 0;
            string name = "";
            string program = "";
            int semesters = 0;

            // INPUT & VALIDATION
            // Validates the input of the student ID as a 9-digit number.
            if (mtbStudentNumber.Text.Contains("_") || mtbStudentNumber.Text.Length < 9)
            {
                // Output error message if input is invalid.
                ttpError.Show("ERROR: Student number is invalid.\nPlease input a 9-digit number starting with '100'.", mtbStudentNumber, 5000);
                return;
            }

            else
            {
                // Parse the input text of the student number into an int32
                studentNum = int.Parse(mtbStudentNumber.Text);
            }

            // Validates the name input and sets it to 'name' if valid
            if (tbxName.Text == "")
            {
                // Output error message if input is invalid.
                ttpError.Show("ERROR: Name cannot be blank.", tbxName, 5000);
                return;
            }

            else
            {
                // Get the name str from the tbx input
                name = tbxName.Text;
            }

            // Get the program selection
            if (cmbProgram.Text == "")
            {
                // Output error message if input is invalid.
                ttpError.Show("ERROR: A student must have a progam selection.", cmbProgram, 5000);
                return;
            }

            else
            {
                program = cmbProgram.Text;
            }

            // No validation on form which is already restricted.
            semesters = Decimal.ToInt32(nudSemesters.Value);

            // PROCESSING & OUTPUT
            // Generate a string based on input
            string outRegistration = "Student Number: " + studentNum +
                "\nName: " + name +
                "\nProgram: " + program +
                "\nDuration Remaining in Semesters: " + semesters;

            // Display output string in a MessageBox
            MessageBox.Show(outRegistration, "Registration Details");

            // Clears each control manually/one-by-one
            mtbStudentNumber.Clear();
            tbxName.Clear();
            cmbProgram.SelectedIndex = -1;
            nudSemesters.ResetText();
        }

        private void nudSemesters_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
