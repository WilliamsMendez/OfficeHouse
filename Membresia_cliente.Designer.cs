﻿
namespace OfficeHouse
{
    partial class Membresia_cliente
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
            this.btnregistro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnusuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregistro
            // 
            this.btnregistro.AutoSize = true;
            this.btnregistro.BackColor = System.Drawing.Color.White;
            this.btnregistro.BackgroundImage = global::OfficeHouse.Properties.Resources.F99909;
            this.btnregistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistro.FlatAppearance.BorderSize = 0;
            this.btnregistro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnregistro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistro.Location = new System.Drawing.Point(36, 230);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(165, 38);
            this.btnregistro.TabIndex = 109;
            this.btnregistro.Text = "Continuar";
            this.btnregistro.UseVisualStyleBackColor = false;
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            this.btnregistro.Validated += new System.EventHandler(this.btnregistro_Validated);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::OfficeHouse.Properties.Resources._0C1231;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 95);
            this.panel1.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(83, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Número de Membresia";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnusuario
            // 
            this.btnusuario.BackColor = System.Drawing.Color.White;
            this.btnusuario.BackgroundImage = global::OfficeHouse.Properties.Resources.F99909;
            this.btnusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnusuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnusuario.FlatAppearance.BorderSize = 0;
            this.btnusuario.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnusuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuario.Location = new System.Drawing.Point(266, 230);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(165, 38);
            this.btnusuario.TabIndex = 108;
            this.btnusuario.Text = "Salir";
            this.btnusuario.UseVisualStyleBackColor = false;
            this.btnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(68, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 18);
            this.label1.TabIndex = 113;
            this.label1.Text = "INGRESE EL NÚMERO DE MEMBRESIA DEL CLIENTE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 176);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MaxLength = 13;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 20);
            this.textBox1.TabIndex = 114;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // Membresia_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OfficeHouse.Properties.Resources.CCB38D;
            this.ClientSize = new System.Drawing.Size(476, 341);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnregistro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnusuario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Membresia_cliente";
            this.Text = "Menbresia Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider epError;
    }
}