using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace COSC2100_ICE2_RobertMacklem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Reset();
        }

        /// <summary>
        /// Resets the form on click, see: Reset()
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        /// <summary>
        /// Clears all the input and placeholder text, and sets
        /// date to today.
        /// </summary>
        private void Reset()
        {
            // Clear all the text from the output display labels
            lblAge.Text = string.Empty;
            lblGeneration.Text = string.Empty;
            lblAppreciationText.Text = string.Empty;

            // Set calendar max date constraint
            dtpCalendarInput.MaxDate = DateTime.Today;

            // Set the calendar date to today
            dtpCalendarInput.Value = DateTime.Today;

            // Clears the generation image
            pbxGeneration.Image = null;
        }

        /// <summary>
        /// Processes the generations data based on the birthday input
        /// on the form's DateTimePicker dtpCalendarInput
        /// </summary>
        private void btnShowResults_Click(object sender, EventArgs e)
        {
            // Gets the birth year from the input
            DateTime birthday = dtpCalendarInput.Value;
            int year = birthday.Year;

            // Calculates and outputs age of user
            lblAge.Text = CalculateAge(birthday).ToString();

            // If else block to determine generation and output based on birth year
            if(year <= 1927)
            {
                lblGeneration.Text = "The Greatest Generation";
                lblAppreciationText.Text = "Damn. You're old!";
                pbxGeneration.Image = Properties.Resources.imgGreatest;
            }

            else if (year <= 1945)
            {
                lblGeneration.Text = "The Silent Generation";
                lblAppreciationText.Text = "Shhhhhh! Zip-it!";
                pbxGeneration.Image = Properties.Resources.imgSilent;
            }

            else if (year <= 1964)
            {
                lblGeneration.Text = "Baby Boomer";
                lblAppreciationText.Text = "Okay Boomer!";
                pbxGeneration.Image = Properties.Resources.imgBoomer;
            }

            else if (year <= 1980)
            {
                lblGeneration.Text = "Gen X";
                lblAppreciationText.Text = "Where are you?!";
                pbxGeneration.Image = Properties.Resources.imgX;
            }

            else if (year <= 1996)
            {
                lblGeneration.Text = "Millenial";
                lblAppreciationText.Text = "What's your ICQ number?";
                pbxGeneration.Image = Properties.Resources.imgMillenial;
            }

            else if (year <= 2012)
            {
                lblGeneration.Text = "Gen Z";
                lblAppreciationText.Text = "You must like Fortnite!";
                pbxGeneration.Image = Properties.Resources.imgZoomer;
            }

            else if (year <= 2025)
            {
                lblGeneration.Text = "Gen Alpha";
                lblAppreciationText.Text = "Good luck kiddo!";
                pbxGeneration.Image = Properties.Resources.imgAlpha;
            }
        }

        /// <summary>
        /// Calculates the user's age using the birthday input
        /// </summary>
        private int CalculateAge(DateTime birthday)
        {
            // Gets the difference in years for the span from today-brithday
            int ageYears = DateTime.Today.Year - birthday.Year;

            // Checks if brithday + years has passed. If so, decrement the result
            // by one (since their birthday hasn't come yet this year)
            if (birthday.AddYears(ageYears) > DateTime.Today) ageYears--;

            // Returns the result
            return ageYears;
        }
    }
}
