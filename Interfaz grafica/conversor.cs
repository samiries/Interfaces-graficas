using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaz_grafica
{
    public partial class conversor : Form
    {
        public conversor()
        {
            InitializeComponent();
            lblresultado.Visible = false;
            btn.Enabled = false;
            lbldatos.Text = "Valor: \n\nDesde: \nHacia: ";

            cmbdesde.Items.Add("Metros");
            cmbdesde.Items.Add("Centimetros");
            cmbhacia.Items.Add("Metros");
            cmbhacia.Items.Add("Centimetros");

        }

        private void validarcosas()
        {
            if (txtvalor.Text != "" && cmbdesde.SelectedIndex != -1 && cmbhacia.SelectedIndex != -1 && cmbdesde.SelectedIndex != cmbhacia.SelectedIndex)
            {
                btn.Enabled = true;
            }
            else
            {
                btn.Enabled = false;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtvalor.Text);
            string desde = cmbdesde.Text;
            string hacia = cmbhacia.Text;
            double res = 0;
            if (desde == "Metros")
            {
                res = num * 100;
            }
            else 
            {
                res = num / 100;
            }
            lblresultado.Visible = true;
            lblresultado.Text = "Resultado: " + res.ToString("f2");

        }


        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

        }

        private void txtvalor_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void cmbdesde_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarcosas();
        }

        private void cmbhacia_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarcosas();
        }
    }
}
