using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaz_grafica
{
    public partial class Farmacia : Form
    {
        public Farmacia()
        {
            InitializeComponent();
            lbldatos.Text = "Medicamento: \nLaboratorio: \nCòdigo: \nPrecio: \n\nStock: \n\nTipo:  ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
