using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerTest
{
    public partial class Form1 : Form
    {
        private int _tempo; 
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _tempo++;
            lblTempo.Text = _tempo.ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
