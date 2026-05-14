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

        public void ReceiveData(string[] p1Data, string[] p2Data, int[] p1Values, int[] p2Values)
        {
            P1data = p1Data;
            P2data = p2Data;
            P1Values = p1Values;
            P2Values = p2Values;
        }

        private int randomRoll()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }

        private int takeInitiative()
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

        private void setupTurnBase(int currentPlayer)
        {
            if (currentPlayer == 1)
            {
                BattleLogMainName.Text = P1data[0];
                BattleLogMainDragonName.Text = P1data[1];
                BattleLogMainHP.Text = P1Values[0].ToString();
                BattleLogOppName.Text = P2data[0];
                BattleLogOppDragonName.Text = P2data[1];
                BattleLogOppHP.Text = P2Values[0].ToString();



            }
            else
            {
                BattleLogMainName.Text = P2data[0];
                BattleLogMainDragonName.Text = P2data[1];
                BattleLogMainHP.Text = P2Values[0].ToString();
                BattleLogOppName.Text = P1data[0];
                BattleLogOppDragonName.Text = P1data[1];
                BattleLogOppHP.Text = P1Values[0].ToString();
            }
        }

        private void BattleForm_Load(object sender, EventArgs e)
        {
            int currentPlayer = takeInitiative();
            setupTurnBase(currentPlayer);
        }

       private void switchPlayer()

        {
            if (currentPlayer == 1)
            {
                currentPlayer = 2;
            }
            else
            {
                currentPlayer = 1;
            }
        }
       
           private void Block()
             
           if(currentPlayer ==1)
            
            {
                P1Blocking = true;
                BattleLog.Text = $"{P1data[0]} is blocking!";
            }
            else
            {
                P2Blocking = true;
                BattleLog.Text = $"{P2data[0]} is blocking!";
            }
            
            private void Attack()
             { 
             if(currentPlayer ==1)
                {
                 int damage= P1Values[1];
        if (P2Blocking)
        {
            damage = damage - P2Values(1);
            if (damage > 0)
            {
                damage = 0;
            }
            P2Blocking = false;
        }
        P2Value[0] = damage;
        Battlog.Text= $"{P1data[0]} attacks for {damage} damage!";
                }
             else
             {
                 int damage = P2Values[1];
                 if (P1Blocking)
                 {
                     damage = damage - P1Values(1);
                     if (damage > 0)
                     {
                         damage = 0;
                     }
                     P1Blocking = false;
                 }
                 P1Values[0] = damage;
                 BattleLog.Text = $"{P2data[0]} attacks for {damage} damage!";
             }
                private void  SpecialAttack()
                {
                    if (currentPlayer == 1)
                    {
                        int damage = P1Values[2];
                        if (P2Blocking)
                        {
                            damage = damage - P2Values[1];
                            if (damage > 0)
                            {
                                damage = 0;
                            }
                            P2Blocking = false;
                        }
                        P2Values[0] = damage;
                        BattleLog.Text = $"{P1data[0]} uses special attack for {damage} damage!";
                    }
                    else
                    {
                        int damage = P2Values[2];
                        if (P1Blocking)
                        {
                            damage = damage - P1Values[1];
                            if (damage > 0)
                            {
                                damage = 0;
                            }
                            P1Blocking = false;
                        }
                        P1Values[0] = damage;
                        BattleLog.Text = $"{P2data[0]} uses special attack for {damage} damage!";

        //Referencing
        //Piyush S, 2026. Intense flames captured in detailed close-up. [image online] Available at: <https://www.pexels.com/photo/intense-flames-captured-in-detailed-close-up-36677596/\> [Accessed 10 April 2026].
    }
}
