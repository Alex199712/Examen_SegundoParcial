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
    public partial class FacturaForm : Form
    {
        public FacturaForm()
        {
            InitializeComponent();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void confirmarbutton_Click(object sender, EventArgs e)
        {
            if (presenseleecionada() != 'F')
            {
               
            }

            int n = dataGridView1.Rows.Add();      
            char presenseleecionada() 
            {
                char seleccionar = 'F';
                if (pequenaradioButton.Checked == true) { seleccionar = 'P'; }
                if(granderadioButton.Checked == true) { seleccionar = 'G'; }
                return seleccionar ;
            } 



            dataGridView1.Rows[n].Cells[0].Value = nombretextBox.Text;
            dataGridView1.Rows[n].Cells[1].Value = direcciontextBox.Text;
            dataGridView1.Rows[n].Cells[2].Value = comboBox1.SelectedItem;
            dataGridView1.Rows[n].Cells[5].Value = totaltextBox.Text;

            if (nombretextBox.Text == "")
            {

                errorProvider1.SetError(nombretextBox, "Ingrese su nombre");
                nombretextBox.Focus();
        
                         
             
                
                return;
            }
            errorProvider1.SetError(nombretextBox, "");

            if (direcciontextBox.Text == "")
            {

                errorProvider1.SetError(direcciontextBox, "Ingrese la dirrecion");
                direcciontextBox.Focus();

                return;
            }
            errorProvider1.SetError(direcciontextBox, "");

            
        }

         private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            string opcionPequena = Convert.ToString(comboBox1.SelectedIndex);
                if (Convert.ToInt32(opcionPequena) < -1)

                switch (opcionPequena)
                {
                    case("Mentolina"):
                        Class1.pp_mentolina = 4;
                       
                    
                        break;

                    case "Panadol":
                        Class1.pp_panadol = 12;
                        break;

                    case "Neurobion":
                        Class1.pp_neurobion = 45;
                        break;

                    case "Vitamina A":
                        Class1.pp_vitamina = 54;
                        break;

                        
                } return;

             
            int opciongrande = comboBox1.SelectedIndex;
           
            if (opciongrande < -1)

                switch (opciongrande)
                {
                    case 0:
                        Class1.preciogrande_mentolina = 57 ;
                       

                        break;

                    case 1:
                        Class1.preciogrande_panadol = 66;
                        break;

                    case 2:
                        Class1.preciogrande_neurobion = 76;
                        break;

                    case 3 :
                        Class1.preciogrande_vitamina =73;
                        break;
                }
            return;
        }

      

        private void FacturaForm_Load(object sender, EventArgs e)
        {

        
        }

        private void pequenaradioButton_CheckedChanged(object sender, EventArgs e)
        { if (pequenaradioButton.Checked == true) 
            {

                
            }
             



        }

        private void granderadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            nombretextBox.Clear();
            direcciontextBox.Clear();
            dataGridView1.Rows.Clear();
            comboBox1.Items.Clear();
            totaltextBox.Clear();
            
        }

        private void cerrarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            totaltextBox.Text = Convert.ToString(numericUpDown1.Value);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

}