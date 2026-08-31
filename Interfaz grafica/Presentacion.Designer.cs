namespace Interfaz_grafica
{
    partial class presentacion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(presentacion));
            lbl1 = new Label();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtedad = new TextBox();
            txtcarrera = new TextBox();
            lbltitulo = new Label();
            btn1 = new Button();
            lblfin = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(92, 39);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(38, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "label1";
            lbl1.Click += lbl1_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(167, 36);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 1;
            txtnombre.TextChanged += txtnombre_TextChanged;
            // 
            // txtapellido
            // 
            txtapellido.Enabled = false;
            txtapellido.Location = new Point(167, 65);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(100, 23);
            txtapellido.TabIndex = 2;
            txtapellido.TextChanged += txtapellido_TextChanged;
            // 
            // txtedad
            // 
            txtedad.Enabled = false;
            txtedad.Location = new Point(167, 94);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(100, 23);
            txtedad.TabIndex = 3;
            txtedad.TextChanged += txtedad_TextChanged;
            // 
            // txtcarrera
            // 
            txtcarrera.Enabled = false;
            txtcarrera.Location = new Point(167, 123);
            txtcarrera.Name = "txtcarrera";
            txtcarrera.Size = new Size(100, 23);
            txtcarrera.TabIndex = 4;
            txtcarrera.TextChanged += txtcarrera_TextChanged;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(121, 9);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(99, 21);
            lbltitulo.TabIndex = 5;
            lbltitulo.Text = "Presentación";
            // 
            // btn1
            // 
            btn1.Enabled = false;
            btn1.Location = new Point(131, 172);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 6;
            btn1.Text = "Presentar";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // lblfin
            // 
            lblfin.AutoSize = true;
            lblfin.Location = new Point(0, 224);
            lblfin.Name = "lblfin";
            lblfin.Size = new Size(38, 15);
            lblfin.TabIndex = 7;
            lblfin.Text = "label1";
            // 
            // presentacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(381, 248);
            Controls.Add(lblfin);
            Controls.Add(btn1);
            Controls.Add(lbltitulo);
            Controls.Add(txtcarrera);
            Controls.Add(txtedad);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(lbl1);
            DoubleBuffered = true;
            Name = "presentacion";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtedad;
        private TextBox txtcarrera;
        private Label lbltitulo;
        private Button btn1;
        private Label lblfin;
    }
}
