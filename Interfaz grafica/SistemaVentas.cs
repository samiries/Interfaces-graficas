using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaz_grafica
{
    public partial class SistemaVentas : Form
    {
        public SistemaVentas()
        {
            InitializeComponent();
            btnagregar.Enabled = false;
            lbltotal.Visible = false;
            lbltotalnum.Visible = false;
            lst.Scrollable = true;

            lst.GridLines = true;
            lst.FullRowSelect = true;
        }


        private void calculartotal()
        {
            double TotalGeneral = 0;

            foreach (ListViewItem item in lst.Items)
            {
                TotalGeneral += double.Parse(item.SubItems[3].Text);


                lbltotal.Visible = true;
                lbltotalnum.Visible = true;
                lbltotalnum.Text = "$" + TotalGeneral.ToString("n2");
            }
        }

        
        private void validarbtnagregar()
        {
            if (txtprod.Text != "" && txtprecio.Text != "" && txtcant.Text != "")
            {
                btnagregar.Enabled = true;
            }
            else
            {
                btnagregar.Enabled = false;
            }
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            string producto = txtprod.Text;
            double precio = double.Parse(txtprecio.Text);
            double cantidad = double.Parse(txtcant.Text);
            double total = precio * cantidad;

            ListViewItem item = new ListViewItem(producto);
            item.SubItems.Add(precio.ToString());
            item.SubItems.Add(cantidad.ToString());
            item.SubItems.Add(total.ToString());

            lst.Items.Add(item);

            calculartotal();

            txtprod.Clear();
            txtprecio.Clear();
            txtcant.Clear();

            txtprod.Focus();

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtcant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtprod_TextChanged(object sender, EventArgs e)
        {
            validarbtnagregar();
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
            validarbtnagregar();
        }

        private void txtcant_TextChanged(object sender, EventArgs e)
        {
            validarbtnagregar();
        }
    }
}
