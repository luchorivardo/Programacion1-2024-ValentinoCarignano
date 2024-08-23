namespace CPresentacion
{
    partial class ABMAutor
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
            tabControlPrincipal = new TabControl();
            tabListado = new TabPage();
            dgvListadoAutores = new DataGridView();
            tabAlta = new TabPage();
            lbFechaNacimientoAlta = new Label();
            tbFechaNacimientoAlta = new TextBox();
            btnGuardar = new Button();
            tbBiografiaAlta = new TextBox();
            lbBiografiaAlta = new Label();
            lbEmailAlta = new Label();
            tbEmailAlta = new TextBox();
            lbNacionalidadAlta = new Label();
            tbNacionalidadAlta = new TextBox();
            lbTelefonoAlta = new Label();
            tbTelefonoAlta = new TextBox();
            lbApellidoAlta = new Label();
            tbApellidoAlta = new TextBox();
            lblNombreAlta = new Label();
            tbNombreAlta = new TextBox();
            tabModificacion = new TabPage();
            tbIdAutorModificacion = new TextBox();
            lbIdAutorModificacion = new Label();
            lbFechaNacimientoModificacion = new Label();
            tbFechaNacimientoModificacion = new TextBox();
            btnActualizar = new Button();
            tbBiografiaModificacion = new TextBox();
            lbBiografiaModificacion = new Label();
            lbEmailModificacion = new Label();
            tbEmailModificacion = new TextBox();
            lbNacionalidadModificacion = new Label();
            tbNacionalidadModificacion = new TextBox();
            lbTelefonoModificacion = new Label();
            tbTelefonoModificacion = new TextBox();
            lbApellidoModificacion = new Label();
            tbApellidoModificacion = new TextBox();
            bvNombreModificacion = new Label();
            tbNombreModificacion = new TextBox();
            tabBaja = new TabPage();
            openFileDialog1 = new OpenFileDialog();
            tabControlPrincipal.SuspendLayout();
            tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoAutores).BeginInit();
            tabAlta.SuspendLayout();
            tabModificacion.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            tabControlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlPrincipal.Controls.Add(tabListado);
            tabControlPrincipal.Controls.Add(tabAlta);
            tabControlPrincipal.Controls.Add(tabModificacion);
            tabControlPrincipal.Controls.Add(tabBaja);
            tabControlPrincipal.Location = new Point(14, 16);
            tabControlPrincipal.Margin = new Padding(3, 4, 3, 4);
            tabControlPrincipal.Name = "tabControlPrincipal";
            tabControlPrincipal.SelectedIndex = 0;
            tabControlPrincipal.Size = new Size(991, 648);
            tabControlPrincipal.TabIndex = 0;
            tabControlPrincipal.SelectedIndexChanged += tabControlPrincipal_SelectedIndexChanged;
            // 
            // tabListado
            // 
            tabListado.Controls.Add(dgvListadoAutores);
            tabListado.Location = new Point(4, 29);
            tabListado.Margin = new Padding(3, 4, 3, 4);
            tabListado.Name = "tabListado";
            tabListado.Padding = new Padding(3, 4, 3, 4);
            tabListado.Size = new Size(983, 615);
            tabListado.TabIndex = 0;
            tabListado.Text = "Listado";
            tabListado.UseVisualStyleBackColor = true;
            // 
            // dgvListadoAutores
            // 
            dgvListadoAutores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListadoAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoAutores.Location = new Point(3, 4);
            dgvListadoAutores.Margin = new Padding(3, 4, 3, 4);
            dgvListadoAutores.Name = "dgvListadoAutores";
            dgvListadoAutores.RowHeadersWidth = 51;
            dgvListadoAutores.Size = new Size(971, 603);
            dgvListadoAutores.TabIndex = 0;
            // 
            // tabAlta
            // 
            tabAlta.Controls.Add(lbFechaNacimientoAlta);
            tabAlta.Controls.Add(tbFechaNacimientoAlta);
            tabAlta.Controls.Add(btnGuardar);
            tabAlta.Controls.Add(tbBiografiaAlta);
            tabAlta.Controls.Add(lbBiografiaAlta);
            tabAlta.Controls.Add(lbEmailAlta);
            tabAlta.Controls.Add(tbEmailAlta);
            tabAlta.Controls.Add(lbNacionalidadAlta);
            tabAlta.Controls.Add(tbNacionalidadAlta);
            tabAlta.Controls.Add(lbTelefonoAlta);
            tabAlta.Controls.Add(tbTelefonoAlta);
            tabAlta.Controls.Add(lbApellidoAlta);
            tabAlta.Controls.Add(tbApellidoAlta);
            tabAlta.Controls.Add(lblNombreAlta);
            tabAlta.Controls.Add(tbNombreAlta);
            tabAlta.Location = new Point(4, 29);
            tabAlta.Margin = new Padding(3, 4, 3, 4);
            tabAlta.Name = "tabAlta";
            tabAlta.Padding = new Padding(3, 4, 3, 4);
            tabAlta.Size = new Size(983, 615);
            tabAlta.TabIndex = 1;
            tabAlta.Text = "Alta";
            tabAlta.UseVisualStyleBackColor = true;
            // 
            // lbFechaNacimientoAlta
            // 
            lbFechaNacimientoAlta.AutoSize = true;
            lbFechaNacimientoAlta.Location = new Point(445, 161);
            lbFechaNacimientoAlta.Name = "lbFechaNacimientoAlta";
            lbFechaNacimientoAlta.Size = new Size(128, 20);
            lbFechaNacimientoAlta.TabIndex = 11;
            lbFechaNacimientoAlta.Text = "Fecha Nacimiento";
            // 
            // tbFechaNacimientoAlta
            // 
            tbFechaNacimientoAlta.Location = new Point(574, 157);
            tbFechaNacimientoAlta.Margin = new Padding(3, 4, 3, 4);
            tbFechaNacimientoAlta.Name = "tbFechaNacimientoAlta";
            tbFechaNacimientoAlta.Size = new Size(180, 27);
            tbFechaNacimientoAlta.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(470, 507);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tbBiografiaAlta
            // 
            tbBiografiaAlta.Location = new Point(257, 303);
            tbBiografiaAlta.Margin = new Padding(3, 4, 3, 4);
            tbBiografiaAlta.Multiline = true;
            tbBiografiaAlta.Name = "tbBiografiaAlta";
            tbBiografiaAlta.Size = new Size(497, 168);
            tbBiografiaAlta.TabIndex = 6;
            // 
            // lbBiografiaAlta
            // 
            lbBiografiaAlta.AutoSize = true;
            lbBiografiaAlta.Location = new Point(153, 306);
            lbBiografiaAlta.Name = "lbBiografiaAlta";
            lbBiografiaAlta.Size = new Size(70, 20);
            lbBiografiaAlta.TabIndex = 10;
            lbBiografiaAlta.Text = "Biografia";
            // 
            // lbEmailAlta
            // 
            lbEmailAlta.AutoSize = true;
            lbEmailAlta.Location = new Point(153, 224);
            lbEmailAlta.Name = "lbEmailAlta";
            lbEmailAlta.Size = new Size(46, 20);
            lbEmailAlta.TabIndex = 9;
            lbEmailAlta.Text = "Email";
            // 
            // tbEmailAlta
            // 
            tbEmailAlta.Location = new Point(257, 220);
            tbEmailAlta.Margin = new Padding(3, 4, 3, 4);
            tbEmailAlta.Name = "tbEmailAlta";
            tbEmailAlta.Size = new Size(180, 27);
            tbEmailAlta.TabIndex = 4;
            // 
            // lbNacionalidadAlta
            // 
            lbNacionalidadAlta.AutoSize = true;
            lbNacionalidadAlta.Location = new Point(153, 161);
            lbNacionalidadAlta.Name = "lbNacionalidadAlta";
            lbNacionalidadAlta.Size = new Size(98, 20);
            lbNacionalidadAlta.TabIndex = 7;
            lbNacionalidadAlta.Text = "Nacionalidad";
            // 
            // tbNacionalidadAlta
            // 
            tbNacionalidadAlta.Location = new Point(257, 157);
            tbNacionalidadAlta.Margin = new Padding(3, 4, 3, 4);
            tbNacionalidadAlta.Name = "tbNacionalidadAlta";
            tbNacionalidadAlta.Size = new Size(180, 27);
            tbNacionalidadAlta.TabIndex = 2;
            // 
            // lbTelefonoAlta
            // 
            lbTelefonoAlta.AutoSize = true;
            lbTelefonoAlta.Location = new Point(501, 224);
            lbTelefonoAlta.Name = "lbTelefonoAlta";
            lbTelefonoAlta.Size = new Size(67, 20);
            lbTelefonoAlta.TabIndex = 5;
            lbTelefonoAlta.Text = "Telefono";
            // 
            // tbTelefonoAlta
            // 
            tbTelefonoAlta.Location = new Point(574, 220);
            tbTelefonoAlta.Margin = new Padding(3, 4, 3, 4);
            tbTelefonoAlta.Name = "tbTelefonoAlta";
            tbTelefonoAlta.Size = new Size(180, 27);
            tbTelefonoAlta.TabIndex = 5;
            // 
            // lbApellidoAlta
            // 
            lbApellidoAlta.AutoSize = true;
            lbApellidoAlta.Location = new Point(502, 99);
            lbApellidoAlta.Name = "lbApellidoAlta";
            lbApellidoAlta.Size = new Size(66, 20);
            lbApellidoAlta.TabIndex = 3;
            lbApellidoAlta.Text = "Apellido";
            // 
            // tbApellidoAlta
            // 
            tbApellidoAlta.Location = new Point(574, 96);
            tbApellidoAlta.Margin = new Padding(3, 4, 3, 4);
            tbApellidoAlta.Name = "tbApellidoAlta";
            tbApellidoAlta.Size = new Size(180, 27);
            tbApellidoAlta.TabIndex = 1;
            // 
            // lblNombreAlta
            // 
            lblNombreAlta.AutoSize = true;
            lblNombreAlta.Location = new Point(153, 96);
            lblNombreAlta.Name = "lblNombreAlta";
            lblNombreAlta.Size = new Size(64, 20);
            lblNombreAlta.TabIndex = 1;
            lblNombreAlta.Text = "Nombre";
            // 
            // tbNombreAlta
            // 
            tbNombreAlta.Location = new Point(257, 96);
            tbNombreAlta.Margin = new Padding(3, 4, 3, 4);
            tbNombreAlta.Name = "tbNombreAlta";
            tbNombreAlta.Size = new Size(180, 27);
            tbNombreAlta.TabIndex = 0;
            // 
            // tabModificacion
            // 
            tabModificacion.Controls.Add(tbIdAutorModificacion);
            tabModificacion.Controls.Add(lbIdAutorModificacion);
            tabModificacion.Controls.Add(lbFechaNacimientoModificacion);
            tabModificacion.Controls.Add(tbFechaNacimientoModificacion);
            tabModificacion.Controls.Add(btnActualizar);
            tabModificacion.Controls.Add(tbBiografiaModificacion);
            tabModificacion.Controls.Add(lbBiografiaModificacion);
            tabModificacion.Controls.Add(lbEmailModificacion);
            tabModificacion.Controls.Add(tbEmailModificacion);
            tabModificacion.Controls.Add(lbNacionalidadModificacion);
            tabModificacion.Controls.Add(tbNacionalidadModificacion);
            tabModificacion.Controls.Add(lbTelefonoModificacion);
            tabModificacion.Controls.Add(tbTelefonoModificacion);
            tabModificacion.Controls.Add(lbApellidoModificacion);
            tabModificacion.Controls.Add(tbApellidoModificacion);
            tabModificacion.Controls.Add(bvNombreModificacion);
            tabModificacion.Controls.Add(tbNombreModificacion);
            tabModificacion.Location = new Point(4, 29);
            tabModificacion.Margin = new Padding(3, 4, 3, 4);
            tabModificacion.Name = "tabModificacion";
            tabModificacion.Padding = new Padding(3, 4, 3, 4);
            tabModificacion.Size = new Size(983, 615);
            tabModificacion.TabIndex = 2;
            tabModificacion.Text = "Modificacion";
            tabModificacion.UseVisualStyleBackColor = true;
            // 
            // tbIdAutorModificacion
            // 
            tbIdAutorModificacion.Location = new Point(465, 35);
            tbIdAutorModificacion.Margin = new Padding(3, 4, 3, 4);
            tbIdAutorModificacion.Name = "tbIdAutorModificacion";
            tbIdAutorModificacion.Size = new Size(180, 27);
            tbIdAutorModificacion.TabIndex = 0;
            // 
            // lbIdAutorModificacion
            // 
            lbIdAutorModificacion.AutoSize = true;
            lbIdAutorModificacion.Location = new Point(394, 38);
            lbIdAutorModificacion.Name = "lbIdAutorModificacion";
            lbIdAutorModificacion.Size = new Size(65, 20);
            lbIdAutorModificacion.TabIndex = 27;
            lbIdAutorModificacion.Text = "ID Autor";
            // 
            // lbFechaNacimientoModificacion
            // 
            lbFechaNacimientoModificacion.AutoSize = true;
            lbFechaNacimientoModificacion.Location = new Point(483, 151);
            lbFechaNacimientoModificacion.Name = "lbFechaNacimientoModificacion";
            lbFechaNacimientoModificacion.Size = new Size(128, 20);
            lbFechaNacimientoModificacion.TabIndex = 26;
            lbFechaNacimientoModificacion.Text = "Fecha Nacimiento";
            // 
            // tbFechaNacimientoModificacion
            // 
            tbFechaNacimientoModificacion.Location = new Point(612, 147);
            tbFechaNacimientoModificacion.Margin = new Padding(3, 4, 3, 4);
            tbFechaNacimientoModificacion.Name = "tbFechaNacimientoModificacion";
            tbFechaNacimientoModificacion.Size = new Size(180, 27);
            tbFechaNacimientoModificacion.TabIndex = 4;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(508, 497);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 31);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // tbBiografiaModificacion
            // 
            tbBiografiaModificacion.Location = new Point(295, 293);
            tbBiografiaModificacion.Margin = new Padding(3, 4, 3, 4);
            tbBiografiaModificacion.Multiline = true;
            tbBiografiaModificacion.Name = "tbBiografiaModificacion";
            tbBiografiaModificacion.Size = new Size(497, 168);
            tbBiografiaModificacion.TabIndex = 7;
            // 
            // lbBiografiaModificacion
            // 
            lbBiografiaModificacion.AutoSize = true;
            lbBiografiaModificacion.Location = new Point(191, 296);
            lbBiografiaModificacion.Name = "lbBiografiaModificacion";
            lbBiografiaModificacion.Size = new Size(70, 20);
            lbBiografiaModificacion.TabIndex = 25;
            lbBiografiaModificacion.Text = "Biografia";
            // 
            // lbEmailModificacion
            // 
            lbEmailModificacion.AutoSize = true;
            lbEmailModificacion.Location = new Point(191, 214);
            lbEmailModificacion.Name = "lbEmailModificacion";
            lbEmailModificacion.Size = new Size(46, 20);
            lbEmailModificacion.TabIndex = 24;
            lbEmailModificacion.Text = "Email";
            // 
            // tbEmailModificacion
            // 
            tbEmailModificacion.Location = new Point(295, 210);
            tbEmailModificacion.Margin = new Padding(3, 4, 3, 4);
            tbEmailModificacion.Name = "tbEmailModificacion";
            tbEmailModificacion.Size = new Size(180, 27);
            tbEmailModificacion.TabIndex = 5;
            // 
            // lbNacionalidadModificacion
            // 
            lbNacionalidadModificacion.AutoSize = true;
            lbNacionalidadModificacion.Location = new Point(191, 151);
            lbNacionalidadModificacion.Name = "lbNacionalidadModificacion";
            lbNacionalidadModificacion.Size = new Size(98, 20);
            lbNacionalidadModificacion.TabIndex = 23;
            lbNacionalidadModificacion.Text = "Nacionalidad";
            // 
            // tbNacionalidadModificacion
            // 
            tbNacionalidadModificacion.Location = new Point(295, 147);
            tbNacionalidadModificacion.Margin = new Padding(3, 4, 3, 4);
            tbNacionalidadModificacion.Name = "tbNacionalidadModificacion";
            tbNacionalidadModificacion.Size = new Size(180, 27);
            tbNacionalidadModificacion.TabIndex = 3;
            // 
            // lbTelefonoModificacion
            // 
            lbTelefonoModificacion.AutoSize = true;
            lbTelefonoModificacion.Location = new Point(539, 214);
            lbTelefonoModificacion.Name = "lbTelefonoModificacion";
            lbTelefonoModificacion.Size = new Size(67, 20);
            lbTelefonoModificacion.TabIndex = 19;
            lbTelefonoModificacion.Text = "Telefono";
            // 
            // tbTelefonoModificacion
            // 
            tbTelefonoModificacion.Location = new Point(612, 210);
            tbTelefonoModificacion.Margin = new Padding(3, 4, 3, 4);
            tbTelefonoModificacion.Name = "tbTelefonoModificacion";
            tbTelefonoModificacion.Size = new Size(180, 27);
            tbTelefonoModificacion.TabIndex = 6;
            // 
            // lbApellidoModificacion
            // 
            lbApellidoModificacion.AutoSize = true;
            lbApellidoModificacion.Location = new Point(540, 89);
            lbApellidoModificacion.Name = "lbApellidoModificacion";
            lbApellidoModificacion.Size = new Size(66, 20);
            lbApellidoModificacion.TabIndex = 17;
            lbApellidoModificacion.Text = "Apellido";
            // 
            // tbApellidoModificacion
            // 
            tbApellidoModificacion.Location = new Point(612, 86);
            tbApellidoModificacion.Margin = new Padding(3, 4, 3, 4);
            tbApellidoModificacion.Name = "tbApellidoModificacion";
            tbApellidoModificacion.Size = new Size(180, 27);
            tbApellidoModificacion.TabIndex = 2;
            // 
            // bvNombreModificacion
            // 
            bvNombreModificacion.AutoSize = true;
            bvNombreModificacion.Location = new Point(191, 86);
            bvNombreModificacion.Name = "bvNombreModificacion";
            bvNombreModificacion.Size = new Size(64, 20);
            bvNombreModificacion.TabIndex = 14;
            bvNombreModificacion.Text = "Nombre";
            // 
            // tbNombreModificacion
            // 
            tbNombreModificacion.Location = new Point(295, 86);
            tbNombreModificacion.Margin = new Padding(3, 4, 3, 4);
            tbNombreModificacion.Name = "tbNombreModificacion";
            tbNombreModificacion.Size = new Size(180, 27);
            tbNombreModificacion.TabIndex = 1;
            // 
            // tabBaja
            // 
            tabBaja.Location = new Point(4, 29);
            tabBaja.Margin = new Padding(3, 4, 3, 4);
            tabBaja.Name = "tabBaja";
            tabBaja.Padding = new Padding(3, 4, 3, 4);
            tabBaja.Size = new Size(983, 615);
            tabBaja.TabIndex = 3;
            tabBaja.Text = "Baja";
            tabBaja.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ABMAutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 680);
            Controls.Add(tabControlPrincipal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ABMAutor";
            Text = "Sistema de Gestion de Libreria";
            Load += ABMAutor_Load;
            tabControlPrincipal.ResumeLayout(false);
            tabListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListadoAutores).EndInit();
            tabAlta.ResumeLayout(false);
            tabAlta.PerformLayout();
            tabModificacion.ResumeLayout(false);
            tabModificacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPrincipal;
        private TabPage tabListado;
        private TabPage tabModificacion;
        private TabPage tabBaja;
        private OpenFileDialog openFileDialog1;
        private DataGridView dgvListadoAutores;
        private TabPage tabAlta;
        private Label lbEmailAlta;
        private TextBox tbEmailAlta;
        private Label lbNacionalidadAlta;
        private TextBox tbNacionalidadAlta;
        private Label lbTelefonoAlta;
        private TextBox tbTelefonoAlta;
        private Label lbApellidoAlta;
        private TextBox tbApellidoAlta;
        private Label lblNombreAlta;
        private TextBox tbNombreAlta;
        private Label lbBiografiaAlta;
        private TextBox tbBiografiaAlta;
        private Button btnGuardar;
        private TextBox tbFechaNacimientoAlta;
        private Label lbFechaNacimientoAlta;
        private Label lbFechaNacimientoModificacion;
        private TextBox tbFechaNacimientoModificacion;
        private Button btnActualizar;
        private TextBox tbBiografiaModificacion;
        private Label lbBiografiaModificacion;
        private Label lbEmailModificacion;
        private TextBox tbEmailModificacion;
        private Label lbNacionalidadModificacion;
        private TextBox tbNacionalidadModificacion;
        private Label lbTelefonoModificacion;
        private TextBox tbTelefonoModificacion;
        private Label lbApellidoModificacion;
        private TextBox tbApellidoModificacion;
        private Label bvNombreModificacion;
        private TextBox tbNombreModificacion;
        private TextBox tbIdAutorModificacion;
        private Label lbIdAutorModificacion;
    }
}