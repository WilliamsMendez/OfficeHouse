﻿
namespace OfficeHouse
{
    partial class MenuDevolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDevolucion));
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btnregistro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnconsultar
            // 
            this.btnconsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnconsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnconsultar.BackgroundImage")));
            this.btnconsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnconsultar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnconsultar.Location = new System.Drawing.Point(111, 224);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(150, 52);
            this.btnconsultar.TabIndex = 134;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = false;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncerrar.BackgroundImage")));
            this.btncerrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncerrar.Location = new System.Drawing.Point(111, 300);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(150, 52);
            this.btncerrar.TabIndex = 133;
            this.btncerrar.Text = "Volver";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnregistro
            // 
            this.btnregistro.BackColor = System.Drawing.Color.Transparent;
            this.btnregistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistro.BackgroundImage")));
            this.btnregistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnregistro.Location = new System.Drawing.Point(111, 148);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(150, 52);
            this.btnregistro.TabIndex = 132;
            this.btnregistro.Text = "Registro";
            this.btnregistro.UseVisualStyleBackColor = false;
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::OfficeHouse.Properties.Resources._0C1231;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 93);
            this.panel1.TabIndex = 131;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Menu Devolución";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OfficeHouse.Properties.Resources.CCB38D;
            this.ClientSize = new System.Drawing.Size(370, 479);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnregistro);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuDevolucion";
            this.Text = "Menu Devolucion";
            this.Load += new System.EventHandler(this.MenuDevolucion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}