
namespace OfficeHouse
{
    partial class registroexitoso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registroexitoso));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::OfficeHouse.Properties.Resources._0C1231;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 77);
            this.panel2.TabIndex = 158;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(228, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 46);
            this.label6.TabIndex = 120;
            this.label6.Text = "Aviso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(170, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 24);
            this.label1.TabIndex = 159;
            this.label1.Text = "SE REALIZÓ CORRECTAMENTE";
            // 
            // btnaceptar
            // 
            this.btnaceptar.AutoSize = true;
            this.btnaceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnaceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaceptar.BackgroundImage")));
            this.btnaceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaceptar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnaceptar.FlatAppearance.BorderSize = 0;
            this.btnaceptar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnaceptar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Location = new System.Drawing.Point(236, 180);
            this.btnaceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(123, 47);
            this.btnaceptar.TabIndex = 162;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // registroexitoso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OfficeHouse.Properties.Resources.CCB38D;
            this.ClientSize = new System.Drawing.Size(627, 265);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "registroexitoso";
            this.Text = "Messageboxcorrecto";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label label6;
    }
}