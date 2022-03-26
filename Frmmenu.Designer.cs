namespace examen2
{
    partial class FrmMenu
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
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.formularioDeRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioDeRegistroToolStripMenuItem,
            this.formularioDePedidoToolStripMenuItem,
            this.formularioDePedidosToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(915, 24);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // formularioDeRegistroToolStripMenuItem
            // 
            this.formularioDeRegistroToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.formularioDeRegistroToolStripMenuItem.Name = "formularioDeRegistroToolStripMenuItem";
            this.formularioDeRegistroToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.formularioDeRegistroToolStripMenuItem.Text = "Formulario de registro ";
            this.formularioDeRegistroToolStripMenuItem.Click += new System.EventHandler(this.formularioDeRegistroToolStripMenuItem_Click);
            // 
            // formularioDePedidoToolStripMenuItem
            // 
            this.formularioDePedidoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.formularioDePedidoToolStripMenuItem.Name = "formularioDePedidoToolStripMenuItem";
            this.formularioDePedidoToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.formularioDePedidoToolStripMenuItem.Text = "Formulario de Productos";
            this.formularioDePedidoToolStripMenuItem.Click += new System.EventHandler(this.formularioDePedidoToolStripMenuItem_Click);
            // 
            // formularioDePedidosToolStripMenuItem
            // 
            this.formularioDePedidosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.formularioDePedidosToolStripMenuItem.Name = "formularioDePedidosToolStripMenuItem";
            this.formularioDePedidosToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.formularioDePedidosToolStripMenuItem.Text = "Formulario de pedidos ";
            this.formularioDePedidosToolStripMenuItem.Click += new System.EventHandler(this.formularioDePedidosToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(739, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip3);
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem formularioDeRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioDePedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioDePedidosToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}