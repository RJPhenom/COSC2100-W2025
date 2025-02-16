using COSC2100_ICE5_RobertMacklem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC2100_ICE5_RobertMacklem
{
    public partial class frmMain : Form
    {
        // CONSTANTS
        // ---------
        // Character strings for character requirements
        const string Lowercase = "abcdefghijklmnopqrstuvwxyz";
        const string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NumericChar = "0123456789";
        const string SpecialChar = "\"!@#$%^&*()[]{}<>?+-=_`~:;'/|\\";

        /// <summary>
        /// Main, with init only
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event is called when text in the password textbox changes.
        /// Uses methods to evaluate the input against the requirements.
        /// </summary>
        private void OnPasswordTextChanged(object sender, EventArgs e)
        {
            // Sets progress bar value according to password strength
            pgbStrength.Value = GetPasswordStrength(tbxPassword.Text);
        }

        /// <summary>
        /// Gets the strength (how many of the five requirements) of the password,
        /// as an int 0-5
        /// </summary>
        private int GetPasswordStrength(string password)
        {
            // track str (out of 5)
            int reqsMet = 0;

            // track individual requirements
            bool lowercaseChar = false;
            bool uppercaseChar = false;
            bool numericChar = false;
            bool specialChar = false;
            bool tenChars = false;

            // Loop through each character in the password and run individual checks for requirements
            foreach (char letter in password)
            {
                if (Lowercase.Contains(letter) && !lowercaseChar) {
                    lowercaseChar =  true;
                    reqsMet++;
                }

                else if (Uppercase.Contains(letter) && !uppercaseChar)
                {
                    uppercaseChar = true;
                    reqsMet++;
                }

                else if (NumericChar.Contains(letter) && !numericChar)
                {
                    numericChar = true;
                    reqsMet++;
                }

                else if (SpecialChar.Contains(letter) && !specialChar)
                {
                    specialChar = true;
                    reqsMet++;
                }

            }

            if (password.Count() >= 10)
            {
                tenChars = true;
                reqsMet++;
            }

            // Set label colours
            SetRequirementLabelColours(lowercaseChar, uppercaseChar, numericChar, specialChar, tenChars);

            return reqsMet;
        }

        /// <summary>
        /// Sets the colours of the requirements labels according to boolean inputs
        /// </summary>
        private void SetRequirementLabelColours(bool az, bool AZ, bool num, bool spec, bool ten)
        {
            lblLowerAlphaReq.BackColor = (az) ? Color.Green : Color.Red;
            lblUpperAlphaReq.BackColor = (AZ) ? Color.Green : Color.Red;
            lblNumericReq.BackColor = (num) ? Color.Green : Color.Red;
            lblSpecialCharReq.BackColor = (spec) ? Color.Green : Color.Red;
            lblTenCharReq.BackColor = (ten) ? Color.Green : Color.Red;
        }

        /// <summary>
        /// Click event for the Randomize button.
        /// Randomly generate a str 5 password in the textbox field.
        /// </summary>
        private void btnRandomize_Click(object sender, EventArgs e)
        {
            // Init random and password
            Random random = new Random();
            string password = "";

            // Repeatedly get randomized chars unit there are 10 chars
            string[] requirements = { Lowercase, Uppercase, NumericChar, SpecialChar };
            while (GetPasswordStrength(password) < 5)
            {
                string requirement = requirements[random.Next(requirements.Length)];
                password += requirement[random.Next(requirement.Length)];
            }

            tbxPassword.Text = password;
        }

        /// <summary>
        /// Click event for the Show Password button.
        /// Toggles passwordChar to hide or display textbox input, and
        /// toggle the image on the button to show state.
        /// </summary>
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            tbxPassword.PasswordChar = (tbxPassword.PasswordChar == (char) 0) ? '•' : (char) 0;  // Default is 0 per MS documentation
            btnShowPassword.BackgroundImage = (tbxPassword.PasswordChar == (char) 0) ? Resources.imgShowPassword : Resources.imgHidePassword;
        }
    }
}
