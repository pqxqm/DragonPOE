using System.Drawing.Text;
using System.Media;

namespace TaskPOEGameDevelopment
{
    public partial class BattleForm : Form
    {
        string[] P1data;
        string[] P2data;
        int[] P1Values;
        int[] P2Values;
        int currentPlayer;
        bool P1Blocking = false;
        bool P2Blocking = false;

        public BattleForm()
        {
            InitializeComponent();
        }

        // Receives the player arrays from Form1
        public void ReceiveData(string[] p1Data, string[] p2Data, int[] p1Values, int[] p2Values)
        {
            P1data = p1Data;
            P2data = p2Data;
            P1Values = p1Values;
            P2Values = p2Values;
        }

        // Returns a random number between 1 and 6
        private int randomRoll()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        private int takeInitiative() // Both players roll until they get different results - higher roll goes first
        {
            int roll1 = 0;
            int roll2 = 0;

            while (roll1 == roll2)
            {
                roll1 = randomRoll();
                roll2 = randomRoll();

            }

            if (roll1 > roll2)
            {
                return 1;
            }
            else
            {
                return 2;
            }

        }

        private void setupTurnBase(int currentPlayer)  // Updates all the labels on the form to show the current and opponent player info
        {
            if (currentPlayer == 1)
            {
                this.Text = $"{P1data[0]}'s Turn";

                PlayerNameLabel.Text = P1data[0];
                DragonType1.Text = P1data[1];
                DragonNameLabel.Text = P1data[2];
                DragonHPLabel1.Text = $"HP: {P1Values[0]}";

                OpponentDragonType.Text = P2data[1];
                OpponentNameLabel.Text = P2data[0];
                OpponentDragonLabel.Text = P2data[2];
                OpponentHPLabel.Text = $"HP: {P2Values[0]}";
            }
            else
            {
                this.Text = $"{P2data[0]}'s Turn";

                PlayerNameLabel.Text = P2data[0];
                DragonType1.Text = P2data[1];
                DragonNameLabel.Text = P2data[2];
                DragonHPLabel1.Text = $"HP: {P2Values[0]}";

                OpponentNameLabel.Text = P1data[0];
                OpponentDragonType.Text = P1data[1];
                OpponentDragonLabel.Text = P1data[2];
                OpponentHPLabel.Text = $"HP: {P1Values[0]}";
            }
        }

        private void BattleForm_Load(object sender, EventArgs e)
        {
            // Roll for initiative and set up the form for whoever goes first
            currentPlayer = takeInitiative();
            setupTurnBase(currentPlayer);
            BattleLogTextBox.ScrollBars = ScrollBars.Vertical;

            // Set the background GIF and stretch it to fill the form
            pictureBoxBackground.Image = Properties.Resources.NatureBackGround;
            pictureBoxBackground.Dock = DockStyle.Fill;

            // Set all controls as children of the background so they show over the GIF
            PlayerNameLabel.Parent = pictureBoxBackground;
            DragonType1.Parent = pictureBoxBackground;
            DragonNameLabel.Parent = pictureBoxBackground;
            DragonHPLabel1.Parent = pictureBoxBackground;
            OpponentNameLabel.Parent = pictureBoxBackground;
            OpponentDragonType.Parent = pictureBoxBackground;
            OpponentDragonLabel.Parent = pictureBoxBackground;
            OpponentHPLabel.Parent = pictureBoxBackground;
            BattleLogGroupBox.Parent = pictureBoxBackground;
            OpponentLabelOne.Parent = pictureBoxBackground;
            CurrentPlayerLabelOne.Parent = pictureBoxBackground;

            timer1.Interval = 1500;
            ActionPicBox.Visible = false;

        }

        private void switchPlayer() // Switches the current player and refreshes the form

        {
            if (currentPlayer == 1)
            {
                currentPlayer = 2;
            }
            else
            {
                currentPlayer = 1;
            }
            setupTurnBase(currentPlayer);
        }

