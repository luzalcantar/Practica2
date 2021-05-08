using System;
using System.Linq;
using System.Windows.Forms;

namespace Practica2
{
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
        }

        //Funcion para validar si el ID es numerico
        private void validarID()
        {
            if (txtID.Text.Trim() != string.Empty && !txtID.Text.All(Char.IsLetter))
            {
                btnConsultar.Enabled = true;
                errorProvider1.SetError(txtID, "");
            }
            else
            {
                if (txtID.Text.All(Char.IsLetter))
                {
                    errorProvider1.SetError(txtID, "Ingrese ID valido");
                }
                else
                {
                    errorProvider1.SetError(txtID, "Ingrese ID valido");
                }
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
            using (FormResultado vResultado = new FormResultado(txtID.Text))
                vResultado.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
