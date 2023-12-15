namespace Contraseñas
{
    partial class Form2
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gpoAgregar = new System.Windows.Forms.GroupBox();
            this.gpoAgregarUsuario = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.ltbSugerencias = new System.Windows.Forms.ListBox();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gpoAgregarCliente = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radSi = new System.Windows.Forms.RadioButton();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.lblEsNuevo = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gpoAgregar.SuspendLayout();
            this.gpoAgregarUsuario.SuspendLayout();
            this.gpoAgregarCliente.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(315, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(60, 13);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Bienvenido";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(12, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(753, 400);
            this.tabControl2.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gpoAgregar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(745, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gpoAgregar
            // 
            this.gpoAgregar.Controls.Add(this.gpoAgregarUsuario);
            this.gpoAgregar.Controls.Add(this.btnAgregar);
            this.gpoAgregar.Controls.Add(this.gpoAgregarCliente);
            this.gpoAgregar.Controls.Add(this.radSi);
            this.gpoAgregar.Controls.Add(this.radNo);
            this.gpoAgregar.Controls.Add(this.lblEsNuevo);
            this.gpoAgregar.Location = new System.Drawing.Point(6, 6);
            this.gpoAgregar.Name = "gpoAgregar";
            this.gpoAgregar.Size = new System.Drawing.Size(733, 362);
            this.gpoAgregar.TabIndex = 0;
            this.gpoAgregar.TabStop = false;
            this.gpoAgregar.Text = "Agregar";
            // 
            // gpoAgregarUsuario
            // 
            this.gpoAgregarUsuario.Controls.Add(this.lblNombre);
            this.gpoAgregarUsuario.Controls.Add(this.txtIdCliente);
            this.gpoAgregarUsuario.Controls.Add(this.ltbSugerencias);
            this.gpoAgregarUsuario.Controls.Add(this.rtxtDescripcion);
            this.gpoAgregarUsuario.Controls.Add(this.lblDescripcion);
            this.gpoAgregarUsuario.Controls.Add(this.lblUsuarios);
            this.gpoAgregarUsuario.Controls.Add(this.txtUsuario);
            this.gpoAgregarUsuario.Controls.Add(this.txtContra);
            this.gpoAgregarUsuario.Controls.Add(this.lblContra);
            this.gpoAgregarUsuario.Location = new System.Drawing.Point(15, 50);
            this.gpoAgregarUsuario.Name = "gpoAgregarUsuario";
            this.gpoAgregarUsuario.Size = new System.Drawing.Size(320, 211);
            this.gpoAgregarUsuario.TabIndex = 14;
            this.gpoAgregarUsuario.TabStop = false;
            this.gpoAgregarUsuario.Text = "Agregar Usuario y contraseña";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre del cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(107, 22);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(120, 20);
            this.txtIdCliente.TabIndex = 0;
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            // 
            // ltbSugerencias
            // 
            this.ltbSugerencias.FormattingEnabled = true;
            this.ltbSugerencias.Location = new System.Drawing.Point(107, 39);
            this.ltbSugerencias.Name = "ltbSugerencias";
            this.ltbSugerencias.Size = new System.Drawing.Size(120, 95);
            this.ltbSugerencias.TabIndex = 11;
            this.ltbSugerencias.SelectedIndexChanged += new System.EventHandler(this.ltbSugerencias_SelectedIndexChanged);
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(79, 123);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(230, 77);
            this.rtxtDescripcion.TabIndex = 3;
            this.rtxtDescripcion.Text = "";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 123);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Location = new System.Drawing.Point(15, 54);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(43, 13);
            this.lblUsuarios.TabIndex = 5;
            this.lblUsuarios.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(64, 51);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(79, 81);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(100, 20);
            this.txtContra.TabIndex = 2;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(15, 84);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(61, 13);
            this.lblContra.TabIndex = 7;
            this.lblContra.Text = "Contraseña";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(296, 276);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 67);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // gpoAgregarCliente
            // 
            this.gpoAgregarCliente.Controls.Add(this.txtTelefono);
            this.gpoAgregarCliente.Controls.Add(this.txtDireccion);
            this.gpoAgregarCliente.Controls.Add(this.txtCorreo);
            this.gpoAgregarCliente.Controls.Add(this.lblTelefono);
            this.gpoAgregarCliente.Controls.Add(this.lblDireccion);
            this.gpoAgregarCliente.Controls.Add(this.lblCorreo);
            this.gpoAgregarCliente.Controls.Add(this.lblNombreCliente);
            this.gpoAgregarCliente.Controls.Add(this.textBox2);
            this.gpoAgregarCliente.Location = new System.Drawing.Point(348, 50);
            this.gpoAgregarCliente.Name = "gpoAgregarCliente";
            this.gpoAgregarCliente.Size = new System.Drawing.Size(314, 171);
            this.gpoAgregarCliente.TabIndex = 12;
            this.gpoAgregarCliente.TabStop = false;
            this.gpoAgregarCliente.Text = "Datos del cliente";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(75, 106);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(77, 77);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(178, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(64, 48);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(244, 20);
            this.txtCorreo.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(19, 109);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(19, 80);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(19, 48);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "Correo";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(19, 22);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(95, 13);
            this.lblNombreCliente.TabIndex = 1;
            this.lblNombreCliente.Text = "Nombre del cliente";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 20);
            this.textBox2.TabIndex = 4;
            // 
            // radSi
            // 
            this.radSi.AutoSize = true;
            this.radSi.Location = new System.Drawing.Point(387, 18);
            this.radSi.Name = "radSi";
            this.radSi.Size = new System.Drawing.Size(34, 17);
            this.radSi.TabIndex = 10;
            this.radSi.Text = "Si";
            this.radSi.UseVisualStyleBackColor = true;
            this.radSi.CheckedChanged += new System.EventHandler(this.radSi_CheckedChanged);
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Checked = true;
            this.radNo.Location = new System.Drawing.Point(296, 18);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(39, 17);
            this.radNo.TabIndex = 9;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            this.radNo.CheckedChanged += new System.EventHandler(this.radNo_CheckedChanged);
            // 
            // lblEsNuevo
            // 
            this.lblEsNuevo.AutoSize = true;
            this.lblEsNuevo.Location = new System.Drawing.Point(171, 20);
            this.lblEsNuevo.Name = "lblEsNuevo";
            this.lblEsNuevo.Size = new System.Drawing.Size(119, 13);
            this.lblEsNuevo.TabIndex = 0;
            this.lblEsNuevo.Text = "¿ Es un cliente nuevo ?";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.lblBuscar);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(745, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(171, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(19, 25);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 304);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(65, 22);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(745, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 416);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form2";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gpoAgregar.ResumeLayout(false);
            this.gpoAgregar.PerformLayout();
            this.gpoAgregarUsuario.ResumeLayout(false);
            this.gpoAgregarUsuario.PerformLayout();
            this.gpoAgregarCliente.ResumeLayout(false);
            this.gpoAgregarCliente.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox gpoAgregar;
        private System.Windows.Forms.RadioButton radSi;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.Label lblEsNuevo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ListBox ltbSugerencias;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gpoAgregarCliente;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox gpoAgregarUsuario;
    }
}