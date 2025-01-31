using COSC2100_ICE3_RobertMacklem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC2100_ICE3_RobertMacklem
{
    public partial class frmMain : Form
    {
        // Constants
        // Start the game with 20s
        const int MaxTime = 20;

        // Fields
        // Tracks time passage
        int timeLeft = MaxTime;

        // Tracks bug is squished and how many so far
        int bugsSquished = 0;
        bool bugSquished = false;

        // Properties
        // Property for bugSquished to bind value to GUI
        public int BugsSquished
        {
            get { return bugsSquished; }
            set
            {
                // Sets value
                bugsSquished = value;
                // Update GUI
                lblBugsSquashed.Text = $"Bugs Squished: {bugsSquished}";
            }
        }

        // Property for the countdown timer to bind the seconds left to GUI and
        // manage GameOver() calls
        public int TimeLeft
        {
            get { return timeLeft; }
            set
            {
                // Sets value
                timeLeft = value;
                // Updates GUI
                lblTime.Text = $"Time Left: {timeLeft}s";
                // Checks if game is over and calls GameOver if true
                if (timeLeft == 0) GameOver();
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Triggered when the player clicks on the bug to squish it.
        /// </summary>
        private void SquishBug(object sender, MouseEventArgs e)
        {
            // Only if the bug is not currently squished (prevents duplicate counts on
            // the same squished bug)
            if (!bugSquished)
            {
                // Set the bug picture to show it is squished, and count it.
                pbxBug.Image = Resources.imgSplat;
                bugSquished = true;
                BugsSquished++;
            }
        }

        /// <summary>
        /// Triggers automatically by the timer control tmrSpawnTimer:
        /// Places the bug at a random position on screen. Resets the image as well.
        /// </summary>
        private void SpawnTick(object sender, EventArgs e)
        {
            // Generates a random x/y coordinate
            Random random = new Random();
            int x = random.Next(0, ClientSize.Width - pbxBug.Width); // Subtraction prevents bug from spawning at the very right edge and clipping off screen
            int y = random.Next(0, ClientSize.Height - pbxBug.Height); // Prevents bug from spawning behind UI Header

            // Sets bug location to generated coordinate
            pbxBug.Location = new Point(x, y);

            // Resets bug state with image and squished bool
            pbxBug.Image = Resources.imgLadyBug;
            bugSquished = false;
        }

        /// <summary>
        /// Tracks time in seconds via decrement on tick
        /// </summary>
        private void tmrCountDown_Tick(object sender, EventArgs e)
        {
            TimeLeft--;
        }

        /// <summary>
        /// Game Over is called when time = 0 (time has run out), pausing all timers
        /// and displaying the GAME OVER panel
        /// </summary>
        private void GameOver()
        {
            // Stop timer(S)
            tmrCountDown.Stop();
            tmrSpawnTimer.Stop();

            // Display GAME OVER box with score and play again options
            tblGameOver.Visible = true;
            lblYouSquashedXBugs.Text = $"You Squashed {BugsSquished} Bugs!";
        }

        /// <summary>
        /// Resets the program to the default state, to play again!
        /// </summary>
        private void Reset()
        {
            // Reset default values
            TimeLeft = MaxTime;
            BugsSquished = 0;

            // Re-enable timers
            tmrCountDown.Start();
            tmrSpawnTimer.Start();

            // Hide Game Over panel
            tblGameOver.Visible = false;
        }

        /// <summary>
        /// Triggers when the quit button is pressed, exiting the program.
        /// </summary>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Triggers when Play Again button is pressed, calling reset to play again.
        /// </summary>
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
