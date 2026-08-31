using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaz_grafica
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
            lblnums.Text = "Número 1: \n\nNúmero 2:";
            lblresultado.Visible = false;
            

            foreach (Control control in pnlbtns.Controls)
            {
                if (control is Button boton)
                {
                    boton.FlatStyle = FlatStyle.Flat;
                }
            }
            ValidarCampos();
        }

        private void ValidarCampos()
        {
            if (txt1.Text != "" && txt2.Text != "")
            {
                pnlbtns.Enabled = true;

            }
            else
            {
                pnlbtns.Enabled = false;

            }
            foreach (Control control in pnlbtns.Controls)
            {
                if (control is Button boton)
                {
                    boton.FlatStyle = FlatStyle.Flat; 
                    boton.BackColor = pnlbtns.Enabled ? Color.White : Color.Gray;
                }
            }
        }


        private void btnsuma_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt1.Text);
            double num2 = double.Parse(txt2.Text);

            double sum = num1 + num2;
            lblresultado.Visible = true;
            lblresultado.Text = "Resultado: " + sum;
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt1.Text);
            double num2 = double.Parse(txt2.Text);

            double resta = num1 - num2;
            lblresultado.Visible = true;
            lblresultado.Text = "Resultado: " + resta;
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt1.Text);
            double num2 = double.Parse(txt2.Text);

            double mult = num1 * num2;
            lblresultado.Visible = true;
            lblresultado.Text = "Resultado: " + mult;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt1.Text);
            double num2 = double.Parse(txt2.Text);

            double div = num1 / num2;
            lblresultado.Visible = true;
            lblresultado.Text = "Resultado: " + div;


        }
    }
}
