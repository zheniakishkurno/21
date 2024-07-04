using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_bj
{
    public partial class Form4 : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=UsersCash.mdb";
        int resultBackGround;
        string data;
        int UserCash;
        int bet;
        int CheckVolume;
        public Form4(int resultBackGround, string data, int UserCash, int CheckVolume)
        {
            InitializeComponent();
            this.resultBackGround = resultBackGround;
            this.data = data;
            this.UserCash = UserCash;
            this.CheckVolume = CheckVolume;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MoneyLabel.Text = UserCash.ToString();
            switch (resultBackGround)
            {
                case 1:
                    {
                        Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\first.jpg");
                        this.BackgroundImage = myImage;
                        label1.ForeColor = Color.Black;
                        label2.ForeColor = Color.Black;
                        break;
                    }
                case 2:
                    {
                        Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\second.jpg");
                        this.BackgroundImage = myImage;
                        label1.ForeColor = Color.Black;
                        label2.ForeColor = Color.Black;
                        break;
                    }
                case 3:
                    {
                        Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\third.jpg");
                        this.BackgroundImage = myImage;
                        label1.ForeColor = Color.Red;
                        label2.ForeColor = Color.White;
                        break;
                    }
                case 4:
                    {
                        Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\21bj.jpg");
                        this.BackgroundImage = myImage;
                        label1.ForeColor = Color.Red;
                        label2.ForeColor = Color.White;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string betText = textBox1.Text;
            int CountofBet = 0;
            for (int i = 0; i < betText.Length; i++)
            {
                if (betText[i] == '1' || betText[i] == '2' || betText[i] == '3' || betText[i] == '4' || betText[i] == '5' || betText[i] == '6' || betText[i] == '7' || betText[i] == '8' || betText[i] == '9' || betText[i] == '0')
                {
                    CountofBet++;
                }
            }
            if (CountofBet == betText.Length)
            {
                if (betText != "")
                {
                    try
                    {
                        bet = Convert.ToInt32(betText);
                        if (bet <= UserCash)
                        {
                            textBox1.ForeColor = Color.Green;
                            button6.BackColor = Color.Lime;
                        }
                        else
                        {
                            textBox1.ForeColor = Color.Red;
                            button6.BackColor = Color.Red;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Слишком большое значение");
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста вводите только цифры");
                textBox1.Text = "";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bet += 50;
            textBox1.Text = bet.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bet += 100;
            textBox1.Text = bet.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bet += 1000;
            textBox1.Text = bet.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bet = UserCash;
            textBox1.Text = bet.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bet = 10;
            textBox1.Text = bet.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bet *= 2;
            textBox1.Text = bet.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bet /= 2;
            textBox1.Text = bet.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bet <= UserCash && bet >= 10)
            {
                Form3 f3 = new Form3(resultBackGround, data, UserCash, bet, CheckVolume);
                switch (resultBackGround)
                {
                    case 1:
                        {
                            Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\first.jpg");
                            f3.BackgroundImage = myImage;
                            break;
                        }
                    case 2:
                        {
                            Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\second.jpg");
                            f3.BackgroundImage = myImage;
                            break;
                        }
                    case 3:
                        {
                            Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\third.jpg");
                            f3.BackgroundImage = myImage;
                            break;
                        }
                    case 4:
                        {
                            Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\21bj.jpg");
                            f3.BackgroundImage = myImage;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                f3.Show();
                this.Close();
            }
            else
            {
                if(textBox1.Text.Length > 0) 
                {
                    if (bet < 10)
                    {
                        MessageBox.Show("Ставка не может быть меньше 10");
                    }
                    if (bet > UserCash)
                    {
                        MessageBox.Show("Невозможно поставить ставку, т.к. она больше вашего баланса");
                    }
                }
                else
                {
                    MessageBox.Show("Введите или выберите ставку");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(resultBackGround, data, CheckVolume);
            f2.Show();
            this.Dispose();
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (UserCash < 1500)
            {
                UserCash += 1500;
                MoneyLabel.Text = UserCash.ToString();
                string updateQuery = "UPDATE UsersCash SET Cash = @Cash WHERE Login = @Login";
                using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
                {
                    dbConnection.Open();
                    using (OleDbCommand command = new OleDbCommand(updateQuery, dbConnection))
                    {
                        command.Parameters.AddWithValue("@Cash", UserCash);
                        command.Parameters.AddWithValue("@Login", data);
                        command.ExecuteNonQuery();
                    }
                    dbConnection.Close();
                }
                if (textBox1.Text != "")
                {
                    if (UserCash >= Convert.ToInt32(textBox1.Text))
                    {
                        textBox1.ForeColor = Color.Green;
                        button6.BackColor = Color.Lime;
                    }
                    else
                    {
                        textBox1.ForeColor = Color.Red;
                        button6.BackColor = Color.Red;
                    }
                }
            }
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
