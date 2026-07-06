namespace ProgramacionDocente
{
    partial class frmDocentes
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            txtClave = new TextBox();
            txtNombreDocente = new TextBox();
            txtTelefono = new TextBox();
            txtPuesto = new TextBox();
            txtCorreo = new TextBox();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            cmbPerfil = new ComboBox();
            label3 = new Label();
            dgvDocentes = new DataGridView();
            txtClaveDocente = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtPuesto);
            panel1.Controls.Add(txtClave);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtNombreDocente);
            panel1.Location = new Point(218, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 291);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(517, -6);
            label1.Name = "label1";
            label1.Size = new Size(210, 62);
            label1.TabIndex = 1;
            label1.Text = "Docente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(218, 51);
            label2.Name = "label2";
            label2.Size = new Size(91, 28);
            label2.TabIndex = 2;
            label2.Text = "Docente";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(cmbPerfil);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsuario);
            panel2.Location = new Point(678, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(469, 291);
            panel2.TabIndex = 1;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(42, 26);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Clave";
            txtClave.Size = new Size(271, 38);
            txtClave.TabIndex = 3;
            // 
            // txtNombreDocente
            // 
            txtNombreDocente.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreDocente.Location = new Point(42, 76);
            txtNombreDocente.Name = "txtNombreDocente";
            txtNombreDocente.PlaceholderText = "Nombre del docente";
            txtNombreDocente.Size = new Size(271, 38);
            txtNombreDocente.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(42, 175);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Teléfono";
            txtTelefono.Size = new Size(271, 38);
            txtTelefono.TabIndex = 5;
            // 
            // txtPuesto
            // 
            txtPuesto.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPuesto.Location = new Point(42, 122);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.PlaceholderText = "Puesto";
            txtPuesto.Size = new Size(271, 38);
            txtPuesto.TabIndex = 6;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(42, 229);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(271, 38);
            txtCorreo.TabIndex = 7;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(96, 26);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(271, 38);
            txtUsuario.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(96, 88);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(271, 38);
            txtPassword.TabIndex = 9;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Location = new Point(96, 147);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(271, 39);
            cmbPerfil.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(678, 51);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 3;
            label3.Text = "Usuario";
            // 
            // dgvDocentes
            // 
            dgvDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocentes.Location = new Point(90, 506);
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.RowHeadersWidth = 51;
            dgvDocentes.Size = new Size(1149, 231);
            dgvDocentes.TabIndex = 4;
            // 
            // txtClaveDocente
            // 
            txtClaveDocente.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClaveDocente.Location = new Point(968, 462);
            txtClaveDocente.Name = "txtClaveDocente";
            txtClaveDocente.PlaceholderText = "Buscar por clave";
            txtClaveDocente.Size = new Size(271, 38);
            txtClaveDocente.TabIndex = 10;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(320, 379);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(183, 65);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(560, 379);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(183, 65);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(820, 379);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(183, 65);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmDocentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 749);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtClaveDocente);
            Controls.Add(dgvDocentes);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "frmDocentes";
            Text = "frmDocentes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private TextBox txtPuesto;
        private TextBox txtClave;
        private TextBox txtTelefono;
        private TextBox txtNombreDocente;
        private TextBox txtCorreo;
        private ComboBox cmbPerfil;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Label label3;
        private DataGridView dgvDocentes;
        private TextBox txtClaveDocente;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}