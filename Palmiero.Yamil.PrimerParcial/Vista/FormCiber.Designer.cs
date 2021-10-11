
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCiber));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.gpbEmpleado = new System.Windows.Forms.GroupBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.rbtNo = new System.Windows.Forms.RadioButton();
            this.rbtSi = new System.Windows.Forms.RadioButton();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.cmbSoftware = new System.Windows.Forms.ComboBox();
            this.cmbPerifericos = new System.Windows.Forms.ComboBox();
            this.cmbJuegos = new System.Windows.Forms.ComboBox();
            this.gpbComputadora = new System.Windows.Forms.GroupBox();
            this.lblJuegos = new System.Windows.Forms.Label();
            this.lblPerifericos = new System.Windows.Forms.Label();
            this.lblSoftware = new System.Windows.Forms.Label();
            this.rtbHistorial = new System.Windows.Forms.RichTextBox();
            this.gpbTelefono = new System.Windows.Forms.GroupBox();
            this.gbCliente.SuspendLayout();
            this.gpbEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.gpbComputadora.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(11, 88);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(34, 136);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 20);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(42, 184);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(35, 20);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI";
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.gpbEmpleado);
            this.gbCliente.Controls.Add(this.nudEdad);
            this.gbCliente.Controls.Add(this.txtDNI);
            this.gbCliente.Controls.Add(this.txtApellido);
            this.gbCliente.Controls.Add(this.txtNombre);
            this.gbCliente.Controls.Add(this.lblNombre);
            this.gbCliente.Controls.Add(this.lblDNI);
            this.gbCliente.Controls.Add(this.lblApellido);
            this.gbCliente.Controls.Add(this.lblEdad);
            this.gbCliente.Location = new System.Drawing.Point(13, 24);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(473, 386);
            this.gbCliente.TabIndex = 5;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // gpbEmpleado
            // 
            this.gpbEmpleado.Controls.Add(this.txtLegajo);
            this.gpbEmpleado.Controls.Add(this.lblLegajo);
            this.gpbEmpleado.Controls.Add(this.rbtNo);
            this.gpbEmpleado.Controls.Add(this.rbtSi);
            this.gpbEmpleado.Location = new System.Drawing.Point(84, 234);
            this.gpbEmpleado.Name = "gpbEmpleado";
            this.gpbEmpleado.Size = new System.Drawing.Size(331, 129);
            this.gpbEmpleado.TabIndex = 9;
            this.gpbEmpleado.TabStop = false;
            this.gpbEmpleado.Text = "Empleado";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(83, 83);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(203, 27);
            this.txtLegajo.TabIndex = 8;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(18, 86);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(54, 20);
            this.lblLegajo.TabIndex = 2;
            this.lblLegajo.Text = "Legajo";
            // 
            // rbtNo
            // 
            this.rbtNo.AutoSize = true;
            this.rbtNo.Location = new System.Drawing.Point(82, 38);
            this.rbtNo.Name = "rbtNo";
            this.rbtNo.Size = new System.Drawing.Size(50, 24);
            this.rbtNo.TabIndex = 1;
            this.rbtNo.TabStop = true;
            this.rbtNo.Text = "No";
            this.rbtNo.UseVisualStyleBackColor = true;
            // 
            // rbtSi
            // 
            this.rbtSi.AutoSize = true;
            this.rbtSi.Location = new System.Drawing.Point(18, 38);
            this.rbtSi.Name = "rbtSi";
            this.rbtSi.Size = new System.Drawing.Size(42, 24);
            this.rbtSi.TabIndex = 0;
            this.rbtSi.TabStop = true;
            this.rbtSi.Text = "Si";
            this.rbtSi.UseVisualStyleBackColor = true;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(84, 136);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(345, 27);
            this.nudEdad.TabIndex = 8;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(83, 181);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(346, 27);
            this.txtDNI.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(83, 85);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(346, 27);
            this.txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(346, 27);
            this.txtNombre.TabIndex = 5;
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(14, 724);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(472, 58);
            this.btnComenzar.TabIndex = 11;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            // 
            // cmbSoftware
            // 
            this.cmbSoftware.FormattingEnabled = true;
            this.cmbSoftware.Items.AddRange(new object[] {
            "Office",
            "Messenger",
            "ICQ",
            "Ares",
            "Winamp",
            "Napster"});
            this.cmbSoftware.Location = new System.Drawing.Point(152, 38);
            this.cmbSoftware.Name = "cmbSoftware";
            this.cmbSoftware.Size = new System.Drawing.Size(263, 28);
            this.cmbSoftware.TabIndex = 12;
            // 
            // cmbPerifericos
            // 
            this.cmbPerifericos.FormattingEnabled = true;
            this.cmbPerifericos.Items.AddRange(new object[] {
            "Camara",
            "Auriculares",
            "Microfono"});
            this.cmbPerifericos.Location = new System.Drawing.Point(152, 92);
            this.cmbPerifericos.Name = "cmbPerifericos";
            this.cmbPerifericos.Size = new System.Drawing.Size(263, 28);
            this.cmbPerifericos.TabIndex = 13;
            // 
            // cmbJuegos
            // 
            this.cmbJuegos.FormattingEnabled = true;
            this.cmbJuegos.Items.AddRange(new object[] {
            "Counter Strike",
            "Diablo II",
            "Commandos",
            "Monkey Island",
            "Warcraft III",
            "Age of Empires II"});
            this.cmbJuegos.Location = new System.Drawing.Point(152, 143);
            this.cmbJuegos.Name = "cmbJuegos";
            this.cmbJuegos.Size = new System.Drawing.Size(263, 28);
            this.cmbJuegos.TabIndex = 14;
            // 
            // gpbComputadora
            // 
            this.gpbComputadora.Controls.Add(this.lblJuegos);
            this.gpbComputadora.Controls.Add(this.lblPerifericos);
            this.gpbComputadora.Controls.Add(this.lblSoftware);
            this.gpbComputadora.Controls.Add(this.cmbJuegos);
            this.gpbComputadora.Controls.Add(this.cmbSoftware);
            this.gpbComputadora.Controls.Add(this.cmbPerifericos);
            this.gpbComputadora.Location = new System.Drawing.Point(13, 431);
            this.gpbComputadora.Name = "gpbComputadora";
            this.gpbComputadora.Size = new System.Drawing.Size(472, 265);
            this.gpbComputadora.TabIndex = 15;
            this.gpbComputadora.TabStop = false;
            this.gpbComputadora.Text = "Computadora";
            // 
            // lblJuegos
            // 
            this.lblJuegos.AutoSize = true;
            this.lblJuegos.Location = new System.Drawing.Point(82, 146);
            this.lblJuegos.Name = "lblJuegos";
            this.lblJuegos.Size = new System.Drawing.Size(54, 20);
            this.lblJuegos.TabIndex = 17;
            this.lblJuegos.Text = "Juegos";
            // 
            // lblPerifericos
            // 
            this.lblPerifericos.AutoSize = true;
            this.lblPerifericos.Location = new System.Drawing.Point(59, 95);
            this.lblPerifericos.Name = "lblPerifericos";
            this.lblPerifericos.Size = new System.Drawing.Size(77, 20);
            this.lblPerifericos.TabIndex = 16;
            this.lblPerifericos.Text = "Perifericos";
            // 
            // lblSoftware
            // 
            this.lblSoftware.AutoSize = true;
            this.lblSoftware.Location = new System.Drawing.Point(68, 41);
            this.lblSoftware.Name = "lblSoftware";
            this.lblSoftware.Size = new System.Drawing.Size(68, 20);
            this.lblSoftware.TabIndex = 15;
            this.lblSoftware.Text = "Software";
            // 
            // rtbHistorial
            // 
            this.rtbHistorial.Location = new System.Drawing.Point(511, 341);
            this.rtbHistorial.Name = "rtbHistorial";
            this.rtbHistorial.Size = new System.Drawing.Size(450, 441);
            this.rtbHistorial.TabIndex = 16;
            this.rtbHistorial.Text = "";
            // 
            // gpbTelefono
            // 
            this.gpbTelefono.Location = new System.Drawing.Point(511, 36);
            this.gpbTelefono.Name = "gpbTelefono";
            this.gpbTelefono.Size = new System.Drawing.Size(449, 195);
            this.gpbTelefono.TabIndex = 17;
            this.gpbTelefono.TabStop = false;
            this.gpbTelefono.Text = "Telefono";
            // 
            // FormCiber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 798);
            this.Controls.Add(this.gpbTelefono);
            this.Controls.Add(this.rtbHistorial);
            this.Controls.Add(this.gpbComputadora);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.btnComenzar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCiber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "El Vicio de Yamil Palmiero 2°D";
            this.Load += new System.EventHandler(this.FormCiber_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gpbEmpleado.ResumeLayout(false);
            this.gpbEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.gpbComputadora.ResumeLayout(false);
            this.gpbComputadora.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.ComboBox cmbSoftware;
        private System.Windows.Forms.ComboBox cmbPerifericos;
        private System.Windows.Forms.ComboBox cmbJuegos;
        private System.Windows.Forms.GroupBox gpbComputadora;
        private System.Windows.Forms.Label lblJuegos;
        private System.Windows.Forms.Label lblPerifericos;
        private System.Windows.Forms.Label lblSoftware;
        private System.Windows.Forms.RichTextBox rtbHistorial;
        private System.Windows.Forms.GroupBox gpbEmpleado;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.RadioButton rbtNo;
        private System.Windows.Forms.RadioButton rbtSi;
        private System.Windows.Forms.GroupBox gpbTelefono;
    }
}

