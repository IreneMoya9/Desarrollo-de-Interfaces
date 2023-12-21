namespace ProyectoWindowsForms_Irene
{
    partial class Form1
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
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            btnSiguiente = new Button();
            btnModificar = new Button();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            lblTipo = new Label();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblSexo = new Label();
            txtGenero = new TextBox();
            lblDatos = new Label();
            lblServicios = new Label();
            lblEuros = new Label();
            btnAnterior = new Button();
            btnGuardar = new Button();
            btnExaminar = new Button();
            cbManicura = new CheckBox();
            cbPintar = new CheckBox();
            lblRegistros = new Label();
            txtRegistros = new TextBox();
            logo = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(192, 258);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(117, 258);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            lblNombre.Click += label1_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(117, 294);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(192, 294);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 5;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(472, 369);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(547, 361);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(44, 23);
            txtPrecio.TabIndex = 8;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSiguiente.Location = new Point(705, 438);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 9;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(234, 481);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.Location = new Point(545, 481);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 12;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(545, 438);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(705, 481);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(60, 481);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(463, 115);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 16;
            label5.Text = "Imagen:";
            label5.Click += label5_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(465, 62);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(33, 15);
            lblTipo.TabIndex = 17;
            lblTipo.Text = "Tipo:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.Location = new Point(117, 330);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 22;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(192, 330);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 23;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSexo.Location = new Point(117, 366);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(48, 15);
            lblSexo.TabIndex = 24;
            lblSexo.Text = "Género:";
            lblSexo.Click += label2_Click;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(192, 366);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(36, 23);
            txtGenero.TabIndex = 25;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDatos.Location = new Point(121, 201);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(207, 29);
            lblDatos.TabIndex = 27;
            lblDatos.Text = "DATOS PERSONALES";
            lblDatos.Click += label1_Click_1;
            // 
            // lblServicios
            // 
            lblServicios.AutoSize = true;
            lblServicios.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblServicios.Location = new Point(466, 25);
            lblServicios.Name = "lblServicios";
            lblServicios.Size = new Size(113, 29);
            lblServicios.TabIndex = 28;
            lblServicios.Text = "SERVICIOS";
            // 
            // lblEuros
            // 
            lblEuros.AutoSize = true;
            lblEuros.Location = new Point(621, 369);
            lblEuros.Name = "lblEuros";
            lblEuros.Size = new Size(72, 15);
            lblEuros.TabIndex = 31;
            lblEuros.Text = "euros aprox.";
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(60, 438);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 23);
            btnAnterior.TabIndex = 32;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(234, 438);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(463, 145);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(65, 41);
            btnExaminar.TabIndex = 34;
            btnExaminar.Text = "Examinar Imagen";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // cbManicura
            // 
            cbManicura.AutoSize = true;
            cbManicura.Location = new Point(550, 61);
            cbManicura.Name = "cbManicura";
            cbManicura.Size = new Size(76, 19);
            cbManicura.TabIndex = 35;
            cbManicura.Text = "Manicura";
            cbManicura.UseVisualStyleBackColor = true;
            cbManicura.CheckedChanged += cbManicura_CheckedChanged;
            // 
            // cbPintar
            // 
            cbPintar.AutoSize = true;
            cbPintar.Location = new Point(550, 86);
            cbPintar.Name = "cbPintar";
            cbPintar.Size = new Size(85, 19);
            cbPintar.TabIndex = 36;
            cbPintar.Text = "Pintar uñas";
            cbPintar.UseVisualStyleBackColor = true;
            cbPintar.CheckedChanged += cbPintar_CheckedChanged;
            // 
            // lblRegistros
            // 
            lblRegistros.AutoSize = true;
            lblRegistros.Location = new Point(389, 442);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(58, 15);
            lblRegistros.TabIndex = 37;
            lblRegistros.Text = "Registros:";
            // 
            // txtRegistros
            // 
            txtRegistros.Location = new Point(389, 481);
            txtRegistros.Name = "txtRegistros";
            txtRegistros.Size = new Size(58, 23);
            txtRegistros.TabIndex = 38;
            // 
            // logo
            // 
            logo.Location = new Point(110, 35);
            logo.Name = "logo";
            logo.Size = new Size(229, 108);
            logo.TabIndex = 39;
            logo.TabStop = false;
            logo.Click += logo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(547, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 230);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(854, 541);
            Controls.Add(logo);
            Controls.Add(txtRegistros);
            Controls.Add(lblRegistros);
            Controls.Add(cbPintar);
            Controls.Add(cbManicura);
            Controls.Add(btnExaminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnAnterior);
            Controls.Add(lblEuros);
            Controls.Add(lblServicios);
            Controls.Add(lblDatos);
            Controls.Add(txtGenero);
            Controls.Add(lblSexo);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(lblTipo);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(btnModificar);
            Controls.Add(btnSiguiente);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtApellido);
            Controls.Add(pictureBox1);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Button btnSiguiente;
        private Button btnModificar;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label5;
        private Label lblTipo;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblSexo;
        private TextBox txtGenero;
        private Label lblDatos;
        private Label lblServicios;
        private Label lblEuros;
        private Button btnAnterior;
        private Button btnGuardar;
        private Button btnExaminar;
        private CheckBox cbManicura;
        private CheckBox cbPintar;
        private Label lblRegistros;
        private TextBox txtRegistros;
        private PictureBox logo;
        private PictureBox pictureBox1;
    }
}