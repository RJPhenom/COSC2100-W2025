using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC2100_ICE4_RobertMacklem
{
    public partial class frmMain : Form
    {
        // CONSTANTS
        readonly string[] emojis = { "😍", "😡", "🤦‍♂️", "😎", "👌", "😒", "😘", "😅"};

        // VARIABLES
        // List of emojis in random order
        List<string> emojiList = new List<string>();

        // Currently selected emoji:
        string selectedEmoji = "";
        Label selectedLabel = null;

        // Tracks the pairs found by the player
        int pairsFound = 0;

        // PROPERTIES
        // Property tracks and sets pairsfound on UI and var
        public int PairsFound
        {
            get { return pairsFound; }
            set { 
                // Sets the var
                pairsFound = value;

                // Updates GUI
                lblPairsFound.Text = "Pairs Found: " + pairsFound.ToString() + " out of " + emojis.Length.ToString();
            }
        }

        /// <summary>
        /// Main initialization
        /// </summary>
        public frmMain()
        {
            // Default init
            InitializeComponent();

            // Run setup
            setupGame();
        }

        /// <summary>
        /// Sets up the game to its initial state
        /// </summary>
        protected void setupGame()
        {
            // Clears the emojiList
            emojiList.Clear();

            // Resets the emoji labels to be blank (invisible)
            foreach (Control square in tlpSquaresTable.Controls)
            {
                // Sets all labels blank
                square.Text = "";
            }

            // Generates the emoji list
            foreach (string emoji in emojis)
            {
                // Adds each emoji twice, guaranteeing pairs
                emojiList.Add(emoji);
                emojiList.Add(emoji);
            }
        }

        /// <summary>
        /// This is the event that is called when a player clicks on a square (label containing
        /// an emoji). This event holds the logic to determine if a match was found and how to proceed.
        /// </summary>

        protected void onSquareClicked(object sender, EventArgs e)
        {
            // Cast the sender to the Label (this is safe as only labels call this event)
            Label clickedLabel = (Label)sender;

            // Get the emoji that corresponds to this sender
            string emoji = emojiList[tlpSquaresTable.Controls.GetChildIndex(clickedLabel)];

            // If they click on an already revealed emoji, do nothing
            if (clickedLabel.Text != "") return;

            // If they click on an unrevealed square, check if we are selecting the first emoji of the pair
            if (selectedEmoji == "")
            {
                
                selectedEmoji = emojiList[tlpSquaresTable.Controls.GetChildIndex(clickedLabel)];
                selectedLabel = clickedLabel;
                clickedLabel.Text = selectedEmoji;
            }

            // Else check if a match was found.
            else if (selectedEmoji == emoji)
            {
                // Set the text visually
                clickedLabel.Text = emoji;

                // Clear the selection vars
                selectedEmoji = "";
                selectedLabel = null;

                // Increment pairs found
                PairsFound++;

                // Check if game won
                if (pairsFound >= 8) playerWins();
            }

            // If no match found
            else
            {
                // Re-hide the selected square
                selectedLabel.Text = "";

                // Reset seletcion
                selectedEmoji = "";
                selectedLabel = null;
            }
        }

        /// <summary>
        /// This function is only called when the player wins and the game is over. It displays
        /// a message box allowing them to play again or quit.
        /// </summary>
        protected void playerWins()
        {
            // Displays a messagebox and stores the result of the Yes/No button options the player clicks
            var playAgain = MessageBox.Show("Congratulations!\n\nPlay Again:", "ALL MATCHES FOUND", MessageBoxButtons.YesNo);

            // If they said yes
            if (playAgain == DialogResult.Yes)
            {
                // Sets up the game to run again
                setupGame();
            }

            // if they said no
            else
            {
                // Quits the program
                Application.Exit();
            }
        }
    }
}
