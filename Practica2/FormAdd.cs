using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class FormAdd : Form
    {
        conexionbd c = new conexionbd();
        public FormAdd()
        {
            InitializeComponent();
        }
        private void FormAdd_Load(object sender, EventArgs e)
        {
            
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            using (FormConsulta vConsulta = new FormConsulta())
                vConsulta.ShowDialog();
        }

        int validarCampos()
        {
            if (txtID.Text.Trim() != string.Empty &&
                txtFecha.Text.Trim() != string.Empty &&
                txtNombre.Text.Trim() != string.Empty &&
                txtApellidoP.Text.Trim() != string.Empty &&
                txtApellidoM.Text.Trim() != string.Empty &&
                txtCalle.Text.Trim() != string.Empty &&
                txtNo.Text.Trim() != string.Empty &&
                txtColonia.Text.Trim() != string.Empty )
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == 1)
            {
                errorProvider1.SetError(lbDistribidor, "Ingrese todos los datos del formulario");
            }
            else
            {
                errorProvider1.SetError(lbDistribidor, "");

                if (c.validarID(txtID.Text) == 0)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(c.Insertar(txtID.Text, txtFecha.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtCalle.Text, txtNo.Text, txtColonia.Text), "Mensaje", buttons); ;
                
                    //Limpiar textbox de formulario
                    txtID.Text = "";
                    txtFecha.Text = "";
                    txtNombre.Text = "";
                    txtApellidoP.Text = "";
                    txtApellidoM.Text = "";
                    txtCalle.Text = "";
                    txtNo.Text = "";
                    txtColonia.Text = "";
                }
                else
                {
                    MessageBox.Show("Id de Usuario Existente");

                }  
            }
        }  
    }
}
