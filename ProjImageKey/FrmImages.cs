using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ProjImageKey
{
    public partial class FrmImages : Form
    {
        String AppPath;
        bool f1, f2, f3, f4, f5, f6;
        public FrmImages()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Bitmap.FromFile(AppPath + "\\error.png");
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Title = "Select your Iamge File..";
            openFileDialog1.FileName = "Choose File..";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Filter = "(*.PNG*)|*.png*";
            String destfile = AppPath + "\\file1.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                File.Delete(destfile);
                File.Copy(openFileDialog1.FileName, destfile, true);
                pictureBox1.Image = Bitmap.FromFile(destfile);
                button1.Text = "Change Image";
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Title = "Select your Iamge File..";
            openFileDialog1.FileName = "Choose File..";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Filter = "(*.PNG*)|*.png*";
            String destfile = AppPath + "\\file2.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName;
                File.Copy(openFileDialog1.FileName, destfile, true);
                pictureBox2.Image = Bitmap.FromFile(destfile);
                button2.Text = "Change Image";
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Title = "Select your Iamge File..";
            openFileDialog1.FileName = "Choose File..";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Filter = "(*.PNG*)|*.png*";
            String destfile = AppPath + "\\file3.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = openFileDialog1.FileName;
                File.Copy(openFileDialog1.FileName, destfile, true);
                pictureBox3.Image = Bitmap.FromFile(destfile);
                button3.Text = "Change Image";
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Title = "Select your Iamge File..";
            openFileDialog1.FileName = "Choose File..";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Filter = "(*.PNG*)|*.png*";
            String destfile = AppPath + "\\file4.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = openFileDialog1.FileName;
                File.Copy(openFileDialog1.FileName, destfile, true);
                pictureBox4.Image = Bitmap.FromFile(destfile);
                button4.Text = "Change Image";
            }
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Title = "Select your Iamge File..";
            openFileDialog1.FileName = "Choose File..";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Filter = "(*.PNG*)|*.png*";
            String destfile = AppPath + "\\file5.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = openFileDialog1.FileName;
                File.Copy(openFileDialog1.FileName, destfile, true);
                pictureBox5.Image = Bitmap.FromFile(destfile);
                button5.Text = "Change Image";
            }
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Title = "Select your Iamge File..";
            openFileDialog1.FileName = "Choose File..";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Filter = "(*.PNG*)|*.png*";
            String destfile = AppPath + "\\file6.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = openFileDialog1.FileName;
                File.Copy(openFileDialog1.FileName, destfile, true);
                pictureBox6.Image = Bitmap.FromFile(destfile);
                button5.Text = "Change Image";
            }
          
        }

        private void BTNnext_Click(object sender, EventArgs e)
        {
            f1 = File.Exists(AppPath+"\\file1.png");
            f2 = File.Exists(AppPath + "\\file2.png");
            f3 = File.Exists(AppPath + "\\file3.png");
            f4 = File.Exists(AppPath + "\\file4.png");
            f5 = File.Exists(AppPath + "\\file5.png");
            f6 = File.Exists(AppPath + "\\file6.png");
            if (f1 & f2 & f3 & f4 & f5 & f6)
            {
                FrmImageKey f = new FrmImageKey();
                f.Show();
            }
            else
            {
                MessageBox.Show("select all files");
            }
        }

        private void FrmImages_Load(object sender, EventArgs e)
        {
           AppPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
           AppPath = AppPath.Substring(6);
           label2.Text = AppPath;
           pictureBox1.Image = Bitmap.FromFile(AppPath + "\\error.png");
           pictureBox2.Image = Bitmap.FromFile(AppPath + "\\error.png");
           pictureBox3.Image = Bitmap.FromFile(AppPath + "\\error.png");
           pictureBox4.Image = Bitmap.FromFile(AppPath + "\\error.png");
           pictureBox5.Image = Bitmap.FromFile(AppPath + "\\error.png");
           pictureBox6.Image = Bitmap.FromFile(AppPath + "\\error.png");
        }

    }
}
