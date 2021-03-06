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
    public partial class FormResultado : Form
    {
        string id_distribuidor;
        conexionbd c = new conexionbd();

        public FormResultado(string id)
        {
            InitializeComponent();
            id_distribuidor = id;
        }

        private void FormResultado_Load(object sender, EventArgs e)
        {
            lbTitulo.Text += id_distribuidor;

            dgvDistribuidor.DataSource = c.consultarID(id_distribuidor);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
