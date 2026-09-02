using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace Interfaz_grafica
{
    public partial class Farmacia : Form
    {
        public Farmacia()
        {
            InitializeComponent();
            txtnombre.TextChanged += validarbtnagregar;
            txtlaboratorio.TextChanged += validarbtnagregar;
            txtcodigo.TextChanged += validarbtnagregar;
            txtprecio.TextChanged += validarbtnagregar;
            txtstock.TextChanged += validarbtnagregar;
            cmbtipo.SelectedIndexChanged += validarbtnagregar;




            btnagregar.Enabled = false;
            btnborrar.Enabled = false;
            btnmodificar.Enabled = false;

        }




        private void validarbtnagregar(object sender, EventArgs e)
        {
            if (txtnombre.Text != "" && txtlaboratorio.Text != "" && txtcodigo.Text != "" && txtprecio.Text != "" && txtstock.Text != "" && cmbtipo.SelectedIndex != -1)
            {
                btnagregar.Enabled = true;
            }
            else
            {
                btnagregar.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string laboratorio = txtlaboratorio.Text;
            string codigo = txtcodigo.Text;
            double precio = double.Parse(txtprecio.Text);
            int stock = int.Parse(txtstock.Text);


            ListViewItem item = new ListViewItem(nombre);
            item.SubItems.Add(precio.ToString());
            item.SubItems.Add(stock.ToString());

            lst.Items.Add(item);

            txtnombre.Clear();
            txtlaboratorio.Clear();
            txtcodigo.Clear();
            txtprecio.Clear();
            txtstock.Clear();
            cmbtipo.SelectedIndex = -1;

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            lst.Items.Remove(lst.SelectedItems[0]);
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst.SelectedItems.Count > 0)
            {

                ListViewItem item = lst.SelectedItems[0];

                txtnombre.Text = item.Text;
                txtprecio.Text = item.SubItems[1].Text;
                txtstock.Text = item.SubItems[2].Text;


                btnmodificar.Enabled = true;
                btnborrar.Enabled = true;
                btnagregar.Enabled = false;
            }


        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            ListViewItem item = lst.SelectedItems[0];
            item.Text = txtnombre.Text;
            item.SubItems[1].Text = txtprecio.Text;
            item.SubItems[2].Text = txtstock.Text;
            lst.SelectedItems[0].Selected = false;

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtbuscar.Text.ToLower();
            bool encontrado = false;

            foreach (ListViewItem item in lst.Items)
            {
                if (item.Text.ToLower().Contains(busqueda))
                {
                    item.Selected = true;
                    item.EnsureVisible();
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró el medicamento.", "AVISO");
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }

}


