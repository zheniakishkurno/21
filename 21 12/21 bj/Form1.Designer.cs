namespace _21_bj
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonAutorizate = new Button();
            buttonRegistration = new Button();
            Autorizate = new Button();
            Registration = new Button();
            LastAutorizate = new Button();
            LastRegistration = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Silver;
            button1.FlatAppearance.MouseOverBackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(1019, 843);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(124, 72);
            button1.TabIndex = 0;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Location = new Point(350, 381);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.MaxLength = 25;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(445, 41);
            textBox1.TabIndex = 1;
            textBox1.Tag = "sadf";
            textBox1.Text = "Логин";
            textBox1.Visible = false;
            textBox1.Enter += textBox1_Enter;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.GrayText;
            textBox2.Location = new Point(350, 458);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.MaxLength = 25;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(445, 41);
            textBox2.TabIndex = 2;
            textBox2.Text = "Пароль";
            textBox2.Visible = false;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Enter += textBox2_Enter;
            textBox2.KeyPress += textBox2_KeyPress;
            textBox2.Leave += textBox2_Leave;
            // 
            // buttonAutorizate
            // 
            buttonAutorizate.FlatAppearance.BorderSize = 0;
            buttonAutorizate.FlatAppearance.MouseDownBackColor = Color.Silver;
            buttonAutorizate.FlatAppearance.MouseOverBackColor = Color.LightGray;
            buttonAutorizate.FlatStyle = FlatStyle.Flat;
            buttonAutorizate.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAutorizate.Location = new Point(510, 554);
            buttonAutorizate.Margin = new Padding(4, 5, 4, 5);
            buttonAutorizate.Name = "buttonAutorizate";
            buttonAutorizate.Size = new Size(107, 53);
            buttonAutorizate.TabIndex = 3;
            buttonAutorizate.Text = "Ок";
            buttonAutorizate.UseVisualStyleBackColor = true;
            buttonAutorizate.Visible = false;
            buttonAutorizate.Click += button2_Click;
            // 
            // buttonRegistration
            // 
            buttonRegistration.FlatAppearance.BorderSize = 0;
            buttonRegistration.FlatAppearance.MouseDownBackColor = Color.Silver;
            buttonRegistration.FlatAppearance.MouseOverBackColor = Color.LightGray;
            buttonRegistration.FlatStyle = FlatStyle.Flat;
            buttonRegistration.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistration.Location = new Point(510, 601);
            buttonRegistration.Margin = new Padding(4, 5, 4, 5);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(107, 53);
            buttonRegistration.TabIndex = 4;
            buttonRegistration.Text = "Ок";
            buttonRegistration.UseVisualStyleBackColor = true;
            buttonRegistration.Visible = false;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // Autorizate
            // 
            Autorizate.FlatAppearance.BorderSize = 0;
            Autorizate.FlatAppearance.MouseDownBackColor = Color.Silver;
            Autorizate.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Autorizate.FlatStyle = FlatStyle.Flat;
            Autorizate.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Autorizate.Location = new Point(444, 346);
            Autorizate.Margin = new Padding(4, 5, 4, 5);
            Autorizate.Name = "Autorizate";
            Autorizate.Size = new Size(241, 90);
            Autorizate.TabIndex = 5;
            Autorizate.Text = "Авторизация";
            Autorizate.UseVisualStyleBackColor = true;
            Autorizate.Click += Autorizate_Click;
            // 
            // Registration
            // 
            Registration.FlatAppearance.BorderSize = 0;
            Registration.FlatAppearance.MouseDownBackColor = Color.Silver;
            Registration.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Registration.FlatStyle = FlatStyle.Flat;
            Registration.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Registration.Location = new Point(444, 457);
            Registration.Margin = new Padding(4, 5, 4, 5);
            Registration.Name = "Registration";
            Registration.Size = new Size(241, 90);
            Registration.TabIndex = 6;
            Registration.Text = "Регистрация";
            Registration.UseVisualStyleBackColor = true;
            Registration.Click += Registration_Click;
            // 
            // LastAutorizate
            // 
            LastAutorizate.FlatAppearance.BorderSize = 0;
            LastAutorizate.FlatAppearance.MouseDownBackColor = Color.Silver;
            LastAutorizate.FlatAppearance.MouseOverBackColor = Color.LightGray;
            LastAutorizate.FlatStyle = FlatStyle.Flat;
            LastAutorizate.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LastAutorizate.Location = new Point(1019, 762);
            LastAutorizate.Margin = new Padding(4, 5, 4, 5);
            LastAutorizate.Name = "LastAutorizate";
            LastAutorizate.Size = new Size(124, 72);
            LastAutorizate.TabIndex = 7;
            LastAutorizate.Text = "Назад";
            LastAutorizate.UseVisualStyleBackColor = true;
            LastAutorizate.Visible = false;
            LastAutorizate.Click += LastAutorizate_Click;
            // 
            // LastRegistration
            // 
            LastRegistration.BackColor = SystemColors.Control;
            LastRegistration.FlatAppearance.BorderSize = 0;
            LastRegistration.FlatAppearance.MouseDownBackColor = Color.Silver;
            LastRegistration.FlatAppearance.MouseOverBackColor = Color.LightGray;
            LastRegistration.FlatStyle = FlatStyle.Flat;
            LastRegistration.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LastRegistration.ForeColor = SystemColors.ControlText;
            LastRegistration.Location = new Point(1019, 762);
            LastRegistration.Margin = new Padding(4, 5, 4, 5);
            LastRegistration.Name = "LastRegistration";
            LastRegistration.Size = new Size(124, 72);
            LastRegistration.TabIndex = 8;
            LastRegistration.Text = "Назад";
            LastRegistration.UseVisualStyleBackColor = false;
            LastRegistration.Visible = false;
            LastRegistration.Click += LastRegistration_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SimSun", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(305, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(570, 97);
            label1.TabIndex = 9;
            label1.Text = "21 ОЧКО";
            label1.Click += label1_Click;
            label1.Enter += label1_Enter;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.eye;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(814, 458);
            button2.Name = "button2";
            button2.Size = new Size(52, 41);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click_1;
            button2.Enter += button2_Enter;
            button2.Leave += button2_Leave;
            button2.MouseDown += button2_MouseDown;
            button2.MouseUp += button2_MouseUp;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.eye;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(814, 534);
            button3.Name = "button3";
            button3.Size = new Size(52, 41);
            button3.TabIndex = 12;
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.MouseDown += button3_MouseDown;
            button3.MouseUp += button3_MouseUp;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.GrayText;
            textBox3.Location = new Point(349, 534);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.MaxLength = 25;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(445, 41);
            textBox3.TabIndex = 11;
            textBox3.Text = "Повторный пароль";
            textBox3.Visible = false;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 914);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(LastRegistration);
            Controls.Add(LastAutorizate);
            Controls.Add(Registration);
            Controls.Add(Autorizate);
            Controls.Add(buttonRegistration);
            Controls.Add(buttonAutorizate);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1160, 970);
            MinimumSize = new Size(1160, 970);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "21 ОЧКО";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonAutorizate;
        private Button buttonRegistration;
        private Button Autorizate;
        private Button Registration;
        private Button LastAutorizate;
        private Button LastRegistration;
        private Label label1;
        private Button button2;
        private Button button3;
        private TextBox textBox3;
    }
}