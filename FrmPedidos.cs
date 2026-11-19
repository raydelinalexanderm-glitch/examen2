using System;
using System.Windows.Forms;

namespace examen2
{
    public partial class FrmPedidos : Form
    {
        const decimal GRANDE = 25, EXTRA = 30, EMPAQUE = 20, DESCUENTO = .1m, ITBIS = .18m;
        decimal subtotal;

        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            lblEncabezado.Text = "Cant".PadRight(6) + "Producto".PadRight(24) + "Precio".PadLeft(10) + "Total".PadLeft(12);
            LimpiarTodo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text)) { Aviso("Escribe el nombre del producto.", txtProducto); return; }
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0) { Aviso("Escribe un precio válido.", txtPrecio); return; }

            int cantidad = (int)nudCantidad.Value;
            string tamano = rbtGrande.Checked ? "Grande" : "Normal";
            precio += rbtGrande.Checked ? GRANDE : 0;
            if (chkPorcionExtra.Checked) { precio += EXTRA; tamano += ", Extra"; }

            decimal total = precio * cantidad;
            subtotal += total;
            string producto = txtProducto.Text.Trim() + " (" + tamano + ")";
            if (producto.Length > 24) producto = producto.Substring(0, 24);
            lstPedido.Items.Add(cantidad.ToString().PadRight(6) + producto.PadRight(24) +
                precio.ToString("0.00").PadLeft(10) + total.ToString("0.00").PadLeft(12));
            Mostrar(lblSubtotal, subtotal);
            LimpiarProducto();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstPedido.Items.Count == 0) { MessageBox.Show("Primero agrega al menos un producto."); return; }

            decimal descuento = chkFrecuente.Checked ? subtotal * DESCUENTO : 0;
            decimal empaque = rbtLlevar.Checked ? EMPAQUE : 0;
            decimal baseImponible = subtotal - descuento + empaque;
            decimal impuesto = baseImponible * ITBIS;
            Mostrar(lblSubtotal, subtotal); Mostrar(lblDescuento, descuento); Mostrar(lblEmpaque, empaque);
            Mostrar(lblItbis, impuesto); Mostrar(lblTotal, baseImponible + impuesto);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Close();
        }

        private void LimpiarProducto()
        {
            txtProducto.Clear(); txtPrecio.Clear(); nudCantidad.Value = 1;
            rbtNormal.Checked = true; chkPorcionExtra.Checked = false;
            txtProducto.Focus();
        }

        private void LimpiarTodo()
        {
            txtCliente.Clear(); chkFrecuente.Checked = false; dtpFecha.Value = DateTime.Today;
            LimpiarProducto(); rbtLocal.Checked = true; lstPedido.Items.Clear(); subtotal = 0;
            Mostrar(lblSubtotal, 0); Mostrar(lblDescuento, 0); Mostrar(lblEmpaque, 0);
            Mostrar(lblItbis, 0); Mostrar(lblTotal, 0);
            txtCliente.Focus();
        }

        private static void Aviso(string texto, Control control)
        {
            MessageBox.Show(texto); control.Focus();
        }

        private static void Mostrar(Label etiqueta, decimal valor)
        {
            etiqueta.Text = $"RD$ {valor:0.00}";
        }
    }
}