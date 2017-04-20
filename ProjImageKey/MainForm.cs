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
    public partial class MainForm : Form
    {
        String AppPath;
        bool f1, f2, f3, f4, f5, f6 , fkey;
        Form form;
        string s1, s2, s3, s4, s5, s6, skey;
        public MainForm()
        {
            InitializeComponent();
            AppPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            AppPath = AppPath.Substring(6);

            s1 = AppPath + "\\file1.png";
            s2 = AppPath + "\\file2.png";
            s3 = AppPath + "\\file3.png";
            s4 = AppPath + "\\file4.png";
            s5 = AppPath + "\\file5.png";
            s6 = AppPath + "\\file6.png";
            skey = AppPath + "\\imgkey.txt";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            f1 = File.Exists(s1);
            f2 = File.Exists(s2);
            f3 = File.Exists(s3);
            f4 = File.Exists(s4);
            f5 = File.Exists(s5);
            f6 = File.Exists(s6);
            fkey = File.Exists(skey);
         
            if (f1 & f2 & f3 & f4 & f5 & f6 & fkey)
            {
                form = new FrmImageKey();
            }
            else
            {
                if (f1)
                {
                    File.Delete(s1);
                }
                if (f2)
                {
                    File.Delete(s2);
                }
                if (f3)
                {
                    File.Delete(s3);
                }
                if(f4)
                {
                    File.Delete(s4);
                }
                if (f5)
                {
                    File.Delete(s5);
                }
                if (f6)
                {
                    File.Delete(s6);
                }
                if (fkey)
                {
                    File.Delete(skey);
                }
                form = new FrmImages();
            }
            form.Show();
           // MainForm.ActiveForm.Close();
        }
    }
}
