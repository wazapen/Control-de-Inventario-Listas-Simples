using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_de_Inventario_Listas_Simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnInsertar.Enabled = false;
        }
        Inventario inventario = new Inventario();
        Producto producto;

        private void limpiarTextBoxes()
        {
            txtNombre.Clear();
            txtCódigo.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            inventario.borrar(Convert.ToInt32(txtPosición.Text));
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            producto = new Producto();
            producto.producto(txtNombre.Text, Convert.ToInt32(txtCódigo.Text), Convert.ToInt32(txtCantidad.Text), Convert.ToDouble(txtPrecio.Text));
            inventario.insertarEnPos(producto, Convert.ToInt32(txtPosición.Text));
            limpiarTextBoxes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtReporte.Clear();
            Producto res = inventario.buscar(Convert.ToInt32(txtPosición.Text));
            if (res != null)
                txtReporte.Text = res.ToString();
            else
                txtReporte.Text = "Not Found!!!";
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Clear();
            txtReporte.Text += inventario.reporte();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            producto = new Producto();
            producto.producto(txtNombre.Text, Convert.ToInt32(txtCódigo.Text), Convert.ToInt32(txtCantidad.Text), Convert.ToDouble(txtPrecio.Text));
            inventario.agregar(producto);
            limpiarTextBoxes();
            btnInsertar.Enabled = true;
        }

        private void btnAgregarEnInicio_Click(object sender, EventArgs e)
        {
            producto = new Producto();
            producto.producto(txtNombre.Text, Convert.ToInt32(txtCódigo.Text), Convert.ToInt32(txtCantidad.Text), Convert.ToDouble(txtPrecio.Text));
            inventario.agregarEnInicio(producto);
            limpiarTextBoxes();
        }

        private void btnReporteInverso_Click(object sender, EventArgs e)
        {
            txtReporte.Clear();
            txtReporte.Text += inventario.reporteInverso();
        }
    }
}
