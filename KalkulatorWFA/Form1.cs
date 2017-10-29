using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorWFA
{
    public partial class Kalkulator : Form
    {
        long zmienna1 = 0;
        long zmienna3 = 0;
        long zmienna2 = 0;
        private long liczba(long x)
        {
            if () {
                if (x != 0) {
                    zmienna2 = zmienna2 * 10 + x;

                }
                else
                {
                    zmienna2 = zmienna2 * 10;
                }
                return zmienna2;
            }
        }
        
        private long add(long x, long y)
        {
           long  sum = x + y;
            return sum;
        }
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region buttony 0-9
        private void but_1_Click(object sender, EventArgs e)
        {   // jak obczaje delegaty
            //Button b = new Button();
            //b = (Button)sender;
            long i = 1;
            liczba(i);
            TBx_1.Text = zmienna2.ToString();

            //zmienna = b.Text;
        }
        private void but_2_Click(object sender, EventArgs e)
        {
            long i = 2;
            liczba(i);
            TBx_1.Text =  zmienna2.ToString();
        }
        private void but_3_Click(object sender, EventArgs e)
        {
            long i = 3;
            liczba(i);
            TBx_1.Text = zmienna2.ToString();
        }
        private void but_4_Click(object sender, EventArgs e)
        {
            long i = 4;
            liczba(i);
            TBx_1.Text = zmienna2.ToString();
        }
        private void but_5_Click(object sender, EventArgs e)
        {
            long i = 5;
            liczba(i);
            TBx_1.Text = zmienna2.ToString();
        }
        private void but_6_Click(object sender, EventArgs e)
        {
            long i = 6;
            liczba(i);
            TBx_1.Text = zmienna2.ToString();
        }
        private void but_7_Click(object sender, EventArgs e)
        {
            long i = 7;
            liczba(i);
            TBx_1.Text = zmienna2.ToString();
        }
        private void but_8_Click(object sender, EventArgs e)
        {
            long i = 8;
            liczba(i);
            TBx_1.Text = zmienna2.ToString();
        }
        private void but_9_Click(object sender, EventArgs e)
        {
            long i = 9;
            liczba(i);
            TBx_1.Text = zmienna2.ToString();
        }
        private void but_0_Click(object sender, EventArgs e)
        {
            long i = 0;
            liczba(i);
            TBx_1.Text = zmienna2.ToString();
        }
        #endregion

        public void but_add_Click(object sender, EventArgs e)  // nie dziala
        {
            
            Methods.add(zmienna2, zmienna3);
            TBx_1.Text = "+ " + zmienna3;


        }

    }
}
