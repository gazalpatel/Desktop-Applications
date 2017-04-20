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
    public partial class ShuffleRandom : Form
    {
        int[] original= {1,2,3,4,5,6,7,8,9,10};
        int[] shuffled;
        Random _random = new Random();

        int count = 0;

        public ShuffleRandom()
        {
            InitializeComponent();
        }
        private void BTNshuffle_Click(object sender, EventArgs e)
        {
            Loriginal.Text = "";
            Lshuffled.Text = "";
            foreach (int item in original)
            {
                Loriginal.Text = Loriginal.Text + "  (" + item.ToString() + ") -";
            }
            shuffled = Shuffle<int>(original);
            foreach (int item in shuffled)
            {
                Lshuffled.Text = Lshuffled.Text + "  (" + item.ToString() + ") -";
            }
        }

        public T[] Shuffle<T>(T[] array)
        {
            var random = _random;
            for (int i = array.Length ; i > 1 ; i-- )
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

        private void ShuffleRandom_Load(object sender, EventArgs e)
        {
            Lcount.Text = count.ToString();
            Loriginal.Text = "";
            foreach (int item in original)
            {
                Loriginal.Text = Loriginal.Text + "  (" + item.ToString() + ") -";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            Lcount.Text = count.ToString();
        }
    }
}
