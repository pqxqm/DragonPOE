namespace TaskPOEGameDevelopment
{
    partial class BattleForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleForm));
            PlayerNameLabel = new Label();
            DragonNameLabel = new Label();
            DragonHPLabel1 = new Label();
            AttackButton1 = new Button();
            SpecialAttackButton1 = new Button();
            BlockButton1 = new Button();
            BattleLogGroupBox = new GroupBox();
            BattleLogTextBox = new TextBox();
            OpponentNameLabel = new Label();
            OpponentDragonLabel = new Label();
            OpponentHPLabel = new Label();
            OpponentDragonType = new Label();
            DragonType1 = new Label();
            pictureBoxBackground = new PictureBox();
            OpponentLabelOne = new Label();
            CurrentPlayerLabelOne = new Label();
            ActionPicBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            BattleLogGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ActionPicBox).BeginInit();
            SuspendLayout();
            // 
            // PlayerNameLabel
            // 
            PlayerNameLabel.BackColor = Color.Transparent;
            resources.ApplyResources(PlayerNameLabel, "PlayerNameLabel");
            PlayerNameLabel.ForeColor = Color.Gold;
            PlayerNameLabel.Name = "PlayerNameLabel";
            // 
            // DragonNameLabel
            // 
            DragonNameLabel.BackColor = Color.Transparent;
            resources.ApplyResources(DragonNameLabel, "DragonNameLabel");
            DragonNameLabel.ForeColor = Color.Gold;
            DragonNameLabel.Name = "DragonNameLabel";
            // 
            // DragonHPLabel1
            // 
            DragonHPLabel1.BackColor = Color.Transparent;
            resources.ApplyResources(DragonHPLabel1, "DragonHPLabel1");
            DragonHPLabel1.ForeColor = Color.Lime;
            DragonHPLabel1.Name = "DragonHPLabel1";
            // 
            // AttackButton1
            // 
            AttackButton1.BackColor = Color.DarkRed;
            resources.ApplyResources(AttackButton1, "AttackButton1");
            AttackButton1.ForeColor = Color.Gold;
            AttackButton1.Name = "AttackButton1";
            AttackButton1.UseVisualStyleBackColor = false;
            AttackButton1.Click += AttackButton1_Click;
            // 
            // SpecialAttackButton1
            // 
            SpecialAttackButton1.BackColor = Color.Indigo;
            resources.ApplyResources(SpecialAttackButton1, "SpecialAttackButton1");
            SpecialAttackButton1.ForeColor = Color.Aqua;
            SpecialAttackButton1.Name = "SpecialAttackButton1";
            SpecialAttackButton1.UseVisualStyleBackColor = false;
            SpecialAttackButton1.Click += SpecialAttackButton1_Click;
            // 
            // BlockButton1
            // 
            BlockButton1.BackColor = Color.DarkSlateGray;
            resources.ApplyResources(BlockButton1, "BlockButton1");
            BlockButton1.ForeColor = Color.Silver;
            BlockButton1.Name = "BlockButton1";
            BlockButton1.UseVisualStyleBackColor = false;
            BlockButton1.Click += BlockButton1_Click;
            // 
            // BattleLogGroupBox
            // 
            BattleLogGroupBox.BackColor = Color.DarkRed;
            BattleLogGroupBox.Controls.Add(BattleLogTextBox);
            resources.ApplyResources(BattleLogGroupBox, "BattleLogGroupBox");
            BattleLogGroupBox.ForeColor = Color.Gold;
            BattleLogGroupBox.Name = "BattleLogGroupBox";
            BattleLogGroupBox.TabStop = false;
            // 
            // BattleLogTextBox
            // 
            BattleLogTextBox.BackColor = Color.FromArgb(26, 10, 0);
            resources.ApplyResources(BattleLogTextBox, "BattleLogTextBox");
            BattleLogTextBox.ForeColor = Color.Gold;
            BattleLogTextBox.Name = "BattleLogTextBox";
            BattleLogTextBox.ReadOnly = true;
            // 
            // OpponentNameLabel
            // 
            OpponentNameLabel.BackColor = Color.Transparent;
            resources.ApplyResources(OpponentNameLabel, "OpponentNameLabel");
            OpponentNameLabel.ForeColor = Color.Gold;
            OpponentNameLabel.Name = "OpponentNameLabel";
            // 
            // OpponentDragonLabel
            // 
            OpponentDragonLabel.BackColor = Color.Transparent;
            resources.ApplyResources(OpponentDragonLabel, "OpponentDragonLabel");
            OpponentDragonLabel.ForeColor = Color.Gold;
            OpponentDragonLabel.Name = "OpponentDragonLabel";
            // 
            // OpponentHPLabel
            // 
            OpponentHPLabel.BackColor = Color.Transparent;
            resources.ApplyResources(OpponentHPLabel, "OpponentHPLabel");
            OpponentHPLabel.ForeColor = Color.Lime;
            OpponentHPLabel.Name = "OpponentHPLabel";
            // 
            // OpponentDragonType
            // 
            OpponentDragonType.BackColor = Color.Transparent;
            resources.ApplyResources(OpponentDragonType, "OpponentDragonType");
            OpponentDragonType.ForeColor = Color.OrangeRed;
            OpponentDragonType.Name = "OpponentDragonType";
            // 
            // DragonType1
            // 
            DragonType1.BackColor = Color.Transparent;
            resources.ApplyResources(DragonType1, "DragonType1");
            DragonType1.ForeColor = Color.OrangeRed;
            DragonType1.Name = "DragonType1";
            // 
            // pictureBoxBackground
            // 
            resources.ApplyResources(pictureBoxBackground, "pictureBoxBackground");
            pictureBoxBackground.Name = "pictureBoxBackground";
            pictureBoxBackground.TabStop = false;
            // 
            // OpponentLabelOne
            // 
            resources.ApplyResources(OpponentLabelOne, "OpponentLabelOne");
            OpponentLabelOne.BackColor = Color.Transparent;
            OpponentLabelOne.ForeColor = Color.OrangeRed;
            OpponentLabelOne.Name = "OpponentLabelOne";
            // 
            // CurrentPlayerLabelOne
            // 
            resources.ApplyResources(CurrentPlayerLabelOne, "CurrentPlayerLabelOne");
            CurrentPlayerLabelOne.BackColor = Color.Transparent;
            CurrentPlayerLabelOne.ForeColor = Color.OrangeRed;
            CurrentPlayerLabelOne.Name = "CurrentPlayerLabelOne";
            // 
            // ActionPicBox
            // 
            ActionPicBox.BackColor = Color.Transparent;
            resources.ApplyResources(ActionPicBox, "ActionPicBox");
            ActionPicBox.Name = "ActionPicBox";
            ActionPicBox.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // BattleForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            Controls.Add(ActionPicBox);
            Controls.Add(CurrentPlayerLabelOne);
            Controls.Add(OpponentLabelOne);
            Controls.Add(OpponentHPLabel);
            Controls.Add(OpponentDragonType);
            Controls.Add(DragonType1);
            Controls.Add(OpponentDragonLabel);
            Controls.Add(BattleLogGroupBox);
            Controls.Add(OpponentNameLabel);
            Controls.Add(BlockButton1);
            Controls.Add(AttackButton1);
            Controls.Add(SpecialAttackButton1);
            Controls.Add(DragonHPLabel1);
            Controls.Add(DragonNameLabel);
            Controls.Add(PlayerNameLabel);
            Controls.Add(pictureBoxBackground);
            Name = "BattleForm";
            Load += BattleForm_Load;
            BattleLogGroupBox.ResumeLayout(false);
            BattleLogGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)ActionPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PlayerNameLabel;
        private Label DragonNameLabel;
        private Label DragonHPLabel1;
        private Button AttackButton1;
        private Button SpecialAttackButton1;
        private Button BlockButton1;
        private GroupBox BattleLogGroupBox;
        private TextBox BattleLogTextBox;
        private Label OpponentNameLabel;
        private Label OpponentDragonLabel;
        private Label OpponentHPLabel;
        private Label OpponentDragonType;
        private Label DragonType1;
        private PictureBox pictureBoxBackground;
        private Label OpponentLabelOne;
        private Label CurrentPlayerLabelOne;
        private PictureBox ActionPicBox;
        private System.Windows.Forms.Timer timer1;
    }
}
