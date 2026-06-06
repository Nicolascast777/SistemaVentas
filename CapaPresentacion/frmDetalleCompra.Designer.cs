namespace CapaPresentacion
{
    partial class frmDetalleCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleCompra));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txttipodocumento = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnombreproveedor = new System.Windows.Forms.TextBox();
            this.txtdocproveedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnumerodocumento = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmontototal = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnbuscarproveedor = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 481);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detalle de Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(338, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número Documento";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(446, 30);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(130, 20);
            this.txtbusqueda.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.txttipodocumento);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(30, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 75);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(235, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(466, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Usuario";
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtfecha.Location = new System.Drawing.Point(6, 44);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(163, 20);
            this.txtfecha.TabIndex = 11;
            // 
            // txttipodocumento
            // 
            this.txttipodocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txttipodocumento.Location = new System.Drawing.Point(238, 44);
            this.txttipodocumento.Name = "txttipodocumento";
            this.txttipodocumento.Size = new System.Drawing.Size(172, 20);
            this.txttipodocumento.TabIndex = 12;
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtusuario.Location = new System.Drawing.Point(469, 44);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(172, 20);
            this.txtusuario.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtnumerodocumento);
            this.groupBox2.Controls.Add(this.txtnombreproveedor);
            this.groupBox2.Controls.Add(this.txtdocproveedor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(30, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 80);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Proveedor";
            // 
            // txtnombreproveedor
            // 
            this.txtnombreproveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtnombreproveedor.Location = new System.Drawing.Point(238, 45);
            this.txtnombreproveedor.Name = "txtnombreproveedor";
            this.txtnombreproveedor.Size = new System.Drawing.Size(172, 20);
            this.txtnombreproveedor.TabIndex = 17;
            // 
            // txtdocproveedor
            // 
            this.txtdocproveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtdocproveedor.Location = new System.Drawing.Point(6, 45);
            this.txtdocproveedor.Name = "txtdocproveedor";
            this.txtdocproveedor.Size = new System.Drawing.Size(163, 20);
            this.txtdocproveedor.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(235, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Razón Social";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Número Documento";
            // 
            // txtnumerodocumento
            // 
            this.txtnumerodocumento.Location = new System.Drawing.Point(618, 45);
            this.txtnumerodocumento.Name = "txtnumerodocumento";
            this.txtnumerodocumento.Size = new System.Drawing.Size(56, 20);
            this.txtnumerodocumento.TabIndex = 9;
            this.txtnumerodocumento.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.PrecioCompra,
            this.Cantidad,
            this.SubTotal});
            this.dataGridView1.Location = new System.Drawing.Point(30, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 196);
            this.dataGridView1.TabIndex = 9;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.Width = 220;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.Width = 120;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 110;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(33, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Monto Total:";
            // 
            // txtmontototal
            // 
            this.txtmontototal.BackColor = System.Drawing.SystemColors.Window;
            this.txtmontototal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontototal.Location = new System.Drawing.Point(106, 435);
            this.txtmontototal.Name = "txtmontototal";
            this.txtmontototal.Size = new System.Drawing.Size(95, 24);
            this.txtmontototal.TabIndex = 18;
            // 
            // iconButton2
            // 
            this.iconButton2.Icon = FontAwesome.Sharp.IconChar.FilePdfO;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 18;
            this.iconButton2.Image = ((System.Drawing.Image)(resources.GetObject("iconButton2.Image")));
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(581, 432);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(129, 27);
            this.iconButton2.TabIndex = 19;
            this.iconButton2.Text = "Descargar PDF";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Icon = FontAwesome.Sharp.IconChar.Eraser;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Image = ((System.Drawing.Image)(resources.GetObject("iconButton1.Image")));
            this.iconButton1.Location = new System.Drawing.Point(648, 29);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(62, 23);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnbuscarproveedor
            // 
            this.btnbuscarproveedor.Icon = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarproveedor.IconColor = System.Drawing.Color.Black;
            this.btnbuscarproveedor.IconSize = 16;
            this.btnbuscarproveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscarproveedor.Image")));
            this.btnbuscarproveedor.Location = new System.Drawing.Point(581, 29);
            this.btnbuscarproveedor.Name = "btnbuscarproveedor";
            this.btnbuscarproveedor.Size = new System.Drawing.Size(62, 23);
            this.btnbuscarproveedor.TabIndex = 5;
            this.btnbuscarproveedor.UseVisualStyleBackColor = true;
            this.btnbuscarproveedor.Click += new System.EventHandler(this.btnbuscarproveedor_Click);
            // 
            // frmDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 501);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.txtmontototal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnbuscarproveedor);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDetalleCompra";
            this.Text = "frmDetalleCompra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbusqueda;
        private FontAwesome.Sharp.IconButton btnbuscarproveedor;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txttipodocumento;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnumerodocumento;
        private System.Windows.Forms.TextBox txtnombreproveedor;
        private System.Windows.Forms.TextBox txtdocproveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmontototal;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}