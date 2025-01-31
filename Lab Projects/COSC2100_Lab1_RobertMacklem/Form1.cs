using COSC2100_Lab1_RobertMacklem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC2100_Lab1_RobertMacklem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Reset(); // Reset to initialize based on our coded defaults
        }

        /// <summary>
        /// On click of the 'Calculate' button, calls Calculate()
        /// and sets output box to the result, also sets the flavour 
        /// text output
        /// </summary>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Calls calculate on click
            int dogYears = Calculate(Decimal.ToInt32(nudHumanYears.Value));

            // Convert results to string and print it to readonly textbox
            tbxDogYears.Text = dogYears.ToString();

            if (dogYears <= 17)
            {
                lblFlavourText.Text = "You're just a puppy!";
                pbxDogImage.Image = Resources.imgPuppy;
            }

            else if (dogYears <= 50)
            {
                lblFlavourText.Text = "Wow, you're an adult!";
                pbxDogImage.Image = Resources.imgAdult;
            }

            else if (dogYears <= 130)
            {
                lblFlavourText.Text = "Old yeller!";
                pbxDogImage.Image = Resources.imgYeller;
            }

            else
            {
                lblFlavourText.Text = "You must be the oldest\ndog in the world!";
                pbxDogImage.Image = Resources.imgGrandpa;
            }
        }


        /// <summary>
        /// Takes the inputted human years from the user and applies
        /// a constant conversion of 7x to convert to dog years, and
        /// displays the output via readonly text.
        /// </summary>
        private int Calculate(int humanYears)
        {
            // Conversaion rate consts
            int YoungDogRate = 10;
            int OldDogRate = 4;
            int OldDogModifier = 12;
            int AgeRateSwitchValue = 2;

            // Declare our out variable
            int dogYears = 0;

            // If the input age is less than the switch value
            if (humanYears <= AgeRateSwitchValue)
            {
                // Use the young dog conversion formula of human years x 10
                dogYears = humanYears * YoungDogRate;
            }

            else
            {
                // Use the old dog formula of (human years x 4) + 12
                dogYears = (humanYears * OldDogRate) + OldDogModifier;
            }

            // Return the result
            return dogYears;
        }

        /// <summary>
        /// On click of the 'Reset' button, calls Reset()
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Calls reset on click
            Reset();
        }

        /// <summary>
        /// Resets the form to is default state.
        /// </summary>
        private void Reset()
        {
            // Sets input and output controls back to default values of '0'
            nudHumanYears.Value = 0;
            tbxDogYears.Text = "0";

            // Clears flavour text values
            lblFlavourText.Text = "";
            pbxDogImage.Image = null;
        }
    }
}
