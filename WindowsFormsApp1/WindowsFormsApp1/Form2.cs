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
    public partial class Form2 : Form
    {
        bool sideBarExpansion;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sidebarTick(object sender, EventArgs e)
        {
            // Tamaño máximo 235, 490 --- Tamaño mínimo 65, 490

            if (sideBarExpansion)
            {
                // Disminuir la anchura
                SideBarContainer.Width -= 10;

                // Si alcanza el tamaño mínimo, detener la animación
                if (SideBarContainer.Width <= SideBarContainer.MinimumSize.Width)
                {
                    sidebar.Stop();
                    sideBarExpansion = false;
                }
            }
            else
            {
                // Aumentar la anchura
                SideBarContainer.Width += 10;

                // Si alcanza el tamaño máximo, detener la animación
                if (SideBarContainer.Width >= SideBarContainer.MaximumSize.Width)
                {
                    sidebar.Stop();
                    sideBarExpansion = true;
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
           sidebar.Start();
        }
    }
}
