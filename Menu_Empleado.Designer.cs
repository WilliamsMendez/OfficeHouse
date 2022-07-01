
namespace OfficeHouse
{
    partial class Menu_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Empleado));
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnalquiler = new System.Windows.Forms.Button();
            this.btnregistro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.BackgroundImage = global::OfficeHouse.Properties.Resources.F99909;
            this.btncerrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncerrar.Location = new System.Drawing.Point(143, 370);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(200, 78);
            this.btncerrar.TabIndex = 125;
            this.btncerrar.Text = "Cerrar Sesión";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnalquiler
            // 
            this.btnalquiler.BackColor = System.Drawing.Color.Transparent;
            this.btnalquiler.BackgroundImage = global::OfficeHouse.Properties.Resources.F99909;
            this.btnalquiler.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalquiler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnalquiler.Location = new System.Drawing.Point(143, 263);
            this.btnalquiler.Margin = new System.Windows.Forms.Padding(4);
            this.btnalquiler.Name = "btnalquiler";
            this.btnalquiler.Size = new System.Drawing.Size(200, 78);
            this.btnalquiler.TabIndex = 124;
            this.btnalquiler.Text = "Alquiler";
            this.btnalquiler.UseVisualStyleBackColor = false;
            this.btnalquiler.Click += new System.EventHandler(this.btnalquiler_Click);
            // 
            // btnregistro
            // 
            this.btnregistro.BackColor = System.Drawing.Color.White;
            this.btnregistro.BackgroundImage = global::OfficeHouse.Properties.Resources.F99909;
            this.btnregistro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnregistro.Location = new System.Drawing.Point(143, 150);
            this.btnregistro.Margin = new System.Windows.Forms.Padding(4);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(200, 78);
            this.btnregistro.TabIndex = 123;
            this.btnregistro.Text = "Registro Libro";
            this.btnregistro.UseVisualStyleBackColor = false;
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 94);
            this.panel2.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(87, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 46);
            this.label3.TabIndex = 119;
            this.label3.Text = "Menu Empleado";
            // 
            // Menu_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OfficeHouse.Properties.Resources.CCB38D;
            this.ClientSize = new System.Drawing.Size(486, 559);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnalquiler);
            this.Controls.Add(this.btnregistro);
            this.Controls.Add(this.panel2);
            this.Name = "Menu_Empleado";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnalquiler;
        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}