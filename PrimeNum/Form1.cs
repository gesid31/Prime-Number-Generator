using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
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
            btnAddAll.Enabled = !string.IsNullOrEmpty(InsertVal.Text);
        }
        
        private void InsertVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void getPrime_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(InsertVal.Text))
            {
                ErrorMsg.Text = "Enter required number";
                clear();
            }
            else if (String.IsNullOrEmpty(PrimeList.Text))
            {
                PrimeList.Items.Clear();
                btnGetPrime.Enabled = false;
                btnAddAll.Enabled = false;
                watch.Start();//Start The Clock
                Thread work = new Thread(SleepTime);
                work.Start();
                int val = Convert.ToInt32(InsertVal.Text.ToString());
                foreach (var i in PrimeNum(val))
                {
                    PrimeList.Items.Add(i.ToString());
                }
                watch.Stop();//Stop the Clock
                timespan.Text = watch.Elapsed.TotalSeconds.ToString();
                btnAddAll.Enabled = true;
                ErrorMsg.Text = "";
            }
        }
        void clear()
        {
            InsertVal.Clear();
            PrimeList.Items.Clear();
            Value.Clear();
            count.Clear();
            timespan.Clear();

        }
        private void SleepTime()
        {
            Thread.Sleep(2000);
        }

        public static IEnumerable<int> PrimeNum(int num)
        {
            if (num > 1)
            {
                yield return 2;
                List<int> primes = new List<int>();
                int ss = 3;
                while (ss <= num)
                {
                    Boolean prime = true;
                    int qs = (int)Math.Sqrt(ss);
                    for (int i = 0; i < primes.Count && primes[i] <= qs; i++)
                    {
                        if (ss % primes[i] == 0)
                        {
                            prime = false;
                            break;
                        }
                    }
                    if (prime)
                    {
                        primes.Add(ss);
                        yield return ss;
                    }
                    ss += 2;
                }
            }
        }

        private void AddAll_Click(object sender, EventArgs e)
        {
            long sum = 0;
            for (int i = 0; i < PrimeList.Items.Count; i++)
            {
                sum += Convert.ToInt32((PrimeList.Items[i]));
            }
            Value.Text = sum.ToString();
            count.Text = PrimeList.Items.Count.ToString();
        }

        private void InsertVal_TextChanged(object sender, EventArgs e)
        {
            btnAddAll.Enabled = !string.IsNullOrEmpty(InsertVal.Text);
            btnGetPrime.Enabled = !string.IsNullOrEmpty(InsertVal.Text);
        }
    }
}
