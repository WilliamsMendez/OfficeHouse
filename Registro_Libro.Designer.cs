
namespace OfficeHouse
{
    partial class Registro_Libro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Libro));
            this.fechaingresolibro = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.preciolibro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Editoriallibro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Autorlibro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Categorialibro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.regitradoxtal = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Titulolibro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Usuario = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registradopor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnatras = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.imgbarra = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbarra)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaingresolibro
            // 
            this.fechaingresolibro.CustomFormat = "yyyy-MM-dd ";
            this.fechaingresolibro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaingresolibro.Location = new System.Drawing.Point(468, 189);
            this.fechaingresolibro.Name = "fechaingresolibro";
            this.fechaingresolibro.Size = new System.Drawing.Size(201, 20);
            this.fechaingresolibro.TabIndex = 138;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(355, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 19);
            this.label9.TabIndex = 137;
            this.label9.Text = "Fecha ingreso:";
            // 
            // preciolibro
            // 
            this.preciolibro.Location = new System.Drawing.Point(468, 146);
            this.preciolibro.Name = "preciolibro";
            this.preciolibro.Size = new System.Drawing.Size(201, 20);
            this.preciolibro.TabIndex = 136;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(400, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 135;
            this.label8.Text = "Precio:";
            // 
            // Editoriallibro
            // 
            this.Editoriallibro.Location = new System.Drawing.Point(129, 238);
            this.Editoriallibro.Name = "Editoriallibro";
            this.Editoriallibro.Size = new System.Drawing.Size(184, 20);
            this.Editoriallibro.TabIndex = 134;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 133;
            this.label7.Text = "Editorial:";
            // 
            // Autorlibro
            // 
            this.Autorlibro.Location = new System.Drawing.Point(129, 193);
            this.Autorlibro.Name = "Autorlibro";
            this.Autorlibro.Size = new System.Drawing.Size(184, 20);
            this.Autorlibro.TabIndex = 132;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 131;
            this.label5.Text = "Autor:";
            // 
            // Categorialibro
            // 
            this.Categorialibro.FormattingEnabled = true;
            this.Categorialibro.Location = new System.Drawing.Point(129, 278);
            this.Categorialibro.Name = "Categorialibro";
            this.Categorialibro.Size = new System.Drawing.Size(184, 21);
            this.Categorialibro.TabIndex = 130;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 129;
            this.label4.Text = "Categoría:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::OfficeHouse.Properties.Resources._0C1231;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 71);
            this.panel1.TabIndex = 128;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(203, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "Registro de libros";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regitradoxtal
            // 
            this.regitradoxtal.FormattingEnabled = true;
            this.regitradoxtal.Location = new System.Drawing.Point(469, 107);
            this.regitradoxtal.Name = "regitradoxtal";
            this.regitradoxtal.Size = new System.Drawing.Size(201, 21);
            this.regitradoxtal.TabIndex = 127;
            this.regitradoxtal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 19);
            this.label6.TabIndex = 126;
            this.label6.Text = "Registrado por:";
            // 
            // Titulolibro
            // 
            this.Titulolibro.Location = new System.Drawing.Point(129, 150);
            this.Titulolibro.Name = "Titulolibro";
            this.Titulolibro.Size = new System.Drawing.Size(184, 20);
            this.Titulolibro.TabIndex = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 124;
            this.label2.Text = "Título:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(129, 107);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(184, 20);
            this.txt_codigo.TabIndex = 123;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 122;
            this.label1.Text = "Código:";
            // 
            // dgv_Usuario
            // 
            this.dgv_Usuario.AllowUserToOrderColumns = true;
            this.dgv_Usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Usuario.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Titulo,
            this.Autor,
            this.Editorial,
            this.Categoría,
            this.Precio,
            this.Registradopor,
            this.Fecha_Ingreso});
            this.dgv_Usuario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Usuario.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Usuario.Location = new System.Drawing.Point(40, 360);
            this.dgv_Usuario.MultiSelect = false;
            this.dgv_Usuario.Name = "dgv_Usuario";
            this.dgv_Usuario.ReadOnly = true;
            this.dgv_Usuario.RowHeadersWidth = 123;
            this.dgv_Usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Usuario.Size = new System.Drawing.Size(640, 132);
            this.dgv_Usuario.TabIndex = 198;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.MinimumWidth = 6;
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Título";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Editorial
            // 
            this.Editorial.HeaderText = "Editorial";
            this.Editorial.MinimumWidth = 6;
            this.Editorial.Name = "Editorial";
            this.Editorial.ReadOnly = true;
            // 
            // Categoría
            // 
            this.Categoría.HeaderText = "Categoría";
            this.Categoría.MinimumWidth = 6;
            this.Categoría.Name = "Categoría";
            this.Categoría.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Registradopor
            // 
            this.Registradopor.HeaderText = "Registrado por";
            this.Registradopor.MinimumWidth = 6;
            this.Registradopor.Name = "Registradopor";
            this.Registradopor.ReadOnly = true;
            // 
            // Fecha_Ingreso
            // 
            this.Fecha_Ingreso.HeaderText = "Fecha Ingreso";
            this.Fecha_Ingreso.MinimumWidth = 6;
            this.Fecha_Ingreso.Name = "Fecha_Ingreso";
            this.Fecha_Ingreso.ReadOnly = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Transparent;
            this.btnmodificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmodificar.BackgroundImage")));
            this.btnmodificar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnmodificar.Location = new System.Drawing.Point(469, 221);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(98, 49);
            this.btnmodificar.TabIndex = 205;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btneliminar.Location = new System.Drawing.Point(354, 291);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(93, 49);
            this.btneliminar.TabIndex = 204;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnregistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistrar.BackgroundImage")));
            this.btnregistrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnregistrar.Location = new System.Drawing.Point(354, 221);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(93, 49);
            this.btnregistrar.TabIndex = 203;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnatras
            // 
            this.btnatras.BackColor = System.Drawing.Color.Transparent;
            this.btnatras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnatras.BackgroundImage")));
            this.btnatras.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnatras.Location = new System.Drawing.Point(473, 291);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(93, 49);
            this.btnatras.TabIndex = 202;
            this.btnatras.Text = "Atras";
            this.btnatras.UseVisualStyleBackColor = false;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // imgbarra
            // 
            this.imgbarra.Location = new System.Drawing.Point(572, 213);
            this.imgbarra.Margin = new System.Windows.Forms.Padding(2);
            this.imgbarra.Name = "imgbarra";
            this.imgbarra.Size = new System.Drawing.Size(208, 127);
            this.imgbarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbarra.TabIndex = 206;
            this.imgbarra.TabStop = false;
            // 
            // Registro_Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OfficeHouse.Properties.Resources.CCB38D;
            this.ClientSize = new System.Drawing.Size(824, 542);
            this.Controls.Add(this.imgbarra);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.dgv_Usuario);
            this.Controls.Add(this.fechaingresolibro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.preciolibro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Editoriallibro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Autorlibro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Categorialibro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.regitradoxtal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Titulolibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registro_Libro";
            this.Text = "Registro_Libro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbarra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker fechaingresolibro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox preciolibro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Editoriallibro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Autorlibro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Categorialibro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox regitradoxtal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Titulolibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Usuario;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox imgbarra;
        public System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoría;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registradopor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Ingreso;
    }
}