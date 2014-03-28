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
    public partial class traineelist : Form
    {
        public traineelist()
        {
            InitializeComponent();
        }

        private void traineelist_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None; this.Left = 0; this.Top = 0; this.Bounds = Screen.PrimaryScreen.Bounds;
            // TODO: This line of code loads data into the 'traineeDataSet1.trainigTime' table. You can move, or remove it, as needed.
            this.trainigTimeTableAdapter1.Fill(this.traineeDataSet1.trainigTime);
            // TODO: This line of code loads data into the 'traineeDataSet.trainigTime' table. You can move, or remove it, as needed.
            this.trainigTimeTableAdapter1.Fill(this.traineeDataSet1.trainigTime);
            // TODO: This line of code loads data into the 'traineeDataSet.trainigTime' table. You can move, or remove it, as needed.
            this.trainigTimeTableAdapter1.Fill(this.traineeDataSet1.trainigTime);
            // TODO: This line of code loads data into the 'traineeDataSet.trainigTime' table. You can move, or remove it, as needed.
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=trainee.mdb;Persist Security Info=True");
            OleDbCommand com = new OleDbCommand("select * from  trainigtime ",con);
            com.Connection = con;
            con.Open();
            OleDbDataAdapter oldb = new OleDbDataAdapter(com);
            DataSet ds = new DataSet();
            oldb.Fill(ds);
            int r = com.ExecuteNonQuery();
           // dataGridView1.DataSource = ds;
            
            con.Close();



        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=trainee.mdb;Persist Security Info=True");
                string str = "select * from trainigtime where id=" + id.ToString();
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(str, con);
                da.Fill(ds);
                string name = (string)ds.Tables[0].Rows[0]["fname"];
                string family = (string)ds.Tables[0].Rows[0]["lname"];
                int TaskAlltrainigtime = (int)ds.Tables[0].Rows[0]["TaskAlltrainigtime"];
                traineeInformation.traineeid = id;
                traineeInformation.name = name;
                traineeInformation.family = family;
                traineeInformation.TaskAlltrainigTime = TaskAlltrainigtime;
                traineeInformation.LastEvent = DateTime.Now;
                Form1 f = new Form1();
                Visible = false;
                f.Show();
                
            }
            catch
            {
                MessageBox.Show("لطفا یک آموزش گیرنده را انتخاب کنید", "اعلام");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=trainee.mdb;Persist Security Info=True");
                string str = "select * from trainigtime where id=" + id.ToString();
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(str, con);
                da.Fill(ds);
                string name = (string)ds.Tables[0].Rows[0]["fname"];
                string age = (string )ds.Tables[0].Rows[0]["age"];
                string family = (string)ds.Tables[0].Rows[0]["lname"];
                int TaskAlltrainigtime = (int)ds.Tables[0].Rows[0]["TaskAlltrainigtime"];
                traineeInformation.traineeid = id;
                traineeInformation.age = age;
                traineeInformation.name = name;
                traineeInformation.family = family;
                traineeInformation.TaskAlltrainigTime = TaskAlltrainigtime;
                traineeInformation.LastEvent = DateTime.Now;
                edit  f = new edit ();
                f.Show();
            }
            catch
            {
                MessageBox.Show("لطفا یک آموزش گیرنده را انتخاب کنید", "اعلام");
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserAddEdit au = new UserAddEdit();
            au.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void traineelist_Activated(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None; this.Left = 0; this.Top = 0; this.Bounds = Screen.PrimaryScreen.Bounds;
            // TODO: This line of code loads data into the 'traineeDataSet1.trainigTime' table. You can move, or remove it, as needed.
            this.trainigTimeTableAdapter1.Fill(this.traineeDataSet1.trainigTime);
            // TODO: This line of code loads data into the 'traineeDataSet.trainigTime' table. You can move, or remove it, as needed.
            this.trainigTimeTableAdapter1.Fill(this.traineeDataSet1.trainigTime);
            // TODO: This line of code loads data into the 'traineeDataSet.trainigTime' table. You can move, or remove it, as needed.
            this.trainigTimeTableAdapter1.Fill(this.traineeDataSet1.trainigTime);
            // TODO: This line of code loads data into the 'traineeDataSet.trainigTime' table. You can move, or remove it, as needed.
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=trainee.mdb;Persist Security Info=True");
            OleDbCommand com = new OleDbCommand("select * from  trainigtime ", con);
            com.Connection = con;
            con.Open();
            OleDbDataAdapter oldb = new OleDbDataAdapter(com);
            DataSet ds = new DataSet();
            oldb.Fill(ds);
            int r = com.ExecuteNonQuery();
            // dataGridView1.DataSource = ds;

            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=trainee.mdb;Persist Security Info=True");
                string str = "select * from trainigtime where id=" + id.ToString();
                 DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(str, con);
                da.Fill(ds);
                string name = (string)ds.Tables[0].Rows[0]["fname"];
                string age = (string)ds.Tables[0].Rows[0]["age"];
                string family = (string)ds.Tables[0].Rows[0]["lname"];
                int TaskAlltrainigtime = (int)ds.Tables[0].Rows[0]["TaskAlltrainigtime"];
                traineeInformation.traineeid = id;
                 con = new OleDbConnection(Properties.Settings.Default.traineeConnectionString);
                OleDbCommand com = new OleDbCommand("delete * from trainigTime where id=" + traineeInformation.traineeid, con);
                con.Open();
                try
                {
                    DialogResult  res = MessageBox.Show("رکورد مورد نظر جذف شود", "اخطار", MessageBoxButtons.OKCancel);
                    if (res == DialogResult.OK)
                    {
                        int r = com.ExecuteNonQuery();
                        MessageBox.Show("اطلاعات کاربر پاک شد", "اعلام");
                    }
                }
                catch
                {
                    MessageBox.Show("اطلاعات کاربر پاک نشد", "اشکال");
                }
            }
            catch
            {
                MessageBox.Show("لطفا یک آموزش گیرنده را انتخاب کنید", "اعلام");
            }


 
        }
    }
}