namespace Interfaz_grafica
{
    public partial class presentacion : Form
    {
        public presentacion()
        {
            InitializeComponent();
            lbl1.Text = "Nombre: \n\nApellido: \n\nEdad: \n\nCarrera: ";
            lblfin.Visible = false;
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
        private void ValidarCampos()
        {
            if (txtnombre.Text != "" && txtapellido.Text != "" && txtedad.Text != "" && txtcarrera.Text != "")
            {
                btn1.Enabled = true;
            }
            else
            {
                btn1.Enabled = false;
            }

        }
        string nombre = "";
        string apellido = "";
        string edad = "";
        string carrera = "";


        private void btn1_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            string edad = txtedad.Text;
            string carrera = txtcarrera.Text;

            lblfin.Visible = true;

            lblfin.Text = "Hola, soy " + nombre + " " + apellido + ", tengo " + edad + " años y estoy en la carrera de " + carrera;

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            if (txtnombre.Text != "")
            {
                txtapellido.Enabled = true;
            }
            else
            {
                txtapellido.Enabled = false;

            }
            ValidarCampos();
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {
            if (txtapellido.Text != "")
            {
                txtedad.Enabled = true;
            }
            else
            {
                txtedad.Enabled = false;
            }
            ValidarCampos();
        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {
            if (txtedad.Text != "")
            {
                txtcarrera.Enabled = true;
            }
            else
            {
                txtcarrera.Enabled = false;
            }
            ValidarCampos();
        }

        private void txtcarrera_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }
    }
}
