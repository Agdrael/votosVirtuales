using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        //labo
        SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=prueba;Integrated Security=True;");
        private void Form3_Load(object sender, EventArgs e)
        {
            //Ocultar las tabs 
            vUsuario.Appearance = TabAppearance.FlatButtons;
            vUsuario.ItemSize = new Size(0, 1);
            vUsuario.SizeMode = TabSizeMode.Fixed;

            foreach (TabPage tab in vUsuario.TabPages)
            {
                tab.Text = "";
            }
        }

        bool sideBarExpansion;
        private void side_Tick(object sender, EventArgs e)
        {
            

            Panel[] sideBarsContainers = { SideBarContainer, SideBarContainer2, SideBarContainer3, SideBarContainer4 };

            int step = sideBarExpansion ? -10 : 10;

            foreach (Panel container in sideBarsContainers)
            {
                container.Width += step;
                if (sideBarExpansion && container.Width <= container.MinimumSize.Width || !sideBarExpansion && container.Width >= container.MaximumSize.Width)
                {
                    side.Stop();
                    sideBarExpansion = !sideBarExpansion;
                }

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
