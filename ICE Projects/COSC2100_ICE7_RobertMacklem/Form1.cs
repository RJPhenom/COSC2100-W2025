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
    public partial class frmMain : Form
    {
        // Randomizer for generating animal emoji
        Random random = new Random();

        // Answer container
        string answer = "";

        // Score container
        int score = 0;

        public frmMain()
        {
            // Init and set first animal
            InitializeComponent();
            Reset();
        }

        /// <summary>
        ///  Called by each button when it is clicked. this checks if it was the right answer
        ///  and either ends the game if incorrect or proceeds to reset for a new answer if correct.
        /// </summary>
        private void SelectOption(object sender, EventArgs e)
        {
            // Cast to button
            Button button = (Button)sender;

            if (button.Text == answer)
            {
                // Increment score
                score++;

                // Set a new animal answer
                SetNewAnimalAnswer(NextAnimal());
            }

            else
            {
                // Stop timer
                tmrTimer.Stop();

                // Show game over screen
                frmGameOver gameOver = new frmGameOver(false, score, answer, this);
                gameOver.ShowDialog();
            }
        }

        /// <summary>
        ///  Pick a random animal from the dict.
        /// </summary>
        private string NextAnimal()
        {
            // Generate a random index, and get the key value for that index for lookup
            int randomIndex = random.Next(Animals.animalName2Emoji.Count);
            string[] animalNames = Animals.animalName2Emoji.Keys.ToArray();
            string animalName = animalNames[randomIndex];

            return animalName;
        }

        /// <summary>
        /// Returns an animal not already present in the passed in list.
        /// </summary>

        private string NextUniqueAnimal(List<string> excludedAnimals)
        {
            // Init string
            string animal = NextAnimal();

            // While the option is not unique
            while (excludedAnimals.Contains(animal))
            {
                // try another string
                animal = NextAnimal();
            }

            // Return the string
            return animal;
        }

        /// <summary>
        /// Generic reset that calls SetNewAnimalAnswer with a new random emoji and then also does a 
        /// progress bar and score reset, essentially reinitalizing the game.
        /// </summary>
        public void Reset()
        {
            // Start the timer up
            tmrTimer.Start();

            // Set the answer and reset progress and score.
            SetNewAnimalAnswer(NextAnimal());
            pgbProgress.Value = 0;
            score = 0;
        }

        /// <summary>
        /// Sets the emoji and all the buttons' text to a random animal. Ensures one and only one
        /// button has the correct animal.
        /// </summary>
        private void SetNewAnimalAnswer(string answerAnimal)
        {
            // Set emoji
            lblAnimalEmoji.Text = Animals.animalName2Emoji[answerAnimal];

            // Create btn array
            List<Button> buttons = new List<Button>
            {
                btnOption1,
                btnOption2,
                btnOption3,
                btnOption4
            };

            // Create and populate names array
            List<string> answers = new List<string>();

            answers.Add(answerAnimal);
            answers.Add(NextUniqueAnimal(answers));
            answers.Add(NextUniqueAnimal(answers));
            answers.Add(NextUniqueAnimal(answers));

            // Set answer
            answer = answerAnimal;

            // Loop through buttons and set text to a random answer,
            // then remove that answer from the collection
            foreach (Button button in buttons)
            {
                int answerIndex = random.Next(answers.Count);
                button.Text = answers[answerIndex];

                    answers.RemoveAt(answerIndex);
            };
        }

        /// <summary>
        /// Called on each update of the timer. Used to update the progress bar.
        /// If the progress is complete, calls TimesUp().
        /// </summary>
        private void TimerTick(object sender, EventArgs e)
        {
            pgbProgress.PerformStep();

            // If times up, call it
            if (pgbProgress.Value == pgbProgress.Maximum) TimesUp();
        }

        private void TimesUp()
        {
            // Stop the timer
            tmrTimer.Stop();

            // Shows game over screen
            frmGameOver gameOver = new frmGameOver(true, score, "", this);
            gameOver.ShowDialog();
        }
    }
}
