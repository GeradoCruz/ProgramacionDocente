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
            pnlDocente = new Panel();
            txtCorreo = new TextBox();
            txtPuesto = new TextBox();
            txtClave = new TextBox();
            txtTelefono = new TextBox();
            txtNombreDocente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pnlUsuario = new Panel();
            cmbPerfil = new ComboBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            dgvDocentes = new DataGridView();
            txtClaveDocente = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            pnlDocente.SuspendLayout();
            pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).BeginInit();
            SuspendLayout();
            // 
            // pnlDocente
            // 
            pnlDocente.BackColor = SystemColors.ActiveCaption;
            pnlDocente.BorderStyle = BorderStyle.Fixed3D;
            pnlDocente.Controls.Add(txtCorreo);
            pnlDocente.Controls.Add(txtPuesto);
            pnlDocente.Controls.Add(txtClave);
            pnlDocente.Controls.Add(txtTelefono);
            pnlDocente.Controls.Add(txtNombreDocente);
            pnlDocente.Location = new Point(218, 79);
            pnlDocente.Name = "pnlDocente";
            pnlDocente.Size = new Size(367, 276);
            pnlDocente.TabIndex = 0;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(42, 218);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(271, 36);
            txtCorreo.TabIndex = 7;
            // 
            // txtPuesto
            // 
            txtPuesto.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPuesto.Location = new Point(42, 117);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.PlaceholderText = "Puesto";
            txtPuesto.Size = new Size(271, 36);
            txtPuesto.TabIndex = 6;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(42, 25);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Clave";
            txtClave.Size = new Size(271, 36);
            txtClave.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(42, 166);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Teléfono";
            txtTelefono.Size = new Size(271, 36);
            txtTelefono.TabIndex = 5;
            // 
            // txtNombreDocente
            // 
            txtNombreDocente.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreDocente.Location = new Point(42, 72);
            txtNombreDocente.Name = "txtNombreDocente";
            txtNombreDocente.PlaceholderText = "Nombre del docente";
            txtNombreDocente.Size = new Size(271, 36);
            txtNombreDocente.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(517, -5);
            label1.Name = "label1";
            label1.Size = new Size(197, 60);
            label1.TabIndex = 1;
            label1.Text = "Docente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(218, 48);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 2;
            label2.Text = "Docente";
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = SystemColors.ActiveCaption;
            pnlUsuario.BorderStyle = BorderStyle.Fixed3D;
            pnlUsuario.Controls.Add(cmbPerfil);
            pnlUsuario.Controls.Add(txtPassword);
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.Location = new Point(678, 79);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(469, 276);
            pnlUsuario.TabIndex = 1;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Location = new Point(96, 139);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(271, 38);
            cmbPerfil.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(96, 84);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(271, 36);
            txtPassword.TabIndex = 9;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(96, 25);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(271, 36);
            txtUsuario.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(678, 48);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 3;
            label3.Text = "Usuario";
            // 
            // dgvDocentes
            // 
            dgvDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocentes.Location = new Point(90, 481);
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.RowHeadersWidth = 51;
            dgvDocentes.Size = new Size(1149, 219);
            dgvDocentes.TabIndex = 4;
            dgvDocentes.SelectionChanged += dgvDocentes_SelectionChanged;
            // 
            // txtClaveDocente
            // 
            txtClaveDocente.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClaveDocente.Location = new Point(968, 438);
            txtClaveDocente.Name = "txtClaveDocente";
            txtClaveDocente.PlaceholderText = "Buscar por clave";
            txtClaveDocente.Size = new Size(271, 36);
            txtClaveDocente.TabIndex = 10;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(320, 360);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(183, 62);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(560, 360);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(183, 62);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(821, 360);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(183, 62);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmDocentes
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 712);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtClaveDocente);
            Controls.Add(dgvDocentes);
            Controls.Add(label3);
            Controls.Add(pnlUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlDocente);
            Name = "frmDocentes";
            Text = "frmDocentes";
            pnlDocente.ResumeLayout(false);
            pnlDocente.PerformLayout();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlDocente;
        private Label label1;
        private Label label2;
        private Panel pnlUsuario;
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