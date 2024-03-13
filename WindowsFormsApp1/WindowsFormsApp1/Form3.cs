using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void side_Tick(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            side.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            side.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vUsuario.SelectTab(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vUsuario.SelectTab(1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            vUsuario.SelectTab(0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            vUsuario.SelectTab(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            side.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vUsuario.SelectTab(2);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            side.Start();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            vUsuario.SelectTab(0);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            vUsuario.SelectTab(0);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            vUsuario.SelectTab(1);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            vUsuario.SelectTab(1);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            vUsuario.SelectTab(2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            vUsuario.SelectTab(2);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            vUsuario.SelectTab(2);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            vUsuario.SelectTab(3);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            vUsuario.SelectTab(3);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            vUsuario.SelectTab(3);
        }

        private void btn_cerrar1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            vUsuario.SelectTab(3);
        }
    }
}
