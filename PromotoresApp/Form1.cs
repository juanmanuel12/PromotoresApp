
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;


namespace PromotoresApp
{

    public partial class FrmMenu : Form
    {
        // static string conexionstri = "server= LAPTOP-5V8A1MMI\\SQLEXPRESS ; database= PROMOTORES ; integrated security = true ";



        public FrmMenu()
        {

            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server = LAPTOP - 5V8A1MMI\\SQLEXPRESS ; database= PROMOTORES ; integrated security = true");


        private void btnAlta_Propecto_Click(object sender, EventArgs e)
        {

            FrmAltaProspectos alt = new FrmAltaProspectos();
            alt.ShowDialog();
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btndoc_Click(object sender, EventArgs e)
        {

            FrmDocumentacioncs doc = new FrmDocumentacioncs();
            doc.ShowDialog();
            
        }
    }
}
