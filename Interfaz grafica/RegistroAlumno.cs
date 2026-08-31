using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaz_grafica
{
    public partial class RegistroAlumno : Form
    {
        public RegistroAlumno()
        {
            InitializeComponent();
            btnregistro.Enabled = false;
            cmbcarrera.Items.Add("Programación");
            cmbcarrera.Items.Add("Otra carrera");

            txtnombre.TextChanged += txtnombre_TextChanged;
            txtapellido.TextChanged += txtapellido_TextChanged;
            txtdni.TextChanged += txtdni_TextChanged;
            radm.CheckedChanged += radMasculino_CheckedChanged;
            radf.CheckedChanged += radFemenino_CheckedChanged;
            chkmañana.CheckedChanged += chkmañana_CheckedChanged;
            chktarde.CheckedChanged += chktarde_CheckedChanged;
            chknoche.CheckedChanged += chknoche_CheckedChanged;
            cmbcarrera.SelectedIndexChanged += cmbcarrera_SelectedIndexChanged;
        }

        private void validarcoso()
        {
            if (txtnombre.Text != "" &&
               txtapellido.Text != "" && txtdni.Text != "" &&
               (radm.Checked || radf.Checked) &&
               (chkmañana.Checked || chktarde.Checked || chknoche.Checked) &&
               cmbcarrera.SelectedIndex != -1)
            {
                btnregistro.Enabled = true;
            }
            else
            {
                btnregistro.Enabled = false;
            }
        }
        private void lbldatos_Click(object sender, EventArgs e)
        {

        }
        private void txtnombre_TextChanged(object sender, EventArgs e) => validarcoso();
        private void txtapellido_TextChanged(object sender, EventArgs e) => validarcoso();
        private void txtdni_TextChanged(object sender, EventArgs e) => validarcoso();
        private void radMasculino_CheckedChanged(object sender, EventArgs e) => validarcoso();
        private void radFemenino_CheckedChanged(object sender, EventArgs e) => validarcoso();
        private void chkmañana_CheckedChanged(object sender, EventArgs e) => validarcoso();
        private void chktarde_CheckedChanged(object sender, EventArgs e) => validarcoso();
        private void chknoche_CheckedChanged(object sender, EventArgs e) => validarcoso();
        private void cmbcarrera_SelectedIndexChanged(object sender, EventArgs e) => validarcoso();

        private void btnregistro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("REGISTRADO", "Finalizado");
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
