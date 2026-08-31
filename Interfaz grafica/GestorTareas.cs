using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaz_grafica
{
    public partial class GestorTareas : Form
    {
        public GestorTareas()
        {
            InitializeComponent();
            lst.CheckBoxes = true;
            btnagregar.Enabled = false;
            btneliminar.Enabled = false;
            btncompletar.Enabled = false;
            lst.ItemCheck += lst_ItemCheck;

        }

        private bool CambioPorCodigo = false;

        private void validarbtnagregar()
        {
            if (txttarea.Text != "" && cmbprioridad.SelectedIndex != -1)
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
            string nombretarea = txttarea.Text;
            string prioridad = (string)cmbprioridad.SelectedItem;

            ListViewItem item = new ListViewItem(nombretarea);
            item.SubItems.Add(prioridad);

            lst.Items.Add(item);

            txttarea.Clear();
            cmbprioridad.SelectedIndex = -1;
            txttarea.Focus();


        }

        private void txttarea_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txttarea_TextChanged(object sender, EventArgs e)
        {
            validarbtnagregar();
        }

        private void cmbprioridad_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarbtnagregar();
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst.SelectedItems.Count > 0)
            {
                btncompletar.Enabled = true;
                btneliminar.Enabled = true;
            }
        }

        private void btncompletar_Click(object sender, EventArgs e)
        {
            CambioPorCodigo = true;
            lst.SelectedItems[0].Checked = true;
            CambioPorCodigo = false;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            lst.Items.Remove(lst.SelectedItems[0]);
        }

        private void lst_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!CambioPorCodigo)
            {
                e.NewValue = e.CurrentValue;
            }
        }
    }
}
