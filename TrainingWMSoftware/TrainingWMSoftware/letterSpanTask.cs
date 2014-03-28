using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrainingWMSoftware
{
    public partial class letterSpanTask : Form
    {
        int[] characters = new int[6];
        int numberofclicks = 0;
        int cell1;
        int cell2;
        int cell3;
        int cell4;
        int cell5;
        int cell6;
        string[] farsialphabet =  { "ا", "ب", "پ", "ت", "ج", "چ", "خ", "د", "ر", "ز", "ژ", "س", "ش", "ع", "غ", "ف", "ق", "ک", "گ", "ل", "م", "ن", "و", "ه", "ی" };
        int hitcounter;
        int[] hitcountArray = new int[6];
        string ballname;
        Control[] ctls;
        int level = 2;
        int poscell1;
        int poscell2;
        int poscell3;
        int poscell4;
        int poscell5;
        int poscell6;
        int forward = 1;
        int suceed = 0;
        public void invispic()
        {
            Control[] ctls;
            for (int i = 1; i < level + 1; i++)
            {
                string ballname1 = "picturebox" + i.ToString();
                ctls = this.Controls.Find(ballname1, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Visible = false;
                    pic.Refresh();
                }
            }
   

        }


        public void clickbutton()
        {
            numberofclicks++;
            if (numberofclicks == 1)
            {
                timer1.Stop();
                hitcounter++;
                if (hitcounter == 7 && level == 6)
                {
                 //   textBox1.Text = farsialphabet[hitcountArray[1] - 1] + "  " + farsialphabet[hitcountArray[2] - 1] + "  " + farsialphabet[hitcountArray[3] - 1] + "  " + farsialphabet[hitcountArray[4] - 1] + "  " + farsialphabet[hitcountArray[5] - 1] + "  " + farsialphabet[hitcountArray[6] - 1];
                    textBox2.Text = farsialphabet[characters[1] - 1] + "  " + farsialphabet[characters[2] - 1] + "  " + farsialphabet[characters[3] - 1] + "  " + farsialphabet[characters[4] - 1] + "  " + farsialphabet[characters[5] - 1] + "  " + farsialphabet[characters[6] - 1];
                    int correctness1;
                    int correctness2;
                    int correctness3;
                    int correctness4;
                    int correctness5;
                    int correctness6;
                    if (forward == 1)
                    {
                        if ((characters[1] == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                        if ((characters[2] == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                        if ((characters[3] == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                        if ((characters[4] == hitcountArray[4])) correctness4 = 1; else correctness4 = 0;
                        if ((characters[5] == hitcountArray[5])) correctness5 = 1; else correctness5 = 0;
                        if ((characters[6] == hitcountArray[6])) correctness6 = 1; else correctness6 = 0;
                    }
                    else
                    {
                        if ((characters[6] == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                        if ((characters[5] == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                        if ((characters[4] == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                        if ((characters[3] == hitcountArray[4])) correctness4 = 1; else correctness4 = 0;
                        if ((characters[2] == hitcountArray[5])) correctness5 = 1; else correctness5 = 0;
                        if ((characters[1] == hitcountArray[6])) correctness6 = 1; else correctness6 = 0;
                    }
                    int correcteness = (int)Math.Round((double)((correctness1 + correctness2 + correctness3 + correctness4 + correctness5 + correctness6) * 16.66));
                    textBox3.Text = correcteness.ToString(); button1.Enabled = true;
                    if (correcteness == 100) suceed++; else suceed = 0;
                    if (suceed == 2)
                    {
                        level++;
                        label4.Text = level.ToString();
                        label4.ForeColor = Color.Red;
                        label4.Refresh();
                        System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
                        sound.SoundLocation = "Fchord.wav";
                        sound.Play(); suceed = 0;
                    }

                }
                if (hitcounter == 6 && level == 5)
                {
                 //   textBox1.Text = farsialphabet[hitcountArray[1] - 1] + "  " + farsialphabet[hitcountArray[2] - 1] + "  " + farsialphabet[hitcountArray[3] - 1] + "  " + farsialphabet[hitcountArray[4] - 1] + "  " + farsialphabet[hitcountArray[5] - 1] ;
                    textBox2.Text = farsialphabet[characters[1] - 1] + "  " + farsialphabet[characters[2] - 1] + "  " + farsialphabet[characters[3] - 1] + "  " + farsialphabet[characters[4] - 1] + "  " + farsialphabet[characters[5] - 1];
                    int correctness1;
                    int correctness2;
                    int correctness3;
                    int correctness4;
                    int correctness5;
                    if (forward == 1)
                    {
                        if ((characters[1] == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                        if ((characters[2] == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                        if ((characters[3] == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                        if ((characters[4] == hitcountArray[4])) correctness4 = 1; else correctness4 = 0;
                        if ((characters[5] == hitcountArray[5])) correctness5 = 1; else correctness5 = 0;
                    }
                    else
                    {
                        if ((characters[5] == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                        if ((characters[4] == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                        if ((characters[3] == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                        if ((characters[2] == hitcountArray[4])) correctness4 = 1; else correctness4 = 0;
                        if ((characters[1] == hitcountArray[5])) correctness5 = 1; else correctness5 = 0;
                    }
                    int correcteness = (int)Math.Round(((double)(correctness1 + correctness2 + correctness3 + correctness4 + correctness5) * 20));
                    textBox3.Text = correcteness.ToString(); button1.Enabled = true;
                    if (correcteness == 100) suceed++; else suceed = 0;
                    if (suceed == 2)
                    {
                        level++;
                        label4.Text = level.ToString();
                        label4.ForeColor = Color.Red;
                        label4.Refresh();
                        System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
                        sound.SoundLocation = "chord.wav";
                        sound.Play();
                        suceed = 0;
                    }
                }
                if (hitcounter == 5 && level == 4)
                {
               //     textBox1.Text = farsialphabet[hitcountArray[1] - 1] + "  " + farsialphabet[hitcountArray[2] - 1] + "  " + farsialphabet[hitcountArray[3] - 1] + "  " + farsialphabet[hitcountArray[4] - 1];
                    textBox2.Text = farsialphabet[characters[1] - 1] + "  " + farsialphabet[characters[2] - 1] + "  " + farsialphabet[characters[3] - 1] + "  " + farsialphabet[characters[4] - 1];
                    int correctness1;
                    int correctness2;
                    int correctness3;
                    int correctness4;
                    if (forward == 1)
                    {
                        if ((characters[1] == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                        if ((characters[2] == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                        if ((characters[3] == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                        if ((characters[4] == hitcountArray[4])) correctness4 = 1; else correctness4 = 0;
                    }
                    else
                    {
                        if ((characters[4] == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                        if ((characters[3] == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                        if ((characters[2] == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                        if ((characters[1] == hitcountArray[4])) correctness4 = 1; else correctness4 = 0;
                    }
                    int correcteness = (int)Math.Round((double)(correctness1 + correctness2 + correctness3 + correctness4) * 25);
                    textBox3.Text = correcteness.ToString(); button1.Enabled = true;
                    if (correcteness == 100) suceed++; else suceed = 0;
                    if (suceed == 2)
                    {
                        level++;
                        label4.Text = level.ToString();
                        label4.ForeColor = Color.Red;
                        label4.Refresh();
                        System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
                        sound.SoundLocation = "chord.wav";
                        sound.Play();
                        suceed = 0;
                    }
                }
                if (hitcounter == 4 && level == 3)
                {
               //     textBox1.Text = farsialphabet[hitcountArray[1]-1] + "  " + farsialphabet[hitcountArray[2]-1] + "  " + farsialphabet[hitcountArray[3]-1];
                    textBox2.Text = farsialphabet[characters[1] - 1] + "  " + farsialphabet[characters[2] - 1] + "  " + farsialphabet[characters[3] - 1];
                    int correctness1;
                    int correctness2;
                    int correctness3;
                    if (forward == 1)
                    {
                        if ((characters[1] == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                        if ((characters[2] == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                        if ((characters[3] == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                    }
                    else
                    {
                        if ((characters[3] == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                        if ((characters[2] == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                        if ((characters[1] == hitcountArray[3])) correctness3 = 1; else correctness3 = 0;
                    }
                    int correcteness = (int)Math.Round((double)(correctness1 + correctness2 + correctness3 ) * 33.33);
                    textBox3.Text = correcteness.ToString(); button1.Enabled = true;
                    if (correcteness == 100) suceed++; else suceed = 0;
                    if (suceed == 2)
                    {
                        level++;
                        label4.Text = level.ToString();
                        label4.ForeColor = Color.Red;
                        label4.Refresh();
                        System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
                        sound.SoundLocation = "chord.wav";
                        sound.Play();
                        suceed = 0;
                    }
                }
                if (hitcounter == 3 && level == 2)
                {
                    //     textBox1.Text = farsialphabet[hitcountArray[1]-1] + "  " + farsialphabet[hitcountArray[2]-1] + "  " + farsialphabet[hitcountArray[3]-1];
                    textBox2.Text = farsialphabet[characters[1] - 1] + "  " + farsialphabet[characters[2] - 1] ;
                    int correctness1;
                    int correctness2;
                    int correctness3;
                    if (forward == 1)
                    {
                        if ((characters[1] == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                        if ((characters[2] == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                    }
                    else
                    {
                        if ((characters[2] == hitcountArray[1])) correctness1 = 1; else correctness1 = 0;
                        if ((characters[1] == hitcountArray[2])) correctness2 = 1; else correctness2 = 0;
                    }
                    int correcteness = (int)Math.Round((double)(correctness1 + correctness2) * 50);
                    textBox3.Text = correcteness.ToString(); button1.Enabled = true;
                    if (correcteness == 100) suceed++; else suceed = 0;
                    if (suceed == 2)
                    {
                        level++;
                        label4.Text = level.ToString();
                        label4.ForeColor = Color.Red;
                        label4.Refresh();
                        System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
                        sound.SoundLocation = "chord.wav";
                        sound.Play();
                        suceed = 0;
                    }
                }
                ballname = "";
                if (hitcounter == 1)
                {
                    ballname = "picturebox" + poscell1.ToString();
                }
                else if (hitcounter == 2)
                {
                    ballname = "picturebox" + poscell2.ToString();
                }
                else if (hitcounter == 3)
                {
                    ballname = "picturebox" + poscell3.ToString();
                }
                else if (hitcounter == 4)
                {
                    ballname = "picturebox" + poscell4.ToString();
                }
                else if (hitcounter == 5)
                {
                    ballname = "picturebox" + poscell5.ToString();
                }
                else if (hitcounter == 6)
                {
                    ballname = "picturebox" + poscell6.ToString();
                }

                invispic();

                Control[] ctls = this.Controls.Find(ballname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Show(); timer1.Start();
                    numberofclicks = 0;
                    numberofclicks = 0;
                    pic.Refresh();
                    timer1.Start();

                }
            }



        }

        public void enablecharacters()
        {
            int i;
            string picname;
            for (i = 7; i <= 39; i++)
            {
                picname = "picturebox" + i.ToString();

                Control[] ctls = this.Controls.Find(picname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Enabled = true;
                    pic.Refresh();

                }

            }



        }


        public letterSpanTask()
        {
            InitializeComponent();
        }

        private void letterSpanTask_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None; this.Left = 0; this.Top = 0; this.Bounds = Screen.PrimaryScreen.Bounds; 
            WindowState = FormWindowState.Maximized;

        }

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

            
            
            
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Refresh();
            textBox2.Refresh();
            textBox3.Refresh();
            cell1 = 0;
            cell2 = 0;
            cell3 = 0;
            cell4 = 0;
            cell5 = 0;
            cell6 = 0;
            poscell1 = 0;
            poscell2 = 0;
            poscell3 = 0;
            poscell4 = 0;
            poscell5 = 0;
            poscell6 = 0;

            forward = 1;

            disablecharacters();
            invispic();
            numberofclicks=0;
            hitcounter = 1;
            button1.Enabled = false;

            Random random = new Random();
            cell1 = random.Next(1, 25);
            cell2 = random.Next(1, 25);
            while (cell2 == cell1)
            {
                cell2 = random.Next(1, 25);
            }

            if ((level != 2))
            {
                cell3 = random.Next(1, 25);
                while ((cell3 == cell1) || (cell3 == cell2))
                {
                    cell3 = random.Next(1, 25);
                }
            }
            if ((level != 3) && (level != 2))
            {
                cell4 = random.Next(1, 25);
                while ((cell4 == cell1) || (cell4 == cell2) || (cell4 == cell3))
                {
                    cell4 = random.Next(1, 25);
                }
            }

            if ((level != 4) && (level != 3) && (level != 2))
            {
                cell5 = random.Next(1, 25);
                while ((cell5 == cell1) || (cell5 == cell2) || (cell5 == cell3) || (cell5 == cell4))
                {
                    cell5 = random.Next(1, 25);


                }
            }

            if ((level != 5) && (level != 4) && (level != 3) && (level != 2))
            {
                cell6 = random.Next(1, 25);
                while ((cell6 == cell1) || (cell6 == cell2) || (cell6 == cell3) || (cell6 == cell4) || (cell6 == cell5))
                {
                    cell6 = random.Next(1, 25);


                }
            }



            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "sounds/letters/" + cell1.ToString() + ".wav";
            player.Play();
            System.Threading.Thread.Sleep(3000);

            player.SoundLocation = "sounds/letters/" + cell2.ToString() + ".wav";
            player.Play();
            System.Threading.Thread.Sleep(3000);

            if ((level != 2) )
            {
                player.SoundLocation = "sounds/letters/" + cell3.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(3000);
            }
            if ((level != 3 )&& (level != 2))
            {
                player.SoundLocation = "sounds/letters/" + cell4.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(3000);
            }

            if ((level != 4) && (level != 3) && (level != 2))
            {
                player.SoundLocation = "sounds/letters/" + cell5.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(3000);
            }

            if ((level != 4) && (level != 5) && (level != 3) && (level != 2))
            {
                player.SoundLocation = "sounds/letters/" + cell6.ToString() + ".wav";
                player.Play();
                System.Threading.Thread.Sleep(3000);
            }



            poscell1 = random.Next(1, level + 1);
            //characters[poscell1] = cell1;
            if (poscell1 == 1) {

                characters[1] = cell1;

            }
            else if (poscell1 == 2)
            {
                characters[1] = cell2;


            }
            else if (poscell1 == 3)
            {
                characters[1] = cell3;


            }
            else if (poscell1 == 4)
            {
                characters[1] = cell4;


            }
            else if (poscell1 == 5)
            {
                characters[1] = cell5;


            }
            else if (poscell1 == 6)
            {
                characters[1] = cell6;


            }


            poscell2 = random.Next(1, level + 1);
            while (poscell2 == poscell1)
            {
                poscell2 = random.Next(1, level + 1);
            }
            //characters[poscell2] = cell2;

            if (poscell2 == 1)
            {

                characters[2] = cell1;

            }
            else if (poscell2 == 2)
            {
                characters[2] = cell2;


            }
            else if (poscell2 == 3)
            {
                characters[2] = cell3;


            }
            else if (poscell2 == 4)
            {
                characters[2] = cell4;


            }
            else if (poscell2 == 5)
            {
                characters[2] = cell5;


            }
            else if (poscell2 == 6)
            {
                characters[2] = cell6;


            }



            if ((level != 2))
            {

                poscell3 = random.Next(1, level + 1);
                while ((poscell3 == poscell1) || (poscell3 == poscell2) )
                {
                    poscell3 = random.Next(1, level + 1);
                }
                //                characters[poscell4] = cell4;
                if (poscell3 == 1)
                {

                    characters[3] = cell1;

                }
                else if (poscell3 == 2)
                {
                    characters[3] = cell2;


                }
                else if (poscell3 == 3)
                {
                    characters[3] = cell3;


                }
                else if (poscell3 == 4)
                {
                    characters[3] = cell4;


                }
                else if (poscell3 == 5)
                {
                    characters[3] = cell5;


                }
                else if (poscell3 == 6)
                {
                    characters[3] = cell6;


                }


            }



            if ((level != 3)&& (level != 2))
            {

                poscell4 = random.Next(1, level + 1);
                while ((poscell4 == poscell1) || (poscell4 == poscell2) || (poscell4 == poscell3))
                {
                    poscell4 = random.Next(1, level + 1);
                }
//                characters[poscell4] = cell4;
                if (poscell4 == 1)
                {

                    characters[4] = cell1;

                }
                else if (poscell4 == 2)
                {
                    characters[4] = cell2;


                }
                else if (poscell4 == 3)
                {
                    characters[4] = cell3;


                }
                else if (poscell4 == 4)
                {
                    characters[4] = cell4;


                }
                else if (poscell4 == 5)
                {
                    characters[4] = cell5;


                }
                else if (poscell4 == 6)
                {
                    characters[4] = cell6;


                }


            }

            if ((level != 4) && (level != 3) && (level != 2))
            {
                 poscell5 = random.Next(1, level + 1);
                while ((poscell5 == poscell1) || (poscell5 == poscell2) || (poscell5 == poscell3) || (poscell5 == poscell4))
                {
                    poscell5 = random.Next(1, level + 1);


                }
                //characters[poscell5] = cell5;
                if (poscell5 == 1)
                {

                    characters[5] = cell1;

                }
                else if (poscell5 == 2)
                {
                    characters[5] = cell2;


                }
                else if (poscell5 == 3)
                {
                    characters[5] = cell3;


                }
                else if (poscell5 == 4)
                {
                    characters[5] = cell4;


                }
                else if (poscell5 == 5)
                {
                    characters[5] = cell5;


                }
                else if (poscell5 == 6)
                {
                    characters[5] = cell6;


                }

            }

            if ((level != 4) && (level != 5) && (level != 3) && (level != 2))
            {
                poscell6 = random.Next(1, level + 1);
                while ((poscell6 == poscell1) || (poscell6 == poscell2) || (poscell6 == poscell3) || (poscell6 == poscell4) || ((poscell6 == poscell5)))
                {
                    poscell6 = random.Next(1, level + 1);


                }
                //characters[poscell6] = cell6;
                if (poscell6 == 1)
                {

                    characters[6] = cell1;

                }
                else if (poscell6 == 2)
                {
                    characters[6] = cell2;


                }
                else if (poscell6 == 3)
                {
                    characters[6] = cell3;


                }
                else if (poscell6 == 4)
                {
                    characters[6] = cell4;


                }
                else if (poscell6 == 5)
                {
                    characters[6] = cell5;


                }
                else if (poscell6 == 6)
                {
                    characters[6] = cell6;


                }

            }

            ballname = "picturebox" + poscell1.ToString();
            ctls = this.Controls.Find(ballname, true);
            if (ctls.Length > 0)
            {
                PictureBox pic = ctls[0] as PictureBox;
                if (pic != null)
                {
                     pic.Show(); timer1.Start();
                    numberofclicks = 0;
   //               System.Threading.Thread.Sleep(3000);


                }
              //  pic.Refresh();
                timer1.Interval = 6000;
                timer1.Start();

            }
            enablecharacters();
            


        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 1;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[0];
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 2;
            clickbutton();
            textBox1.Text = textBox1.Text + " " +  farsialphabet[1];
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 3;
            clickbutton();
            textBox1.Text = textBox1.Text + " "  + farsialphabet[2];

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 4;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[3];
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 5;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[4];

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 5;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[4];

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 6;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[5];

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 8;
            clickbutton();
            textBox1.Text = textBox1.Text + " "  + farsialphabet[7];

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 7;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[6];

        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 8;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[7];

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 11;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[10];

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 9;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[8];

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 10;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[9];

        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 11;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[10];

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 12;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[11];

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 13;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[12];

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 17;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[16];

        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 18;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[17];

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 19;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[18];

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 20;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[19];

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 14;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[13];

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 15;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[14];

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 16;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[15];

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 17;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[16];

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 18;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[17];

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 19;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[18];

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 20;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[19];

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 21;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[20];

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 22;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[21];

        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 23;
            clickbutton();
            textBox1.Text = textBox1.Text + " "  + farsialphabet[22];

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 24;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[23];

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            hitcountArray[hitcounter] = 25;
            clickbutton();
            textBox1.Text = textBox1.Text + " " + farsialphabet[24];

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hitcounter <= level)
            {
                for (int i = 1; i < level + 1; i++)
                {
                    ballname = "picturebox" + i.ToString();
                    Control[] ctls = this.Controls.Find(ballname, true);
                    if (ctls.Length > 0)
                    {
                        PictureBox pic = ctls[0] as PictureBox;
                        if (pic != null)
                            pic.Visible = false;
                        pic.Refresh();
                    }
                }
                timer1.Stop();
            }
            else
            {
                timer1.Stop();
                button1.Enabled = true;
                hitcounter = 0;
                disablecharacters();
            }
        }
        public void disablecharacters()
        {
            int i;
            string picname;
            for (i = 7; i <= 39; i++)
            {
                picname = "picturebox" + i.ToString();

                Control[] ctls = this.Controls.Find(picname, true);
                if (ctls.Length > 0)
                {
                    PictureBox pic = ctls[0] as PictureBox;
                    if (pic != null)
                        pic.Enabled = false;
                    pic.Refresh();

                }

            }



        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}