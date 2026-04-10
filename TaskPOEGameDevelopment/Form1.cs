namespace TaskPOEGameDevelopment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
