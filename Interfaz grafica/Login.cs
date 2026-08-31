using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaz_grafica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lblerror.Visible = false;
            lblx.Visible = false;
            btningresar.Enabled = false;



        }

        private void validarbtn()
        {
            if (txtclave.Text != "" && txtusuario.Text != "")
            {
                btningresar.Enabled = true;
            }
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            lblerror.Visible = true;
            lblx.Visible = true;
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            validarbtn();
        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {
            validarbtn();
        }
    }
}
