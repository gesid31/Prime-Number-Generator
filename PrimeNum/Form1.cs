using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PrimeNum
{
    public partial class PrimeGen : Form
    {
        Stopwatch watch = new Stopwatch();//To Track Time
        public PrimeGen()
        {
            InitializeComponent();
            InsertVal.Focus();
        }

        private void getPrime_Click(object sender, EventArgs e)
        {
            getPrime.Enabled = false;
            AddAll.Enabled = false;
            watch.Start();//Start The Clock
            int val = Convert.ToInt32(InsertVal.Text.ToString());
            for (int i = 2; i <= val; i++)
            {
                if ((PrimeNum(i) == true))
                {
                    PrimeList.Items.Add(i.ToString());
                }
            }
            watch.Stop();//Stop the Clock
            timespan.Text = watch.Elapsed.TotalSeconds.ToString();
            getPrime.Enabled = true;
            AddAll.Enabled = true;
        }

        public static bool PrimeNum(int num)
        {
            bool PrimeNum = true;
            int factor = num / 2;
            for (int i = 2; i <= factor; i++)
            {
                if ((num % i) == 0)
                {
                    PrimeNum = false;
                }
            }
            return PrimeNum;
        }

        private void AddAll_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < PrimeList.Items.Count; i++)
            {
                sum += Convert.ToInt32((PrimeList.Items[i]));
            }
            Value.Text = sum.ToString();
            count.Text = PrimeList.Items.Count.ToString();
        }
    }
}
