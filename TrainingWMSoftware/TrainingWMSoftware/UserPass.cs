using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;
namespace TrainingWMSoftware
{
    public partial class UserPass : Form
    {
        public UserPass()
        {
            InitializeComponent();
        }
        public static string HardDiskID()
        {
            ManagementClass partionsClass = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection partions = partionsClass.GetInstances();

            string hdd = string.Empty;

            foreach (ManagementObject partion in partions)
            {
                hdd = Convert.ToString(partion["VolumeSerialNumber"]);

                if (hdd != string.Empty)
                    return hdd;
            }

            return hdd;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string HID = HardDiskID();
            string s2 = HID.Replace("A", "6");
            string s3 = s2.Replace("B", "7");
            string s4 = s3.Replace("C", "8");
            string s5 = s4.Replace("D", "9");
            string s6 = s5.Replace("E", "0");
            string s7 = s6.Replace("1", "2");
            string s8 = s7.Replace("3", "4");
            string s9 = s8.Replace("5", "6");
            string s10 = s9.Replace("7", "8");
            string s11 = s10.Replace("9", "0");
            string realpassword = s11.Substring(1, 1) + "7" + s11.Substring(5, 1) + "N" + s11.Substring(3, 1) + s11.Substring(6, 1);
            string enteredpass = textBox1.Text;

            if (enteredpass == realpassword)
            {
                Visible = false;
                traineelist t = new traineelist();
                t.Show();
            }
            else

                MessageBox.Show("رمز عبور نادرست است");



            }


        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}