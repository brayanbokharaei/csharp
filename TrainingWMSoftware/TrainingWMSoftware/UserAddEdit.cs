using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TrainingWMSoftware
{
    public partial class UserAddEdit : Form
    {
        public UserAddEdit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "" ) && (textBox2.Text != ""))
            {
                if (textBox3.Text == null) textBox3.Text = "";

                OleDbConnection con = new OleDbConnection(Properties.Settings.Default.traineeConnectionString);
                OleDbCommand com = new OleDbCommand("INSERT INTO trainigTime ( Fname, Lname, age ) values('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ")", con);
                com.Connection = con;
                con.Open();
                try
                {
                    int r = com.ExecuteNonQuery();
                    MessageBox.Show("مشخصات درج شد", "اعلام");
                }
                catch
                {
                    MessageBox.Show("اشکال در درج مشخصات", "اعلام");
                }

            }
            else
                MessageBox.Show("نام یا نام خانوادگی را پر کنید", "خطا");
        }

        private void UserAddEdit_Load(object sender, EventArgs e)
        {
        }
    }
}