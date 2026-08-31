namespace Interfaz_grafica
{
    partial class Farmacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Farmacia));
            lbldatos = new Label();
            lbltitulo = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            cmbtipo = new ComboBox();
            btnagregar = new Button();
            btnmodificar = new Button();
            btnborrar = new Button();
            lst = new ListView();
            btnbuscar = new Button();
            txtbuscar = new TextBox();
            SuspendLayout();
            // 
            // lbldatos
            // 
            lbldatos.AutoSize = true;
            lbldatos.Font = new Font("Impact", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbldatos.Location = new Point(45, 42);
            lbldatos.Name = "lbldatos";
            lbldatos.Size = new Size(63, 26);
            lbldatos.TabIndex = 0;
            lbldatos.Text = "label1";
            lbldatos.Click += label1_Click;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Location = new Point(176, 9);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(112, 15);
            lbltitulo.TabIndex = 1;
            lbltitulo.Text = "Gestion de farmacia";
            lbltitulo.Click += lbltitulo_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(176, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(176, 129);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(176, 177);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 6;
            // 
            // cmbtipo
            // 
            cmbtipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbtipo.FormattingEnabled = true;
            cmbtipo.Items.AddRange(new object[] { "Venta libre", "Receta\t\t\t" });
            cmbtipo.Location = new Point(167, 239);
            cmbtipo.Name = "cmbtipo";
            cmbtipo.Size = new Size(121, 23);
            cmbtipo.TabIndex = 7;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(90, 304);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(75, 23);
            btnagregar.TabIndex = 8;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            btnmodificar.Location = new Point(201, 304);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new Size(75, 23);
            btnmodificar.TabIndex = 9;
            btnmodificar.Text = "Modificar";
            btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btnborrar
            // 
            btnborrar.Location = new Point(325, 304);
            btnborrar.Name = "btnborrar";
            btnborrar.Size = new Size(75, 23);
            btnborrar.TabIndex = 10;
            btnborrar.Text = "Borrar";
            btnborrar.UseVisualStyleBackColor = true;
            // 
            // lst
            // 
            lst.Location = new Point(90, 371);
            lst.Name = "lst";
            lst.Size = new Size(310, 97);
            lst.TabIndex = 11;
            lst.UseCompatibleStateImageBehavior = false;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(234, 502);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(100, 23);
            btnbuscar.TabIndex = 12;
            btnbuscar.Text = "Buscar medicamento";
            btnbuscar.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(90, 503);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(100, 23);
            txtbuscar.TabIndex = 13;
            // 
            // Farmacia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(556, 564);
            Controls.Add(txtbuscar);
            Controls.Add(btnbuscar);
            Controls.Add(lst);
            Controls.Add(btnborrar);
            Controls.Add(btnmodificar);
            Controls.Add(btnagregar);
            Controls.Add(cmbtipo);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbltitulo);
            Controls.Add(lbldatos);
            Name = "Farmacia";
            Text = "Farmacia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbldatos;
        private Label lbltitulo;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox cmbtipo;
        private Button btnagregar;
        private Button btnmodificar;
        private Button btnborrar;
        private ListView lst;
        private Button btnbuscar;
        private TextBox txtbuscar;
    }
}