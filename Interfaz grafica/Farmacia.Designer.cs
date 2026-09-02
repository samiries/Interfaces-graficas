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
            lbldatos1 = new Label();
            lbltitulo = new Label();
            txtnombre = new TextBox();
            txtlaboratorio = new TextBox();
            txtcodigo = new TextBox();
            txtprecio = new TextBox();
            txtstock = new TextBox();
            cmbtipo = new ComboBox();
            btnagregar = new Button();
            btnmodificar = new Button();
            btnborrar = new Button();
            lst = new ListView();
            Medicamento = new ColumnHeader();
            Precio = new ColumnHeader();
            Stock = new ColumnHeader();
            btnbuscar = new Button();
            txtbuscar = new TextBox();
            lbldatos2 = new Label();
            lbldatos3 = new Label();
            lbldatos4 = new Label();
            lbldatos5 = new Label();
            lbldatos6 = new Label();
            SuspendLayout();
            // 
            // lbldatos1
            // 
            lbldatos1.AutoSize = true;
            lbldatos1.Font = new Font("Impact", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbldatos1.Location = new Point(108, 50);
            lbldatos1.Name = "lbldatos1";
            lbldatos1.Size = new Size(133, 26);
            lbldatos1.TabIndex = 0;
            lbldatos1.Text = "Medicamento:";
            lbldatos1.Click += label1_Click;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Algerian", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(108, 9);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(254, 24);
            lbltitulo.TabIndex = 1;
            lbltitulo.Text = "Gestion de farmacia";
            lbltitulo.Click += lbltitulo_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(251, 53);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 2;
            // 
            // txtlaboratorio
            // 
            txtlaboratorio.Location = new Point(251, 82);
            txtlaboratorio.Name = "txtlaboratorio";
            txtlaboratorio.Size = new Size(100, 23);
            txtlaboratorio.TabIndex = 3;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(251, 111);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(100, 23);
            txtcodigo.TabIndex = 4;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(251, 140);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(100, 23);
            txtprecio.TabIndex = 5;
            txtprecio.KeyPress += txtprecio_KeyPress;
            // 
            // txtstock
            // 
            txtstock.Location = new Point(251, 169);
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(100, 23);
            txtstock.TabIndex = 6;
            txtstock.KeyPress += txtstock_KeyPress;
            // 
            // cmbtipo
            // 
            cmbtipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbtipo.FormattingEnabled = true;
            cmbtipo.Items.AddRange(new object[] { "Venta libre", "Receta\t\t\t" });
            cmbtipo.Location = new Point(242, 234);
            cmbtipo.Name = "cmbtipo";
            cmbtipo.Size = new Size(121, 23);
            cmbtipo.TabIndex = 7;
            // 
            // btnagregar
            // 
            btnagregar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic);
            btnagregar.Location = new Point(90, 304);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(94, 30);
            btnagregar.TabIndex = 8;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // btnmodificar
            // 
            btnmodificar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic);
            btnmodificar.Location = new Point(208, 304);
            btnmodificar.Name = "btnmodificar";
            btnmodificar.Size = new Size(94, 30);
            btnmodificar.TabIndex = 9;
            btnmodificar.Text = "Modificar";
            btnmodificar.UseVisualStyleBackColor = true;
            btnmodificar.Click += btnmodificar_Click;
            // 
            // btnborrar
            // 
            btnborrar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic);
            btnborrar.Location = new Point(325, 304);
            btnborrar.Name = "btnborrar";
            btnborrar.Size = new Size(94, 30);
            btnborrar.TabIndex = 10;
            btnborrar.Text = "Borrar";
            btnborrar.UseVisualStyleBackColor = true;
            btnborrar.Click += btnborrar_Click;
            // 
            // lst
            // 
            lst.Columns.AddRange(new ColumnHeader[] { Medicamento, Precio, Stock });
            lst.FullRowSelect = true;
            lst.Location = new Point(63, 371);
            lst.Name = "lst";
            lst.Size = new Size(398, 97);
            lst.TabIndex = 11;
            lst.UseCompatibleStateImageBehavior = false;
            lst.View = View.Details;
            lst.SelectedIndexChanged += lst_SelectedIndexChanged;
            // 
            // Medicamento
            // 
            Medicamento.Text = "Medicamento";
            Medicamento.Width = 200;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.Width = 90;
            // 
            // Stock
            // 
            Stock.Text = "Stock";
            Stock.Width = 90;
            // 
            // btnbuscar
            // 
            btnbuscar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnbuscar.Location = new Point(234, 493);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(117, 34);
            btnbuscar.TabIndex = 13;
            btnbuscar.Text = "Buscar medicamento";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(90, 502);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(100, 23);
            txtbuscar.TabIndex = 12;
            txtbuscar.TextChanged += txtbuscar_TextChanged;
            // 
            // lbldatos2
            // 
            lbldatos2.AutoSize = true;
            lbldatos2.Font = new Font("Impact", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbldatos2.Location = new Point(108, 82);
            lbldatos2.Name = "lbldatos2";
            lbldatos2.Size = new Size(117, 26);
            lbldatos2.TabIndex = 15;
            lbldatos2.Text = "Laboratorio:";
            // 
            // lbldatos3
            // 
            lbldatos3.AutoSize = true;
            lbldatos3.Font = new Font("Impact", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbldatos3.Location = new Point(108, 108);
            lbldatos3.Name = "lbldatos3";
            lbldatos3.Size = new Size(77, 26);
            lbldatos3.TabIndex = 16;
            lbldatos3.Text = "Código:";
            // 
            // lbldatos4
            // 
            lbldatos4.AutoSize = true;
            lbldatos4.Font = new Font("Impact", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbldatos4.Location = new Point(108, 140);
            lbldatos4.Name = "lbldatos4";
            lbldatos4.Size = new Size(72, 26);
            lbldatos4.TabIndex = 17;
            lbldatos4.Text = "Precio:";
            // 
            // lbldatos5
            // 
            lbldatos5.AutoSize = true;
            lbldatos5.Font = new Font("Impact", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbldatos5.Location = new Point(108, 169);
            lbldatos5.Name = "lbldatos5";
            lbldatos5.Size = new Size(64, 26);
            lbldatos5.TabIndex = 18;
            lbldatos5.Text = "Stock:";
            // 
            // lbldatos6
            // 
            lbldatos6.AutoSize = true;
            lbldatos6.Font = new Font("Impact", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbldatos6.Location = new Point(108, 234);
            lbldatos6.Name = "lbldatos6";
            lbldatos6.Size = new Size(53, 26);
            lbldatos6.TabIndex = 19;
            lbldatos6.Text = "Tipo:";
            // 
            // Farmacia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(556, 564);
            Controls.Add(lbldatos6);
            Controls.Add(lbldatos5);
            Controls.Add(lbldatos4);
            Controls.Add(lbldatos3);
            Controls.Add(lbldatos2);
            Controls.Add(txtbuscar);
            Controls.Add(btnbuscar);
            Controls.Add(lst);
            Controls.Add(btnborrar);
            Controls.Add(btnmodificar);
            Controls.Add(btnagregar);
            Controls.Add(cmbtipo);
            Controls.Add(txtstock);
            Controls.Add(txtprecio);
            Controls.Add(txtcodigo);
            Controls.Add(txtlaboratorio);
            Controls.Add(txtnombre);
            Controls.Add(lbltitulo);
            Controls.Add(lbldatos1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Farmacia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmacia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbldatos1;
        private Label lbltitulo;
        private TextBox txtnombre;
        private TextBox txtlaboratorio;
        private TextBox txtcodigo;
        private TextBox txtprecio;
        private TextBox txtstock;
        private ComboBox cmbtipo;
        private Button btnagregar;
        private Button btnmodificar;
        private Button btnborrar;
        private ListView lst;
        private Button btnbuscar;
        private TextBox txtbuscar;
        private Label lbldatos2;
        private Label lbldatos3;
        private Label lbldatos4;
        private Label lbldatos5;
        private Label lbldatos6;
        private ColumnHeader Medicamento;
        private ColumnHeader Precio;
        private ColumnHeader Stock;
    }
}