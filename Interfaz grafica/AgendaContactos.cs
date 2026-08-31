using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaz_grafica
{
    public partial class AgendaContactos : Form
    {
        public AgendaContactos()
        {
            InitializeComponent();
            btnagregar.Enabled = false;
            btneliminar.Enabled = false;
            txtphone.MaxLength = 15;
        }
        private void validarbtnagregar()
        {
            if (txtnombre.Text != "" && txtphone.Text != "")
            {
                btnagregar.Enabled = true;
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            validarbtnagregar();

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {
            validarbtnagregar();
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            btneliminar.Enabled = lst.SelectedIndex != -1;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string contacto = txtnombre.Text + " " + txtphone.Text;
            lst.Items.Add(contacto);
            txtnombre.Clear();
            txtphone.Clear();
            txtnombre.Focus();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            lst.Items.Remove(lst.SelectedItem);
            lst.ClearSelected();

        }
    }
}
