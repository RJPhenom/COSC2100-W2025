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

        // Tracks the pairs found by the player
        int pairsFound = 0;

        public frmMain()
        {
            InitializeComponent();
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
                square.Text = "";
            }

            // Generates the emoji list
            foreach (string emoji in emojis)
            {
                emojiList.Add(emoji);
                emojiList.Add(emoji);
            }
        }

        protected void onSquareClicked(object sender, EventArgs e)
        {
            // Cast the sender to the Label (this is safe as only labels call this event)
            Label clickedLabel = (Label)sender;

            foreach (Control c in tlpSquaresTable.Controls)
            {
                MessageBox.Show(c.Name);
            }

            // Get the emoji that corresponds to this sender
            string emoji = emojiList[tlpSquaresTable.Controls.GetChildIndex(clickedLabel)];

            // If they click on an already revealed emoji, do nothing
            if (clickedLabel.Text != "") return;

            // If they click on an unrevealed square, check if we are in comparison mode against
            // a selected emoji
            if (selectedEmoji == "")
            {
                
                selectedEmoji = emojiList[tlpSquaresTable.Controls.GetChildIndex(clickedLabel)];
                clickedLabel.Text = selectedEmoji;
            }

            else if (selectedEmoji == emoji)
            {
                clickedLabel.Text = emoji;
                pairsFound++;

                if (pairsFound >= 8) playerWins();
            }

            else
            {
                selectedEmoji = "";
            }
        }

        protected void playerWins()
        {
            MessageBox.Show("You win!");
        }
    }
}
