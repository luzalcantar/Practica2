using System;
using System.Linq;
using System.Windows.Forms;

namespace Practica2
{
    public partial class FormConsulta : Form
    {
        conexionbd c = new conexionbd();

        public FormConsulta()
        {
            InitializeComponent();
        }

        //Funcion para validar Si el Id es Valido
        private void validarID()
        {
            if (txtID.Text.Trim() != string.Empty)
            {
                btnConsultar.Enabled = true;
                errorProvider1.SetError(txtID, "");
            }
            else
            {
                errorProvider1.SetError(txtID, "Ingrese ID valido");
               
                btnConsultar.Enabled = false;
                txtID.Focus();
            }
        }
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            validarID();
        }

        private void FormID_Load(object sender, EventArgs e)
        {
            btnConsultar.Enabled = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (c.validarID(txtID.Text) > 0)
            {
                using (FormResultado vResultado = new FormResultado(txtID.Text))
                    vResultado.ShowDialog();
            }
            else
            {
                MessageBox.Show("Distribuidor no existente");
            }
                
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
