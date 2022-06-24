
namespace OfficeHouse
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_IniSec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnprueba = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_IniSec
            // 
            this.btn_IniSec.BackColor = System.Drawing.Color.Transparent;
            this.btn_IniSec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_IniSec.BackgroundImage")));
            this.btn_IniSec.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IniSec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_IniSec.Location = new System.Drawing.Point(139, 396);
            this.btn_IniSec.Margin = new System.Windows.Forms.Padding(4);
            this.btn_IniSec.Name = "btn_IniSec";
            this.btn_IniSec.Size = new System.Drawing.Size(285, 43);
            this.btn_IniSec.TabIndex = 50;
            this.btn_IniSec.Text = "Iniciar Sesión";
            this.btn_IniSec.UseVisualStyleBackColor = false;
            this.btn_IniSec.Click += new System.EventHandler(this.btn_IniSec_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(140, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 46);
            this.label3.TabIndex = 10;
            this.label3.Text = "OFFICE HOUSE";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(140, 182);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(139, 283);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(140, 361);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 2);
            this.panel3.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(140, 260);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 2);
            this.panel2.TabIndex = 44;
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(139, 329);
            this.txt_clave.Margin = new System.Windows.Forms.Padding(4);
            this.txt_clave.MaxLength = 20;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(284, 22);
            this.txt_clave.TabIndex = 43;
            this.txt_clave.UseSystemPasswordChar = true;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(139, 228);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usuario.MaxLength = 30;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(284, 22);
            this.txt_usuario.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 128);
            this.panel1.TabIndex = 48;
            // 
            // btnprueba
            // 
            this.btnprueba.BackColor = System.Drawing.Color.Transparent;
            this.btnprueba.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnprueba.BackgroundImage")));
            this.btnprueba.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprueba.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnprueba.Location = new System.Drawing.Point(138, 477);
            this.btnprueba.Margin = new System.Windows.Forms.Padding(4);
            this.btnprueba.Name = "btnprueba";
            this.btnprueba.Size = new System.Drawing.Size(285, 43);
            this.btnprueba.TabIndex = 51;
            this.btnprueba.Text = "Prueba base";
            this.btnprueba.UseVisualStyleBackColor = false;
            this.btnprueba.Click += new System.EventHandler(this.btnprueba_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(547, 580);
            this.Controls.Add(this.btnprueba);
            this.Controls.Add(this.btn_IniSec);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.txt_usuario);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_IniSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnprueba;
    }
}

