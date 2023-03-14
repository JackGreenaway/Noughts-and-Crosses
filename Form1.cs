namespace TicTacToe
{
    public partial class Window : Form
    {
        // control the symbols for player and AI
        public enum Player
        {
            X, O
        }

        Player currentPlayer; // calling the player class

        List<Button> buttons; // creating a list of buttons
        Random rand = new Random(); // get a random number for the AI
        int PlayerWin = 0;
        int AIwin = 0;

        public Window()
        {
            InitializeComponent();
            resetGame();
        }

        private void PlayerMove(object sender, EventArgs e)
        {
            var Button = (Button)sender;
            currentPlayer = Player.X;
            Button.Text = currentPlayer.ToString(); // change the button of the player to X
            Button.Enabled = false; // disable the button from being clicked again
            Button.BackColor = System.Drawing.Color.GreenYellow; // set the button to cyan
            buttons.Remove(Button); // remove that button from list
            Check(); // check for win
            AI_timer.Start(); // start the AI timer

        }

        private void AImove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count); // generate a random number from the buttons available
                buttons[index].Enabled = false; // disable button

                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString(); // show O on the button
                buttons[index].BackColor = System.Drawing.Color.Salmon; // change the background of the button dark salmon colour
                buttons.RemoveAt(index); // remove that button from the list
                Check(); // check if the AI won anything
                AI_timer.Stop(); // stop the AI timer
            }
        }

        private void RestartGame(object sender, EventArgs e)
        {
            resetGame();
        }

        private void loadbuttons()
        {
            buttons = new List<Button> { button3, button1, button2, button5, button6, button4, button8, button9, button7 };
        }

        private void resetGame()
        {
            foreach (Control X in this.Controls)
            {
                if (X is Button && X.Tag == "play")
                {
                    ((Button)X).Enabled = true; // change them all back to enabled or clickable
                    ((Button)X).Text = "?"; // set the text to question mark
                    ((Button)X).BackColor = default(Color); // change the background colour to default button colors    
                }
            }
            loadbuttons();
        }

        private void Check()
        {
            // check for if player has won 
            if (// horizontal
                button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
                button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
                // vertical
                button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
                button2.Text == "X" && button5.Text == "X" && button8.Text == "X" ||
                button3.Text == "X" && button6.Text == "X" && button9.Text == "X" ||
                // diagonal
                button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
                button3.Text == "X" && button5.Text == "X" && button7.Text == "X"
                )
            {
                AI_timer.Stop();
                MessageBox.Show("Player Wins");
                PlayerWin++; // add a win to the players tally
                label1.Text = "Player Wins - " + PlayerWin; // update the text
                resetGame();
            }

            // check for if AI has won 
            else if (// horizontal
                button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
                button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
                // vertical
                button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
                button2.Text == "O" && button5.Text == "O" && button8.Text == "O" ||
                button3.Text == "O" && button6.Text == "O" && button9.Text == "O" ||
                // diagonal
                button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
                button3.Text == "O" && button5.Text == "O" && button7.Text == "O"
                )
            {
                AI_timer.Stop();
                MessageBox.Show("AI Wins");
                AIwin++; // add a win to the players tally
                label2.Text = "AI Wins - " + AIwin; // update the text
                resetGame();
            }
        }

        private void Hard_Reset(object sender, EventArgs e)
        {
            label1.Text = "Player Wins";
            label2.Text = "AI Wins";
            resetGame();
        }
    }
}
