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

        // Defines the indicies that make up the two diagonal victory sets in a table 0-8
        int[] SlopeUp = { 2, 4, 6 };
        int[] SlopeDown = { 0, 4, 8 };

        // VARIABLES
        // Score trackers
        int xScore = 0;
        int oScore = 0;

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

            // Check if it hasn't been picked
            if (clickedLabel.Text == "")
            {
                // If so, pick it for the player whose turn it is
                clickedLabel.Text = (isPlayerOTurn) ? "O" : "X";
                clickedLabel.ForeColor = (isPlayerOTurn) ? Color.Red : Color.Blue;

                // Get the index for feeding the CheckGameWon method
                int square = tlpGameArea.Controls.GetChildIndex((Control)sender);

                // Checks if the player who made the pick has won the game
                if (CheckGameWon(square, clickedLabel.Text))
                {
                    WinGame((isPlayerOTurn) ? tbxPlayerO.Text : tbxPlayerX.Text);
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
        private bool CheckGameWon(int square, string player)
        {
            // Gets current table state
            TableLayoutControlCollection table = tlpGameArea.Controls;

            // CHECKING COLUMN FOR A MATCH
            //****************************
            // Gets the col and row through modulo
            int col = square % GridDimension;

            // Checks column to see if they are match 3 and returns result
            bool colMatch = (
                table[col].Text == player
                && table[col + GridDimension].Text == player
                && table[col + GridDimension + GridDimension].Text == player
                );

            // CHECKING ROW FOR A MATCH
            //*************************
            // Declare row match bool
            bool rowMatch = false;

            // Declare 2 int array to track neighbor indices
            int[] rowNeighbor = { 0, 0 };
            switch (col)
            {
                case 0:
                    // Case if neighbors are both left (index increments)
                    rowNeighbor = new int[] { 1, 2 };
                    break;

                case 1:
                    // Case if neighbors are both sides (index increment and decrement)
                    rowNeighbor = new int[] { -1, 1 };
                    break;

                case 2:
                    // Case if neighbors are both right (index decrements)
                    rowNeighbor = new int[] { -1, -2 };
                    break;
            }

            // Check the two other cells in the row, using neighbor indices
            rowMatch = (table[square + rowNeighbor[0]].Text == player && table[square + rowNeighbor[1]].Text == player);

            // CHECKING THE DIAGONALS FOR A MATCH
            // **********************************
            // Declares vars for diagonal match checks
            bool slopeUpMatch = false;
            bool slopeDownMatch = false;

            // Checks if an angle win is possible, which is only on even square indices
            if (square % 2 == 0)
            {
                // if it is possible, do a check for the relevant diagonal set that the index is in
                if (SlopeUp.Contains(square))
                {
                    // if they all match the player text, its a match
                    slopeUpMatch = (table[SlopeUp[0]].Text == player && table[SlopeUp[1]].Text == player && table[SlopeUp[2]].Text == player);
                }

                else
                {
                    slopeDownMatch = (table[SlopeDown[0]].Text == player && table[SlopeDown[1]].Text == player && table[SlopeDown[2]].Text == player);
                }
            }

            // Return true if ANY match cases are true
            return colMatch || rowMatch || slopeUpMatch || slopeDownMatch ;
        }

        /// <summary>
        /// Handles processing a victory. Takes in the player whose turn it is, increments score, compares score
        /// to set the winner label, then uses a message box to ask users if they wish to keep playing.
        /// </summary>
        private void WinGame(string playerWhoWon)
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

            // Sets winner text & colour based on score differential
            if (OScore > XScore)
            {
                lblWinner.Text = "O";
                lblWinner.ForeColor = Color.Red;
            }

            else if (OScore == XScore)
            {
                lblWinner.Text = "_";
                lblWinner.ForeColor = Color.Black;
            }

            else
            {
                lblWinner.Text = "X";
                lblWinner.ForeColor = Color.Blue;
            }

            // Show game over messagebox with options to replay, and store selection
            var playAgain = MessageBox.Show(playerWhoWon + " Wins!\nDo you want to play again?", "Game Over!", MessageBoxButtons.YesNo);

            // If they chose play again, reset.
            if (playAgain == DialogResult.Yes)
            {
                Reset();
                StartGame();
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
            // Disable game area
            tlpGameArea.Enabled = false;

            // Reset the turn
            isPlayerOTurn = false;

            // Resets all squares to "" or invisible and resets forecolour
            foreach (Label square in tlpGameArea.Controls)
            {
                square.Text = "";
                square.ForeColor = Color.Black;
            }
        }
    }
}
