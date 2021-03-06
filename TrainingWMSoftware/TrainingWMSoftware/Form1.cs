using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Globalization;
using System.Data.OleDb;
namespace TrainingWMSoftware
{
    public partial class Form1 : Form
    {
        public int timeOfgame;
        public Form1()
        {
            InitializeComponent();
        }
        public System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        private void button1_Click(object sender, EventArgs e)
        {
         
            if (radioButton1.Checked == true)
            {
                grid g = new grid();
                g.Name = "grid1";
                this.Hide();
                g.Show();
            } else if (radioButton2.Checked == true)
            {
                Backward_Digit_Span b = new Backward_Digit_Span();
                this.Hide();            
                b.Show();
            } else if (radioButton3.Checked == true)
            {
                letterSpanTask  l = new letterSpanTask();
                this.Hide();
                l.Show();
            }else if (radioButton4.Checked == true)
            {
                Form3 f = new Form3();
                this.Hide();
                f.Show();
            } else if (radioButton5.Checked == true)
            {
                PseudowordsMachingDismaching p = new PseudowordsMachingDismaching();
                this.Hide();
                p.Show();
            }

            timer1.Start();
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None; this.Left = 0; this.Top = 0;
           this.Bounds = Screen.PrimaryScreen.Bounds;
            // TODO: This line of code loads data into the 'traineeDataSet.trainigTime' table. You can move, or remove it, as needed.
         //   timer1.Start();
//            bool b = System.IO.File.Exists(@"C:\windows\HafezehKary.txt");
//            if (b == true)
//            {
//                MessageBox.Show("با عرض تشکر از شما کاربر محترم دوره استفاده از نرم افزار به صورت رایگان به پایان رسیده است", "اعلام", MessageBoxButtons.OK);
 //               Application.Exit();


 //           }

            System.IO.StreamWriter sw = new System.IO.StreamWriter(Application.StartupPath + "\\0.txt", true);
            sw.Close();
            System.IO.StreamReader sr = new System.IO.StreamReader(Application.StartupPath+"\\0.txt");
            string s2 = sr.ReadLine();
            sr.Close();
            System.IO.StreamWriter sw3 = new System.IO.StreamWriter(Application.StartupPath + "\\0.txt", true);
            sw3.Close();
           sr = new System.IO.StreamReader(Application.StartupPath+@"\\InstallDate.txt");
            s2 = sr.ReadLine();
            sr.Close();
            if (s2 == null )
            {
                sw = new System.IO.StreamWriter(Application.StartupPath + @"\\InstallDate.txt", true);
                sw.Write(1);
                sw.Close();
            }
            else {
                string s = s2.Substring(0, 10);
                CultureInfo provider = CultureInfo.InvariantCulture;
                string format = "yyyy/MM/dd";
                DateTime  dt = DateTime.ParseExact(s,format,provider);
                int installdayofyear = dt.Month * 30 + dt.Day;
                int i = DateTime.Now.Month * 30 + DateTime.Now.Day - installdayofyear;
                if (i > 60) {
                    MessageBox.Show("با عرض تشکر از شما کاربر محترم دوره استفاده از نرم افزار به صورت رایگان به پایان رسیده است","اعلام",MessageBoxButtons.OK);
                    sw = new System.IO.StreamWriter(@"C:\windows\HafezehKary.txt", true);
                    sw.Write(DateTime.Now);
                    sw.Close();
  //                  Application.Exit();

   //         string mounths2 = (System.Convert.ToInt32(s[6], 10));
   //         string mounths3 = (string)s[8];
    //        string mounths4 = (string)s[9];

            }
            sr.Close();

        }}

        private void timer1_Tick(object sender, EventArgs e)
        {

              int lastevent =  traineeInformation.LastEvent.Hour* 60 + traineeInformation.LastEvent.Minute;
                int diff = DateTime.Now.Hour * 60 + DateTime.Now.Minute - lastevent;

                if (diff < 3)
                {

                    OleDbConnection con = new OleDbConnection(Properties.Settings.Default.traineeConnectionString);
                    OleDbCommand com = new OleDbCommand("update trainigtime set TaskAlltrainigTime=TaskAlltrainigTime+1" +" where id = " + (traineeInformation.traineeid).ToString(), con);
                    com.Connection = con;
                    con.Open();
                    try
                    {
                        int r = com.ExecuteNonQuery();
                    }
                        catch
                    {}

                    string str = "select * from trainigtime where id=" + traineeInformation.traineeid.ToString();
                    DataSet ds = new DataSet();
                    OleDbDataAdapter da = new OleDbDataAdapter(str, con);
                    da.Fill(ds);
                    int TaskAlltrainigtime = (int)ds.Tables[0].Rows[0]["TaskAlltrainigtime"];
                    traineeInformation.TaskAlltrainigTime = TaskAlltrainigtime;

                 con.Close();

              }         
                       
            System.IO.StreamWriter sw2 = new System.IO.StreamWriter(@"C:\HafezehKary.txt", true);
            sw2.Write(DateTime.Now);
            sw2.WriteLine("");
            sw2.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            player.SoundLocation = "sounds/background.wav";
            
            player.PlayLooping();

        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}
