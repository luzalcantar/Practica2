
namespace Practica2
{
    partial class FormConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el ID del Distribuidor que desea consultar";
            // 
            // btnConsultar
            // 
            this.btnConsultar.AutoSize = true;
            this.btnConsultar.Location = new System.Drawing.Point(243, 108);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnConsultar.Size = new System.Drawing.Size(117, 50);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(94, 73);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(290, 29);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.Color.Brown;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(120, 108);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.btnCancelar.Size = new System.Drawing.Size(117, 50);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(486, 193);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormConsulta";
            this.Text = "Ingresar ID";
            this.Load += new System.EventHandler(this.FormID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCancelar;
    }
}