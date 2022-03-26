using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen2
{
    public partial class ingresarForm : Form
    {
        public ingresarForm()
        {
            InitializeComponent();
           
           
            this.toolTip1.SetToolTip(this.txtusuario, "");
            this.toolTip1.SetToolTip(this.txtcontraseña, "");
        }

        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirmarbutton_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {

                errorProvider1.SetError(txtusuario, "Ingrese el usuario");
                txtusuario.Focus();
                
                return;
            }
            errorProvider1.SetError(txtusuario, "");

            if (txtcontraseña.Text == "")
            {

                errorProvider1.SetError(txtcontraseña, "Ingrese una contraseña");
                txtcontraseña.Focus();

                return;
            }
            errorProvider1.SetError(txtcontraseña, "");

            FrmMenu formulario = new FrmMenu();
            formulario.Show();
            this.Hide();


        }
    }
}


