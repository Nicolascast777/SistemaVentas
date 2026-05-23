namespace CapaPresentacion
{
    partial class frmNegocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNegocio));
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txtnit = new System.Windows.Forms.TextBox();
            this.lblnit = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsubir = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Detalle Negocio";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 450);
            this.label1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.iconButton2);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.lbldireccion);
            this.groupBox1.Controls.Add(this.txtnit);
            this.groupBox1.Controls.Add(this.lblnit);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnsubir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.picLogo);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 291);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // iconButton2
            // 
            this.iconButton2.Icon = FontAwesome.Sharp.IconChar.FloppyO;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 16;
            this.iconButton2.Image = ((System.Drawing.Image)(resources.GetObject("iconButton2.Image")));
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton2.Location = new System.Drawing.Point(223, 212);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(233, 36);
            this.iconButton2.TabIndex = 557;
            this.iconButton2.Text = "Guardar";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(223, 170);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(233, 20);
            this.txtdireccion.TabIndex = 3;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(220, 154);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(52, 13);
            this.lbldireccion.TabIndex = 7;
            this.lbldireccion.Text = "Direccion";
            // 
            // txtnit
            // 
            this.txtnit.Location = new System.Drawing.Point(223, 103);
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(233, 20);
            this.txtnit.TabIndex = 2;
            // 
            // lblnit
            // 
            this.lblnit.AutoSize = true;
            this.lblnit.Location = new System.Drawing.Point(220, 87);
            this.lblnit.Name = "lblnit";
            this.lblnit.Size = new System.Drawing.Size(31, 13);
            this.lblnit.TabIndex = 5;
            this.lblnit.Text = "N.I.T";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(223, 38);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(233, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre Negocio";
            // 
            // btnsubir
            // 
            this.btnsubir.Icon = FontAwesome.Sharp.IconChar.Upload;
            this.btnsubir.IconColor = System.Drawing.Color.Black;
            this.btnsubir.IconSize = 16;
            this.btnsubir.Image = ((System.Drawing.Image)(resources.GetObject("btnsubir.Image")));
            this.btnsubir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsubir.Location = new System.Drawing.Point(25, 212);
            this.btnsubir.Name = "btnsubir";
            this.btnsubir.Size = new System.Drawing.Size(128, 35);
            this.btnsubir.TabIndex = 23;
            this.btnsubir.Text = "Subir";
            this.btnsubir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsubir.UseVisualStyleBackColor = true;
            this.btnsubir.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 556;
            this.label2.Text = "Logo";
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(15, 38);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(148, 152);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // frmNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "frmNegocio";
            this.Text = "frmNegocio";
            this.Load += new System.EventHandler(this.frmNegocio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnsubir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox txtnit;
        private System.Windows.Forms.Label lblnit;
        private System.Windows.Forms.TextBox txtnombre;
    }
}