        private void Block()
        {
            // Show block GIF for 1.5 seconds
            ActionPicBox.Image = Properties.Resources.Block;
            ActionPicBox.Visible = true;
            timer1.Start();

            if (currentPlayer == 1)

            {
                P1Blocking = true;
                BattleLogTextBox.Text += $"\n{P1data[0]} is blocking!\r\n";
                BattleLogTextBox.Text += "***************************\r\n";
            }
            else
            {
                P2Blocking = true;
                BattleLogTextBox.Text += $"\n{P2data[0]} is blocking!\r\n";
                BattleLogTextBox.Text += "***************************\r\n";
            }

            BattleLogTextBox.SelectionStart = BattleLogTextBox.Text.Length;
            BattleLogTextBox.Focus();
            BattleLogTextBox.ScrollToCaret();
            switchPlayer();
        }
        private void Attack()
        {
            // Show block GIF for 1.5 seconds
            ActionPicBox.Image = Properties.Resources.AttackGif;
            ActionPicBox.Visible = true;
            timer1.Start();

            if (currentPlayer == 1)
            {
                int damage = P1Values[1];
                // If opponent is blocking, reduce damage by their block value
                if (P2Blocking == true)
                {
                    damage = damage - P2Values[3];
                    if (damage < 0) damage = 0;
                    P2Blocking = false;

                }
                P2Values[0] -= damage;
                BattleLogTextBox.Text += $"\n{P1data[0]} attacks for {damage} damage!\r\n";
                BattleLogTextBox.Text += "***************************\r\n";
            }
            else
            {
                int damage = P2Values[1];
                if (P1Blocking == true)
                {
                    damage = damage - P1Values[3];
                    if (damage < 0) damage = 0;
                    P1Blocking = false;

                }
                P1Values[0] -= damage;
                BattleLogTextBox.Text += $"\n{P2data[0]} attacks for {damage} damage!\r\n";
                BattleLogTextBox.Text += "***************************\r\n";
            }

            BattleLogTextBox.SelectionStart = BattleLogTextBox.Text.Length;
            BattleLogTextBox.Focus();
            BattleLogTextBox.ScrollToCaret();

            checkWinner();
            switchPlayer();
        }
        private void specialAttack()
        {
            // Show special attack GIF for 1.5 seconds
            ActionPicBox.Image = Properties.Resources.SpecialAttack;
            ActionPicBox.Visible = true;
            timer1.Start();

            if (currentPlayer == 1)
            {
                // Special attack uses index 2 instead of 1
                int damage = P1Values[2];
                if (P2Blocking == true)
                {
                    damage = damage - P2Values[3];
                    if (damage < 0) damage = 0;
                    P2Blocking = false;

                }
                P2Values[0] -= damage;
                BattleLogTextBox.Text += $"\n{P1data[0]} uses their special attack for {damage} damage!\r\n";
                BattleLogTextBox.Text += "***************************\r\n";
            }
            else
            {
                int damage = P2Values[2];
                if (P1Blocking == true)
                {
                    damage = damage - P1Values[3];
                    if (damage < 0) damage = 0;
                    P1Blocking = false;

                }
                P1Values[0] -= damage;
                BattleLogTextBox.Text += $"\n{P2data[0]} uses their special attack for {damage} damage!\r\n";
                BattleLogTextBox.Text += "***************************\r\n";
            }

            BattleLogTextBox.SelectionStart = BattleLogTextBox.Text.Length;
            BattleLogTextBox.Focus();
            BattleLogTextBox.ScrollToCaret();

            checkWinner();
            switchPlayer();
        }


        // Disables all action buttons when the game is over
        private void disableButtons()
        {
            AttackButton1.Enabled = false;
            SpecialAttackButton1.Enabled = false;
            BlockButton1.Enabled = false;
        }

        // Checks if either player has run out of HP
        private void checkWinner()
        {
            if (P1Values[0] <= 0)
            {
                BattleLogTextBox.Text += $"\n {P1data[0]}'s dragon has been defeated!\r\n";
                BattleLogTextBox.Text += "***************************\r\n";
                BattleLogTextBox.Text += $"\n {P2data[0]} wins the battle!\r\n";
                BattleLogTextBox.Text += "***************************\r\n";
                disableButtons();
            }
            else if (P2Values[0] <= 0)
            {
                BattleLogTextBox.Text += $"\n {P2data[0]}'s dragon has been defeated!\r\n";
                BattleLogTextBox.Text += "***************************\r\n";
                BattleLogTextBox.Text += $"\n {P1data[0]} wins the battle!\r\n";
                BattleLogTextBox.Text += "***************************\r\n";
                disableButtons();
            }
        }

        private void AttackButton1_Click(object sender, EventArgs e)
        {
            Attack();
        }

        private void SpecialAttackButton1_Click(object sender, EventArgs e)
        {
            specialAttack();
        }

        private void BlockButton1_Click(object sender, EventArgs e)
        {
            Block();
        }

        // Hides the action GIF after 1.5 seconds
        private void timer1_Tick(object sender, EventArgs e)
        {
            ActionPicBox.Visible = false;
            timer1.Stop();
        }
    }
    //Referencing
    //Piyush S, 2026. Intense flames captured in detailed close-up. [image online] Available at: <https://www.pexels.com/photo/intense-flames-captured-in-detailed-close-up-36677596/\> [Accessed 10 April 2026].
    //Pixabay, 2024. Nature, lake, butterfly. [gif online] Available at: <https://pixabay.com/gifs/nature-lake-butterfly-fauna-3481/\> [Accessed 15 May 2026].
    //Pixabay, 2024. Centurion, Roman, Rome. [video online] Available at: <https://pixabay.com/videos/centurion-roman-rome-soldier-300076/\> [Accessed 15 May 2026].
    //Pixabay, 2024. Centurion, Roman, Rome. [video online] Available at: <https://pixabay.com/videos/centurion-roman-rome-soldier-300063/\> [Accessed 15 May 2026].
    //Pixabay, 2024. Centurion, Roman, Rome. [video online] Available at: <https://pixabay.com/videos/centurion-roman-rome-soldier-300042/\> [Accessed 15 May 2026].
}