using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace _21_bj
{
    public partial class Form3 : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=UsersCash.mdb";
        string Way = "";
        int UserCash;
        int resultBackGround;
        string data;
        string[] RandomMas = new string[36] { "6 б 6", "6 п 6", "6 т 6", "6 ч 6", "7 б 7", "7 п 7", "7 т 7", "7 ч 7", "8 б 8", "8 п 8", "8 т 8", "8 ч 8", "9 б 9", "9 п 9", "9 т 9", "9 ч 9", "10 б 10", "10 п 10", "10 т 10", "10 ч 10", "валет б 2", "валет п 2", "валет т 2", "валет ч 2", "дама б 3", "дама п 3", "дама т 3", "дама ч 3", "король б 4", "король п 4", "король т 4", "король ч 4", "туз б 11", "туз п 11", "туз т 11", "туз ч 11" };
        int SummOfCardsDealer = 0;
        int SummOfCardsUser = 0;
        int CountOfCardsDealer = 1;
        int CountOfCardsUser = 1;
        int resultOfGame = 0;
        int bet;
        int CheckVolume = 1;
        public Form3(int resultBackGround, string data, int UserCash, int bet, int CheckVolume)
        {
            this.data = data;
            this.resultBackGround = resultBackGround;
            this.UserCash = UserCash;
            this.bet = bet;
            this.CheckVolume = CheckVolume;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MoneyLabel.Text = UserCash.ToString();
            for (int j = 0; j < 36; j++)
            {
                Random rand = new Random();
                int RandForMass = rand.Next(0, 36);
                int RandForMass1 = rand.Next(0, 36);
                for (int i = 0; i < 36; i++)
                {
                    RandForMass = rand.Next(0, 36);
                    RandForMass1 = rand.Next(0, 36);
                    string ChoosenOne = RandomMas[RandForMass];
                    RandomMas[RandForMass] = RandomMas[RandForMass1];
                    RandomMas[RandForMass1] = ChoosenOne;
                }
            }
            Way = "C:\\Users\\Diablo\\Desktop\\УП 3 Курс курсач\\21 12\\21 bj\\Properties\\Колода карт\\jpg\\" + RandomMas[0] + ".jpg";
            DealerPictureBox1.Image = Image.FromFile(Way);
            Way = "C:\\Users\\Diablo\\Desktop\\УП 3 Курс курсач\\21 12\\21 bj\\Properties\\Колода карт\\jpg\\" + RandomMas[1] + ".jpg";
            UserPictureBox1.Image = Image.FromFile(Way);

            SummOfCardsDealer += Convert.ToInt32(RandomMas[0].Substring(RandomMas[0].Length - 2));
            TotalOfCardsDealer.Text = SummOfCardsDealer.ToString();
            SummOfCardsUser += Convert.ToInt32(RandomMas[1].Substring(RandomMas[1].Length - 2));
            TotalOfCardsUser.Text = SummOfCardsUser.ToString();
            MoneyLabel.Text = Convert.ToString(UserCash);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(resultBackGround, data, CheckVolume);
            f2.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MoneyLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            switch (CountOfCardsUser)
            {
                case 1:
                    {
                        Way = "C:\\Users\\Diablo\\Desktop\\УП 3 Курс курсач\\21 12\\21 bj\\Properties\\Колода карт\\jpg\\" + RandomMas[2] + ".jpg";
                        UserPictureBox2.Image = Image.FromFile(Way);
                        UserPictureBox2.Visible = true;
                        CountOfCardsUser++;
                        SummOfCardsUser += Convert.ToInt32(RandomMas[2].Substring(RandomMas[2].Length - 2));
                        TotalOfCardsUser.Text = SummOfCardsUser.ToString();
                        break;
                    }
                case 2:
                    {
                        Way = "C:\\Users\\Diablo\\Desktop\\УП 3 Курс курсач\\21 12\\21 bj\\Properties\\Колода карт\\jpg\\" + RandomMas[3] + ".jpg";
                        UserPictureBox3.Image = Image.FromFile(Way);
                        UserPictureBox3.Visible = true;
                        CountOfCardsUser++;
                        SummOfCardsUser += Convert.ToInt32(RandomMas[3].Substring(RandomMas[3].Length - 2));
                        TotalOfCardsUser.Text = SummOfCardsUser.ToString();
                        break;
                    }
                case 3:
                    {
                        Way = "C:\\Users\\Diablo\\Desktop\\УП 3 Курс курсач\\21 12\\21 bj\\Properties\\Колода карт\\jpg\\" + RandomMas[4] + ".jpg";
                        UserPictureBox4.Image = Image.FromFile(Way);
                        UserPictureBox4.Visible = true;
                        CountOfCardsUser++;
                        SummOfCardsUser += Convert.ToInt32(RandomMas[4].Substring(RandomMas[4].Length - 2));
                        TotalOfCardsUser.Text = SummOfCardsUser.ToString();
                        break;
                    }
                case 4:
                    {
                        Way = "C:\\Users\\Diablo\\Desktop\\УП 3 Курс курсач\\21 12\\21 bj\\Properties\\Колода карт\\jpg\\" + RandomMas[5] + ".jpg";
                        UserPictureBox5.Image = Image.FromFile(Way);
                        UserPictureBox5.Visible = true;
                        CountOfCardsUser++;
                        SummOfCardsUser += Convert.ToInt32(RandomMas[5].Substring(RandomMas[5].Length - 2));
                        TotalOfCardsUser.Text = SummOfCardsUser.ToString();
                        break;
                    }
            }
        }

        private async void StopButton_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            AddButton.Enabled = false;
            StopButton.Enabled = false;
            while (SummOfCardsDealer <= 16)
            {
                switch (CountOfCardsDealer)
                {
                    case 1:
                        {
                            await Task.Delay(1000);
                            Way = "C:\\Users\\Diablo\\Desktop\\УП 3 Курс курсач\\21 12\\21 bj\\Properties\\Колода карт\\jpg\\" + RandomMas[CountOfCardsUser + 2] + ".jpg";
                            DealerPictureBox2.Image = Image.FromFile(Way);
                            DealerPictureBox2.Visible = true;
                            CountOfCardsDealer++;
                            SummOfCardsDealer += Convert.ToInt32(RandomMas[CountOfCardsUser + 2].Substring(RandomMas[CountOfCardsUser + 2].Length - 2));
                            TotalOfCardsDealer.Text = SummOfCardsDealer.ToString();
                            break;
                        }
                    case 2:
                        {
                            await Task.Delay(1000);
                            Way = "C:\\Users\\Diablo\\Desktop\\УП 3 Курс курсач\\21 12\\21 bj\\Properties\\Колода карт\\jpg\\" + RandomMas[CountOfCardsUser + 3] + ".jpg";
                            DealerPictureBox3.Image = Image.FromFile(Way);
                            DealerPictureBox3.Visible = true;
                            CountOfCardsDealer++;
                            SummOfCardsDealer += Convert.ToInt32(RandomMas[CountOfCardsUser + 3].Substring(RandomMas[CountOfCardsUser + 3].Length - 2));
                            TotalOfCardsDealer.Text = SummOfCardsDealer.ToString();
                            break;
                        }
                    case 3:
                        {
                            await Task.Delay(1000);
                            Way = "C:\\Users\\Diablo\\Desktop\\УП 3 Курс курсач\\21 12\\21 bj\\Properties\\Колода карт\\jpg\\" + RandomMas[CountOfCardsUser + 4] + ".jpg";
                            DealerPictureBox4.Image = Image.FromFile(Way);
                            DealerPictureBox4.Visible = true;
                            CountOfCardsDealer++;
                            SummOfCardsDealer += Convert.ToInt32(RandomMas[CountOfCardsUser + 4].Substring(RandomMas[CountOfCardsUser + 4].Length - 2));
                            TotalOfCardsDealer.Text = SummOfCardsDealer.ToString();
                            break;
                        }
                    case 4:
                        {
                            await Task.Delay(1000);
                            Way = "C:\\Users\\Diablo\\Desktop\\УП 3 Курс курсач\\21 12\\21 bj\\Properties\\Колода карт\\jpg\\" + RandomMas[CountOfCardsUser + 5] + ".jpg";
                            DealerPictureBox5.Image = Image.FromFile(Way);
                            DealerPictureBox5.Visible = true;
                            CountOfCardsDealer++;
                            SummOfCardsDealer += Convert.ToInt32(RandomMas[CountOfCardsUser + 5].Substring(RandomMas[CountOfCardsUser + 5].Length - 2));
                            TotalOfCardsDealer.Text = SummOfCardsDealer.ToString(); 
                            break;
                        }
                }
            }
            await Task.Delay(500);
            if (SummOfCardsDealer <= 21 && SummOfCardsUser <= 21)
            {
                if (SummOfCardsUser > SummOfCardsDealer)
                {
                    if (CheckVolume == 1)
                    {
                        SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\1.wav");
                        simpleSound.Play();
                    }
                    MessageBox.Show("Победа!!!");
                    resultOfGame = 1;
                }
                if (SummOfCardsDealer > SummOfCardsUser)
                {
                    if (CheckVolume == 1)
                    {
                        SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\2.wav");
                        simpleSound.Play();
                    }
                    MessageBox.Show("Проигрыш!!!");
                    resultOfGame = -1;
                }
                if (SummOfCardsUser == SummOfCardsDealer)
                {
                    MessageBox.Show("Ничья");
                }
            }
            else
            {
                if (SummOfCardsUser > 21 && SummOfCardsDealer <= 21)
                {
                    if (CheckVolume == 1)
                    {
                        SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\2.wav");
                        simpleSound.Play();
                    }
                    MessageBox.Show("Проигрыш!!!");
                    resultOfGame = -1;
                }
                if (SummOfCardsDealer > 21 && SummOfCardsUser <= 21)
                {
                    if (CheckVolume == 1)
                    {
                        SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\1.wav");
                        simpleSound.Play();
                    }
                    MessageBox.Show("Победа!!!");
                    resultOfGame = 1;
                }
                if (SummOfCardsDealer > 21 && SummOfCardsUser > 21)
                {
                    MessageBox.Show("Ничья!!!");
                }
            }
            if (resultOfGame == 1)
            {
                UserCash += bet;
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
            }
            if (resultOfGame == -1)
            {
                UserCash -= bet;
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
            }
            Form4 f4 = new Form4(resultBackGround, data, UserCash, CheckVolume);
            f4.Show();
            this.Dispose();
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            this.Close();
            /* DealerPictureBox1.Image = null;
             DealerPictureBox2.Image = null;
             DealerPictureBox3.Image = null;
             DealerPictureBox4.Image = null;
             DealerPictureBox5.Image = null;
             DealerPictureBox1.Visible = false;
             DealerPictureBox2.Visible = false;
             DealerPictureBox3.Visible = false;
             DealerPictureBox4.Visible = false;
             DealerPictureBox5.Visible = false;
             UserPictureBox1.Image= null;
             UserPictureBox2.Image= null;
             UserPictureBox3.Image= null;
             UserPictureBox4.Image= null;
             UserPictureBox5.Image= null;
             UserPictureBox1.Visible = false;
             UserPictureBox2.Visible = false;
             UserPictureBox3.Visible = false;
             UserPictureBox4.Visible = false;
             UserPictureBox5.Visible = false;
             SummOfCardsDealer = 0;
             SummOfCardsUser = 0;
             CountOfCardsDealer = 0;
             CountOfCardsUser = 0;*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
