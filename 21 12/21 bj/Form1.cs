using System.Windows.Forms;
using System.Data.OleDb;
using _21_bj.Properties;
using Microsoft.VisualBasic.Logging;
using System.Text.RegularExpressions;

namespace _21_bj
{
    public partial class Form1 : Form
    {
        int resultBackGround;
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Users.mdb";
        private string connectionString1 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=UsersBackGrounds.mdb";
        private string connectionString2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=UsersCash.mdb";
        string data;
        int CheckVolume = 1;
        private void Connect()
        {
            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
            {
                try
                {
                    dbConnection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к базе данных:" + ex.Message);
                }
                finally
                {
                    dbConnection.Close();
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) //Авторизация
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            if (textBox1.Text.Length >= 2 && textBox2.Text.Length >= 5)
            {
                using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
                {

                    dbConnection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Login = @Login AND Password = @Password";
                    using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                    {
                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@Password", password);
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            data = login;
                            Form2 f2 = new Form2(resultBackGround, data, CheckVolume);
                            f2.Show();
                            GC.Collect(4, GCCollectionMode.Forced);
                            GC.GetTotalMemory(true);
                            this.Hide();
                            MessageBox.Show("Добро пожаловать - " + textBox1.Text);
                        }
                        else
                        {
                            MessageBox.Show("Неверное имя пользователя или пароль");
                        }
                        dbConnection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Кароткий пароль или логин");
            }
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
        }

        private void Autorizate_Click(object sender, EventArgs e)
        {

            buttonAutorizate.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            Autorizate.Visible = false;
            Registration.Visible = false;
            LastAutorizate.Visible = true;
            button2.Visible = true;
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            buttonRegistration.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            Autorizate.Visible = false;
            Registration.Visible = false;
            LastRegistration.Visible = true;
            button2.Visible = true;
            textBox3.Visible = true;
            button3.Visible = true;
        }

        private void LastRegistration_Click(object sender, EventArgs e)
        {
            buttonRegistration.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            Autorizate.Visible = true;
            Registration.Visible = true;
            LastRegistration.Visible = false;
            button2.Visible = false;
            textBox1.Text = "Логин";
            textBox2.Text = "Пароль";
            textBox2.UseSystemPasswordChar = false;
            textBox3.Visible = false;
            button3.Visible = false;
            textBox3.Text = "Повторный пароль";
        }

        private void LastAutorizate_Click(object sender, EventArgs e)
        {
            buttonAutorizate.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            Autorizate.Visible = true;
            Registration.Visible = true;
            LastAutorizate.Visible = false;
            button2.Visible = false;
            textBox1.Text = "Логин";
            textBox2.Text = "Пароль";
            textBox2.UseSystemPasswordChar = false;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Логин")
            {
                textBox1.Clear();
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Пароль")
            {
                textBox2.Clear();
                textBox2.ForeColor = Color.Black;
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "Пароль";
                textBox2.ForeColor = Color.Gray;
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Логин";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e) //Регистрация
        {
            if (textBox2.Text == textBox3.Text)
            {
                string login = textBox1.Text;
                int loginCount = login.Length;
                string password = textBox2.Text;
                int passwordCount = password.Length;
                string pattern = $@"^(?=.*[A-ZА-Я]{{{1},{passwordCount}}})(?=.*\d{{{1},{passwordCount}}})(?=.*[a-zа-я]{{{1},{passwordCount}}})(?=.*\D{{{1},{passwordCount}}})";
                bool isValid = Regex.IsMatch(password, pattern);
                if (isValid == true)
                {
                    for (int i = 0; i < login.Length; i++)
                    {
                        if (login[i] == ' ')
                        {
                            loginCount--;
                        }
                    }
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (password[i] == ' ')
                        {
                            passwordCount--;
                        }
                    }
                    if (textBox2.Text.Length > 5 && textBox1.Text.Length > 2)
                    {
                        if (loginCount == login.Length && passwordCount == password.Length && login.Length != 0 && password.Length != 0 && login != "Логин" && password != "Пароль")
                        {
                            int count;
                            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
                            {
                                dbConnection.Open();
                                string query = "SELECT COUNT(*) FROM Users WHERE Login = @Login";
                                using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                                {
                                    command.Parameters.AddWithValue("@Login", login);
                                    count = Convert.ToInt32(command.ExecuteScalar());
                                }
                                if (count > 0)
                                {
                                    MessageBox.Show("Имя пользователя уже занято. Пожалуйста, выберите другое");
                                }
                                else
                                {

                                    data = login;
                                    query = "INSERT INTO Users VALUES (@Login, @Password)";
                                    using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                                    {
                                        command.Parameters.AddWithValue("@Login", login);
                                        command.Parameters.AddWithValue("@Password", password);
                                        command.ExecuteNonQuery();
                                    }
                                }
                                dbConnection.Close();
                                GC.Collect(4, GCCollectionMode.Forced);
                                GC.GetTotalMemory(true);
                            }
                            if (count == 0)
                            {
                                using (OleDbConnection dbConnection1 = new OleDbConnection(connectionString1))
                                {
                                    dbConnection1.Open();
                                    string query1 = "INSERT INTO UsersBackGrounds VALUES (@Login, @BackGround)";
                                    using (OleDbCommand command1 = new OleDbCommand(query1, dbConnection1))
                                    {
                                        command1.Parameters.AddWithValue("@Login", login);
                                        command1.Parameters.AddWithValue("@BackGround", "1");
                                        command1.ExecuteNonQuery();
                                    }
                                    dbConnection1.Close();
                                }
                                using (OleDbConnection dbConnection2 = new OleDbConnection(connectionString2))
                                {
                                    dbConnection2.Open();
                                    string query1 = "INSERT INTO UsersCash VALUES (@Login, @Cash)";
                                    using (OleDbCommand command1 = new OleDbCommand(query1, dbConnection2))
                                    {
                                        command1.Parameters.AddWithValue("@Login", login);
                                        command1.Parameters.AddWithValue("@Cash", "1500");
                                        command1.ExecuteNonQuery();
                                    }
                                    dbConnection2.Close();
                                }
                                MessageBox.Show("Регистрация прошла успешно.");
                                Form2 f2 = new Form2(resultBackGround, data, CheckVolume);
                                f2.Show();
                                GC.Collect(4, GCCollectionMode.Forced);
                                GC.GetTotalMemory(true);
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Неправильный ввод данных");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Короткий пароль или логин");
                    }
                }
                else
                {
                    MessageBox.Show("Пароль должен содержать цифры, большие и маленькие буквы");
                }
            }
            else
            {
                if(textBox2.Text =="Пароль" && textBox3.Text == "Повторный пароль")
                {
                    MessageBox.Show("Введите данные");
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\21bj.jpg");
            this.BackgroundImage = myImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Leave(object sender, EventArgs e)
        {

        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox2.Text != "Пароль")
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            if (textBox2.Text != "Пароль")
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == ';' || e.KeyChar == ':' || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Повторный пароль")
            {
                textBox3.Clear();
                textBox3.ForeColor = Color.Black;
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = "Повторный пароль";
                textBox3.ForeColor = Color.Gray;
                textBox3.UseSystemPasswordChar = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox3.Text != "Повторный пароль")
            {
                textBox3.UseSystemPasswordChar = false;
            }
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            if (textBox3.Text != "Повторный пароль")
            {
                textBox3.UseSystemPasswordChar = true;
            }
        }
    }
}