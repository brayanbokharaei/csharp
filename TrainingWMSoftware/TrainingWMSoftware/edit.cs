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
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
        }

        private void edit_Load(object sender, EventArgs e)
        {
                textBox1.Text = traineeInformation.name;
                textBox2.Text = traineeInformation.family;
                textBox3.Text = traineeInformation.age;



        }

        private void button1_Click(object sender, EventArgs e)
        {
                        if ((textBox1.Text != "" ) && (textBox2.Text != ""))
            {

                OleDbConnection con = new OleDbConnection(Properties.Settings.Default.traineeConnectionString);
                OleDbCommand com = new OleDbCommand("UPDATE trainigTime set fname= '" + textBox1.Text + "' , lname='" + textBox2.Text +"' , age ='" + textBox3.Text +"' where id="+traineeInformation.traineeid ,con);
                con.Open();
                try
                {
                    int r = com.ExecuteNonQuery();
                }
                catch
                { }

            }
            else
                MessageBox.Show("نام یا نام خانوادگی را پر کنید", "خطا");
        


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}