using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ProjGazzKey
{
    public partial class FrmCircularKey : Form
    {
        String key;
        int countKey;
        int countResultkey;
        Boolean verify;
        String finalkey = "";
        String verifyingKey = "";
        String keyPath =@"C:\Users\Public\circularkey.txt";
  
        public FrmCircularKey()
        {
            InitializeComponent();
            label1.Text = ""; countKey = 0;
            countResultkey = 0;
           
           // verify = false;
        }

        void addKey(String keyText)
        {
            label1.Text = label1.Text + key;
            countKey = countKey + 1;
        }

        void verifyKey(String keyText)
        {
            label1.Text = label1.Text + key;
            countResultkey = countResultkey + 1;
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
                MessageBox.Show("count : " + countKey.ToString() + "\n" + "key : " + label1.Text, "saved key details");
                finalkey = label1.Text;
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
            label1.Text = "";
        }

        private void BTNverify_Click(object sender, EventArgs e)
        {
            verifyingKey = label1.Text;
            finalkey = File.ReadAllText(keyPath);
            if (finalkey.Equals(verifyingKey))
            {
                MessageBox.Show("key matched", "success");
                this.Close();
            }
            else
            {
                countResultkey = 0;
                label1.Text = "";
                MessageBox.Show("key not matched","ooops");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            key = button1.Text.ToString();
            if (verify)
            {
                verifyKey(key);  
            }
            else
            {
                addKey(key);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            key = button2.Text.ToString();
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            key = button3.Text.ToString();
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            key = button4.Text.ToString();
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            key = button5.Text.ToString();
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            key = button6.Text.ToString();
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            key = button7.Text.ToString();
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            key = button8.Text.ToString();
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            key = button9.Text.ToString();
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            key = button10.Text.ToString();
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            key = button11.Text.ToString();
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            key = button12.Text.ToString();
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            key = button13.Text.ToString();
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            key = button14.Text.ToString();
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            key = button15.Text.ToString();
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            key = button16.Text.ToString();
            if (verify)
            {
                verifyKey(key);
            }
            else
            {
                addKey(key);
            }
        }

        private void FrmCircularKey_Load(object sender, EventArgs e)
        {
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
        }  
    }
}
