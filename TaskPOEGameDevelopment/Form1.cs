namespace TaskPOEGameDevelopment
{
    public partial class Form1 : Form
    {

        public static string[] P1data = new string[2];
        public static string[] P2data = new string[2];

        public static int[] P1values = new int[4];
        public static int[] P2values = new int[4];

        const string ICE_Dragon_Name = "Ice Dragon";
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
            ButtonStartGame.Enabled = false;
        }

        private void SaveButton1_Click(object sender, EventArgs e)
        {
            int dragonChoice = 0;
            if (RadioFireDragon1.Checked) dragonChoice = 1;
            else if (RadioIceDragon1.Checked) dragonChoice = 2;
            else if (RadioEarthDragon1.Checked) dragonChoice = 3;
            else if (RadioWindDragon1.Checked) dragonChoice = 4;

            saveValues(P1data, P1values, textBox2.Text, dragonChoice);

            SaveButton1.Enabled = false;

            if(SaveButton1.Enabled == false && SaveButton2.Enabled == false)
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

            saveValues(P2data, P2values, textBox4.Text, dragonChoice);

            SaveButton2.Enabled = false;

            if(SaveButton1.Enabled == false && SaveButton2.Enabled == false)
            {
                ButtonStartGame.Enabled = true;
            }
        }
        private void saveValues(string[] dataArray, int[] valuesArray, string playerName, int dragonChoice)
        {
            dataArray[0] = playerName;

            if (dragonChoice == 1)
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

        private void ButtonStartGame_Click(object sender, EventArgs e)
        {
            //once clicked open up second form and hide this form
            this.Hide();
            BattleForm battleForm = new BattleForm();
            battleForm.Show();

        }
        //Referencing
        //MythologyArt, 2024. Red dragon, dragon, fantasy, reptile. [image online] Available at: <https://pixabay.com/illustrations/red-dragon-dragon-fantasy-reptile-8930685/\> [Accessed 10 April 2026].
        //AIArtKingdom, 2024. Dragon, fantasy art, fantasy. [image online] Available at: <https://pixabay.com/illustrations/dragon-fantasy-art-fantasy-8840975/\> [Accessed 10 April 2026].
        //jcoope12, 2024. Ai generated, white dragon, dragon. [image online] Available at: <https://pixabay.com/illustrations/ai-generated-white-dragon-dragon-9039314/\> [Accessed 10 April 2026].
        //jcoope12, 2024. Ai generated, dragon, baby dragon. [image online] Available at: <https://pixabay.com/illustrations/ai-generated-dragon-baby-dragon-8491360/\> [Accessed 10 April 2026].
    }
}
