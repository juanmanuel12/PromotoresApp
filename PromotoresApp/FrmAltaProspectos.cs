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

namespace PromotoresApp
{
    public partial class FrmAltaProspectos : Form
    {
        public FrmAltaProspectos()
        {
            InitializeComponent();
        }

        // SqlConnection conexion = new SqlConnection("server = LAPTOP - 5V8A1MMI\\SQLEXPRESS ; database= PROMOTORES ; integrated security = true");


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public class UsoBD
        {
            public static SqlConnection ConectaBD(string strConec)
            {
                SqlConnection sqlConnection = new SqlConnection(strConec);
                try
                {
                    sqlConnection.Open();
                    return sqlConnection;
                }
                catch (SqlException)
                {
                    return null;
                }
            }
        }

        public static SqlDataReader Consulta(string instrSelect, SqlConnection conn)
        {
            SqlDataReader sqlDataReader = null;
            SqlCommand sqlCommand = new SqlCommand(instrSelect, conn);
            try
            {
                return sqlCommand.ExecuteReader();
            }
            catch (SqlException)
            {
                conn.Close();
                return null;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Guardar?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPri_Ape.Text) || string.IsNullOrWhiteSpace(txtSeg_Ape.Text) || string.IsNullOrWhiteSpace(txtCalle.Text) || string.IsNullOrWhiteSpace(txtCalle.Text) || string.IsNullOrWhiteSpace(txtNumero.Text) || string.IsNullOrWhiteSpace(txtColonia.Text) || string.IsNullOrWhiteSpace(txtCodi_Post.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtRfc.Text))
                {
                    MessageBox.Show("Información Faltante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string strCon = "Data Source=LAPTOP-5V8A1MMI\\empeño facil;Initial Catalog=Prospecto;Integrated Security=True";
                SqlConnection conn = UsoBD.ConectaBD(strCon);
                if (conn == null)
                {
                    MessageBox.Show("Imposible Conectar con BD");
                    return;
                }
                string Nombre = txtNombre.Text;
                string Primer_Apellido = txtPri_Ape.Text;
                string Segundo_Apellido = txtSeg_Ape.Text;
                string Calle = txtCalle.Text;
                int Numero = Convert.ToInt32(txtNumero.Text);
                string Colonia = txtColonia.Text;
                string Codigo_Postal = txtCodi_Post.Text;
                string Telefono = txtTelefono.Text;
                string RFC = txtRfc.Text;


                string strComandoSQL = "insert into Prospecto";
                strComandoSQL += " values(@Nombre,@Primer_Apellido,@Segundo_Apellido,@Calle,@Numero,@Colonia,@Codigo_Postal,@Telefono,@RFC)";
                SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Primer_Apellido", Primer_Apellido);
                cmd.Parameters.AddWithValue("@Segundo_Apellido", Segundo_Apellido);
                cmd.Parameters.AddWithValue("@Calle", Calle);
                cmd.Parameters.AddWithValue("@Numero", Numero);
                cmd.Parameters.AddWithValue("@Colonia", Colonia);
                cmd.Parameters.AddWithValue("@Codigo_Postal", Codigo_Postal);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@RFC", RFC);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Prospecto dada de alta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                Limpia();


            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpia();
        }
        public void Limpia()
        {
            
            txtNombre.Text = "";
            txtPri_Ape.Text = "";
            txtSeg_Ape.Text = "";
            txtCalle.Text = "";
            txtNumero.Text = "";
            txtColonia.Text = "";
            txtCodi_Post.Text = "";
            txtTelefono.Text = "";
            txtRfc.Text = "";

        }

    }

    
}

