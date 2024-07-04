namespace _21_bj
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Game = new Button();
            Setings = new Button();
            Exit = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkVolumeBox = new CheckBox();
            SettingsButtonToMM = new Button();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            changeLoginButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // Game
            // 
            Game.FlatAppearance.BorderSize = 0;
            Game.FlatAppearance.MouseDownBackColor = Color.Silver;
            Game.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Game.FlatStyle = FlatStyle.Flat;
            Game.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Game.ForeColor = Color.Green;
            Game.Location = new Point(468, 304);
            Game.Margin = new Padding(4, 5, 4, 5);
            Game.Name = "Game";
            Game.Size = new Size(237, 88);
            Game.TabIndex = 0;
            Game.Text = "Играть";
            Game.UseVisualStyleBackColor = true;
            Game.Click += Game_Click;
            // 
            // Setings
            // 
            Setings.FlatAppearance.BorderSize = 0;
            Setings.FlatAppearance.MouseDownBackColor = Color.Silver;
            Setings.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Setings.FlatStyle = FlatStyle.Flat;
            Setings.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Setings.Location = new Point(469, 402);
            Setings.Margin = new Padding(4, 5, 4, 5);
            Setings.Name = "Setings";
            Setings.Size = new Size(237, 88);
            Setings.TabIndex = 1;
            Setings.Text = "Настройки";
            Setings.UseVisualStyleBackColor = true;
            Setings.Click += Setings_Click;
            // 
            // Exit
            // 
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.MouseDownBackColor = Color.Silver;
            Exit.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Exit.ForeColor = Color.Red;
            Exit.Location = new Point(468, 500);
            Exit.Margin = new Padding(4, 5, 4, 5);
            Exit.Name = "Exit";
            Exit.Size = new Size(237, 88);
            Exit.TabIndex = 2;
            Exit.Text = "Выход";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(322, 269);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 112);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(652, 269);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 112);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(322, 403);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(99, 112);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(469, 293);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 40);
            label1.TabIndex = 6;
            label1.Text = "Фон 1";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(799, 294);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 40);
            label2.TabIndex = 7;
            label2.Text = "Фон 2";
            label2.Visible = false;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(468, 434);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 40);
            label3.TabIndex = 8;
            label3.Text = "Фон 3";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // checkVolumeBox
            // 
            checkVolumeBox.AutoSize = true;
            checkVolumeBox.BackColor = Color.Transparent;
            checkVolumeBox.Checked = true;
            checkVolumeBox.CheckState = CheckState.Checked;
            checkVolumeBox.FlatStyle = FlatStyle.Flat;
            checkVolumeBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkVolumeBox.Location = new Point(443, 548);
            checkVolumeBox.Margin = new Padding(4, 5, 4, 5);
            checkVolumeBox.Name = "checkVolumeBox";
            checkVolumeBox.Size = new Size(369, 44);
            checkVolumeBox.TabIndex = 9;
            checkVolumeBox.Text = "Звуковые эффекты";
            checkVolumeBox.UseVisualStyleBackColor = false;
            checkVolumeBox.Visible = false;
            checkVolumeBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // SettingsButtonToMM
            // 
            SettingsButtonToMM.FlatStyle = FlatStyle.Flat;
            SettingsButtonToMM.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SettingsButtonToMM.Location = new Point(517, 688);
            SettingsButtonToMM.Margin = new Padding(4, 5, 4, 5);
            SettingsButtonToMM.Name = "SettingsButtonToMM";
            SettingsButtonToMM.Size = new Size(156, 73);
            SettingsButtonToMM.TabIndex = 10;
            SettingsButtonToMM.Text = "Назад";
            SettingsButtonToMM.UseVisualStyleBackColor = true;
            SettingsButtonToMM.Visible = false;
            SettingsButtonToMM.Click += SettingsButtonToMM_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(799, 428);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 40);
            label4.TabIndex = 12;
            label4.Text = "Фон 4";
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(652, 403);
            pictureBox4.Margin = new Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(99, 112);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // changeLoginButton
            // 
            changeLoginButton.FlatStyle = FlatStyle.Flat;
            changeLoginButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            changeLoginButton.Location = new Point(-2, -8);
            changeLoginButton.Margin = new Padding(4, 5, 4, 5);
            changeLoginButton.Name = "changeLoginButton";
            changeLoginButton.Size = new Size(365, 73);
            changeLoginButton.TabIndex = 13;
            changeLoginButton.Text = "Сменить пользователя";
            changeLoginButton.UseVisualStyleBackColor = true;
            changeLoginButton.Visible = false;
            changeLoginButton.Click += changeLoginButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1131, 905);
            Controls.Add(changeLoginButton);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(SettingsButtonToMM);
            Controls.Add(checkVolumeBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Exit);
            Controls.Add(Setings);
            Controls.Add(Game);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1153, 961);
            MinimumSize = new Size(1153, 961);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main menu";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Game;
        private Button Setings;
        private Button Exit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkVolumeBox;
        private Button SettingsButtonToMM;
        private Label label4;
        private PictureBox pictureBox4;
        private Button changeLoginButton;
    }
}