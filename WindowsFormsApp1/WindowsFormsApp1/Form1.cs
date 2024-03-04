using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=prueba;Integrated Security=True");



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            String usuario, contraseña;


            try {

                String query = "SELECT * FROM usarios WHERE nombre ='"+txt_usuario.Text+"'AND contraseña='"+txt_contra.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    usuario = txt_usuario.Text;
                    contraseña = txt_contra.Text;
                    int tUsuario = Convert.ToInt32(dataTable.Rows[0]["tipo_usuario"]);
                    if (tUsuario == 1) {
                        Form2 form2 = new Form2();
                        form2.Show();
                        
                    }
                    else
                    {
                        Form3 form3 = new Form3();
                        form3.Show();
                        
                    }
                                  

                    

                    Console.WriteLine($"ASDSADSAD{usuario}");

                }
                else {
                    MessageBox.Show("Informacion invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_usuario.Clear();
                    txt_contra.Clear();
                }
            } catch {

                MessageBox.Show("Error");

            } finally { 
                conn.Close();
            }

        }
    }
}
