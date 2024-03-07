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
        
        public Form2()
        {
            InitializeComponent();
        }

        //sin uso
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }



        //Animacion barra lateral
        bool sideBarExpansion;
        private void sidebarTick(object sender, EventArgs e)
        {
            // Tamaño máximo 235, 490 --- Tamaño mínimo 65, 490
            
            //Codigo Optimizado

            Panel[] sideBarsContainers = { SideBarContainer, SideBarContainer2, SideBarContainer3, SideBarContainer4 };

            int step = sideBarExpansion ? -10 : 10;

            foreach (Panel container in sideBarsContainers)
            {
                container.Width += step;
                if (sideBarExpansion && container.Width <= container.MinimumSize.Width || !sideBarExpansion && container.Width >= container.MaximumSize.Width)
                {
                    sidebar.Stop();
                    sideBarExpansion = !sideBarExpansion;
                }
            
            }

            /* Codigo NO optimizado
             *  
             *  if (sideBarExpansion)
             *   {
             *   // Disminuir la anchura
             *   SideBarContainer.Width -= 10;
             *   SideBarContainer2.Width -= 10;
             *   SideBarContainer3.Width -= 10;
             *   SideBarContainer4.Width -= 10;

                // Si alcanza el tamaño mínimo, detener la animación
                if (SideBarContainer.Width <= SideBarContainer.MinimumSize.Width || SideBarContainer2.Width <= SideBarContainer2.MinimumSize.Width || SideBarContainer3.Width <= SideBarContainer3.MinimumSize.Width || SideBarContainer4.Width <= SideBarContainer4.MinimumSize.Width)
                {
                    sidebar.Stop();
                    sideBarExpansion = false;
                }
            }
            else
            {
                // Aumentar la anchura
                SideBarContainer.Width += 10;
                SideBarContainer2.Width += 10;
                SideBarContainer3.Width += 10;
                SideBarContainer4.Width += 10;

                // Si alcanza el tamaño máximo, detener la animación
                if (SideBarContainer.Width >= SideBarContainer.MaximumSize.Width || SideBarContainer2.Width >= SideBarContainer2.MaximumSize.Width || SideBarContainer3.Width >= SideBarContainer3.MaximumSize.Width || SideBarContainer4.Width >= SideBarContainer4.MaximumSize.Width)
                {
                    sidebar.Stop();
                    sideBarExpansion = true;
                }
            }
        */

           
        }
        private void button4_Click(object sender, EventArgs e)
        {
           sidebar.Start();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            sidebar.Start();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            sidebar.Start();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            sidebar.Start();
        }

        //Tab Control paginas 1
        private void button1_Click(object sender, EventArgs e)
        {
            vAdmin.SelectTab(0);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            vAdmin.SelectTab(0);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            vAdmin.SelectTab(0);
        }
        private void button17_Click(object sender, EventArgs e)
        {
            vAdmin.SelectTab(0);
        }

        //Tab Control paginas 2

        private void button2_Click(object sender, EventArgs e)
        {
            vAdmin.SelectTab(1);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            vAdmin.SelectTab(1);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            vAdmin.SelectTab(1);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            vAdmin.SelectTab(1);
        }

        //Tab Control paginas 3
        private void button3_Click(object sender, EventArgs e)
        {
            vAdmin.SelectTab(2);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            vAdmin.SelectTab(2);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            vAdmin.SelectTab(2);
        }
        private void button19_Click(object sender, EventArgs e)
        {
            vAdmin.SelectTab(2);
        }

        //Tab control pagina 4

        private void button20_Click(object sender, EventArgs e)
        {
            vAdmin.SelectTab(3);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            vAdmin.SelectTab(3);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            vAdmin.SelectTab(3);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            vAdmin.SelectTab(3);
        }

        
    }
}
