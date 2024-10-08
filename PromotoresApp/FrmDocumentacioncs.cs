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
using LibreriaBD;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace PromotoresApp
{
    public partial class FrmDocumentacioncs : Form
    {
        public FrmDocumentacioncs()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
           
            string strCon = "Data Source=LAPTOP-5V8A1MMI\\empeño facil;Initial Catalog=Documentos;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }
            string Nombre_Documentos = txtDoc.Text;

            string strCommandoQSL = "insert into Documentos (Nombre_Documentos) ";
            strCommandoQSL += "values(@Nombre_Documentos)";
            SqlCommand cmd = new SqlCommand(strCommandoQSL);
            cmd.Parameters.AddWithValue("@Nombre_Documentos", Nombre_Documentos);
          //  string Nombre_Documentos = txtDoc.Text;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Documentacion dada de alta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
            
        }
    }
}
