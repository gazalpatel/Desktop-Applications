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
    public partial class FrmImageKey : Form
    {
        String AppPath;
        String CatchKey;
        String key;
        int countKey;
        int countResultkey;
        Boolean verify;
        String finalkey = "";
        String verifyingKey = "";
        String keyPath;

        Random _random;
        int count = 0;

        int[] original = { 0, 1, 2, 3, 4, 5 };
        int[] shuffled;
        
        int[] xlist = { 12, 142, 272,  12, 142, 272};
        int[] ylist = { 12,  12,  12, 142, 142, 142};

        public FrmImageKey()
        {
            InitializeComponent();
            countKey = 0;
            countResultkey = 0;
            _random = new Random();
        }

        private void FrmImageKey_Load(object sender, EventArgs e)
        {
            AppPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            AppPath = AppPath.Substring(6);
            keyPath = AppPath + "\\imgkey.txt";

            if (File.Exists(keyPath))
            {
                verify = true;
                BTNsave.Visible = false;
                BTNverify.Visible = true;
            }
            else
            {
                verify = false;
                BTNverify.Visible = false;
                BTNsave.Visible = true;
            }

           
            pictureBox1.Image = Bitmap.FromFile(AppPath + "\\file1.png");
            pictureBox2.Image = Bitmap.FromFile(AppPath + "\\file2.png");
            pictureBox3.Image = Bitmap.FromFile(AppPath + "\\file3.png");
            pictureBox4.Image = Bitmap.FromFile(AppPath + "\\file4.png");
            pictureBox5.Image = Bitmap.FromFile(AppPath + "\\file5.png");
            pictureBox6.Image = Bitmap.FromFile(AppPath + "\\file6.png");

            timer1_Tick(sender, e);
        }

        void addKey(String keyText)
        {
            CatchKey = CatchKey + key;
            countKey = countKey + 1;
        }

        void verifyKey(String keyText)
        {
            CatchKey = CatchKey + key;
            countResultkey = countResultkey + 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("pic 1");
            key = "(file1)";
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("pic 2");
            key = "(file2)";
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            key = "(file3)";
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            key = "(file4)";
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            key = "(file5)";
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            key = "(file6)";
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }
  
        private void BTNsave_Click(object sender, EventArgs e)
        {
             if (countKey < 4)
            {
                MessageBox.Show("invalid key");
                countKey = 0;
            }
            else
            {
                MessageBox.Show("count : " + countKey.ToString() + "\n" + "key : " + CatchKey, "saved key details");
                finalkey = CatchKey;
                using (FileStream fs = File.Create(keyPath))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(finalkey);
                    fs.Write(info, 0, info.Length);
                }
                verify = true;
                BTNsave.Visible = false;
                BTNverify.Visible = true;
                //this.Close();
            }
            CatchKey = "";
        }

        private void BTNverify_Click(object sender, EventArgs e)
        {
            verifyingKey = CatchKey;
            finalkey = File.ReadAllText(keyPath);
            if (finalkey.Equals(verifyingKey))
            {
                MessageBox.Show("key matched", "success");
                this.Close();
            }
            else
            {
                countResultkey = 0;
                CatchKey = "";
                MessageBox.Show("key not matched", "ooops");
            }
        }

        public T[] Shuffle<T>(T[] array)
        {
            var random = _random;
            for (int i = array.Length; i > 1; i--)
            {
                //pick random element to swap
                int j = random.Next(i); // 0<= j<=i-1
                //swap
                T tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }
            return array;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            shuffled = Shuffle<int>(original);
            pictureBox1.Location = new System.Drawing.Point(xlist[shuffled[0]],ylist[shuffled[0]]);
            pictureBox1.TabIndex = shuffled[0];

           // shuffled = Shuffle<int>(original);
            pictureBox2.Location = new System.Drawing.Point(xlist[shuffled[1]], ylist[shuffled[1]]);
            pictureBox2.TabIndex = shuffled[1];

            //shuffled = Shuffle<int>(original);
            pictureBox3.Location = new System.Drawing.Point(xlist[shuffled[2]], ylist[shuffled[2]]);
            pictureBox3.TabIndex = shuffled[2];

            //shuffled = Shuffle<int>(original);
            pictureBox4.Location = new System.Drawing.Point(xlist[shuffled[3]], ylist[shuffled[3]]);
            pictureBox4.TabIndex = shuffled[3];

            //shuffled = Shuffle<int>(original);
            pictureBox5.Location = new System.Drawing.Point(xlist[shuffled[4]], ylist[shuffled[4]]);
            pictureBox5.TabIndex = shuffled[4];

            //shuffled = Shuffle<int>(original);
            pictureBox6.Location = new System.Drawing.Point(xlist[shuffled[5]], ylist[shuffled[5]]);
            pictureBox6.TabIndex = shuffled[5];
        }
    
    }
}
