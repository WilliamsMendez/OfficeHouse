
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
            this.btnpagar = new System.Windows.Forms.Button();
            this.btnatras = new System.Windows.Forms.Button();
            this.fecha_alquier = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.autor_alquier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.titulo_alquiler = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codigo_alquiler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Usuario = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Alquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechaentrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cantidad_alquiler = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_fecha_aprox_entrega = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(736, 79);
            this.panel2.TabIndex = 151;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(202, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 36);
            this.label3.TabIndex = 119;
            this.label3.Text = "Registro de Alquiler";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(546, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 49);
            this.button2.TabIndex = 203;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(431, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 49);
            this.button1.TabIndex = 202;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnpagar
            // 
            this.btnpagar.BackColor = System.Drawing.Color.Transparent;
            this.btnpagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpagar.BackgroundImage")));
            this.btnpagar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnpagar.Location = new System.Drawing.Point(431, 119);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(93, 49);
            this.btnpagar.TabIndex = 201;
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
            this.btnatras.Location = new System.Drawing.Point(482, 273);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(93, 49);
            this.btnatras.TabIndex = 200;
            this.btnatras.Text = "Atras";
            this.btnatras.UseVisualStyleBackColor = false;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // fecha_alquier
            // 
            this.fecha_alquier.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_alquier.Location = new System.Drawing.Point(207, 162);
            this.fecha_alquier.Name = "fecha_alquier";
            this.fecha_alquier.Size = new System.Drawing.Size(184, 27);
            this.fecha_alquier.TabIndex = 199;
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
            this.label4.Location = new System.Drawing.Point(20, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 197;
            this.label4.Text = "Cantidad:";
            // 
            // autor_alquier
            // 
            this.autor_alquier.Location = new System.Drawing.Point(207, 119);
            this.autor_alquier.Name = "autor_alquier";
            this.autor_alquier.Size = new System.Drawing.Size(184, 27);
            this.autor_alquier.TabIndex = 196;
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
            // titulo_alquiler
            // 
            this.titulo_alquiler.Location = new System.Drawing.Point(207, 76);
            this.titulo_alquiler.Name = "titulo_alquiler";
            this.titulo_alquiler.Size = new System.Drawing.Size(184, 27);
            this.titulo_alquiler.TabIndex = 194;
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
            // codigo_alquiler
            // 
            this.codigo_alquiler.Enabled = false;
            this.codigo_alquiler.Location = new System.Drawing.Point(207, 34);
            this.codigo_alquiler.Name = "codigo_alquiler";
            this.codigo_alquiler.Size = new System.Drawing.Size(184, 27);
            this.codigo_alquiler.TabIndex = 192;
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
            // dgv_Usuario
            // 
            this.dgv_Usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Usuario.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Titulo,
            this.Autor,
            this.Categoría,
            this.Fecha_Alquiler,
            this.Fechaentrega,
            this.Cantidad,
            this.Precio});
            this.dgv_Usuario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Usuario.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Usuario.Location = new System.Drawing.Point(10, 378);
            this.dgv_Usuario.MultiSelect = false;
            this.dgv_Usuario.Name = "dgv_Usuario";
            this.dgv_Usuario.RowHeadersWidth = 123;
            this.dgv_Usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Usuario.Size = new System.Drawing.Size(700, 132);
            this.dgv_Usuario.TabIndex = 190;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
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
            // Categoría
            // 
            this.Categoría.HeaderText = "Categoría";
            this.Categoría.MinimumWidth = 6;
            this.Categoría.Name = "Categoría";
            // 
            // Fecha_Alquiler
            // 
            this.Fecha_Alquiler.HeaderText = "Fecha Alquiler";
            this.Fecha_Alquiler.MinimumWidth = 6;
            this.Fecha_Alquiler.Name = "Fecha_Alquiler";
            this.Fecha_Alquiler.ReadOnly = true;
            // 
            // Fechaentrega
            // 
            this.Fechaentrega.HeaderText = "Fecha a Entregar";
            this.Fechaentrega.MinimumWidth = 6;
            this.Fechaentrega.Name = "Fechaentrega";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 19);
            this.label6.TabIndex = 205;
            this.label6.Text = "Fecha aprox de entrega:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(546, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 49);
            this.button3.TabIndex = 206;
            this.button3.Text = "Pagar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // cantidad_alquiler
            // 
            this.cantidad_alquiler.Location = new System.Drawing.Point(207, 240);
            this.cantidad_alquiler.Name = "cantidad_alquiler";
            this.cantidad_alquiler.Size = new System.Drawing.Size(184, 27);
            this.cantidad_alquiler.TabIndex = 207;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtp_fecha_aprox_entrega);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cantidad_alquiler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.codigo_alquiler);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.titulo_alquiler);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.autor_alquier);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.fecha_alquier);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 279);
            this.groupBox1.TabIndex = 208;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Aquiler";
            // 
            // dtp_fecha_aprox_entrega
            // 
            this.dtp_fecha_aprox_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_aprox_entrega.Location = new System.Drawing.Point(206, 202);
            this.dtp_fecha_aprox_entrega.Name = "dtp_fecha_aprox_entrega";
            this.dtp_fecha_aprox_entrega.Size = new System.Drawing.Size(184, 27);
            this.dtp_fecha_aprox_entrega.TabIndex = 208;
            // 
            // Registro_alquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OfficeHouse.Properties.Resources.CCB38D;
            this.ClientSize = new System.Drawing.Size(729, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.dgv_Usuario);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registro_alquiler";
            this.Text = "Registro_alquiler";
            this.Load += new System.EventHandler(this.Registro_alquiler_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnpagar;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.DateTimePicker fecha_alquier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox autor_alquier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox titulo_alquiler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigo_alquiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Usuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox cantidad_alquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoría;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Alquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechaentrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_fecha_aprox_entrega;
    }
}