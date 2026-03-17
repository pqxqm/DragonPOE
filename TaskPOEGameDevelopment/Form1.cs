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
    }
}
