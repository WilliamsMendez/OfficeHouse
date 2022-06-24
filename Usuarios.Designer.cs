
namespace OfficeHouse
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cerrarform = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.txt_NomUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cb_puesto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtp_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.dtp_contratacion = new System.Windows.Forms.DateTimePicker();
            this.btnatras = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_contratacion = new System.Windows.Forms.TextBox();
            this.txt_nacimiento = new System.Windows.Forms.TextBox();
            this.dgv_Usuario = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::OfficeHouse.Properties.Resources._0C1231;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(-3, -3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 74);
            this.panel2.TabIndex = 135;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(360, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 46);
            this.label5.TabIndex = 120;
            this.label5.Text = "Usuarios";
            // 
            // cerrarform
            // 
            this.cerrarform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarform.AutoSize = true;
            this.cerrarform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cerrarform.Location = new System.Drawing.Point(688, 20);
            this.cerrarform.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cerrarform.Name = "cerrarform";
            this.cerrarform.Size = new System.Drawing.Size(0, 20);
            this.cerrarform.TabIndex = 132;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 24);
            this.label10.TabIndex = 126;
            this.label10.Text = "Apellido:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 24);
            this.label7.TabIndex = 123;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 124;
            this.label6.Text = "Código:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_Apellido.Location = new System.Drawing.Point(145, 105);
            this.txt_Apellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(132, 23);
            this.txt_Apellido.TabIndex = 127;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_Nombre.Location = new System.Drawing.Point(145, 66);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(132, 23);
            this.txt_Nombre.TabIndex = 128;
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.SystemColors.Control;
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_codigo.Location = new System.Drawing.Point(145, 31);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(132, 23);
            this.txt_codigo.TabIndex = 129;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(345, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 130;
            this.label8.Text = "Puestos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 131;
            this.label4.Text = " Usuario:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 132;
            this.label3.Text = "Clave:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 133;
            this.label1.Text = "Nacimiento:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Clave
            // 
            this.txt_Clave.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_Clave.Location = new System.Drawing.Point(145, 231);
            this.txt_Clave.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(132, 23);
            this.txt_Clave.TabIndex = 135;
            // 
            // txt_NomUsuario
            // 
            this.txt_NomUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txt_NomUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_NomUsuario.Location = new System.Drawing.Point(145, 202);
            this.txt_NomUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NomUsuario.Name = "txt_NomUsuario";
            this.txt_NomUsuario.Size = new System.Drawing.Size(132, 23);
            this.txt_NomUsuario.TabIndex = 136;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 24);
            this.label9.TabIndex = 137;
            this.label9.Text = "Nombre:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Transparent;
            this.btnmodificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmodificar.BackgroundImage")));
            this.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodificar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnmodificar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(512, 126);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(139, 37);
            this.btnmodificar.TabIndex = 126;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmodificar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(512, 84);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 37);
            this.btnAgregar.TabIndex = 125;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // cb_puesto
            // 
            this.cb_puesto.BackColor = System.Drawing.SystemColors.Control;
            this.cb_puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_puesto.FormattingEnabled = true;
            this.cb_puesto.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cb_puesto.Location = new System.Drawing.Point(440, 27);
            this.cb_puesto.Margin = new System.Windows.Forms.Padding(4);
            this.cb_puesto.Name = "cb_puesto";
            this.cb_puesto.Size = new System.Drawing.Size(143, 25);
            this.cb_puesto.TabIndex = 141;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 142;
            this.label2.Text = "Contratación:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(512, 170);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(139, 37);
            this.btnEliminar.TabIndex = 127;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dtp_nacimiento
            // 
            this.dtp_nacimiento.CustomFormat = "MM-dd-yyyy";
            this.dtp_nacimiento.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_nacimiento.Location = new System.Drawing.Point(304, 166);
            this.dtp_nacimiento.Margin = new System.Windows.Forms.Padding(1);
            this.dtp_nacimiento.Name = "dtp_nacimiento";
            this.dtp_nacimiento.Size = new System.Drawing.Size(132, 25);
            this.dtp_nacimiento.TabIndex = 145;
            // 
            // dtp_contratacion
            // 
            this.dtp_contratacion.CustomFormat = "MM-dd-yyyy";
            this.dtp_contratacion.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_contratacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_contratacion.Location = new System.Drawing.Point(304, 133);
            this.dtp_contratacion.Margin = new System.Windows.Forms.Padding(1);
            this.dtp_contratacion.Name = "dtp_contratacion";
            this.dtp_contratacion.Size = new System.Drawing.Size(132, 25);
            this.dtp_contratacion.TabIndex = 146;
            this.dtp_contratacion.Value = new System.DateTime(2022, 2, 23, 12, 17, 19, 0);
            // 
            // btnatras
            // 
            this.btnatras.BackColor = System.Drawing.Color.Transparent;
            this.btnatras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnatras.BackgroundImage")));
            this.btnatras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnatras.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnatras.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatras.Location = new System.Drawing.Point(512, 215);
            this.btnatras.Margin = new System.Windows.Forms.Padding(4);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(139, 37);
            this.btnatras.TabIndex = 130;
            this.btnatras.Text = "Atras";
            this.btnatras.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnatras.UseVisualStyleBackColor = false;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_contratacion);
            this.groupBox1.Controls.Add(this.btnatras);
            this.groupBox1.Controls.Add(this.txt_nacimiento);
            this.groupBox1.Controls.Add(this.dtp_contratacion);
            this.groupBox1.Controls.Add(this.dtp_nacimiento);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_puesto);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_NomUsuario);
            this.groupBox1.Controls.Add(this.txt_Clave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.txt_Apellido);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(95, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(676, 262);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Usuario";
            // 
            // txt_contratacion
            // 
            this.txt_contratacion.BackColor = System.Drawing.SystemColors.Control;
            this.txt_contratacion.Enabled = false;
            this.txt_contratacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_contratacion.Location = new System.Drawing.Point(145, 137);
            this.txt_contratacion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contratacion.Name = "txt_contratacion";
            this.txt_contratacion.Size = new System.Drawing.Size(132, 23);
            this.txt_contratacion.TabIndex = 148;
            // 
            // txt_nacimiento
            // 
            this.txt_nacimiento.BackColor = System.Drawing.SystemColors.Control;
            this.txt_nacimiento.Enabled = false;
            this.txt_nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_nacimiento.Location = new System.Drawing.Point(145, 169);
            this.txt_nacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nacimiento.Name = "txt_nacimiento";
            this.txt_nacimiento.Size = new System.Drawing.Size(132, 23);
            this.txt_nacimiento.TabIndex = 147;
            // 
            // dgv_Usuario
            // 
            this.dgv_Usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Usuario.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Autor,
            this.Categoría,
            this.Estado_libro,
            this.Precio,
            this.Fecha,
            this.Puesto});
            this.dgv_Usuario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Usuario.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Usuario.Location = new System.Drawing.Point(13, 362);
            this.dgv_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Usuario.MultiSelect = false;
            this.dgv_Usuario.Name = "dgv_Usuario";
            this.dgv_Usuario.ReadOnly = true;
            this.dgv_Usuario.RowHeadersWidth = 123;
            this.dgv_Usuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Usuario.Size = new System.Drawing.Size(853, 162);
            this.dgv_Usuario.TabIndex = 197;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Apellido";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Categoría
            // 
            this.Categoría.HeaderText = "Contratación";
            this.Categoría.MinimumWidth = 6;
            this.Categoría.Name = "Categoría";
            this.Categoría.ReadOnly = true;
            // 
            // Estado_libro
            // 
            this.Estado_libro.HeaderText = "Nacimiento";
            this.Estado_libro.MinimumWidth = 6;
            this.Estado_libro.Name = "Estado_libro";
            this.Estado_libro.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Usuario";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Clave";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.MinimumWidth = 6;
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OfficeHouse.Properties.Resources.CCB38D;
            this.ClientSize = new System.Drawing.Size(914, 572);
            this.Controls.Add(this.dgv_Usuario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cerrarform);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cerrarform;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Clave;
        private System.Windows.Forms.TextBox txt_NomUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cb_puesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker dtp_nacimiento;
        private System.Windows.Forms.DateTimePicker dtp_contratacion;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Usuario;
        private System.Windows.Forms.TextBox txt_contratacion;
        private System.Windows.Forms.TextBox txt_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoría;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
    }
}