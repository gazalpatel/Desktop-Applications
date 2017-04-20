using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjGazzKey
{
    public partial class RandomButtons : Form
    {
        Random _random;
        int count = 0;

        int[] original = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] shuffled;
        //0 to 9 arrays for (x,y)
        int[] xlist = {20 , 80 , 140,200,260, 20, 80,140,200,260};
        int[] ylist = {85 , 85 , 85 , 85, 85,140,140,140,140,140};
        //Boolean[] checklist = {false, false, false, false, false, false, false, false, false, false};
        //String places;
        
        Bitmap[] bitBlack = { global::ProjGazzKey.Properties.Resources.black1, global::ProjGazzKey.Properties.Resources.black2, global::ProjGazzKey.Properties.Resources.black3, global::ProjGazzKey.Properties.Resources.black4, global::ProjGazzKey.Properties.Resources.black5, global::ProjGazzKey.Properties.Resources.black6, global::ProjGazzKey.Properties.Resources.black7, global::ProjGazzKey.Properties.Resources.black8, global::ProjGazzKey.Properties.Resources.black9, global::ProjGazzKey.Properties.Resources.black10 };
        
        Bitmap[] bitBlue = { global::ProjGazzKey.Properties.Resources.blue1, global::ProjGazzKey.Properties.Resources.blue2, global::ProjGazzKey.Properties.Resources.blue3, global::ProjGazzKey.Properties.Resources.blue4, global::ProjGazzKey.Properties.Resources.blue5, global::ProjGazzKey.Properties.Resources.blue6, global::ProjGazzKey.Properties.Resources.blue7, global::ProjGazzKey.Properties.Resources.blue8, global::ProjGazzKey.Properties.Resources.blue9, global::ProjGazzKey.Properties.Resources.blue10 };
        
        Bitmap[] bitGreen = { global::ProjGazzKey.Properties.Resources.green1, global::ProjGazzKey.Properties.Resources.green2, global::ProjGazzKey.Properties.Resources.green3, global::ProjGazzKey.Properties.Resources.green4, global::ProjGazzKey.Properties.Resources.green5, global::ProjGazzKey.Properties.Resources.green6, global::ProjGazzKey.Properties.Resources.green7, global::ProjGazzKey.Properties.Resources.green8, global::ProjGazzKey.Properties.Resources.green9, global::ProjGazzKey.Properties.Resources.green10 };
        
        Bitmap[] bitGrey = { global::ProjGazzKey.Properties.Resources.grey1, global::ProjGazzKey.Properties.Resources.grey2, global::ProjGazzKey.Properties.Resources.grey3, global::ProjGazzKey.Properties.Resources.grey4, global::ProjGazzKey.Properties.Resources.grey5, global::ProjGazzKey.Properties.Resources.grey6, global::ProjGazzKey.Properties.Resources.grey7, global::ProjGazzKey.Properties.Resources.grey8, global::ProjGazzKey.Properties.Resources.grey9, global::ProjGazzKey.Properties.Resources.grey10 };
        
        Bitmap[] bitMaroon = { global::ProjGazzKey.Properties.Resources.maroon1, global::ProjGazzKey.Properties.Resources.maroon2, global::ProjGazzKey.Properties.Resources.maroon3, global::ProjGazzKey.Properties.Resources.maroon4, global::ProjGazzKey.Properties.Resources.maroon5, global::ProjGazzKey.Properties.Resources.maroon6, global::ProjGazzKey.Properties.Resources.maroon7, global::ProjGazzKey.Properties.Resources.maroon8, global::ProjGazzKey.Properties.Resources.maroon9, global::ProjGazzKey.Properties.Resources.maroon10 };
        
        Bitmap[] bitOrange = { global::ProjGazzKey.Properties.Resources.ora1, global::ProjGazzKey.Properties.Resources.ora2, global::ProjGazzKey.Properties.Resources.ora3, global::ProjGazzKey.Properties.Resources.ora4, global::ProjGazzKey.Properties.Resources.ora5, global::ProjGazzKey.Properties.Resources.ora6, global::ProjGazzKey.Properties.Resources.ora7, global::ProjGazzKey.Properties.Resources.ora8, global::ProjGazzKey.Properties.Resources.ora9, global::ProjGazzKey.Properties.Resources.ora10 };
        
        Bitmap[] bitPink = { global::ProjGazzKey.Properties.Resources.pink1, global::ProjGazzKey.Properties.Resources.pink2, global::ProjGazzKey.Properties.Resources.pink3, global::ProjGazzKey.Properties.Resources.pink4, global::ProjGazzKey.Properties.Resources.pink5, global::ProjGazzKey.Properties.Resources.pink6, global::ProjGazzKey.Properties.Resources.pink7, global::ProjGazzKey.Properties.Resources.pink8, global::ProjGazzKey.Properties.Resources.pink9, global::ProjGazzKey.Properties.Resources.pink10 };
        
        Bitmap[] bitPurple = { global::ProjGazzKey.Properties.Resources.purple1, global::ProjGazzKey.Properties.Resources.purple2, global::ProjGazzKey.Properties.Resources.purple3, global::ProjGazzKey.Properties.Resources.purple4, global::ProjGazzKey.Properties.Resources.purple5, global::ProjGazzKey.Properties.Resources.purple6, global::ProjGazzKey.Properties.Resources.purple7, global::ProjGazzKey.Properties.Resources.purple8, global::ProjGazzKey.Properties.Resources.purple9, global::ProjGazzKey.Properties.Resources.purple10 };
        
        Bitmap[] bitRed = { global::ProjGazzKey.Properties.Resources.red1, global::ProjGazzKey.Properties.Resources.red2, global::ProjGazzKey.Properties.Resources.red3, global::ProjGazzKey.Properties.Resources.red4, global::ProjGazzKey.Properties.Resources.red5, global::ProjGazzKey.Properties.Resources.red6, global::ProjGazzKey.Properties.Resources.red7, global::ProjGazzKey.Properties.Resources.red8, global::ProjGazzKey.Properties.Resources.red9, global::ProjGazzKey.Properties.Resources.red10 };
        
        Bitmap[] bitYellow = { global::ProjGazzKey.Properties.Resources.yellow1, global::ProjGazzKey.Properties.Resources.yellow2, global::ProjGazzKey.Properties.Resources.yellow3, global::ProjGazzKey.Properties.Resources.yellow4, global::ProjGazzKey.Properties.Resources.yellow5, global::ProjGazzKey.Properties.Resources.yellow6, global::ProjGazzKey.Properties.Resources.yellow7, global::ProjGazzKey.Properties.Resources.yellow8, global::ProjGazzKey.Properties.Resources.yellow9, global::ProjGazzKey.Properties.Resources.yellow10 };
        
        public RandomButtons()
        {
            _random = new Random();
            InitializeComponent();
        }

        private void BTNrefresh_Click(object sender, EventArgs e)
        {
            shuffled = Shuffle<int>(original);

            //places = "";
            //foreach (int item in shuffled)
            //{
            //    places = places + "  (" + item.ToString() + ") -";
            //}
            //MessageBox.Show(places);
          
            button1.Location = new System.Drawing.Point(xlist[shuffled[0]], ylist[shuffled[0]]);
            button1.TabIndex = shuffled[0];
            button1.Image = bitBlack[shuffled[0]];

            button2.Location = new System.Drawing.Point(xlist[shuffled[1]], ylist[shuffled[1]]);
            button2.TabIndex = shuffled[1];
            button2.Image = bitBlue[shuffled[1]];
            
            button3.Location = new System.Drawing.Point(xlist[shuffled[2]], ylist[shuffled[2]]);
            button3.TabIndex = shuffled[2];
            button3.Image = bitGreen[shuffled[2]];
            
            button4.Location = new System.Drawing.Point(xlist[shuffled[3]], ylist[shuffled[3]]);
            button4.TabIndex = shuffled[3];
            button4.Image = bitGrey[shuffled[3]];
            
            button5.Location = new System.Drawing.Point(xlist[shuffled[4]], ylist[shuffled[4]]);
            button5.TabIndex = shuffled[4];
            button5.Image = bitMaroon[shuffled[4]];
            
            button6.Location = new System.Drawing.Point(xlist[shuffled[5]], ylist[shuffled[5]]);
            button6.TabIndex = shuffled[5];
            button6.Image = bitOrange[shuffled[5]];
            
            button7.Location = new System.Drawing.Point(xlist[shuffled[6]], ylist[shuffled[6]]);
            button7.TabIndex = shuffled[6];
            button7.Image = bitPink[shuffled[6]];
            
            button8.Location = new System.Drawing.Point(xlist[shuffled[7]], ylist[shuffled[7]]);
            button8.TabIndex = shuffled[7];
            button8.Image = bitPurple[shuffled[7]];
            
            button9.Location = new System.Drawing.Point(xlist[shuffled[8]], ylist[shuffled[8]]);
            button9.TabIndex = shuffled[8];
            button9.Image = bitRed[shuffled[8]];

            button10.Location = new System.Drawing.Point(xlist[shuffled[9]], ylist[shuffled[9]]);
            button10.TabIndex = shuffled[9];
            button10.Image = bitYellow[shuffled[9]];
            count++;
            Lcount.Text = count.ToString();
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

        private void random_Load(object sender, EventArgs e)
        {
            BTNrefresh_Click(sender, e);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BTNrefresh_Click(sender, e);
        }
    }
}
