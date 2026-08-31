namespace Interfaz_grafica
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lbltitulo = new Label();
            lblusuario = new Label();
            lblcont = new Label();
            btningresar = new Button();
            txtusuario = new TextBox();
            txtclave = new TextBox();
            lblerror = new Label();
            lblx = new Label();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Algerian", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(119, 9);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(67, 24);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Login";
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Algerian", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblusuario.Location = new Point(23, 86);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(102, 24);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "Usuario:";
            // 
            // lblcont
            // 
            lblcont.AutoSize = true;
            lblcont.Font = new Font("Algerian", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblcont.Location = new Point(33, 129);
            lblcont.Name = "lblcont";
            lblcont.Size = new Size(81, 24);
            lblcont.TabIndex = 2;
            lblcont.Text = "Clave:";
            // 
            // btningresar
            // 
            btningresar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btningresar.Location = new Point(88, 184);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(109, 44);
            btningresar.TabIndex = 3;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btningresar_Click;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(177, 86);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(100, 23);
            txtusuario.TabIndex = 4;
            txtusuario.TextChanged += txtusuario_TextChanged;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(177, 129);
            txtclave.Name = "txtclave";
            txtclave.Size = new Size(100, 23);
            txtclave.TabIndex = 5;
            txtclave.TextChanged += txtclave_TextChanged;
            // 
            // lblerror
            // 
            lblerror.AutoSize = true;
            lblerror.Location = new Point(88, 260);
            lblerror.Name = "lblerror";
            lblerror.Size = new Size(149, 15);
            lblerror.TabIndex = 6;
            lblerror.Text = "Usuario o clave incorrectos";
            // 
            // lblx
            // 
            lblx.AutoSize = true;
            lblx.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblx.ForeColor = Color.Red;
            lblx.Location = new Point(67, 252);
            lblx.Name = "lblx";
            lblx.Size = new Size(24, 25);
            lblx.TabIndex = 7;
            lblx.Text = "X";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(356, 302);
            Controls.Add(lblx);
            Controls.Add(lblerror);
            Controls.Add(txtclave);
            Controls.Add(txtusuario);
            Controls.Add(btningresar);
            Controls.Add(lblcont);
            Controls.Add(lblusuario);
            Controls.Add(lbltitulo);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private Label lblusuario;
        private Label lblcont;
        private Button btningresar;
        private TextBox txtusuario;
        private TextBox txtclave;
        private Label lblerror;
        private Label lblx;
    }
}