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
        int id_distribuidor;
        public FormResultado(string id)
        {
            InitializeComponent();
            id_distribuidor = Int32.Parse(id);
        }

        private void FormResultado_Load(object sender, EventArgs e)
        {
            lbTitulo.Text += id_distribuidor;
        }
    }
}
