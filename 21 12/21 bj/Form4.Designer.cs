namespace _21_bj
{
    partial class Form4
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
            label1 = new Label();
            textBox1 = new TextBox();
            MoneyLabel = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button9 = new Button();
            button10 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(497, 299);
            label1.Name = "label1";
            label1.Size = new Size(167, 52);
            label1.TabIndex = 0;
            label1.Text = "Ставка";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(435, 387);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 45);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // MoneyLabel
            // 
            MoneyLabel.AutoSize = true;
            MoneyLabel.BackColor = Color.Transparent;
            MoneyLabel.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point);
            MoneyLabel.ForeColor = Color.Red;
            MoneyLabel.Location = new Point(26, 834);
            MoneyLabel.Name = "MoneyLabel";
            MoneyLabel.Size = new Size(46, 52);
            MoneyLabel.TabIndex = 21;
            MoneyLabel.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 775);
            label2.Name = "label2";
            label2.Size = new Size(170, 52);
            label2.TabIndex = 20;
            label2.Text = "Баланс";
            // 
            // button1
            // 
            button1.FlatAppearance.MouseDownBackColor = Color.Silver;
            button1.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(185, 452);
            button1.Name = "button1";
            button1.Size = new Size(150, 69);
            button1.TabIndex = 22;
            button1.Text = "+50";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.MouseDownBackColor = Color.Silver;
            button2.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(341, 452);
            button2.Name = "button2";
            button2.Size = new Size(150, 69);
            button2.TabIndex = 23;
            button2.Text = "+100";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.MouseDownBackColor = Color.Silver;
            button3.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(497, 452);
            button3.Name = "button3";
            button3.Size = new Size(150, 69);
            button3.TabIndex = 24;
            button3.Text = "+1000";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.MouseDownBackColor = Color.Silver;
            button4.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(653, 452);
            button4.Name = "button4";
            button4.Size = new Size(150, 69);
            button4.TabIndex = 25;
            button4.Text = "Max";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.MouseDownBackColor = Color.Silver;
            button5.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(809, 452);
            button5.Name = "button5";
            button5.Size = new Size(150, 69);
            button5.TabIndex = 26;
            button5.Text = "Min";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Lime;
            button6.FlatAppearance.MouseDownBackColor = Color.Silver;
            button6.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(788, 387);
            button6.Name = "button6";
            button6.Size = new Size(138, 46);
            button6.TabIndex = 31;
            button6.Text = "Поставить";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button9
            // 
            button9.FlatAppearance.MouseDownBackColor = Color.Silver;
            button9.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(578, 527);
            button9.Name = "button9";
            button9.Size = new Size(150, 69);
            button9.TabIndex = 28;
            button9.Text = "/2";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.FlatAppearance.MouseDownBackColor = Color.Silver;
            button10.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(422, 527);
            button10.Name = "button10";
            button10.Size = new Size(150, 69);
            button10.TabIndex = 27;
            button10.Text = "x2";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button7
            // 
            button7.FlatAppearance.MouseDownBackColor = Color.Silver;
            button7.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(960, 834);
            button7.Name = "button7";
            button7.Size = new Size(171, 72);
            button7.TabIndex = 32;
            button7.Text = "Выйти";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.FlatAppearance.MouseDownBackColor = Color.Silver;
            button8.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(-5, -4);
            button8.Name = "button8";
            button8.Size = new Size(301, 92);
            button8.TabIndex = 33;
            button8.Text = "Добавить денег(при балансе < 1500)";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click_1;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 905);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(MoneyLabel);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            MaximumSize = new Size(1153, 961);
            MinimumSize = new Size(1153, 961);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bet";
            Load += Form4_Load;
            KeyDown += Form4_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label MoneyLabel;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button9;
        private Button button10;
        private Button button7;
        private Button button8;
    }
}