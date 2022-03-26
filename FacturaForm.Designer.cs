
namespace examen2
{
    partial class FacturaForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.preciotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totaltextBox = new System.Windows.Forms.TextBox();
            this.confirmarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.direcciontextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nombretextBox = new System.Windows.Forms.TextBox();
            this.pequenaradioButton = new System.Windows.Forms.RadioButton();
            this.granderadioButton = new System.Windows.Forms.RadioButton();
            this.cerrarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(6, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 286);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre cliente";
            this.nombre.Name = "nombre";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Dirección";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Medicamento";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Presentación";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio unitario";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total a pagar";
            this.Column6.Name = "Column6";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(334, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 31);
            this.label8.TabIndex = 21;
            this.label8.Text = "Pedidos";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mentolina",
            "Panadol",
            "Neurobion",
            "Vitamina A "});
            this.comboBox1.Location = new System.Drawing.Point(521, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(712, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio Unitario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(733, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad";
            // 
            // preciotextBox
            // 
            this.preciotextBox.Location = new System.Drawing.Point(794, 49);
            this.preciotextBox.Name = "preciotextBox";
            this.preciotextBox.Size = new System.Drawing.Size(65, 20);
            this.preciotextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del medicamento";
            // 
            // totaltextBox
            // 
            this.totaltextBox.Location = new System.Drawing.Point(715, 117);
            this.totaltextBox.Name = "totaltextBox";
            this.totaltextBox.Size = new System.Drawing.Size(65, 20);
            this.totaltextBox.TabIndex = 9;
            // 
            // confirmarbutton
            // 
            this.confirmarbutton.Location = new System.Drawing.Point(771, 297);
            this.confirmarbutton.Name = "confirmarbutton";
            this.confirmarbutton.Size = new System.Drawing.Size(111, 50);
            this.confirmarbutton.TabIndex = 1;
            this.confirmarbutton.Text = "Confirmar pedido";
            this.confirmarbutton.UseVisualStyleBackColor = true;
            this.confirmarbutton.Click += new System.EventHandler(this.confirmarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Presentacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total a pagar";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(794, 94);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.Location = new System.Drawing.Point(771, 353);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(111, 50);
            this.cancelarbutton.TabIndex = 17;
            this.cancelarbutton.Text = "Cancelar pedido";
            this.cancelarbutton.UseVisualStyleBackColor = true;
            this.cancelarbutton.Click += new System.EventHandler(this.cancelarbutton_Click);
            // 
            // direcciontextBox
            // 
            this.direcciontextBox.Location = new System.Drawing.Point(148, 88);
            this.direcciontextBox.Name = "direcciontextBox";
            this.direcciontextBox.Size = new System.Drawing.Size(207, 20);
            this.direcciontextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre del cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Direccion";
            // 
            // nombretextBox
            // 
            this.nombretextBox.Location = new System.Drawing.Point(148, 49);
            this.nombretextBox.Name = "nombretextBox";
            this.nombretextBox.Size = new System.Drawing.Size(207, 20);
            this.nombretextBox.TabIndex = 11;
            // 
            // pequenaradioButton
            // 
            this.pequenaradioButton.AutoSize = true;
            this.pequenaradioButton.Location = new System.Drawing.Point(521, 94);
            this.pequenaradioButton.Name = "pequenaradioButton";
            this.pequenaradioButton.Size = new System.Drawing.Size(67, 17);
            this.pequenaradioButton.TabIndex = 19;
            this.pequenaradioButton.TabStop = true;
            this.pequenaradioButton.Text = "pequena";
            this.pequenaradioButton.UseVisualStyleBackColor = true;
            this.pequenaradioButton.CheckedChanged += new System.EventHandler(this.pequenaradioButton_CheckedChanged);
            // 
            // granderadioButton
            // 
            this.granderadioButton.AutoSize = true;
            this.granderadioButton.Location = new System.Drawing.Point(612, 94);
            this.granderadioButton.Name = "granderadioButton";
            this.granderadioButton.Size = new System.Drawing.Size(60, 17);
            this.granderadioButton.TabIndex = 20;
            this.granderadioButton.TabStop = true;
            this.granderadioButton.Text = "Grande";
            this.granderadioButton.UseVisualStyleBackColor = true;
            this.granderadioButton.CheckedChanged += new System.EventHandler(this.granderadioButton_CheckedChanged);
            // 
            // cerrarbutton
            // 
            this.cerrarbutton.Location = new System.Drawing.Point(771, 409);
            this.cerrarbutton.Name = "cerrarbutton";
            this.cerrarbutton.Size = new System.Drawing.Size(111, 42);
            this.cerrarbutton.TabIndex = 22;
            this.cerrarbutton.Text = "Cerrar todo";
            this.cerrarbutton.UseVisualStyleBackColor = true;
            this.cerrarbutton.Click += new System.EventHandler(this.cerrarbutton_Click);
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(894, 618);
            this.Controls.Add(this.cerrarbutton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.granderadioButton);
            this.Controls.Add(this.pequenaradioButton);
            this.Controls.Add(this.nombretextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.direcciontextBox);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmarbutton);
            this.Controls.Add(this.totaltextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.preciotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Name = "FacturaForm";
            this.Text = "Interfaz_Facturación";
            this.Load += new System.EventHandler(this.FacturaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cerrarbutton;
        private System.Windows.Forms.RadioButton granderadioButton;
        private System.Windows.Forms.RadioButton pequenaradioButton;
        private System.Windows.Forms.TextBox nombretextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox direcciontextBox;
        private System.Windows.Forms.Button cancelarbutton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmarbutton;
        private System.Windows.Forms.TextBox totaltextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox preciotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}