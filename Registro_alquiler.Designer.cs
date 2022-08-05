
namespace OfficeHouse
{
    partial class Registro_alquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_alquiler));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnatras = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.titulo_alquiler = new System.Windows.Forms.ComboBox();
            this.fechalquiler = new System.Windows.Forms.DateTimePicker();
            this.cantidad_alquiler = new System.Windows.Forms.TextBox();
            this.codigo_alquiler = new System.Windows.Forms.TextBox();
            this.autor_alquier = new System.Windows.Forms.TextBox();
            this.dgv_alquiler = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::OfficeHouse.Properties.Resources._0C1231;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 79);
            this.panel2.TabIndex = 151;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(202, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 37);
            this.label3.TabIndex = 119;
            this.label3.Text = "Registro de Alquiler";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(590, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 49);
            this.button2.TabIndex = 203;
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
            this.button1.Location = new System.Drawing.Point(475, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 49);
            this.button1.TabIndex = 202;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnatras
            // 
            this.btnatras.BackColor = System.Drawing.Color.Transparent;
            this.btnatras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnatras.BackgroundImage")));
            this.btnatras.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnatras.Location = new System.Drawing.Point(526, 259);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(93, 49);
            this.btnatras.TabIndex = 200;
            this.btnatras.Text = "Atras";
            this.btnatras.UseVisualStyleBackColor = false;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 19);
            this.label9.TabIndex = 198;
            this.label9.Text = "Fecha de Alquiler:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 197;
            this.label4.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 195;
            this.label5.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 193;
            this.label2.Text = "Título:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 191;
            this.label1.Text = "Código:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(590, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 49);
            this.button3.TabIndex = 206;
            this.button3.Text = "Pagar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.titulo_alquiler);
            this.groupBox1.Controls.Add(this.fechalquiler);
            this.groupBox1.Controls.Add(this.cantidad_alquiler);
            this.groupBox1.Controls.Add(this.codigo_alquiler);
            this.groupBox1.Controls.Add(this.autor_alquier);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 253);
            this.groupBox1.TabIndex = 208;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Aquiler";
            // 
            // titulo_alquiler
            // 
            this.titulo_alquiler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titulo_alquiler.FormattingEnabled = true;
            this.titulo_alquiler.Location = new System.Drawing.Point(208, 74);
            this.titulo_alquiler.Name = "titulo_alquiler";
            this.titulo_alquiler.Size = new System.Drawing.Size(184, 27);
            this.titulo_alquiler.TabIndex = 216;
            this.titulo_alquiler.SelectedIndexChanged += new System.EventHandler(this.titulo_alquiler_SelectedIndexChanged);
            // 
            // fechalquiler
            // 
            this.fechalquiler.CustomFormat = "yyyy-MM-dd ";
            this.fechalquiler.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechalquiler.Location = new System.Drawing.Point(208, 161);
            this.fechalquiler.MaxDate = new System.DateTime(2022, 7, 29, 0, 0, 0, 0);
            this.fechalquiler.MinDate = new System.DateTime(2022, 7, 29, 0, 0, 0, 0);
            this.fechalquiler.Name = "fechalquiler";
            this.fechalquiler.Size = new System.Drawing.Size(184, 27);
            this.fechalquiler.TabIndex = 214;
            this.fechalquiler.Value = new System.DateTime(2022, 7, 29, 0, 0, 0, 0);
            // 
            // cantidad_alquiler
            // 
            this.cantidad_alquiler.Location = new System.Drawing.Point(208, 210);
            this.cantidad_alquiler.MaxLength = 2;
            this.cantidad_alquiler.Name = "cantidad_alquiler";
            this.cantidad_alquiler.Size = new System.Drawing.Size(184, 27);
            this.cantidad_alquiler.TabIndex = 213;
            this.cantidad_alquiler.TextChanged += new System.EventHandler(this.cantidad_alquiler_TextChanged);
            this.cantidad_alquiler.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_alquiler_KeyPress);
            // 
            // codigo_alquiler
            // 
            this.codigo_alquiler.Location = new System.Drawing.Point(208, 32);
            this.codigo_alquiler.MaxLength = 8;
            this.codigo_alquiler.Name = "codigo_alquiler";
            this.codigo_alquiler.Size = new System.Drawing.Size(184, 27);
            this.codigo_alquiler.TabIndex = 210;
            this.codigo_alquiler.TextChanged += new System.EventHandler(this.codigo_alquiler_TextChanged);
            this.codigo_alquiler.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo_alquiler_KeyPress);
            // 
            // autor_alquier
            // 
            this.autor_alquier.Enabled = false;
            this.autor_alquier.Location = new System.Drawing.Point(208, 117);
            this.autor_alquier.MaxLength = 150;
            this.autor_alquier.Name = "autor_alquier";
            this.autor_alquier.Size = new System.Drawing.Size(184, 27);
            this.autor_alquier.TabIndex = 212;
            // 
            // dgv_alquiler
            // 
            this.dgv_alquiler.AllowUserToOrderColumns = true;
            this.dgv_alquiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_alquiler.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_alquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alquiler.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_alquiler.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_alquiler.Location = new System.Drawing.Point(10, 377);
            this.dgv_alquiler.MultiSelect = false;
            this.dgv_alquiler.Name = "dgv_alquiler";
            this.dgv_alquiler.ReadOnly = true;
            this.dgv_alquiler.RowHeadersWidth = 123;
            this.dgv_alquiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_alquiler.Size = new System.Drawing.Size(756, 171);
            this.dgv_alquiler.TabIndex = 209;
            this.dgv_alquiler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_libro_CellClick);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrar.Location = new System.Drawing.Point(476, 105);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(93, 49);
            this.btnRegistrar.TabIndex = 210;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Registro_alquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OfficeHouse.Properties.Resources.CCB38D;
            this.ClientSize = new System.Drawing.Size(779, 560);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgv_alquiler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registro_alquiler";
            this.Text = "Registro_alquiler";
            this.Load += new System.EventHandler(this.Registro_alquiler_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alquiler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_alquiler;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DateTimePicker fechalquiler;
        public System.Windows.Forms.TextBox cantidad_alquiler;
        private System.Windows.Forms.TextBox codigo_alquiler;
        private System.Windows.Forms.TextBox autor_alquier;
        private System.Windows.Forms.ComboBox titulo_alquiler;
    }
}