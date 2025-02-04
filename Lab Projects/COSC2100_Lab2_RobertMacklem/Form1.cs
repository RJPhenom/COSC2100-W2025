using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC2100_Lab2_RobertMacklem
{
    public partial class frmMain : Form
    {
        // CONSTANTS
        // grid is square and size is fixed 3x3
        const int GridDimension = 3;

        // Constant input for playerWhoWon on draw
        const string Nobody = "Nodoby";

        // Constant strings for player characters
        const string X = "X";
        const string O = "O";
        const string Neither = "_";

        // VARIABLES
        // Score trackers
        int xScore = 0;
        int oScore = 0;

        // Defines the sets of indicies that make up the winning match 3 cases
        int[][] WinConditions = new int[8][] { 
            new int[3] {0,1,2}, 
            new int[3] {3,4,5},
            new int[3] {6,7,8},
            new int[3] {0,3,6},
            new int[3] {1,4,7},
            new int[3] {2,5,8},
            new int[3] {0,4,8},
            new int[3] {2,4,6},
        };

        // Tracks claimed squares
        int squaresClaimed = 0;

        // Turn tracker
        bool isPlayerOTurn = false;

        // PROPERTIES
        // Score Trackers
        public int XScore
        {
            get { return xScore; }
            set
            {
                xScore = value;
                tbxScoreX.Text = xScore.ToString();
            }
        }

        public int OScore
        {
            get { return oScore; }
            set
            {
                oScore = value;
                tbxScoreO.Text = oScore.ToString();
            }
        }

        // Turn tracker
        public bool IsPlayerOTurn
        {
            get { return isPlayerOTurn; }
            set
            {
                // Sets value
                isPlayerOTurn = value;

                // Determines whose turn it is to print to GUI, and prints it via game status label
                string playerWhoseTurnItIs = (isPlayerOTurn) ? tbxPlayerO.Text : tbxPlayerX.Text;
                lblGameStatus.Text = playerWhoseTurnItIs + "'s Turn";
            }
        }


        // Mainloop
        public frmMain()
        {
            // Default init
            InitializeComponent();

            // Perform initial reset
            Reset();
        }

        /// <summary>
        /// Called when a player clicks on a square, attempting to select it for marking
        /// as X or O, respectively.
        /// </summary>
        private void OnSquareClicked(object sender, EventArgs e)
        {
            // Cast even caller to Label, since thats the control were using this on
            Label clickedLabel = (Label) sender;

            // Get the index (cell in table)
            int square = tlpGameArea.Controls.GetChildIndex((Control)sender);

            // Check if it hasn't been picked
            if (clickedLabel.Text == "")
            {
                // If so, claim it for tracking purposes
                squaresClaimed++;

                // Update GUI
                clickedLabel.Text = (isPlayerOTurn) ? O : X;
                clickedLabel.ForeColor = (isPlayerOTurn) ? Color.Red : Color.Blue;

                // Checks if the player who made the pick has won the game
                if (CheckGameWon(clickedLabel.Text))
                {
                    // Call game over and pass in that player name as winner
                    GameOver((isPlayerOTurn) ? tbxPlayerO.Text : tbxPlayerX.Text);
                }

                // If the player hasn't won, checks to see if the board is full
                else if (squaresClaimed == GridDimension*GridDimension)
                {
                    // If so, call game over and pass in nobody as winner
                    GameOver(Nobody);
                }

                // Otherwise, change turns
                else
                {
                    IsPlayerOTurn = !isPlayerOTurn;
                }
            }

            else
            {
                // TODO: Error tooltip
            }
        }

        /// <summary>
        /// Called when one of the textboxes change text value (an input has been provided)
        /// </summary>
        private void OnPlayerNameChanged(object sender, EventArgs e)
        {
            // If check game start is true
            if (CheckGameStart())
            {
                // Startgame
                StartGame();
            }

            else
            {
                // TODO: error tooltip
            }
        }

        /// <summary>
        /// Checks if one player has gotten 3 in a row, ending the game and declaring them
        /// winner of the round
        /// </summary>
        private bool CheckGameWon(string player)
        {
            // Gets current table state
            TableLayoutControlCollection table = tlpGameArea.Controls;

            foreach (int[] win in WinConditions)
            {
                if (table[win[0]].Text == player && table[win[1]].Text == player && table[win[2]].Text == player) return true;
            }

            // Return true if ANY match cases are true
            return false;
        }

        /// <summary>
        /// Handles processing a victory. Takes in the player whose turn it is, increments score, compares score
        /// to set the winner label, then uses a message box to ask users if they wish to keep playing.
        /// </summary>
        private void GameOver(string playerWhoWon)
        {
            // If one of the players has won
            if (playerWhoWon != Nobody)
            {
                // Increment the respective score
                if (isPlayerOTurn)
                {
                    OScore++;
                }

                else
                {
                    XScore++;
                }
            }

            // Sets winner text & colour based on score differential
            if (OScore > XScore)
            {
                lblWinner.Text = O;
                lblWinner.ForeColor = Color.Red;
            }

            else if (OScore == XScore)
            {
                lblWinner.Text = Neither;
                lblWinner.ForeColor = Color.Black;
            }

            else
            {
                lblWinner.Text = X;
                lblWinner.ForeColor = Color.Blue;
            }

            // Show game over messagebox with options to replay, and store selection
            var playAgain = MessageBox.Show(playerWhoWon + " Wins!\nDo you want to play again?", "Game Over!", MessageBoxButtons.YesNo);

            // If they chose play again, reset.
            if (playAgain == DialogResult.Yes)
            {
                Reset();
            }

            // If not, quit
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Checks if both player textboxes have input, and returns true (game can start)
        /// if both players have valid names.
        /// </summary>
        private bool CheckGameStart()
        {
            return (tbxPlayerO.Text != "" && tbxPlayerX.Text != "");
        }

        /// <summary>
        /// Called at the start of each new game to setup the game board
        /// </summary>
        private void StartGame()
        {
            // Disable editing the player names until the game is over
            tbxPlayerX.Enabled = false;
            tbxPlayerO.Enabled = false;

            // Enable game area
            tlpGameArea.Enabled = true;

            // Set the first status message
            lblGameStatus.Text = tbxPlayerX.Text + "'s Turn";
        }

        private void Reset()
        {
            // Reset the turn
            IsPlayerOTurn = false;

            // Reset player squares claimed tracker
            squaresClaimed = 0;

            // Resets all squares to "" or invisible and resets forecolour
            foreach (Label square in tlpGameArea.Controls)
            {
                square.Text = "";
                square.ForeColor = Color.Black;
            }
        }
    }
}
