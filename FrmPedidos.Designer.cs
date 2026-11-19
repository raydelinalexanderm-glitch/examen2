namespace examen2
{
    partial class FrmPedidos
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.chkFrecuente = new System.Windows.Forms.CheckBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.grpTamano = new System.Windows.Forms.GroupBox();
            this.rbtNormal = new System.Windows.Forms.RadioButton();
            this.rbtGrande = new System.Windows.Forms.RadioButton();
            this.grpServicio = new System.Windows.Forms.GroupBox();
            this.rbtLlevar = new System.Windows.Forms.RadioButton();
            this.rbtLocal = new System.Windows.Forms.RadioButton();
            this.chkPorcionExtra = new System.Windows.Forms.CheckBox();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.lstPedido = new System.Windows.Forms.ListBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblEmpaque = new System.Windows.Forms.Label();
            this.lblItbis = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Subtotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.grpTamano.SuspendLayout();
            this.grpServicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.AccessibleName = "txtcliente";
            this.txtCliente.Location = new System.Drawing.Point(131, 6);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(200, 20);
            this.txtCliente.TabIndex = 0;
            // 
            // txtProducto
            // 
            this.txtProducto.AccessibleName = "txtproducto";
            this.txtProducto.Location = new System.Drawing.Point(131, 89);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(200, 20);
            this.txtProducto.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(131, 55);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // chkFrecuente
            // 
            this.chkFrecuente.AutoSize = true;
            this.chkFrecuente.Location = new System.Drawing.Point(45, 32);
            this.chkFrecuente.Name = "chkFrecuente";
            this.chkFrecuente.Size = new System.Drawing.Size(106, 17);
            this.chkFrecuente.TabIndex = 3;
            this.chkFrecuente.Text = "Cliente frecuente";
            this.chkFrecuente.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(43, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(42, 62);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(42, 96);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 6;
            this.lblProducto.Text = "Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(43, 136);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(131, 129);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(200, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(33, 171);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(131, 171);
            this.nudCantidad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 10;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpTamano
            // 
            this.grpTamano.AccessibleName = "grpTamano";
            this.grpTamano.Controls.Add(this.rbtNormal);
            this.grpTamano.Controls.Add(this.rbtGrande);
            this.grpTamano.Location = new System.Drawing.Point(36, 219);
            this.grpTamano.Name = "grpTamano";
            this.grpTamano.Size = new System.Drawing.Size(124, 84);
            this.grpTamano.TabIndex = 11;
            this.grpTamano.TabStop = false;
            this.grpTamano.Text = "Tamaño";
            // 
            // rbtNormal
            // 
            this.rbtNormal.AutoSize = true;
            this.rbtNormal.Checked = true;
            this.rbtNormal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtNormal.Location = new System.Drawing.Point(0, 26);
            this.rbtNormal.Name = "rbtNormal";
            this.rbtNormal.Size = new System.Drawing.Size(56, 17);
            this.rbtNormal.TabIndex = 13;
            this.rbtNormal.TabStop = true;
            this.rbtNormal.Text = "normal";
            this.rbtNormal.UseVisualStyleBackColor = true;
            // 
            // rbtGrande
            // 
            this.rbtGrande.AutoSize = true;
            this.rbtGrande.Enabled = false;
            this.rbtGrande.Location = new System.Drawing.Point(0, 49);
            this.rbtGrande.Name = "rbtGrande";
            this.rbtGrande.Size = new System.Drawing.Size(124, 17);
            this.rbtGrande.TabIndex = 13;
            this.rbtGrande.TabStop = true;
            this.rbtGrande.Text = "Grande (+RD$25.00)";
            this.rbtGrande.UseVisualStyleBackColor = true;
            // 
            // grpServicio
            // 
            this.grpServicio.Controls.Add(this.rbtLlevar);
            this.grpServicio.Controls.Add(this.rbtLocal);
            this.grpServicio.Location = new System.Drawing.Point(202, 219);
            this.grpServicio.Name = "grpServicio";
            this.grpServicio.Size = new System.Drawing.Size(155, 66);
            this.grpServicio.TabIndex = 12;
            this.grpServicio.TabStop = false;
            this.grpServicio.Text = "Tipo de servicios";
            // 
            // rbtLlevar
            // 
            this.rbtLlevar.AutoSize = true;
            this.rbtLlevar.Location = new System.Drawing.Point(6, 43);
            this.rbtLlevar.Name = "rbtLlevar";
            this.rbtLlevar.Size = new System.Drawing.Size(139, 17);
            this.rbtLlevar.TabIndex = 15;
            this.rbtLlevar.Text = "Para llevar (+RD$20.00)";
            this.rbtLlevar.UseVisualStyleBackColor = true;
            // 
            // rbtLocal
            // 
            this.rbtLocal.AutoSize = true;
            this.rbtLocal.Checked = true;
            this.rbtLocal.Location = new System.Drawing.Point(6, 19);
            this.rbtLocal.Name = "rbtLocal";
            this.rbtLocal.Size = new System.Drawing.Size(51, 17);
            this.rbtLocal.TabIndex = 15;
            this.rbtLocal.TabStop = true;
            this.rbtLocal.Text = "Local";
            this.rbtLocal.UseVisualStyleBackColor = true;
            // 
            // chkPorcionExtra
            // 
            this.chkPorcionExtra.AutoSize = true;
            this.chkPorcionExtra.Location = new System.Drawing.Point(36, 320);
            this.chkPorcionExtra.Name = "chkPorcionExtra";
            this.chkPorcionExtra.Size = new System.Drawing.Size(152, 17);
            this.chkPorcionExtra.TabIndex = 14;
            this.chkPorcionExtra.Text = "Porcion extra (+RD$30.00)";
            this.chkPorcionExtra.UseVisualStyleBackColor = true;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Location = new System.Drawing.Point(356, 11);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(287, 15);
            this.lblEncabezado.TabIndex = 15;
            this.lblEncabezado.Text = "Cant producto          precio      total";
            // 
            // lstPedido
            // 
            this.lstPedido.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPedido.FormattingEnabled = true;
            this.lstPedido.ItemHeight = 15;
            this.lstPedido.Location = new System.Drawing.Point(435, 96);
            this.lstPedido.Name = "lstPedido";
            this.lstPedido.Size = new System.Drawing.Size(230, 124);
            this.lstPedido.TabIndex = 16;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(563, 272);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(53, 13);
            this.lblSubtotal.TabIndex = 17;
            this.lblSubtotal.Text = "0.00 RD$";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(563, 306);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(53, 13);
            this.lblDescuento.TabIndex = 18;
            this.lblDescuento.Text = "0.00 RD$";
            // 
            // lblEmpaque
            // 
            this.lblEmpaque.AutoSize = true;
            this.lblEmpaque.Location = new System.Drawing.Point(563, 340);
            this.lblEmpaque.Name = "lblEmpaque";
            this.lblEmpaque.Size = new System.Drawing.Size(53, 13);
            this.lblEmpaque.TabIndex = 19;
            this.lblEmpaque.Text = "0.00 RD$";
            // 
            // lblItbis
            // 
            this.lblItbis.AutoSize = true;
            this.lblItbis.Location = new System.Drawing.Point(563, 375);
            this.lblItbis.Name = "lblItbis";
            this.lblItbis.Size = new System.Drawing.Size(53, 13);
            this.lblItbis.TabIndex = 20;
            this.lblItbis.Text = "0.00 RD$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(563, 411);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 13);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "0.00 RD$";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(462, 32);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(154, 58);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(26, 375);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(66, 23);
            this.btnCalcular.TabIndex = 23;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(113, 375);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(208, 375);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 23);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSize = true;
            this.Subtotal.Location = new System.Drawing.Point(501, 272);
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Size = new System.Drawing.Size(49, 13);
            this.Subtotal.TabIndex = 26;
            this.Subtotal.Text = "Subtotal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Descuento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Empaque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "ITBIS (18%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "TOTAL A PAGAR :";
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Subtotal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblItbis);
            this.Controls.Add(this.lblEmpaque);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lstPedido);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.chkPorcionExtra);
            this.Controls.Add(this.grpServicio);
            this.Controls.Add(this.grpTamano);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.chkFrecuente);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lblCliente);
            this.Name = "FrmPedidos";
            this.Text = "+";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.grpTamano.ResumeLayout(false);
            this.grpTamano.PerformLayout();
            this.grpServicio.ResumeLayout(false);
            this.grpServicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox chkFrecuente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.GroupBox grpTamano;
        private System.Windows.Forms.GroupBox grpServicio;
        private System.Windows.Forms.RadioButton rbtNormal;
        private System.Windows.Forms.RadioButton rbtGrande;
        private System.Windows.Forms.CheckBox chkPorcionExtra;
        private System.Windows.Forms.RadioButton rbtLlevar;
        private System.Windows.Forms.RadioButton rbtLocal;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.ListBox lstPedido;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblEmpaque;
        private System.Windows.Forms.Label lblItbis;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label Subtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

