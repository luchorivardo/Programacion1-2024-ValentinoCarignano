namespace CPresentacion
{
    partial class ABMEditorial
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txt_nombre = new TextBox();
            txt_direccion = new TextBox();
            txt_contacto = new TextBox();
            label1 = new Label();
            Direccion = new Label();
            label3 = new Label();
            bt_agregar = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(bt_agregar);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(Direccion);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txt_contacto);
            tabPage1.Controls.Add(txt_direccion);
            tabPage1.Controls.Add(txt_nombre);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(106, 88);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(100, 23);
            txt_nombre.TabIndex = 0;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(329, 88);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(100, 23);
            txt_direccion.TabIndex = 1;
            // 
            // txt_contacto
            // 
            txt_contacto.Location = new Point(542, 88);
            txt_contacto.Name = "txt_contacto";
            txt_contacto.Size = new Size(100, 23);
            txt_contacto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 91);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // Direccion
            // 
            Direccion.AutoSize = true;
            Direccion.Location = new Point(272, 91);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(57, 15);
            Direccion.TabIndex = 4;
            Direccion.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(485, 91);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Contacto";
            // 
            // bt_agregar
            // 
            bt_agregar.Location = new Point(615, 345);
            bt_agregar.Name = "bt_agregar";
            bt_agregar.Size = new Size(75, 23);
            bt_agregar.TabIndex = 6;
            bt_agregar.Text = "Agregar";
            bt_agregar.UseVisualStyleBackColor = true;
            bt_agregar.Click += bt_agregar_Click;
            // 
            // ABMEditorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "ABMEditorial";
            Text = "ABMEditorial";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private Label Direccion;
        private Label label1;
        private TextBox txt_contacto;
        private TextBox txt_direccion;
        private TextBox txt_nombre;
        private TabPage tabPage2;
        private Button bt_agregar;
    }
}