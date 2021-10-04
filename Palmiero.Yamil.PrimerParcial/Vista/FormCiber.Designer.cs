
namespace Vista
{
    partial class FormCiber
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.rbtComputadora = new System.Windows.Forms.RadioButton();
            this.rbtTelefono = new System.Windows.Forms.RadioButton();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.cmbSoftware = new System.Windows.Forms.ComboBox();
            this.cmbPerifericos = new System.Windows.Forms.ComboBox();
            this.cmbJuegos = new System.Windows.Forms.ComboBox();
            this.gpbServicio = new System.Windows.Forms.GroupBox();
            this.lblSoftware = new System.Windows.Forms.Label();
            this.lblPerifericos = new System.Windows.Forms.Label();
            this.lblJuegos = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.gpbServicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(13, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(169, 57);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "El Vicio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(21, 103);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(44, 151);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 20);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(52, 199);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(35, 20);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI";
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.nudEdad);
            this.gbCliente.Controls.Add(this.txtDNI);
            this.gbCliente.Controls.Add(this.txtApellido);
            this.gbCliente.Controls.Add(this.txtNombre);
            this.gbCliente.Controls.Add(this.lblNombre);
            this.gbCliente.Controls.Add(this.lblDNI);
            this.gbCliente.Controls.Add(this.lblApellido);
            this.gbCliente.Controls.Add(this.lblEdad);
            this.gbCliente.Location = new System.Drawing.Point(12, 100);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(473, 266);
            this.gbCliente.TabIndex = 5;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(346, 27);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(93, 100);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(346, 27);
            this.txtApellido.TabIndex = 6;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(93, 196);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(346, 27);
            this.txtDNI.TabIndex = 7;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(94, 151);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(345, 27);
            this.nudEdad.TabIndex = 8;
            // 
            // rbtComputadora
            // 
            this.rbtComputadora.AutoSize = true;
            this.rbtComputadora.Location = new System.Drawing.Point(21, 60);
            this.rbtComputadora.Name = "rbtComputadora";
            this.rbtComputadora.Size = new System.Drawing.Size(122, 24);
            this.rbtComputadora.TabIndex = 9;
            this.rbtComputadora.TabStop = true;
            this.rbtComputadora.Text = "Computadora";
            this.rbtComputadora.UseVisualStyleBackColor = true;
            // 
            // rbtTelefono
            // 
            this.rbtTelefono.AutoSize = true;
            this.rbtTelefono.Location = new System.Drawing.Point(21, 30);
            this.rbtTelefono.Name = "rbtTelefono";
            this.rbtTelefono.Size = new System.Drawing.Size(88, 24);
            this.rbtTelefono.TabIndex = 10;
            this.rbtTelefono.TabStop = true;
            this.rbtTelefono.Text = "Telefono";
            this.rbtTelefono.UseVisualStyleBackColor = true;
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(12, 688);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(472, 58);
            this.btnComenzar.TabIndex = 11;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            // 
            // cmbSoftware
            // 
            this.cmbSoftware.FormattingEnabled = true;
            this.cmbSoftware.Location = new System.Drawing.Point(176, 104);
            this.cmbSoftware.Name = "cmbSoftware";
            this.cmbSoftware.Size = new System.Drawing.Size(263, 28);
            this.cmbSoftware.TabIndex = 12;
            // 
            // cmbPerifericos
            // 
            this.cmbPerifericos.FormattingEnabled = true;
            this.cmbPerifericos.Location = new System.Drawing.Point(176, 158);
            this.cmbPerifericos.Name = "cmbPerifericos";
            this.cmbPerifericos.Size = new System.Drawing.Size(263, 28);
            this.cmbPerifericos.TabIndex = 13;
            // 
            // cmbJuegos
            // 
            this.cmbJuegos.FormattingEnabled = true;
            this.cmbJuegos.Location = new System.Drawing.Point(176, 209);
            this.cmbJuegos.Name = "cmbJuegos";
            this.cmbJuegos.Size = new System.Drawing.Size(263, 28);
            this.cmbJuegos.TabIndex = 14;
            // 
            // gpbServicio
            // 
            this.gpbServicio.Controls.Add(this.lblJuegos);
            this.gpbServicio.Controls.Add(this.lblPerifericos);
            this.gpbServicio.Controls.Add(this.lblSoftware);
            this.gpbServicio.Controls.Add(this.rbtComputadora);
            this.gpbServicio.Controls.Add(this.cmbJuegos);
            this.gpbServicio.Controls.Add(this.rbtTelefono);
            this.gpbServicio.Controls.Add(this.cmbSoftware);
            this.gpbServicio.Controls.Add(this.cmbPerifericos);
            this.gpbServicio.Location = new System.Drawing.Point(13, 385);
            this.gpbServicio.Name = "gpbServicio";
            this.gpbServicio.Size = new System.Drawing.Size(472, 276);
            this.gpbServicio.TabIndex = 15;
            this.gpbServicio.TabStop = false;
            this.gpbServicio.Text = "Servicio";
            // 
            // lblSoftware
            // 
            this.lblSoftware.AutoSize = true;
            this.lblSoftware.Location = new System.Drawing.Point(92, 107);
            this.lblSoftware.Name = "lblSoftware";
            this.lblSoftware.Size = new System.Drawing.Size(68, 20);
            this.lblSoftware.TabIndex = 15;
            this.lblSoftware.Text = "Software";
            // 
            // lblPerifericos
            // 
            this.lblPerifericos.AutoSize = true;
            this.lblPerifericos.Location = new System.Drawing.Point(83, 161);
            this.lblPerifericos.Name = "lblPerifericos";
            this.lblPerifericos.Size = new System.Drawing.Size(77, 20);
            this.lblPerifericos.TabIndex = 16;
            this.lblPerifericos.Text = "Perifericos";
            // 
            // lblJuegos
            // 
            this.lblJuegos.AutoSize = true;
            this.lblJuegos.Location = new System.Drawing.Point(106, 212);
            this.lblJuegos.Name = "lblJuegos";
            this.lblJuegos.Size = new System.Drawing.Size(54, 20);
            this.lblJuegos.TabIndex = 17;
            this.lblJuegos.Text = "Juegos";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(511, 100);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(450, 645);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // FormCiber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 769);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.gpbServicio);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnComenzar);
            this.Name = "FormCiber";
            this.Text = "El Vicio de Yamil Palmiero 2°D";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.gpbServicio.ResumeLayout(false);
            this.gpbServicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton rbtComputadora;
        private System.Windows.Forms.RadioButton rbtTelefono;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.ComboBox cmbSoftware;
        private System.Windows.Forms.ComboBox cmbPerifericos;
        private System.Windows.Forms.ComboBox cmbJuegos;
        private System.Windows.Forms.GroupBox gpbServicio;
        private System.Windows.Forms.Label lblJuegos;
        private System.Windows.Forms.Label lblPerifericos;
        private System.Windows.Forms.Label lblSoftware;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

