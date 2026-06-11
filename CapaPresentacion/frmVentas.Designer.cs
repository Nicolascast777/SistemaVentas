namespace CapaPresentacion
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbotipodocumento = new System.Windows.Forms.ComboBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnbuscarproveedor = new FontAwesome.Sharp.IconButton();
            this.txtnombreCliente = new System.Windows.Forms.TextBox();
            this.txtdocumentoCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtideproducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtcodigoProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnagregarProducto = new FontAwesome.Sharp.IconButton();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtpagocon = new System.Windows.Forms.TextBox();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnregistrarcompra = new FontAwesome.Sharp.IconButton();
            this.btn_5k = new FontAwesome.Sharp.IconButton();
            this.btn_10k = new FontAwesome.Sharp.IconButton();
            this.btn_20k = new FontAwesome.Sharp.IconButton();
            this.btn_50k = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(938, 486);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registrar Venta";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbotipodocumento);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(30, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 61);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Venta";
            // 
            // cbotipodocumento
            // 
            this.cbotipodocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipodocumento.FormattingEnabled = true;
            this.cbotipodocumento.Location = new System.Drawing.Point(149, 32);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.Size = new System.Drawing.Size(141, 21);
            this.cbotipodocumento.TabIndex = 3;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(9, 32);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(132, 20);
            this.txtfecha.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipo Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnbuscarproveedor);
            this.groupBox2.Controls.Add(this.txtnombreCliente);
            this.groupBox2.Controls.Add(this.txtdocumentoCliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(346, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 61);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre Completo";
            // 
            // btnbuscarproveedor
            // 
            this.btnbuscarproveedor.Icon = FontAwesome.Sharp.IconChar.Search;
            this.btnbuscarproveedor.IconColor = System.Drawing.Color.Black;
            this.btnbuscarproveedor.IconSize = 16;
            this.btnbuscarproveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscarproveedor.Image")));
            this.btnbuscarproveedor.Location = new System.Drawing.Point(125, 30);
            this.btnbuscarproveedor.Name = "btnbuscarproveedor";
            this.btnbuscarproveedor.Size = new System.Drawing.Size(28, 23);
            this.btnbuscarproveedor.TabIndex = 6;
            this.btnbuscarproveedor.UseVisualStyleBackColor = true;
            this.btnbuscarproveedor.Click += new System.EventHandler(this.btnbuscarproveedor_Click);
            // 
            // txtnombreCliente
            // 
            this.txtnombreCliente.Location = new System.Drawing.Point(161, 31);
            this.txtnombreCliente.Name = "txtnombreCliente";
            this.txtnombreCliente.Size = new System.Drawing.Size(148, 20);
            this.txtnombreCliente.TabIndex = 5;
            // 
            // txtdocumentoCliente
            // 
            this.txtdocumentoCliente.Location = new System.Drawing.Point(9, 32);
            this.txtdocumentoCliente.Name = "txtdocumentoCliente";
            this.txtdocumentoCliente.Size = new System.Drawing.Size(110, 20);
            this.txtdocumentoCliente.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número Documento";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtideproducto);
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtstock);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtprecio);
            this.groupBox3.Controls.Add(this.txtProducto);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.iconButton1);
            this.groupBox3.Controls.Add(this.txtcodigoProducto);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(30, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(634, 83);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Producto";
            // 
            // txtideproducto
            // 
            this.txtideproducto.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtideproducto.Location = new System.Drawing.Point(130, 11);
            this.txtideproducto.Name = "txtideproducto";
            this.txtideproducto.Size = new System.Drawing.Size(50, 20);
            this.txtideproducto.TabIndex = 16;
            this.txtideproducto.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(489, 51);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(94, 20);
            this.txtCantidad.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(486, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Cantidad";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(425, 51);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(49, 20);
            this.txtstock.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(426, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Stock";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Precio";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(326, 51);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(86, 20);
            this.txtprecio.TabIndex = 10;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(167, 51);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(153, 20);
            this.txtProducto.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Producto";
            // 
            // iconButton1
            // 
            this.iconButton1.Icon = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Image = ((System.Drawing.Image)(resources.GetObject("iconButton1.Image")));
            this.iconButton1.Location = new System.Drawing.Point(131, 49);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(28, 23);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtcodigoProducto
            // 
            this.txtcodigoProducto.BackColor = System.Drawing.Color.White;
            this.txtcodigoProducto.Location = new System.Drawing.Point(9, 51);
            this.txtcodigoProducto.Name = "txtcodigoProducto";
            this.txtcodigoProducto.Size = new System.Drawing.Size(116, 20);
            this.txtcodigoProducto.TabIndex = 4;
            this.txtcodigoProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodigoProducto_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cod. Producto";
            // 
            // btnagregarProducto
            // 
            this.btnagregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnagregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarProducto.Icon = FontAwesome.Sharp.IconChar.Plus;
            this.btnagregarProducto.IconColor = System.Drawing.Color.Green;
            this.btnagregarProducto.IconSize = 25;
            this.btnagregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnagregarProducto.Image")));
            this.btnagregarProducto.Location = new System.Drawing.Point(672, 115);
            this.btnagregarProducto.Name = "btnagregarProducto";
            this.btnagregarProducto.Size = new System.Drawing.Size(253, 78);
            this.btnagregarProducto.TabIndex = 16;
            this.btnagregarProducto.Text = "Agregar";
            this.btnagregarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnagregarProducto.UseVisualStyleBackColor = true;
            this.btnagregarProducto.Click += new System.EventHandler(this.btnagregarProducto_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
            this.dgvdata.Location = new System.Drawing.Point(26, 202);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowTemplate.Height = 30;
            this.dgvdata.Size = new System.Drawing.Size(638, 277);
            this.dgvdata.TabIndex = 17;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.txttotalpagar.Enabled = false;
            this.txttotalpagar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpagar.ForeColor = System.Drawing.Color.Blue;
            this.txttotalpagar.Location = new System.Drawing.Point(802, 456);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.Size = new System.Drawing.Size(124, 26);
            this.txttotalpagar.TabIndex = 34;
            this.txttotalpagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(802, 422);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 32);
            this.label12.TabIndex = 33;
            this.label12.Text = "Total a pagar";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtpagocon
            // 
            this.txtpagocon.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpagocon.ForeColor = System.Drawing.Color.Blue;
            this.txtpagocon.Location = new System.Drawing.Point(801, 204);
            this.txtpagocon.Name = "txtpagocon";
            this.txtpagocon.Size = new System.Drawing.Size(124, 26);
            this.txtpagocon.TabIndex = 36;
            this.txtpagocon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpagocon_KeyDown);
            this.txtpagocon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpagocon_KeyPress);
            // 
            // txtcambio
            // 
            this.txtcambio.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtcambio.Enabled = false;
            this.txtcambio.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcambio.ForeColor = System.Drawing.Color.Blue;
            this.txtcambio.Location = new System.Drawing.Point(751, 386);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.Size = new System.Drawing.Size(124, 26);
            this.txtcambio.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(751, 354);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 31);
            this.label14.TabIndex = 37;
            this.label14.Text = "Cambio:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnregistrarcompra
            // 
            this.btnregistrarcompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrarcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrarcompra.ForeColor = System.Drawing.Color.Green;
            this.btnregistrarcompra.Icon = FontAwesome.Sharp.IconChar.Tag;
            this.btnregistrarcompra.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnregistrarcompra.IconSize = 20;
            this.btnregistrarcompra.Image = ((System.Drawing.Image)(resources.GetObject("btnregistrarcompra.Image")));
            this.btnregistrarcompra.Location = new System.Drawing.Point(672, 426);
            this.btnregistrarcompra.Name = "btnregistrarcompra";
            this.btnregistrarcompra.Size = new System.Drawing.Size(124, 57);
            this.btnregistrarcompra.TabIndex = 39;
            this.btnregistrarcompra.Text = "Registrar Venta";
            this.btnregistrarcompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnregistrarcompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnregistrarcompra.UseVisualStyleBackColor = true;
            this.btnregistrarcompra.Click += new System.EventHandler(this.btnregistrarcompra_Click);
            // 
            // btn_5k
            // 
            this.btn_5k.BackgroundImage = global::CapaPresentacion.Properties.Resources._5k;
            this.btn_5k.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_5k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_5k.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_5k.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_5k.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_5k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5k.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5k.Icon = FontAwesome.Sharp.IconChar.None;
            this.btn_5k.IconColor = System.Drawing.Color.Black;
            this.btn_5k.IconSize = 16;
            this.btn_5k.Image = ((System.Drawing.Image)(resources.GetObject("btn_5k.Image")));
            this.btn_5k.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_5k.Location = new System.Drawing.Point(678, 242);
            this.btn_5k.Name = "btn_5k";
            this.btn_5k.Size = new System.Drawing.Size(103, 45);
            this.btn_5k.TabIndex = 40;
            this.btn_5k.Tag = "5.000";
            this.btn_5k.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_5k.UseVisualStyleBackColor = true;
            this.btn_5k.Click += new System.EventHandler(this.btn_5k_Click);
            this.btn_5k.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_5k_KeyPress);
            // 
            // btn_10k
            // 
            this.btn_10k.BackgroundImage = global::CapaPresentacion.Properties.Resources._10k;
            this.btn_10k.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_10k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_10k.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_10k.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_10k.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_10k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_10k.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_10k.Icon = FontAwesome.Sharp.IconChar.None;
            this.btn_10k.IconColor = System.Drawing.Color.Black;
            this.btn_10k.IconSize = 16;
            this.btn_10k.Image = ((System.Drawing.Image)(resources.GetObject("btn_10k.Image")));
            this.btn_10k.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_10k.Location = new System.Drawing.Point(823, 242);
            this.btn_10k.Name = "btn_10k";
            this.btn_10k.Size = new System.Drawing.Size(103, 45);
            this.btn_10k.TabIndex = 41;
            this.btn_10k.Tag = "10.000";
            this.btn_10k.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_10k.UseVisualStyleBackColor = true;
            this.btn_10k.Click += new System.EventHandler(this.btn_10k_Click);
            // 
            // btn_20k
            // 
            this.btn_20k.BackgroundImage = global::CapaPresentacion.Properties.Resources._20K;
            this.btn_20k.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_20k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_20k.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_20k.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_20k.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_20k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_20k.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_20k.Icon = FontAwesome.Sharp.IconChar.None;
            this.btn_20k.IconColor = System.Drawing.Color.Black;
            this.btn_20k.IconSize = 16;
            this.btn_20k.Image = ((System.Drawing.Image)(resources.GetObject("btn_20k.Image")));
            this.btn_20k.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_20k.Location = new System.Drawing.Point(678, 297);
            this.btn_20k.Name = "btn_20k";
            this.btn_20k.Size = new System.Drawing.Size(103, 45);
            this.btn_20k.TabIndex = 42;
            this.btn_20k.Tag = "20.000";
            this.btn_20k.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_20k.UseVisualStyleBackColor = true;
            this.btn_20k.Click += new System.EventHandler(this.btn_20k_Click);
            // 
            // btn_50k
            // 
            this.btn_50k.BackgroundImage = global::CapaPresentacion.Properties.Resources._50k;
            this.btn_50k.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_50k.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_50k.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_50k.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_50k.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_50k.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_50k.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_50k.Icon = FontAwesome.Sharp.IconChar.None;
            this.btn_50k.IconColor = System.Drawing.Color.Black;
            this.btn_50k.IconSize = 16;
            this.btn_50k.Image = ((System.Drawing.Image)(resources.GetObject("btn_50k.Image")));
            this.btn_50k.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_50k.Location = new System.Drawing.Point(822, 297);
            this.btn_50k.Name = "btn_50k";
            this.btn_50k.Size = new System.Drawing.Size(103, 45);
            this.btn_50k.TabIndex = 43;
            this.btn_50k.Tag = "50.000";
            this.btn_50k.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_50k.UseVisualStyleBackColor = true;
            this.btn_50k.Click += new System.EventHandler(this.btn_50k_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(672, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 31);
            this.label13.TabIndex = 35;
            this.label13.Text = "Paga Con";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btneliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btneliminar.Width = 27;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.Width = 150;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Visible = false;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 507);
            this.Controls.Add(this.btn_50k);
            this.Controls.Add(this.btn_20k);
            this.Controls.Add(this.btn_10k);
            this.Controls.Add(this.btn_5k);
            this.Controls.Add(this.btnregistrarcompra);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtpagocon);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txttotalpagar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btnagregarProducto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbotipodocumento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnombreCliente;
        private System.Windows.Forms.TextBox txtdocumentoCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnbuscarproveedor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtcodigoProducto;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnagregarProducto;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.TextBox txttotalpagar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtpagocon;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconButton btnregistrarcompra;
        private System.Windows.Forms.TextBox txtideproducto;
        private FontAwesome.Sharp.IconButton btn_5k;
        private FontAwesome.Sharp.IconButton btn_10k;
        private FontAwesome.Sharp.IconButton btn_20k;
        private FontAwesome.Sharp.IconButton btn_50k;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
    }
}