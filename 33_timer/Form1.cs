using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33_timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if(sayac>=0 && sayac <= 30)
            {
                panel1.BackColor = Color.Green;
                panel2.BackColor = DefaultBackColor;
                panel3.BackColor = DefaultBackColor;
            }
            if(sayac>=31 && sayac <= 40)
            {
                panel2.BackColor = Color.Yellow;
                panel1.BackColor = DefaultBackColor;
                panel3.BackColor = DefaultBackColor;
            }
            if(sayac>=41 && sayac <= 71)
            {
                panel3.BackColor = Color.Red;
                panel1.BackColor = DefaultBackColor;
                panel2.BackColor = DefaultBackColor;
            }
            if (sayac == 72)
            {
                sayac = 0;
            }
        }
    }
}
