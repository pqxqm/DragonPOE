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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleForm));
            PlayerNameLabel = new Label();
            DragonNameLabel = new Label();
            DragonHPLabel1 = new Label();
            AttackButton1 = new Button();
            SpecialAttackButton1 = new Button();
            BlockButton1 = new Button();
            BattleLogGroupBox = new GroupBox();
            OpponentGroupBox1 = new GroupBox();
            OpponentHPLabel = new Label();
            OpponentDragonLabel = new Label();
            OpponentNameLabel = new Label();
            BattleLogTextBox = new TextBox();
            BattleLogGroupBox.SuspendLayout();
            OpponentGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // PlayerNameLabel
            // 
            resources.ApplyResources(PlayerNameLabel, "PlayerNameLabel");
            PlayerNameLabel.Name = "PlayerNameLabel";
            // 
            // DragonNameLabel
            // 
            resources.ApplyResources(DragonNameLabel, "DragonNameLabel");
            DragonNameLabel.Name = "DragonNameLabel";
            // 
            // DragonHPLabel1
            // 
            resources.ApplyResources(DragonHPLabel1, "DragonHPLabel1");
            DragonHPLabel1.Name = "DragonHPLabel1";
            // 
            // AttackButton1
            // 
            resources.ApplyResources(AttackButton1, "AttackButton1");
            AttackButton1.Name = "AttackButton1";
            AttackButton1.UseVisualStyleBackColor = true;
            // 
            // SpecialAttackButton1
            // 
            resources.ApplyResources(SpecialAttackButton1, "SpecialAttackButton1");
            SpecialAttackButton1.Name = "SpecialAttackButton1";
            SpecialAttackButton1.UseVisualStyleBackColor = true;
            // 
            // BlockButton1
            // 
            resources.ApplyResources(BlockButton1, "BlockButton1");
            BlockButton1.Name = "BlockButton1";
            BlockButton1.UseVisualStyleBackColor = true;
            // 
            // BattleLogGroupBox
            // 
            BattleLogGroupBox.Controls.Add(BattleLogTextBox);
            resources.ApplyResources(BattleLogGroupBox, "BattleLogGroupBox");
            BattleLogGroupBox.Name = "BattleLogGroupBox";
            BattleLogGroupBox.TabStop = false;
            // 
            // OpponentGroupBox1
            // 
            OpponentGroupBox1.Controls.Add(OpponentHPLabel);
            OpponentGroupBox1.Controls.Add(OpponentDragonLabel);
            OpponentGroupBox1.Controls.Add(OpponentNameLabel);
            resources.ApplyResources(OpponentGroupBox1, "OpponentGroupBox1");
            OpponentGroupBox1.Name = "OpponentGroupBox1";
            OpponentGroupBox1.TabStop = false;
            // 
            // OpponentHPLabel
            // 
            resources.ApplyResources(OpponentHPLabel, "OpponentHPLabel");
            OpponentHPLabel.Name = "OpponentHPLabel";
            // 
            // OpponentDragonLabel
            // 
            resources.ApplyResources(OpponentDragonLabel, "OpponentDragonLabel");
            OpponentDragonLabel.Name = "OpponentDragonLabel";
            // 
            // OpponentNameLabel
            // 
            resources.ApplyResources(OpponentNameLabel, "OpponentNameLabel");
            OpponentNameLabel.Name = "OpponentNameLabel";
            // 
            // BattleLogTextBox
            // 
            resources.ApplyResources(BattleLogTextBox, "BattleLogTextBox");
            BattleLogTextBox.Name = "BattleLogTextBox";
            // 
            // BattleForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OpponentGroupBox1);
            Controls.Add(BattleLogGroupBox);
            Controls.Add(BlockButton1);
            Controls.Add(SpecialAttackButton1);
            Controls.Add(AttackButton1);
            Controls.Add(DragonHPLabel1);
            Controls.Add(DragonNameLabel);
            Controls.Add(PlayerNameLabel);
            Name = "BattleForm";
            Load += BattleForm_Load;
            BattleLogGroupBox.ResumeLayout(false);
            BattleLogGroupBox.PerformLayout();
            OpponentGroupBox1.ResumeLayout(false);
            OpponentGroupBox1.PerformLayout();
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
        private GroupBox OpponentGroupBox1;
        private Label OpponentHPLabel;
        private Label OpponentDragonLabel;
        private Label OpponentNameLabel;
        private TextBox BattleLogTextBox;
    }
}
