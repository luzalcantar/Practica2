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
        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            using (FormConsulta vConsulta = new FormConsulta())
                vConsulta.ShowDialog();
        }
    }
}
