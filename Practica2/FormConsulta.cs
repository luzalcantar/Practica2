﻿using System;
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
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();
        }
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
                    errorProvider1.SetError(txtID, "Ingresar solo numeros");
                }
                else
                {
                    errorProvider1.SetError(txtID, "Ingresar ID");
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
    }
}
