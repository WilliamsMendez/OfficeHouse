
namespace OfficeHouse
{
    partial class Registro_Devolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Devolucion));
            this.fecha_devolucion = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codigo_devolucion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnpagar = new System.Windows.Forms.Button();
            this.btnatras = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.estado_libro = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.titulo_devolucion = new System.Windows.Forms.ComboBox();
            this.autor_devolucion = new System.Windows.Forms.TextBox();
            this.dgv_devolucion = new System.Windows.Forms.DataGridView();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // fecha_devolucion
            // 
            this.fecha_devolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_devolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_devolucion.Location = new System.Drawing.Point(211, 150);
            this.fecha_devolucion.MaxDate = new System.DateTime(2022, 7, 31, 0, 0, 0, 0);
            this.fecha_devolucion.MinDate = new System.DateTime(2022, 7, 29, 0, 0, 0, 0);
            this.fecha_devolucion.Name = "fecha_devolucion";
            this.fecha_devolucion.Size = new System.Drawing.Size(184, 23);
            this.fecha_devolucion.TabIndex = 180;
            this.fecha_devolucion.Value = new System.DateTime(2022, 7, 29, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 19);
            this.label9.TabIndex = 179;
            this.label9.Text = "Fecha de Devolución:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 173;
            this.label5.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 171;
            this.label2.Text = "Título:";
            // 
            // codigo_devolucion
            // 
            this.codigo_devolucion.Enabled = false;
            this.codigo_devolucion.Location = new System.Drawing.Point(211, 22);
            this.codigo_devolucion.MaxLength = 4;
            this.codigo_devolucion.Name = "codigo_devolucion";
            this.codigo_devolucion.Size = new System.Drawing.Size(184, 27);
            this.codigo_devolucion.TabIndex = 170;
            this.codigo_devolucion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo_devolucion_KeyPress);
            this.codigo_devolucion.Validated += new System.EventHandler(this.codigo_devolucion_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 169;
            this.label1.Text = "Código:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::OfficeHouse.Properties.Resources._0C1231;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 82);
            this.panel2.TabIndex = 167;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(177, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 37);
            this.label3.TabIndex = 119;
            this.label3.Text = "Registro de Devolución";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(539, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 49);
            this.button2.TabIndex = 188;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(424, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 49);
            this.button1.TabIndex = 187;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnpagar
            // 
            this.btnpagar.BackColor = System.Drawing.Color.Transparent;
            this.btnpagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpagar.BackgroundImage")));
            this.btnpagar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnpagar.Location = new System.Drawing.Point(424, 112);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(93, 49);
            this.btnpagar.TabIndex = 186;
            this.btnpagar.Text = "Registrar";
            this.btnpagar.UseVisualStyleBackColor = false;
            this.btnpagar.Click += new System.EventHandler(this.btnpagar_Click);
            // 
            // btnatras
            // 
            this.btnatras.BackColor = System.Drawing.Color.Transparent;
            this.btnatras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnatras.BackgroundImage")));
            this.btnatras.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnatras.Location = new System.Drawing.Point(480, 248);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(93, 49);
            this.btnatras.TabIndex = 185;
            this.btnatras.Text = "Atras";
            this.btnatras.UseVisualStyleBackColor = false;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(539, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 49);
            this.button3.TabIndex = 201;
            this.button3.Text = "Realizar Devolucion";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 202;
            this.label4.Text = "Estado de libro:";
            // 
            // estado_libro
            // 
            this.estado_libro.BackColor = System.Drawing.SystemColors.Control;
            this.estado_libro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estado_libro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.estado_libro.FormattingEnabled = true;
            this.estado_libro.Location = new System.Drawing.Point(211, 187);
            this.estado_libro.Name = "estado_libro";
            this.estado_libro.Size = new System.Drawing.Size(184, 21);
            this.estado_libro.TabIndex = 203;
            this.estado_libro.SelectedIndexChanged += new System.EventHandler(this.cb_puesto_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.titulo_devolucion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.estado_libro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.codigo_devolucion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.autor_devolucion);
            this.groupBox1.Controls.Add(this.fecha_devolucion);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 227);
            this.groupBox1.TabIndex = 204;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Devolucion";
            // 
            // titulo_devolucion
            // 
            this.titulo_devolucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titulo_devolucion.FormattingEnabled = true;
            this.titulo_devolucion.Location = new System.Drawing.Point(211, 62);
            this.titulo_devolucion.Name = "titulo_devolucion";
            this.titulo_devolucion.Size = new System.Drawing.Size(184, 27);
            this.titulo_devolucion.TabIndex = 204;
            this.titulo_devolucion.SelectedIndexChanged += new System.EventHandler(this.titulo_devolucion_SelectedIndexChanged);
            this.titulo_devolucion.Validated += new System.EventHandler(this.titulo_devolucion_Validated);
            // 
            // autor_devolucion
            // 
            this.autor_devolucion.Enabled = false;
            this.autor_devolucion.Location = new System.Drawing.Point(211, 106);
            this.autor_devolucion.MaxLength = 255;
            this.autor_devolucion.Name = "autor_devolucion";
            this.autor_devolucion.Size = new System.Drawing.Size(184, 27);
            this.autor_devolucion.TabIndex = 174;
            // 
            // dgv_devolucion
            // 
            this.dgv_devolucion.AllowUserToOrderColumns = true;
            this.dgv_devolucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_devolucion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_devolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_devolucion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_devolucion.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_devolucion.Location = new System.Drawing.Point(10, 319);
            this.dgv_devolucion.MultiSelect = false;
            this.dgv_devolucion.Name = "dgv_devolucion";
            this.dgv_devolucion.ReadOnly = true;
            this.dgv_devolucion.RowHeadersWidth = 123;
            this.dgv_devolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_devolucion.Size = new System.Drawing.Size(692, 154);
            this.dgv_devolucion.TabIndex = 210;
            this.dgv_devolucion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_devolucion_CellClick);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // Registro_Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OfficeHouse.Properties.Resources.CCB38D;
            this.ClientSize = new System.Drawing.Size(712, 484);
            this.Controls.Add(this.dgv_devolucion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registro_Devolucion";
            this.Text = "Registro_Devolucion";
            this.Load += new System.EventHandler(this.Registro_Devolucion_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker fecha_devolucion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigo_devolucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnpagar;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox estado_libro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_devolucion;
        private System.Windows.Forms.ComboBox titulo_devolucion;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.TextBox autor_devolucion;
    }
}