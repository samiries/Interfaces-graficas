namespace Interfaz_grafica
{
    partial class RegistroAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroAlumno));
            lbltitulo = new Label();
            lblnombre = new Label();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtdni = new TextBox();
            lblsexo = new Label();
            radm = new RadioButton();
            radf = new RadioButton();
            chkmañana = new CheckBox();
            chktarde = new CheckBox();
            chknoche = new CheckBox();
            lblturno = new Label();
            lblcarrera = new Label();
            cmbcarrera = new ComboBox();
            btnregistro = new Button();
            lblapellido = new Label();
            lbldni = new Label();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Impact", 15.75F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(209, 0);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(179, 26);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Registro de alumno";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI", 11F);
            lblnombre.Location = new Point(175, 51);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(75, 20);
            lblnombre.TabIndex = 1;
            lblnombre.Text = "Nombre:  ";
            lblnombre.Click += lbldatos_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(321, 52);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 2;
            txtnombre.KeyPress += txtnombre_KeyPress;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(321, 81);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(100, 23);
            txtapellido.TabIndex = 3;
            txtapellido.KeyPress += txtapellido_KeyPress;
            // 
            // txtdni
            // 
            txtdni.Location = new Point(321, 110);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(100, 23);
            txtdni.TabIndex = 4;
            txtdni.KeyPress += txtdni_KeyPress;
            // 
            // lblsexo
            // 
            lblsexo.AutoSize = true;
            lblsexo.Font = new Font("Segoe UI", 11F);
            lblsexo.Location = new Point(175, 165);
            lblsexo.Name = "lblsexo";
            lblsexo.Size = new Size(44, 20);
            lblsexo.TabIndex = 5;
            lblsexo.Text = "Sexo:";
            // 
            // radm
            // 
            radm.AutoSize = true;
            radm.Location = new Point(249, 167);
            radm.Name = "radm";
            radm.Size = new Size(80, 19);
            radm.TabIndex = 6;
            radm.TabStop = true;
            radm.Text = "Masculino";
            radm.UseVisualStyleBackColor = true;
            // 
            // radf
            // 
            radf.AutoSize = true;
            radf.Location = new Point(365, 168);
            radf.Name = "radf";
            radf.Size = new Size(78, 19);
            radf.TabIndex = 7;
            radf.TabStop = true;
            radf.Text = "Femenino";
            radf.UseVisualStyleBackColor = true;
            // 
            // chkmañana
            // 
            chkmañana.AutoSize = true;
            chkmañana.Location = new Point(235, 213);
            chkmañana.Name = "chkmañana";
            chkmañana.Size = new Size(69, 19);
            chkmañana.TabIndex = 8;
            chkmañana.Text = "Mañana";
            chkmañana.UseVisualStyleBackColor = true;
            // 
            // chktarde
            // 
            chktarde.AutoSize = true;
            chktarde.Location = new Point(321, 213);
            chktarde.Name = "chktarde";
            chktarde.Size = new Size(54, 19);
            chktarde.TabIndex = 9;
            chktarde.Text = "Tarde";
            chktarde.UseVisualStyleBackColor = true;
            // 
            // chknoche
            // 
            chknoche.AutoSize = true;
            chknoche.Location = new Point(399, 213);
            chknoche.Name = "chknoche";
            chknoche.Size = new Size(61, 19);
            chknoche.TabIndex = 10;
            chknoche.Text = "Noche";
            chknoche.UseVisualStyleBackColor = true;
            // 
            // lblturno
            // 
            lblturno.AutoSize = true;
            lblturno.Font = new Font("Segoe UI", 11F);
            lblturno.Location = new Point(175, 210);
            lblturno.Name = "lblturno";
            lblturno.Size = new Size(54, 20);
            lblturno.TabIndex = 11;
            lblturno.Text = "Turno: ";
            // 
            // lblcarrera
            // 
            lblcarrera.AutoSize = true;
            lblcarrera.Font = new Font("Segoe UI", 11F);
            lblcarrera.Location = new Point(175, 265);
            lblcarrera.Name = "lblcarrera";
            lblcarrera.Size = new Size(60, 20);
            lblcarrera.TabIndex = 12;
            lblcarrera.Text = "Carrera:";
            // 
            // cmbcarrera
            // 
            cmbcarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbcarrera.FormattingEnabled = true;
            cmbcarrera.Location = new Point(300, 265);
            cmbcarrera.Name = "cmbcarrera";
            cmbcarrera.Size = new Size(121, 23);
            cmbcarrera.TabIndex = 13;
            // 
            // btnregistro
            // 
            btnregistro.Font = new Font("Algerian", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregistro.Location = new Point(209, 316);
            btnregistro.Name = "btnregistro";
            btnregistro.Size = new Size(166, 35);
            btnregistro.TabIndex = 14;
            btnregistro.Text = "Registrar";
            btnregistro.UseVisualStyleBackColor = true;
            btnregistro.Click += btnregistro_Click;
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Font = new Font("Segoe UI", 11F);
            lblapellido.Location = new Point(175, 84);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(66, 20);
            lblapellido.TabIndex = 15;
            lblapellido.Text = "Apellido";
            // 
            // lbldni
            // 
            lbldni.AutoSize = true;
            lbldni.Font = new Font("Segoe UI", 11F);
            lbldni.Location = new Point(175, 113);
            lbldni.Name = "lbldni";
            lbldni.Size = new Size(35, 20);
            lbldni.TabIndex = 16;
            lbldni.Text = "DNI";
            // 
            // RegistroAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(642, 363);
            Controls.Add(lbldni);
            Controls.Add(lblapellido);
            Controls.Add(btnregistro);
            Controls.Add(cmbcarrera);
            Controls.Add(lblcarrera);
            Controls.Add(lblturno);
            Controls.Add(chknoche);
            Controls.Add(chktarde);
            Controls.Add(chkmañana);
            Controls.Add(radf);
            Controls.Add(radm);
            Controls.Add(lblsexo);
            Controls.Add(txtdni);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(lblnombre);
            Controls.Add(lbltitulo);
            Name = "RegistroAlumno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistroAlumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private Label lblnombre;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtdni;
        private Label lblsexo;
        private RadioButton radm;
        private RadioButton radf;
        private CheckBox chkmañana;
        private CheckBox chktarde;
        private CheckBox chknoche;
        private Label lblturno;
        private Label lblcarrera;
        private ComboBox cmbcarrera;
        private Button btnregistro;
        private Label lblapellido;
        private Label lbldni;
    }
}