using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrainingWMSoftware
{
    public partial class PseudowordsMachingDismaching : Form
    {
        public PseudowordsMachingDismaching()
        {
            InitializeComponent();
        }
        int numberofpsudowords = 51;
        string[ , ] Pseudowords4 = new string[51 ,4];
        int sel1 = 0;
        int sel2 = 0;
        int sel3 = 0;
        int sel4 = 0;
        int cell1 ;
        int cell2;
        int negativetime = 100;
        int score = 0;
        int timebetween = 2000;

       // Pseudowords4[0] = 


        private void button1_Click(object sender, EventArgs e)
        {
            traineeInformation.LastEvent = DateTime.Now;

            System.IO.StreamWriter sw = new System.IO.StreamWriter(Application.StartupPath + @"\\lastevent.txt", true);
            sw.Close();
            System.IO.StreamReader sr = new System.IO.StreamReader(Application.StartupPath + @"\\lastevent.txt");
            string s2 = sr.ReadLine();
            sr.Close();
            if (s2 == null)
            {
                sw = new System.IO.StreamWriter(Application.StartupPath + @"\\lastevent.txt", true);
                sw.Write(DateTime.Now);
                sw.Close();
            }
            else
            {
                System.IO.File.Delete(Application.StartupPath + @"\\lastevent.txt");
                sw = new System.IO.StreamWriter(Application.StartupPath + @"\\lastevent.txt", true);
                sw.Write(DateTime.Now);
                sw.Close();
            }


            
            
            
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            
            string ballname = "";
            Control[] ctls;
            ballname = "picturebox4";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                if (pic != null)
                    pic.ImageLocation = Application.StartupPath + "\\images\\questionmark.jpg";
                pic.Refresh();
            }
            ballname = "";
            
            ballname = "picturebox3";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                if (pic != null)
                    pic.ImageLocation = Application.StartupPath + "\\images\\questionmark.jpg";
                pic.Refresh();
            }
            ballname = "";
            ballname = "picturebox2";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                if (pic != null)
                    pic.ImageLocation = Application.StartupPath + "\\images\\questionmark.jpg";
                pic.Refresh();
            }
            ballname = "";
            ballname = "picturebox1";
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                if (pic != null)
                    pic.ImageLocation = Application.StartupPath + "\\images\\questionmark.jpg";
                pic.Refresh();
            }
            tableLayoutPanel1.Refresh();
            sel1 = 0;
            sel2 = 0;
            sel3 = 0;
            sel4 = 0;
            Random random = new Random();
             cell1 = random.Next(1, numberofpsudowords);

             cell2 = random.Next(1, numberofpsudowords);
             while (cell2 == cell1)
             {
                 cell2 = random.Next(1, numberofpsudowords);
             }

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "sounds/numberofpsudowords/" + cell1.ToString() + ".wav";
            player.Play();
            System.Threading.Thread.Sleep(timebetween);
            player.SoundLocation = "sounds/numberofpsudowords/" + cell2.ToString() + ".wav";
            player.Play();
            timer1.Start();


            




          //  Pseudowords4[1] = 


        }

        private void PseudowordsMachingDismaching_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None; this.Left = 0; this.Top = 0; this.Bounds = Screen.PrimaryScreen.Bounds; 
            WindowState = FormWindowState.Maximized;
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";


            Pseudowords4[0,0] = "ب";
            Pseudowords4[0,1] = "ا";
            Pseudowords4[0,2] = "ز";
            Pseudowords4[0, 3] = "";
            
            Pseudowords4[1,0] = "د";
            Pseudowords4[1,1] = "و";
            Pseudowords4[1,2] = "ز";
            Pseudowords4[1, 3] = "";
            
            Pseudowords4[2,0] = "ر";
            Pseudowords4[2,1] = "ا";
            Pseudowords4[2,2] = "ز";
            Pseudowords4[2, 3] = "";
            
            Pseudowords4[3,0] = "س";
            Pseudowords4[3,1] = "و";
            Pseudowords4[3,2] = "ز";
            Pseudowords4[3, 3] = "";
            
            Pseudowords4[4,0] = "ب";
            Pseudowords4[4,1] = "ا";
            Pseudowords4[4,2] = "ر";
            Pseudowords4[4, 3] = "";


            Pseudowords4[5,0] = "ب";
            Pseudowords4[5,1] = "ا";
            Pseudowords4[5,2] = "م";
            Pseudowords4[5, 3] = "";
            
            Pseudowords4[6,0] = "گ";
            Pseudowords4[6,1] = "ا";
            Pseudowords4[6,2] = "ه";
            Pseudowords4[6, 3] = "";
            
            Pseudowords4[7,0] = "ر";
            Pseudowords4[7,1] = "ا";
            Pseudowords4[7,2] = "ه";
            Pseudowords4[7, 3] = "";
            
            Pseudowords4[8,0] = "گ";
            Pseudowords4[8,1] = "ا";
            Pseudowords4[8,2] = "م";
            Pseudowords4[8, 3] = "";
            
            Pseudowords4[9,0] = "د";
            Pseudowords4[9,1] = "ا";
            Pseudowords4[9,2] = "م";
            Pseudowords4[9, 3] = "";

            Pseudowords4[10,0] = "و";
            Pseudowords4[10,1] = "ا";
            Pseudowords4[10,2] = "م";
            Pseudowords4[10, 3] = "";
            
            Pseudowords4[11,0] = "خ";
            Pseudowords4[11,1] = "ا";
            Pseudowords4[11,2] = "م";
            Pseudowords4[11, 3] = "";
            
            Pseudowords4[12,0] = "ن";
            Pseudowords4[12,1] = "ا";
            Pseudowords4[12,2] = "ی";
            Pseudowords4[12, 3] = "";
            
            Pseudowords4[13,0] = "چ";
            Pseudowords4[13,1] = "ا";
            Pseudowords4[13,2] = "ی";
            Pseudowords4[13, 3] = "";
            
            Pseudowords4[14,0] = "و";
            Pseudowords4[14,1] = "ا";
            Pseudowords4[14,2] = "ی";
            Pseudowords4[14, 3] = "";


            Pseudowords4[15,0] = "ر";
            Pseudowords4[15,1] = "و";
            Pseudowords4[15,2] = "ز";
            Pseudowords4[15, 3] = "";
            
            Pseudowords4[16,0] = "س";
            Pseudowords4[16,1] = "ی";
            Pseudowords4[16,2] = "ب";
            Pseudowords4[16, 3] = "";
            
            Pseudowords4[17,0] = "ب";
            Pseudowords4[17,1] = "ی";
            Pseudowords4[17,2] = "ب";
            Pseudowords4[17, 3] = "";
            
            Pseudowords4[18,0] = "ش";
            Pseudowords4[18,1] = "ی";
            Pseudowords4[18,2] = "ر";
            Pseudowords4[18, 3] = "";
            
            Pseudowords4[19,0] = "پ";
            Pseudowords4[19,1] = "و";
            Pseudowords4[19,2] = "ر";
            Pseudowords4[19, 3] = "";


            Pseudowords4[20, 0] = "ک";
            Pseudowords4[20, 1] = "و";
            Pseudowords4[20, 2] = "ر";
            Pseudowords4[20, 3] = "";


            Pseudowords4[21, 0] = "ش";
            Pseudowords4[21, 1] = "ی";
            Pseudowords4[21, 2] = "ن";
            Pseudowords4[21, 3] = "";


            Pseudowords4[22, 0] = "د";
            Pseudowords4[22, 1] = "ی";
            Pseudowords4[22, 2] = "ن";
            Pseudowords4[22, 3] = "";



            Pseudowords4[23, 0] = "ک";
            Pseudowords4[23, 1] = "ی";
            Pseudowords4[23, 2] = "ن";
            Pseudowords4[23, 3] = "";


            Pseudowords4[24, 0] = "خ";
            Pseudowords4[24, 1] = "ی";
            Pseudowords4[24, 2] = "ن";
            Pseudowords4[24, 3] = "";


            Pseudowords4[25, 0] = "ل";
            Pseudowords4[25, 1] = "ی";
            Pseudowords4[25, 2] = "د";
            Pseudowords4[25, 3] = "";

            Pseudowords4[26, 0] = "ن";
            Pseudowords4[26, 1] = "م";
            Pseudowords4[26, 2] = "ا";
            Pseudowords4[26, 3] = "";


            Pseudowords4[27, 0] = "ب";
            Pseudowords4[27, 1] = "ا";
            Pseudowords4[27, 2] = "ف";
            Pseudowords4[27, 3] = "ت";


            Pseudowords4[28, 0] = "د";
            Pseudowords4[28, 1] = "ا";
            Pseudowords4[28, 2] = "ر";
            Pseudowords4[28, 3] = "ت";

            Pseudowords4[29, 0] = "ب";
            Pseudowords4[29, 1] = "ا";
            Pseudowords4[29, 2] = "ز";
            Pseudowords4[29, 3] = "";


            Pseudowords4[30, 0] = "ن";
            Pseudowords4[30, 1] = "ص";
            Pseudowords4[30, 2] = "ب";
            Pseudowords4[30, 3] = "";


            Pseudowords4[31, 0] = "س";
            Pseudowords4[31, 1] = "ا";
            Pseudowords4[31, 2] = "س";
            Pseudowords4[31, 3] = "";

            Pseudowords4[32, 0] = "ش";
            Pseudowords4[32, 1] = "ک";
            Pseudowords4[32, 2] = "ل";
            Pseudowords4[32, 3] = "";


    /*      Pseudowords4[33, 0] = "چ";
            Pseudowords4[33, 1] = "س";
            Pseudowords4[33, 2] = "ب";
            Pseudowords4[33, 3] = "";

            Pseudowords4[34, 0] = "پ";
            Pseudowords4[34, 1] = "و";
            Pseudowords4[34, 2] = "س";
            Pseudowords4[34, 3] = "ت";

            Pseudowords4[35, 0] = "د";
            Pseudowords4[35, 1] = "و";
            Pseudowords4[35, 2] = "س";
            Pseudowords4[35, 3] = "ت";

            Pseudowords4[36, 0] = "د";
            Pseudowords4[36, 1] = "ا";
            Pseudowords4[36, 2] = "ش";
            Pseudowords4[36, 3] = "ت";

            Pseudowords4[37, 0] = "ک";
            Pseudowords4[37, 1] = "ا";
            Pseudowords4[37, 2] = "ش";
            Pseudowords4[37, 3] = "ت";

            Pseudowords4[38, 0] = "ب";
            Pseudowords4[38, 1] = "ا";
            Pseudowords4[38, 2] = "ف";
            Pseudowords4[38, 3] = "ت";

            Pseudowords4[39, 0] = "ک";
            Pseudowords4[39, 1] = "و";
            Pseudowords4[39, 2] = "ف";
            Pseudowords4[39, 3] = "ت";

            Pseudowords4[40, 0] = "ک";
            Pseudowords4[40, 1] = "و";
            Pseudowords4[40, 2] = "ف";
            Pseudowords4[40, 3] = "ت";

            Pseudowords4[41, 0] = "ب";
            Pseudowords4[41, 1] = "ا";
            Pseudowords4[41, 2] = "ف";
            Pseudowords4[41, 3] = "ت";

            Pseudowords4[42, 0] = "ک";
            Pseudowords4[42, 1] = "ا";
            Pseudowords4[42, 2] = "ش";
            Pseudowords4[42, 3] = "ت";

            Pseudowords4[43, 0] = "د";
            Pseudowords4[43, 1] = "ا";
            Pseudowords4[43, 2] = "ش";
            Pseudowords4[43, 3] = "ت";

            Pseudowords4[44, 0] = "د";
            Pseudowords4[44, 1] = "و";
            Pseudowords4[44, 2] = "س";
            Pseudowords4[44, 3] = "ت";

            Pseudowords4[45, 0] = "ن";
            Pseudowords4[45, 1] = "ی";
            Pseudowords4[45, 2] = "ا";
            Pseudowords4[45, 3] = "ز";

            Pseudowords4[46, 0] = "ک";
            Pseudowords4[46, 1] = "م";
            Pseudowords4[46, 2] = "ن";
            Pseudowords4[46, 3] = "د";

            Pseudowords4[47, 0] = "ف";
            Pseudowords4[47, 1] = "ا";
            Pseudowords4[47, 2] = "ر";
            Pseudowords4[47, 3] = "س";

            Pseudowords4[48, 0] = "ک";
            Pseudowords4[48, 1] = "ا";
            Pseudowords4[48, 2] = "ر";
            Pseudowords4[48, 3] = "د";

            Pseudowords4[49, 0] = "گ";
            Pseudowords4[49, 1] = "ر";
            Pseudowords4[49, 2] = "ی";
            Pseudowords4[49, 3] = "س";


            Pseudowords4[50, 0] = "ت";
            Pseudowords4[50, 1] = "ا";
            Pseudowords4[50, 2] = "ف";
            Pseudowords4[50, 3] = "ت";

            Pseudowords4[51, 0] = "گ";
            Pseudowords4[51, 1] = "و";
            Pseudowords4[51, 2] = "ش";
            Pseudowords4[51, 3] = "ت";

            Pseudowords4[52, 0] = "ک";
            Pseudowords4[52, 1] = "ا";
            Pseudowords4[52, 2] = "ب";
            Pseudowords4[52, 3] = "ل";

            Pseudowords4[53, 0] = "خ";
            Pseudowords4[53, 1] = "و";
            Pseudowords4[53, 2] = "ا";
            Pseudowords4[53, 3] = "ب";

            Pseudowords4[54, 0] = "ب";
            Pseudowords4[54, 1] = "ا";
            Pseudowords4[54, 2] = "ف";
            Pseudowords4[54, 3] = "ت";

            Pseudowords4[28, 0] = "د";
            Pseudowords4[28, 1] = "ا";
            Pseudowords4[28, 2] = "ر";
            Pseudowords4[28, 3] = "ت";

            Pseudowords4[29, 0] = "ر";
            Pseudowords4[29, 1] = "ا";
            Pseudowords4[29, 2] = "ن";
            Pseudowords4[29, 3] = "ت";

            Pseudowords4[30, 0] = "پ";
            Pseudowords4[30, 1] = "ا";
            Pseudowords4[30, 2] = "ر";
            Pseudowords4[30, 3] = "س";*/

           Pseudowords4[33, 0] = "ت";
            Pseudowords4[33, 1] = "ا";
            Pseudowords4[33, 2] = "";
            Pseudowords4[33, 3] = "";

            Pseudowords4[34, 0] = "و";
            Pseudowords4[34, 1] = "ا";
            Pseudowords4[34, 2] = "";
            Pseudowords4[35, 3] = "";

            Pseudowords4[35, 0] = "ا";
            Pseudowords4[35, 1] = "ی";
            Pseudowords4[35, 2] = "";
            Pseudowords4[35, 3] = "";

            Pseudowords4[36, 0] = "ک";
            Pseudowords4[36, 1] = "ه";
            Pseudowords4[36, 2] = "";
            Pseudowords4[36, 3] = "";

            Pseudowords4[37, 0] = "ش";
            Pseudowords4[37, 1] = "ب";
            Pseudowords4[37, 2] = "";
            Pseudowords4[37, 3] = "";

            Pseudowords4[38, 0] = "د";
            Pseudowords4[38, 1] = "ر";
            Pseudowords4[38, 2] = "";
            Pseudowords4[38, 3] = "";

            Pseudowords4[39, 0] = "ه";
            Pseudowords4[39, 1] = "ل";
            Pseudowords4[39, 2] = "";
            Pseudowords4[39, 3] = "";

            Pseudowords4[40, 0] = "د";
            Pseudowords4[40, 1] = "و";
            Pseudowords4[40, 2] = "";
            Pseudowords4[40, 3] = "";

            Pseudowords4[41, 0] = "س";
            Pseudowords4[41, 1] = "ه";
            Pseudowords4[41, 2] = "";
            Pseudowords4[41, 3] = "";

            Pseudowords4[42, 0] = "ف";
            Pseudowords4[42, 1] = "ا";
            Pseudowords4[42, 2] = "";
            Pseudowords4[42, 3] = "";
            
            Pseudowords4[43, 0] = "ل";
            Pseudowords4[43, 1] = "ا";
            Pseudowords4[43, 2] = "";
            Pseudowords4[43, 3] = "";

            Pseudowords4[44, 0] = "ک";
            Pseudowords4[44, 1] = "ه";
            Pseudowords4[44, 2] = "";
            Pseudowords4[44, 3] = "";

            Pseudowords4[45, 0] = "ب";
            Pseudowords4[45, 1] = "و";
            Pseudowords4[45, 2] = "";
            Pseudowords4[45, 3] = "";

            Pseudowords4[46, 0] = "خ";
            Pseudowords4[46, 1] = "و";
            Pseudowords4[46, 2] = "";
            Pseudowords4[46, 3] = "";

            Pseudowords4[47, 0] = "ش";
            Pseudowords4[47, 1] = "ا";
            Pseudowords4[47, 2] = "";
            Pseudowords4[47, 3] = "";

            Pseudowords4[48, 0] = "م";
            Pseudowords4[48, 1] = "ا";
            Pseudowords4[48, 2] = "";
            Pseudowords4[48, 3] = "";

            Pseudowords4[49, 0] = "م";
            Pseudowords4[49, 1] = "ی";
            Pseudowords4[49, 2] = "";
            Pseudowords4[49, 3] = "";

            Pseudowords4[50, 0] = "ز";
            Pseudowords4[50, 1] = "ی";
            Pseudowords4[50, 2] = "";
            Pseudowords4[50, 3] = "";

        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int SELL = 0;
            label3.Text = Pseudowords4[cell1 -1,0].ToString();
            label4.Text = Pseudowords4[cell1 -1, 1].ToString();
            label5.Text = Pseudowords4[cell1 -1, 2].ToString();
            label6.Text = Pseudowords4[cell1 - 1, 3].ToString();
            label7.Text = Pseudowords4[cell2 - 1, 0].ToString();
            label8.Text = Pseudowords4[cell2 -1, 1].ToString();
            label9.Text = Pseudowords4[cell2 -1, 2].ToString();
            label10.Text = Pseudowords4[cell2 - 1, 3].ToString();
            timer1.Stop();
            if ((sel1 == 1) & (label3.Text == label7.Text)) {


            string ballname = "";
            Control[] ctls;
                 ballname = "picturebox4";
                ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.ImageLocation = Application.StartupPath+"\\images\\tasavi.jpg";
                }
                SELL++;
            }
            if ((sel1 == 1) & (label3.Text != label7.Text))
            {


                string ballname = "";
                Control[] ctls;
                    ballname = "picturebox4";
                    ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.ImageLocation = Application.StartupPath + "\\images\\zarbdar.jpg";
                }

            }

            if ((sel2 == 1) & (label4.Text == label8.Text))
            {


                string ballname = "";
                Control[] ctls;
                for (int j = 1; j <= 16; j++)
                {
                    ballname = "picturebox3";
                    ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.ImageLocation = Application.StartupPath + "\\images\\tasavi.jpg";
                    }
                }
                SELL++;
 
            }
            if ((sel2 == 1) & (label4.Text != label8.Text))
            {


                string ballname = "";
                Control[] ctls;
                    ballname = "picturebox3";
                    ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.ImageLocation = Application.StartupPath + "\\images\\zarbdar.jpg";
                }
            }

            if ((sel3 == 1) & (label5.Text == label9.Text))
            {


                string ballname = "";
                Control[] ctls;
                    ballname = "picturebox2";
                    ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.ImageLocation = Application.StartupPath + "\\images\\tasavi.jpg";
                }
                SELL++;
            }
            if ((sel3 == 1) & (label5.Text != label9.Text))
            {


                string ballname = "";
                Control[] ctls;
                    ballname = "picturebox2";
                    ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.ImageLocation = Application.StartupPath + "\\images\\zarbdar.jpg";
                }
            }

            if ((sel4 == 1) & (label6.Text == label10.Text))
            {


                string ballname = "";
                Control[] ctls;
                    ballname = "picturebox1";
                    ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.ImageLocation = Application.StartupPath + "\\images\\tasavi.jpg";
                }
                SELL++;
            }
            if ((sel4 == 1) & (label6.Text != label10.Text))
            {


                string ballname = "";
                Control[] ctls;
                   ballname = "picturebox1";
                    ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.ImageLocation = Application.StartupPath + "\\images\\zarbdar.jpg";
                    }
            }
            int ALL = 0;
            if ( label3.Text == label7.Text) ALL++ ;
            if ( label4.Text == label8.Text) ALL++ ;
            if (( label5.Text == label9.Text)&&(label5.Text != "" )) ALL++ ;
            if ((label6.Text == label10.Text)&&(label6.Text != "" )) ALL++;
            int p;
            if (ALL != 0)
                p = (int)Math.Round((double)100 * (SELL / ALL));
            else if (SELL == 0) p = 100; else p = 0;

            if ((p == 100)&(score == 2)) {
                score = 0 ;
                timer1.Interval  = timer1.Interval - 500;
                timebetween = timebetween -100;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
                sound.SoundLocation = "chord.wav";
                sound.Play();
            }
            else if ((p==100)&(ALL !=0)) score++;

            textBox1.Text = p.ToString()+"%";


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            sel1 = 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sel2 = 1;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sel3 = 1;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sel4 = 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "Form1")
                {
                    form.Show();
                    return;
                }
            }
            Form child = new Form();
            child.Name = "Form1";
            child.Owner = this;
            child.Show(this);
            this.Visible = false;

        }
    }
}