using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC2100_ICE7_RobertMacklem
{
    public partial class frmGameOver : Form
    {
        // Containers main form ref
        frmMain parent;

        public frmGameOver(bool timesUp, int score, string answer, frmMain inParent)
        {
            InitializeComponent();

            // Set ref
            parent = inParent;

            // Set game over reason && correct answer str
            string gameOverReason = timesUp ? "Time's Up!" : "Wrong answer!";
            string correctAnswer = timesUp ? "" : "\nThe answer is " + answer;

            // Set output text
            lblGameOver.Text = gameOverReason 
                + correctAnswer
                + "\nYou got " 
                + score.ToString() + " correct!";
        }

        /// <summary>
        /// Closes the program.
        /// </summary>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Resets the parent form state and closes the modal form.
        /// </summary>
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            parent.Reset();
            Close();
        }
    }
}
