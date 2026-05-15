namespace TaskPOEGameDevelopment
{
    public partial class Form1 : Form
    {

        public static string[] P1data = new string[3]; //Arrays to store each player's name, dragon type and dragon name
        public static string[] P2data = new string[3];

        public static int[] P1values = new int[4]; // Arrays to store each player's dragon stats (HP, Attack, Special, Block)
        public static int[] P2values = new int[4];

        const string ICE_Dragon_Name = "Ice Dragon"; // Dragon stat constants
        const int ICE_Dragon_Health = 30;
        const int ICE_Dragon_Attack = 4;
        const int ICE_Dragon_SpecialAttack = 9;
        const int ICE_Dragon_Block = 5;

        const string FIRE_Dragon_Name = "Fire Dragon";
        const int FIRE_Dragon_Health = 20;
        const int FIRE_Dragon_Attack = 5;
        const int FIRE_Dragon_SpecialAttack = 12;
        const int FIRE_Dragon_Block = 4;

        const string EARTH_Dragon_Name = "Earth Dragon";
        const int EARTH_Dragon_Health = 50;
        const int EARTH_Dragon_Attack = 2;
        const int EARTH_Dragon_SpecialAttack = 5;
        const int EARTH_Dragon_Block = 4;

        const string WIND_Dragon_Name = "Wind Dragon";
        const int WIND_Dragon_Health = 40;
        const int WIND_Dragon_Attack = 3;
        const int WIND_Dragon_SpecialAttack = 7;
        const int WIND_Dragon_Block = 5;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonStartGame.Enabled = false; // Start game button stays disabled until both players have saved

            // Makes the button transparent so the GIF behind it shows through

            ButtonStartGame.Parent = pictureBox1;
            ButtonStartGame.BackColor = Color.Transparent;
            ButtonStartGame.FlatStyle = FlatStyle.Flat;
            ButtonStartGame.FlatAppearance.BorderSize = 0;
            ButtonStartGame.Size = pictureBox1.Size;
            ButtonStartGame.Location = new Point(0, 0);
            pictureBox1.Image = Properties.Resources.FireGif;

        }

        private void SaveButton1_Click(object sender, EventArgs e)
        {
            int dragonChoice = 0; // Check which dragon Player 1 picked
            if (RadioFireDragon1.Checked) dragonChoice = 1;
            else if (RadioIceDragon1.Checked) dragonChoice = 2;
            else if (RadioEarthDragon1.Checked) dragonChoice = 3;
            else if (RadioWindDragon1.Checked) dragonChoice = 4;

            saveValues(P1data, P1values, textBox2.Text, textBox1.Text, dragonChoice);

            SaveButton1.Enabled = false;  // Disable save button so player cant save twice

            if (SaveButton1.Enabled == false && SaveButton2.Enabled == false)  // Only enable start game once both players have saved
            {
                ButtonStartGame.Enabled = true;
            }
        }

        private void SaveButton2_Click(object sender, EventArgs e)
        {
            int dragonChoice = 0;
            if (RadioFireDragon2.Checked) dragonChoice = 1;
            else if (RadioIceDragon2.Checked) dragonChoice = 2;
            else if (RadioEarthDragon2.Checked) dragonChoice = 3;
            else if (RadioWindDragon2.Checked) dragonChoice = 4;

            saveValues(P2data, P2values, textBox4.Text, textBox3.Text, dragonChoice);

            SaveButton2.Enabled = false;

            if (SaveButton1.Enabled == false && SaveButton2.Enabled == false)
            {
                ButtonStartGame.Enabled = true;
            }
        }

        // Generic method that works for both players - fills arrays based on dragon picked
        private void saveValues(string[] dataArray, int[] valuesArray, string playerName, string dragonName, int dragonChoice)
        {
            dataArray[0] = playerName;
            dataArray[2] = dragonName;

            if (dragonChoice == 1) // Assign the correct dragon stats based on the radio button choice
            {
                dataArray[1] = FIRE_Dragon_Name;
                valuesArray[0] = FIRE_Dragon_Health;
                valuesArray[1] = FIRE_Dragon_Attack;
                valuesArray[2] = FIRE_Dragon_SpecialAttack;
                valuesArray[3] = FIRE_Dragon_Block;

            }
            else if (dragonChoice == 2)
            {
                dataArray[1] = ICE_Dragon_Name;
                valuesArray[0] = ICE_Dragon_Health;
                valuesArray[1] = ICE_Dragon_Attack;
                valuesArray[2] = ICE_Dragon_SpecialAttack;
                valuesArray[3] = ICE_Dragon_Block;
            }
            else if (dragonChoice == 3)
            {
                dataArray[1] = EARTH_Dragon_Name;
                valuesArray[0] = EARTH_Dragon_Health;
                valuesArray[1] = EARTH_Dragon_Attack;
                valuesArray[2] = EARTH_Dragon_SpecialAttack;
                valuesArray[3] = EARTH_Dragon_Block;
            }
            else if (dragonChoice == 4)
            {
                dataArray[1] = WIND_Dragon_Name;
                valuesArray[0] = WIND_Dragon_Health;
                valuesArray[1] = WIND_Dragon_Attack;
                valuesArray[2] = WIND_Dragon_SpecialAttack;
                valuesArray[3] = WIND_Dragon_Block;
            }
        }
        private void RadioFireDragon1_CheckedChanged(object sender, EventArgs e) // Radio buttons change the dragon image when clicked
        {
            if (RadioFireDragon1.Checked)
            {
                DragonPicBox1.Image = Properties.Resources.FireDragon;
            }
        }

        private void RadioIceDragon1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioIceDragon1.Checked)
            {
                DragonPicBox1.Image = Properties.Resources.IceDragon;
            }
        }
        private void RadioEarthDragon1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioEarthDragon1.Checked)
            {
                DragonPicBox1.Image = Properties.Resources.EarthDragon;
            }
        }

        private void RadioWindDragon1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioWindDragon1.Checked)
            {
                DragonPicBox1.Image = Properties.Resources.WindDragon;
            }
        }

        private void RadioFireDragon2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioFireDragon2.Checked)
            {
                DragonPicBox2.Image = Properties.Resources.FireDragon;
            }
        }

        private void RadioIceDragon2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioIceDragon2.Checked)
            {
                DragonPicBox2.Image = Properties.Resources.IceDragon;
            }
        }

        private void RadioEarthDragon2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioEarthDragon2.Checked)
            {
                DragonPicBox2.Image = Properties.Resources.EarthDragon;
            }
        }
        private void RadioWindDragon2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioWindDragon2.Checked)
            {
                DragonPicBox2.Image = Properties.Resources.WindDragon;
            }
        }

        private void ButtonStartGame_Click_1(object sender, EventArgs e)
        {

            // Hide this form and pass both players data to the battle form
            this.Hide();
            BattleForm battleForm = new BattleForm();

            battleForm.ReceiveData(P1data, P2data, P1values, P2values);
            battleForm.Show();
        }
        //Referencing
        //MythologyArt, 2024. Red dragon, dragon, fantasy, reptile. [image online] Available at: <https://pixabay.com/illustrations/red-dragon-dragon-fantasy-reptile-8930685/\> [Accessed 10 April 2026].
        //AIArtKingdom, 2024. Dragon, fantasy art, fantasy. [image online] Available at: <https://pixabay.com/illustrations/dragon-fantasy-art-fantasy-8840975/\> [Accessed 10 April 2026].
        //jcoope12, 2024. Ai generated, white dragon, dragon. [image online] Available at: <https://pixabay.com/illustrations/ai-generated-white-dragon-dragon-9039314/\> [Accessed 10 April 2026].
        //jcoope12, 2024. Ai generated, dragon, baby dragon. [image online] Available at: <https://pixabay.com/illustrations/ai-generated-dragon-baby-dragon-8491360/\> [Accessed 10 April 2026].
        //Pixabay, 2024. Fire, flame, burn. [video online] Available at: <https://pixabay.com/videos/fire-flame-burn-hot-koster-sparks-219971/\> [Accessed 15 May 2026].
    }
}