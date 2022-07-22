
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Libro));
            this.fechaingresolibro = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.preciolibro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.dgv_libro = new System.Windows.Forms.DataGridView();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnatras = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.imgbarra = new System.Windows.Forms.PictureBox();
            this.Autorlibro = new System.Windows.Forms.TextBox();
            this.Editoriallibro = new System.Windows.Forms.ComboBox();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_libro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaingresolibro
            // 
            this.fechaingresolibro.CustomFormat = "yyyy-MM-dd ";
            this.fechaingresolibro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaingresolibro.Location = new System.Drawing.Point(624, 233);
            this.fechaingresolibro.Margin = new System.Windows.Forms.Padding(4);
            this.fechaingresolibro.Name = "fechaingresolibro";
            this.fechaingresolibro.Size = new System.Drawing.Size(267, 22);
            this.fechaingresolibro.TabIndex = 138;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(473, 233);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 24);
            this.label9.TabIndex = 137;
            this.label9.Text = "Fecha ingreso:";
            // 
            // preciolibro
            // 
            this.preciolibro.Location = new System.Drawing.Point(624, 180);
            this.preciolibro.Margin = new System.Windows.Forms.Padding(4);
            this.preciolibro.Name = "preciolibro";
            this.preciolibro.Size = new System.Drawing.Size(267, 22);
            this.preciolibro.TabIndex = 136;
            this.preciolibro.TextChanged += new System.EventHandler(this.preciolibro_TextChanged);
            this.preciolibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.preciolibro_KeyPress);
            this.preciolibro.Validated += new System.EventHandler(this.preciolibro_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(533, 180);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 24);
            this.label8.TabIndex = 135;
            this.label8.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 24);
            this.label7.TabIndex = 133;
            this.label7.Text = "Editorial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 131;
            this.label5.Text = "Autor:";
            // 
            // Categorialibro
            // 
            this.Categorialibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categorialibro.FormattingEnabled = true;
            this.Categorialibro.Location = new System.Drawing.Point(172, 342);
            this.Categorialibro.Margin = new System.Windows.Forms.Padding(4);
            this.Categorialibro.Name = "Categorialibro";
            this.Categorialibro.Size = new System.Drawing.Size(244, 24);
            this.Categorialibro.TabIndex = 130;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
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
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 87);
            this.panel1.TabIndex = 128;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(271, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 46);
            this.label3.TabIndex = 10;
            this.label3.Text = "Registro de libros";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regitradoxtal
            // 
            this.regitradoxtal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regitradoxtal.FormattingEnabled = true;
            this.regitradoxtal.Location = new System.Drawing.Point(625, 132);
            this.regitradoxtal.Margin = new System.Windows.Forms.Padding(4);
            this.regitradoxtal.Name = "regitradoxtal";
            this.regitradoxtal.Size = new System.Drawing.Size(267, 24);
            this.regitradoxtal.TabIndex = 127;
            this.regitradoxtal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(467, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 24);
            this.label6.TabIndex = 126;
            this.label6.Text = "Registrado por:";
            // 
            // Titulolibro
            // 
            this.Titulolibro.Location = new System.Drawing.Point(172, 185);
            this.Titulolibro.Margin = new System.Windows.Forms.Padding(4);
            this.Titulolibro.Name = "Titulolibro";
            this.Titulolibro.Size = new System.Drawing.Size(244, 22);
            this.Titulolibro.TabIndex = 125;
            this.Titulolibro.Validated += new System.EventHandler(this.Titulolibro_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 124;
            this.label2.Text = "Título:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(172, 132);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(244, 22);
            this.txt_codigo.TabIndex = 123;
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            this.txt_codigo.Validated += new System.EventHandler(this.txt_codigo_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 122;
            this.label1.Text = "Código:";
            // 
            // dgv_libro
            // 
            this.dgv_libro.AllowUserToOrderColumns = true;
            this.dgv_libro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_libro.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_libro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_libro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_libro.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_libro.Location = new System.Drawing.Point(53, 443);
            this.dgv_libro.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_libro.MultiSelect = false;
            this.dgv_libro.Name = "dgv_libro";
            this.dgv_libro.ReadOnly = true;
            this.dgv_libro.RowHeadersWidth = 123;
            this.dgv_libro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_libro.Size = new System.Drawing.Size(1008, 210);
            this.dgv_libro.TabIndex = 198;
            this.dgv_libro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_libro_CellClick);
            this.dgv_libro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_libro_CellContentClick);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Transparent;
            this.btnmodificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmodificar.BackgroundImage")));
            this.btnmodificar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnmodificar.Location = new System.Drawing.Point(625, 272);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(131, 60);
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
            this.btneliminar.Location = new System.Drawing.Point(472, 358);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(124, 60);
            this.btneliminar.TabIndex = 204;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnregistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistrar.BackgroundImage")));
            this.btnregistrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnregistrar.Location = new System.Drawing.Point(472, 272);
            this.btnregistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(124, 60);
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
            this.btnatras.Location = new System.Drawing.Point(631, 358);
            this.btnatras.Margin = new System.Windows.Forms.Padding(4);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(124, 60);
            this.btnatras.TabIndex = 202;
            this.btnatras.Text = "Atras";
            this.btnatras.UseVisualStyleBackColor = false;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // imgbarra
            // 
            this.imgbarra.Location = new System.Drawing.Point(763, 262);
            this.imgbarra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgbarra.Name = "imgbarra";
            this.imgbarra.Size = new System.Drawing.Size(277, 156);
            this.imgbarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbarra.TabIndex = 206;
            this.imgbarra.TabStop = false;
            // 
            // Autorlibro
            // 
            this.Autorlibro.Location = new System.Drawing.Point(172, 238);
            this.Autorlibro.Margin = new System.Windows.Forms.Padding(4);
            this.Autorlibro.Name = "Autorlibro";
            this.Autorlibro.Size = new System.Drawing.Size(244, 22);
            this.Autorlibro.TabIndex = 132;
            this.Autorlibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Autorlibro_KeyPress);
            this.Autorlibro.Validated += new System.EventHandler(this.Autorlibro_Validated);
            // 
            // Editoriallibro
            // 
            this.Editoriallibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Editoriallibro.FormattingEnabled = true;
            this.Editoriallibro.Location = new System.Drawing.Point(172, 293);
            this.Editoriallibro.Margin = new System.Windows.Forms.Padding(4);
            this.Editoriallibro.Name = "Editoriallibro";
            this.Editoriallibro.Size = new System.Drawing.Size(244, 24);
            this.Editoriallibro.TabIndex = 207;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // Registro_Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OfficeHouse.Properties.Resources.CCB38D;
            this.ClientSize = new System.Drawing.Size(1099, 667);
            this.Controls.Add(this.Editoriallibro);
            this.Controls.Add(this.imgbarra);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.dgv_libro);
            this.Controls.Add(this.fechaingresolibro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.preciolibro);
            this.Controls.Add(this.label8);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registro_Libro";
            this.Text = "Registro_Libro";
            this.Load += new System.EventHandler(this.Registro_Libro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_libro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgbarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker fechaingresolibro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox preciolibro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.DataGridView dgv_libro;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox imgbarra;
        public System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox Autorlibro;
        private System.Windows.Forms.ComboBox Editoriallibro;
        private System.Windows.Forms.ErrorProvider epError;
    }
}