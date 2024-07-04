using _21_bj.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace _21_bj
{
    public partial class Form2 : Form
    {
        private string data;
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=UsersBackGrounds.mdb";
        private string connectionString1 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=UsersCash.mdb";
        int resultBackGround;
        int UserCash;
        int CheckVolume = 1;
        public Form2(int resultBackGround, string data, int CheckVolume)
        {
            InitializeComponent();
            this.data = data;
            this.resultBackGround = resultBackGround;
            this.CheckVolume = CheckVolume;
            if (CheckVolume == 1)
            {
                checkVolumeBox.Checked = true;
            }
            else
            {
                checkVolumeBox.Checked = false;
            }

        }

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

        private void Form2_Load(object sender, EventArgs e)
        {
            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
            {
                try
                {
                    dbConnection.Open();
                    string query = "SELECT BackGround FROM UsersBackGrounds WHERE Login = data";
                    using (OleDbCommand command = new OleDbCommand(query, dbConnection))
                    {
                        command.Parameters.AddWithValue("@Login", data);
                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            resultBackGround = reader.GetInt32(0);
                            switch (resultBackGround)
                            {
                                case 1:
                                    {
                                        Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\first.jpg");
                                        this.BackgroundImage = myImage;
                                        label1.ForeColor = Color.Black;
                                        label2.ForeColor = Color.Black;
                                        label3.ForeColor = Color.Black;
                                        label4.ForeColor = Color.Black;
                                        checkVolumeBox.ForeColor = Color.Black;
                                        break;
                                    }
                                case 2:
                                    {
                                        Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\second.jpg");
                                        this.BackgroundImage = myImage;
                                        label1.ForeColor = Color.Black;
                                        label2.ForeColor = Color.Black;
                                        label3.ForeColor = Color.Black;
                                        label4.ForeColor = Color.Black;
                                        checkVolumeBox.ForeColor = Color.Black;
                                        break;
                                    }
                                case 3:
                                    {
                                        Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\third.jpg");
                                        this.BackgroundImage = myImage;
                                        label1.ForeColor = Color.Red;
                                        label2.ForeColor = Color.Red;
                                        label3.ForeColor = Color.Red;
                                        label4.ForeColor = Color.Red;
                                        checkVolumeBox.ForeColor = Color.Red;
                                        break;
                                    }
                                case 4:
                                    {
                                        Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\21bj.jpg");
                                        this.BackgroundImage = myImage;
                                        label1.ForeColor = Color.Red;
                                        label2.ForeColor = Color.Red;
                                        label3.ForeColor = Color.Red;
                                        label4.ForeColor = Color.Red;
                                        checkVolumeBox.ForeColor = Color.Red;
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                        }
                    }
                    dbConnection.Close();
                    GC.Collect(4, GCCollectionMode.Forced);
                    GC.GetTotalMemory(true);
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
            using (OleDbConnection dbConnection2 = new OleDbConnection(connectionString1))
            {

                dbConnection2.Open();
                string query = "SELECT Cash FROM UsersCash WHERE Login = data";
                using (OleDbCommand command = new OleDbCommand(query, dbConnection2))
                {
                    command.Parameters.AddWithValue("@Login", data);
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UserCash = reader.GetInt32(0);
                    }
                }
                dbConnection2.Close();
            }
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Setings_Click(object sender, EventArgs e)
        {
            Setings.Visible = false;
            Game.Visible = false;
            Exit.Visible = false;
            pictureBox1.Visible = true;
            Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\first.jpg");
            pictureBox1.Image = myImage;
            pictureBox2.Visible = true;
            myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\second.jpg");
            pictureBox2.Image = myImage;
            pictureBox3.Visible = true;
            myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\third.jpg");
            pictureBox3.Image = myImage;
            myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\21bj.jpg");
            pictureBox4.Image = myImage;
            pictureBox4.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            checkVolumeBox.Visible = true;
            SettingsButtonToMM.Visible = true;
            changeLoginButton.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\first.jpg");
            this.BackgroundImage = myImage;
            resultBackGround = 1;
            string updateQuery = "UPDATE UsersBackGrounds SET BackGround = @BackGround WHERE Login = @Login";
            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
            {
                dbConnection.Open();
                using (OleDbCommand command = new OleDbCommand(updateQuery, dbConnection))
                {
                    command.Parameters.AddWithValue("@BackGround", resultBackGround);
                    command.Parameters.AddWithValue("@Login", data);
                    command.ExecuteNonQuery();
                }
                dbConnection.Close();
            }
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            checkVolumeBox.ForeColor = Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\first.jpg");
            this.BackgroundImage = myImage;
            resultBackGround = 1;
            string updateQuery = "UPDATE UsersBackGrounds SET BackGround = @BackGround WHERE Login = @Login";
            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
            {
                dbConnection.Open();
                using (OleDbCommand command = new OleDbCommand(updateQuery, dbConnection))
                {
                    command.Parameters.AddWithValue("@BackGround", resultBackGround);
                    command.Parameters.AddWithValue("@Login", data);
                    command.ExecuteNonQuery();
                }
                dbConnection.Close();
            }
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            checkVolumeBox.ForeColor = Color.Black;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkVolumeBox.Checked == true)
            {
                CheckVolume = 1;
            }
            else
            {
                CheckVolume = 0;
            }
        }
        private void SettingsButtonToMM_Click(object sender, EventArgs e)
        {
            Setings.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            checkVolumeBox.Visible = false;
            SettingsButtonToMM.Visible = false;
            Game.Visible = true;
            Exit.Visible = true;
            changeLoginButton.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\second.jpg");
            this.BackgroundImage = myImage;
            resultBackGround = 2;
            string updateQuery = "UPDATE UsersBackGrounds SET BackGround = @BackGround WHERE Login = @Login";
            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
            {
                dbConnection.Open();
                using (OleDbCommand command = new OleDbCommand(updateQuery, dbConnection))
                {
                    command.Parameters.AddWithValue("@BackGround", resultBackGround);
                    command.Parameters.AddWithValue("@Login", data);
                    command.ExecuteNonQuery();
                }
                dbConnection.Close();
            }
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            checkVolumeBox.ForeColor = Color.Black;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\third.jpg");
            this.BackgroundImage = myImage;
            resultBackGround = 3;
            string updateQuery = "UPDATE UsersBackGrounds SET BackGround = @BackGround WHERE Login = @Login";
            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
            {
                dbConnection.Open();
                using (OleDbCommand command = new OleDbCommand(updateQuery, dbConnection))
                {
                    command.Parameters.AddWithValue("@BackGround", resultBackGround);
                    command.Parameters.AddWithValue("@Login", data);
                    command.ExecuteNonQuery();
                }
                dbConnection.Close();
            }
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Red;
            label3.ForeColor = Color.Red;
            label4.ForeColor = Color.Red;
            checkVolumeBox.ForeColor = Color.Red;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\third.jpg");
            this.BackgroundImage = myImage;
            resultBackGround = 3;
            string updateQuery = "UPDATE UsersBackGrounds SET BackGround = @BackGround WHERE Login = @Login";
            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
            {
                dbConnection.Open();
                using (OleDbCommand command = new OleDbCommand(updateQuery, dbConnection))
                {
                    command.Parameters.AddWithValue("@BackGround", resultBackGround);
                    command.Parameters.AddWithValue("@Login", data);
                    command.ExecuteNonQuery();
                }
                dbConnection.Close();
            }
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Red;
            label3.ForeColor = Color.Red;
            label4.ForeColor = Color.Red;
            checkVolumeBox.ForeColor = Color.Red;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\second.jpg");
            this.BackgroundImage = myImage;
            resultBackGround = 2;
            string updateQuery = "UPDATE UsersBackGrounds SET BackGround = @BackGround WHERE Login = @Login";
            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
            {
                dbConnection.Open();
                using (OleDbCommand command = new OleDbCommand(updateQuery, dbConnection))
                {
                    command.Parameters.AddWithValue("@BackGround", resultBackGround);
                    command.Parameters.AddWithValue("@Login", data);
                    command.ExecuteNonQuery();
                }
                dbConnection.Close();
            }
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            checkVolumeBox.ForeColor = Color.Black;
        }

        private void Game_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(resultBackGround, data, UserCash, CheckVolume);
            f4.Show();
            switch (resultBackGround)
            {
                case 1:
                    {
                        Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\first.jpg");
                        f4.BackgroundImage = myImage;
                        break;
                    }
                case 2:
                    {
                        Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\second.jpg");
                        f4.BackgroundImage = myImage;
                        break;
                    }
                case 3:
                    {
                        Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\third.jpg");
                        f4.BackgroundImage = myImage;
                        break;
                    }
                case 4:
                    {
                        Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\21bj.jpg");
                        f4.BackgroundImage = myImage;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            f4.Show();
            this.Dispose();
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\21bj.jpg");
            this.BackgroundImage = myImage;
            resultBackGround = 4;
            string updateQuery = "UPDATE UsersBackGrounds SET BackGround = @BackGround WHERE Login = @Login";
            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
            {
                dbConnection.Open();
                using (OleDbCommand command = new OleDbCommand(updateQuery, dbConnection))
                {
                    command.Parameters.AddWithValue("@BackGround", resultBackGround);
                    command.Parameters.AddWithValue("@Login", data);
                    command.ExecuteNonQuery();
                }
                dbConnection.Close();
            }
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Red;
            label3.ForeColor = Color.Red;
            label4.ForeColor = Color.Red;
            checkVolumeBox.ForeColor = Color.Red;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Image myImage = new Bitmap(@"C:\Users\Diablo\Desktop\УП 3 Курс курсач\21 12\21 bj\Properties\21bj.jpg");
            this.BackgroundImage = myImage;
            resultBackGround = 4;
            string updateQuery = "UPDATE UsersBackGrounds SET BackGround = @BackGround WHERE Login = @Login";
            using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
            {
                dbConnection.Open();
                using (OleDbCommand command = new OleDbCommand(updateQuery, dbConnection))
                {
                    command.Parameters.AddWithValue("@BackGround", resultBackGround);
                    command.Parameters.AddWithValue("@Login", data);
                    command.ExecuteNonQuery();
                }
                dbConnection.Close();
            }
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Red;
            label3.ForeColor = Color.Red;
            label4.ForeColor = Color.Red;
            checkVolumeBox.ForeColor = Color.Red;
        }

        private void changeLoginButton_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Dispose();
            this.Close();
            GC.Collect(4, GCCollectionMode.Forced);
            GC.GetTotalMemory(true);
        }
    }
}
