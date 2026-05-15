namespace TaskPOEGameDevelopment
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBoxPlayer1 = new GroupBox();
            SaveButton1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            GroupBoxDragonType1 = new GroupBox();
            DragonPicBox1 = new PictureBox();
            RadioEarthDragon1 = new RadioButton();
            RadioWindDragon1 = new RadioButton();
            RadioIceDragon1 = new RadioButton();
            RadioFireDragon1 = new RadioButton();
            LabelDragonName1 = new Label();
            LabelPlayerName1 = new Label();
            groupBoxPlayer2 = new GroupBox();
            SaveButton2 = new Button();
            GroupBoxDragonType2 = new GroupBox();
            DragonPicBox2 = new PictureBox();
            RadioEarthDragon2 = new RadioButton();
            RadioWindDragon2 = new RadioButton();
            RadioIceDragon2 = new RadioButton();
            RadioFireDragon2 = new RadioButton();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            LabelDragonName2 = new Label();
            LabelPlayerName2 = new Label();
            LabelDragonStats = new Label();
            IceDragonInfoLabel = new Label();
            FireDragonInfoLabel = new Label();
            EarthDragonInfoLabel = new Label();
            WindDragonInfoLabel = new Label();
            pictureBox1 = new PictureBox();
            ButtonStartGame = new Button();
            groupBoxPlayer1.SuspendLayout();
            GroupBoxDragonType1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DragonPicBox1).BeginInit();
            groupBoxPlayer2.SuspendLayout();
            GroupBoxDragonType2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DragonPicBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxPlayer1
            // 
            groupBoxPlayer1.Controls.Add(SaveButton1);
            groupBoxPlayer1.Controls.Add(textBox1);
            groupBoxPlayer1.Controls.Add(textBox2);
            groupBoxPlayer1.Controls.Add(GroupBoxDragonType1);
            groupBoxPlayer1.Controls.Add(LabelDragonName1);
            groupBoxPlayer1.Controls.Add(LabelPlayerName1);
            groupBoxPlayer1.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold | FontStyle.Italic);
            groupBoxPlayer1.Location = new Point(12, 12);
            groupBoxPlayer1.Name = "groupBoxPlayer1";
            groupBoxPlayer1.Size = new Size(454, 381);
            groupBoxPlayer1.TabIndex = 0;
            groupBoxPlayer1.TabStop = false;
            groupBoxPlayer1.Text = "Player 1";
            // 
            // SaveButton1
            // 
            SaveButton1.BackColor = Color.DarkSlateGray;
            SaveButton1.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SaveButton1.ForeColor = Color.OrangeRed;
            SaveButton1.Location = new Point(39, 303);
            SaveButton1.Name = "SaveButton1";
            SaveButton1.Size = new Size(366, 33);
            SaveButton1.TabIndex = 12;
            SaveButton1.Text = "SAVE";
            SaveButton1.UseVisualStyleBackColor = false;
            SaveButton1.Click += SaveButton1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 27);
            textBox2.TabIndex = 10;
            // 
            // GroupBoxDragonType1
            // 
            GroupBoxDragonType1.Controls.Add(DragonPicBox1);
            GroupBoxDragonType1.Controls.Add(RadioEarthDragon1);
            GroupBoxDragonType1.Controls.Add(RadioWindDragon1);
            GroupBoxDragonType1.Controls.Add(RadioIceDragon1);
            GroupBoxDragonType1.Controls.Add(RadioFireDragon1);
            GroupBoxDragonType1.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            GroupBoxDragonType1.Location = new Point(39, 122);
            GroupBoxDragonType1.Name = "GroupBoxDragonType1";
            GroupBoxDragonType1.Size = new Size(366, 166);
            GroupBoxDragonType1.TabIndex = 9;
            GroupBoxDragonType1.TabStop = false;
            GroupBoxDragonType1.Text = "Dragon Type";
            // 
            // DragonPicBox1
            // 
            DragonPicBox1.Location = new Point(198, 27);
            DragonPicBox1.Margin = new Padding(3, 2, 3, 2);
            DragonPicBox1.Name = "DragonPicBox1";
            DragonPicBox1.Size = new Size(156, 112);
            DragonPicBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            DragonPicBox1.TabIndex = 8;
            DragonPicBox1.TabStop = false;
            // 
            // RadioEarthDragon1
            // 
            RadioEarthDragon1.AutoSize = true;
            RadioEarthDragon1.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RadioEarthDragon1.ForeColor = Color.FromArgb(128, 64, 0);
            RadioEarthDragon1.Location = new Point(19, 110);
            RadioEarthDragon1.Name = "RadioEarthDragon1";
            RadioEarthDragon1.Size = new Size(128, 26);
            RadioEarthDragon1.TabIndex = 3;
            RadioEarthDragon1.TabStop = true;
            RadioEarthDragon1.Text = "Earth Dragon";
            RadioEarthDragon1.UseVisualStyleBackColor = true;
            RadioEarthDragon1.CheckedChanged += RadioEarthDragon1_CheckedChanged;
            // 
            // RadioWindDragon1
            // 
            RadioWindDragon1.AutoSize = true;
            RadioWindDragon1.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic);
            RadioWindDragon1.ForeColor = Color.FromArgb(192, 255, 255);
            RadioWindDragon1.Location = new Point(19, 85);
            RadioWindDragon1.Name = "RadioWindDragon1";
            RadioWindDragon1.Size = new Size(130, 26);
            RadioWindDragon1.TabIndex = 2;
            RadioWindDragon1.TabStop = true;
            RadioWindDragon1.Text = "Wind Dragon";
            RadioWindDragon1.UseVisualStyleBackColor = true;
            RadioWindDragon1.CheckedChanged += RadioWindDragon1_CheckedChanged;
            // 
            // RadioIceDragon1
            // 
            RadioIceDragon1.AutoSize = true;
            RadioIceDragon1.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic);
            RadioIceDragon1.ForeColor = Color.Cyan;
            RadioIceDragon1.Location = new Point(19, 60);
            RadioIceDragon1.Name = "RadioIceDragon1";
            RadioIceDragon1.Size = new Size(110, 26);
            RadioIceDragon1.TabIndex = 1;
            RadioIceDragon1.TabStop = true;
            RadioIceDragon1.Text = "Ice Dragon";
            RadioIceDragon1.UseVisualStyleBackColor = true;
            RadioIceDragon1.CheckedChanged += RadioIceDragon1_CheckedChanged;
            // 
            // RadioFireDragon1
            // 
            RadioFireDragon1.AutoSize = true;
            RadioFireDragon1.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic);
            RadioFireDragon1.ForeColor = Color.Red;
            RadioFireDragon1.Location = new Point(19, 35);
            RadioFireDragon1.Name = "RadioFireDragon1";
            RadioFireDragon1.Size = new Size(119, 26);
            RadioFireDragon1.TabIndex = 0;
            RadioFireDragon1.TabStop = true;
            RadioFireDragon1.Text = "Fire Dragon";
            RadioFireDragon1.UseVisualStyleBackColor = true;
            RadioFireDragon1.CheckedChanged += RadioFireDragon1_CheckedChanged;
            // 
            // LabelDragonName1
            // 
            LabelDragonName1.AutoSize = true;
            LabelDragonName1.Font = new Font("Sylfaen", 10F, FontStyle.Bold | FontStyle.Italic);
            LabelDragonName1.Location = new Point(6, 58);
            LabelDragonName1.Name = "LabelDragonName1";
            LabelDragonName1.Size = new Size(104, 18);
            LabelDragonName1.TabIndex = 3;
            LabelDragonName1.Text = "Dragon Name:";
            // 
            // LabelPlayerName1
            // 
            LabelPlayerName1.AutoSize = true;
            LabelPlayerName1.Font = new Font("Sylfaen", 10F, FontStyle.Bold | FontStyle.Italic);
            LabelPlayerName1.Location = new Point(6, 29);
            LabelPlayerName1.Name = "LabelPlayerName1";
            LabelPlayerName1.Size = new Size(97, 18);
            LabelPlayerName1.TabIndex = 2;
            LabelPlayerName1.Text = "Player Name:";
            // 
            // groupBoxPlayer2
            // 
            groupBoxPlayer2.Controls.Add(SaveButton2);
            groupBoxPlayer2.Controls.Add(GroupBoxDragonType2);
            groupBoxPlayer2.Controls.Add(textBox3);
            groupBoxPlayer2.Controls.Add(textBox4);
            groupBoxPlayer2.Controls.Add(LabelDragonName2);
            groupBoxPlayer2.Controls.Add(LabelPlayerName2);
            groupBoxPlayer2.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold | FontStyle.Italic);
            groupBoxPlayer2.Location = new Point(488, 12);
            groupBoxPlayer2.Name = "groupBoxPlayer2";
            groupBoxPlayer2.Size = new Size(454, 381);
            groupBoxPlayer2.TabIndex = 1;
            groupBoxPlayer2.TabStop = false;
            groupBoxPlayer2.Text = "Player 2";
            // 
            // SaveButton2
            // 
            SaveButton2.BackColor = Color.DarkSlateGray;
            SaveButton2.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold | FontStyle.Italic);
            SaveButton2.ForeColor = Color.OrangeRed;
            SaveButton2.Location = new Point(39, 303);
            SaveButton2.Name = "SaveButton2";
            SaveButton2.Size = new Size(366, 33);
            SaveButton2.TabIndex = 13;
            SaveButton2.Text = "SAVE";
            SaveButton2.UseVisualStyleBackColor = false;
            SaveButton2.Click += SaveButton2_Click;
            // 
            // GroupBoxDragonType2
            // 
            GroupBoxDragonType2.Controls.Add(DragonPicBox2);
            GroupBoxDragonType2.Controls.Add(RadioEarthDragon2);
            GroupBoxDragonType2.Controls.Add(RadioWindDragon2);
            GroupBoxDragonType2.Controls.Add(RadioIceDragon2);
            GroupBoxDragonType2.Controls.Add(RadioFireDragon2);
            GroupBoxDragonType2.Font = new Font("Ink Free", 11.9999981F, FontStyle.Bold | FontStyle.Italic);
            GroupBoxDragonType2.Location = new Point(39, 122);
            GroupBoxDragonType2.Name = "GroupBoxDragonType2";
            GroupBoxDragonType2.Size = new Size(366, 166);
            GroupBoxDragonType2.TabIndex = 8;
            GroupBoxDragonType2.TabStop = false;
            GroupBoxDragonType2.Text = "Dragon Type";
            // 
            // DragonPicBox2
            // 
            DragonPicBox2.Location = new Point(198, 27);
            DragonPicBox2.Margin = new Padding(3, 2, 3, 2);
            DragonPicBox2.Name = "DragonPicBox2";
            DragonPicBox2.Size = new Size(156, 112);
            DragonPicBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            DragonPicBox2.TabIndex = 9;
            DragonPicBox2.TabStop = false;
            // 
            // RadioEarthDragon2
            // 
            RadioEarthDragon2.AutoSize = true;
            RadioEarthDragon2.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic);
            RadioEarthDragon2.ForeColor = Color.FromArgb(128, 64, 0);
            RadioEarthDragon2.Location = new Point(19, 110);
            RadioEarthDragon2.Name = "RadioEarthDragon2";
            RadioEarthDragon2.Size = new Size(128, 26);
            RadioEarthDragon2.TabIndex = 7;
            RadioEarthDragon2.TabStop = true;
            RadioEarthDragon2.Text = "Earth Dragon";
            RadioEarthDragon2.UseVisualStyleBackColor = true;
            RadioEarthDragon2.CheckedChanged += RadioEarthDragon2_CheckedChanged;
            // 
            // RadioWindDragon2
            // 
            RadioWindDragon2.AutoSize = true;
            RadioWindDragon2.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic);
            RadioWindDragon2.ForeColor = Color.FromArgb(192, 255, 255);
            RadioWindDragon2.Location = new Point(19, 85);
            RadioWindDragon2.Name = "RadioWindDragon2";
            RadioWindDragon2.Size = new Size(130, 26);
            RadioWindDragon2.TabIndex = 6;
            RadioWindDragon2.TabStop = true;
            RadioWindDragon2.Text = "Wind Dragon";
            RadioWindDragon2.UseVisualStyleBackColor = true;
            RadioWindDragon2.CheckedChanged += RadioWindDragon2_CheckedChanged;
            // 
            // RadioIceDragon2
            // 
            RadioIceDragon2.AutoSize = true;
            RadioIceDragon2.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic);
            RadioIceDragon2.ForeColor = Color.Cyan;
            RadioIceDragon2.Location = new Point(19, 60);
            RadioIceDragon2.Name = "RadioIceDragon2";
            RadioIceDragon2.Size = new Size(110, 26);
            RadioIceDragon2.TabIndex = 5;
            RadioIceDragon2.TabStop = true;
            RadioIceDragon2.Text = "Ice Dragon";
            RadioIceDragon2.UseVisualStyleBackColor = true;
            RadioIceDragon2.CheckedChanged += RadioIceDragon2_CheckedChanged;
            // 
            // RadioFireDragon2
            // 
            RadioFireDragon2.AutoSize = true;
            RadioFireDragon2.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic);
            RadioFireDragon2.ForeColor = Color.Red;
            RadioFireDragon2.Location = new Point(19, 35);
            RadioFireDragon2.Name = "RadioFireDragon2";
            RadioFireDragon2.Size = new Size(119, 26);
            RadioFireDragon2.TabIndex = 4;
            RadioFireDragon2.TabStop = true;
            RadioFireDragon2.Text = "Fire Dragon";
            RadioFireDragon2.UseVisualStyleBackColor = true;
            RadioFireDragon2.CheckedChanged += RadioFireDragon2_CheckedChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(112, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(264, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(105, 26);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(271, 27);
            textBox4.TabIndex = 6;
            // 
            // LabelDragonName2
            // 
            LabelDragonName2.AutoSize = true;
            LabelDragonName2.Font = new Font("Sylfaen", 10F, FontStyle.Bold | FontStyle.Italic);
            LabelDragonName2.Location = new Point(6, 58);
            LabelDragonName2.Name = "LabelDragonName2";
            LabelDragonName2.Size = new Size(104, 18);
            LabelDragonName2.TabIndex = 4;
            LabelDragonName2.Text = "Dragon Name:";
            // 
            // LabelPlayerName2
            // 
            LabelPlayerName2.AutoSize = true;
            LabelPlayerName2.Font = new Font("Sylfaen", 10F, FontStyle.Bold | FontStyle.Italic);
            LabelPlayerName2.Location = new Point(6, 30);
            LabelPlayerName2.Name = "LabelPlayerName2";
            LabelPlayerName2.Size = new Size(97, 18);
            LabelPlayerName2.TabIndex = 3;
            LabelPlayerName2.Text = "Player Name:";
            // 
            // LabelDragonStats
            // 
            LabelDragonStats.AutoSize = true;
            LabelDragonStats.Location = new Point(965, 9);
            LabelDragonStats.Name = "LabelDragonStats";
            LabelDragonStats.Size = new Size(77, 15);
            LabelDragonStats.TabIndex = 3;
            LabelDragonStats.Text = "Dragon Stats:";
            // 
            // IceDragonInfoLabel
            // 
            IceDragonInfoLabel.AutoSize = true;
            IceDragonInfoLabel.Location = new Point(965, 33);
            IceDragonInfoLabel.Name = "IceDragonInfoLabel";
            IceDragonInfoLabel.Size = new Size(137, 75);
            IceDragonInfoLabel.TabIndex = 4;
            IceDragonInfoLabel.Text = "Ice Dragon\r\n30 HP\r\n4 Attack Damage\r\n9 Special Attack Damage\r\n5 Block Damage";
            // 
            // FireDragonInfoLabel
            // 
            FireDragonInfoLabel.AutoSize = true;
            FireDragonInfoLabel.Location = new Point(965, 120);
            FireDragonInfoLabel.Name = "FireDragonInfoLabel";
            FireDragonInfoLabel.Size = new Size(143, 75);
            FireDragonInfoLabel.TabIndex = 5;
            FireDragonInfoLabel.Text = "Fire Dragon\r\n20 HP\r\n5 Attack Damage\r\n12 Special Attack Damage\r\n4 Block Damage\r\n";
            // 
            // EarthDragonInfoLabel
            // 
            EarthDragonInfoLabel.AutoSize = true;
            EarthDragonInfoLabel.Location = new Point(965, 207);
            EarthDragonInfoLabel.Name = "EarthDragonInfoLabel";
            EarthDragonInfoLabel.Size = new Size(137, 75);
            EarthDragonInfoLabel.TabIndex = 6;
            EarthDragonInfoLabel.Text = "Earth Dragon\r\n50 HP\r\n2 Attack Damage\r\n5 Special Attack Damage\r\n4 Block Damage\r\n";
            // 
            // WindDragonInfoLabel
            // 
            WindDragonInfoLabel.AutoSize = true;
            WindDragonInfoLabel.Location = new Point(965, 295);
            WindDragonInfoLabel.Name = "WindDragonInfoLabel";
            WindDragonInfoLabel.Size = new Size(137, 75);
            WindDragonInfoLabel.TabIndex = 7;
            WindDragonInfoLabel.Text = "Wind Dragon\r\n40 HP\r\n3 Attack Damage\r\n7 Special Attack Damage\r\n5 Block Damage\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(12, 399);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(930, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // ButtonStartGame
            // 
            ButtonStartGame.BackColor = Color.Transparent;
            ButtonStartGame.FlatAppearance.BorderSize = 0;
            ButtonStartGame.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ButtonStartGame.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ButtonStartGame.FlatStyle = FlatStyle.Flat;
            ButtonStartGame.Font = new Font("Constantia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonStartGame.ForeColor = Color.Gold;
            ButtonStartGame.Location = new Point(12, 399);
            ButtonStartGame.Name = "ButtonStartGame";
            ButtonStartGame.Size = new Size(930, 37);
            ButtonStartGame.TabIndex = 9;
            ButtonStartGame.Text = "START GAME";
            ButtonStartGame.UseVisualStyleBackColor = false;
            ButtonStartGame.Click += ButtonStartGame_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1141, 450);
            Controls.Add(ButtonStartGame);
            Controls.Add(WindDragonInfoLabel);
            Controls.Add(EarthDragonInfoLabel);
            Controls.Add(FireDragonInfoLabel);
            Controls.Add(IceDragonInfoLabel);
            Controls.Add(LabelDragonStats);
            Controls.Add(groupBoxPlayer2);
            Controls.Add(groupBoxPlayer1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "DRAGON BATTLE!";
            Load += Form1_Load;
            groupBoxPlayer1.ResumeLayout(false);
            groupBoxPlayer1.PerformLayout();
            GroupBoxDragonType1.ResumeLayout(false);
            GroupBoxDragonType1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DragonPicBox1).EndInit();
            groupBoxPlayer2.ResumeLayout(false);
            groupBoxPlayer2.PerformLayout();
            GroupBoxDragonType2.ResumeLayout(false);
            GroupBoxDragonType2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DragonPicBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxPlayer1;
        private GroupBox groupBoxPlayer2;
        private Label LabelPlayerName1;
        private Label LabelPlayerName2;
        private Label LabelDragonName1;
        private Label LabelDragonName2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox GroupBoxDragonType1;
        private GroupBox GroupBoxDragonType2;
        private RadioButton RadioEarthDragon1;
        private RadioButton RadioWindDragon1;
        private RadioButton RadioIceDragon1;
        private RadioButton RadioFireDragon1;
        private RadioButton RadioEarthDragon2;
        private RadioButton RadioWindDragon2;
        private RadioButton RadioIceDragon2;
        private RadioButton RadioFireDragon2;
        private Button SaveButton1;
        private Button SaveButton2;
        private Label LabelDragonStats;
        private Label IceDragonInfoLabel;
        private Label FireDragonInfoLabel;
        private Label EarthDragonInfoLabel;
        private Label WindDragonInfoLabel;
        private PictureBox DragonPicBox2;
        private PictureBox DragonPicBox1;
        private PictureBox pictureBox1;
        private Button ButtonStartGame;
    }
}
