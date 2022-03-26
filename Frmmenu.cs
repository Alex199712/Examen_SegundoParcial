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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
                    }

        private void formularioDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FacturaForm();
            formulario.Show();
        }

        private void formularioDeRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario= new ingresarForm();
            formulario.Show();
        }

        private void formularioDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FacturaForm();
            formulario.Show();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
