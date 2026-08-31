namespace Interfaz_grafica
{
    partial class SistemaVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaVentas));
            lbltitulo = new Label();
            lblprod = new Label();
            lblprecio = new Label();
            lblcant = new Label();
            txtprod = new TextBox();
            txtprecio = new TextBox();
            txtcant = new TextBox();
            btnagregar = new Button();
            lst = new ListView();
            Producto = new ColumnHeader();
            Precio = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Total = new ColumnHeader();
            lbltotal = new Label();
            lbltotalnum = new Label();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Stencil", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(254, 9);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(209, 25);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Sistema de ventas";
            // 
            // lblprod
            // 
            lblprod.AutoSize = true;
            lblprod.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblprod.Location = new Point(178, 54);
            lblprod.Name = "lblprod";
            lblprod.Size = new Size(80, 17);
            lblprod.TabIndex = 1;
            lblprod.Text = "Producto:";
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblprecio.Location = new Point(178, 82);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(61, 17);
            lblprecio.TabIndex = 2;
            lblprecio.Text = "Precio:";
            // 
            // lblcant
            // 
            lblcant.AutoSize = true;
            lblcant.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblcant.Location = new Point(178, 113);
            lblcant.Name = "lblcant";
            lblcant.Size = new Size(78, 17);
            lblcant.TabIndex = 3;
            lblcant.Text = "Cantidad:";
            // 
            // txtprod
            // 
            txtprod.Location = new Point(300, 51);
            txtprod.Name = "txtprod";
            txtprod.Size = new Size(100, 23);
            txtprod.TabIndex = 4;
            txtprod.TextChanged += txtprod_TextChanged;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(300, 80);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(100, 23);
            txtprecio.TabIndex = 5;
            txtprecio.TextChanged += txtprecio_TextChanged;
            txtprecio.KeyPress += textBox2_KeyPress;
            // 
            // txtcant
            // 
            txtcant.Location = new Point(300, 109);
            txtcant.Name = "txtcant";
            txtcant.Size = new Size(100, 23);
            txtcant.TabIndex = 6;
            txtcant.TextChanged += txtcant_TextChanged;
            txtcant.KeyPress += txtcant_KeyPress;
            // 
            // btnagregar
            // 
            btnagregar.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnagregar.Location = new Point(287, 138);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(134, 36);
            btnagregar.TabIndex = 7;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // lst
            // 
            lst.Columns.AddRange(new ColumnHeader[] { Producto, Precio, Cantidad, Total });
            lst.Location = new Point(135, 180);
            lst.Name = "lst";
            lst.Size = new Size(423, 97);
            lst.TabIndex = 8;
            lst.UseCompatibleStateImageBehavior = false;
            lst.View = View.Details;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 200;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.TextAlign = HorizontalAlignment.Center;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.TextAlign = HorizontalAlignment.Center;
            Cantidad.Width = 65;
            // 
            // Total
            // 
            Total.Text = "Total";
            Total.Width = 90;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltotal.Location = new Point(178, 307);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(57, 23);
            lbltotal.TabIndex = 9;
            lbltotal.Text = "TOTAL:";
            // 
            // lbltotalnum
            // 
            lbltotalnum.AutoSize = true;
            lbltotalnum.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltotalnum.Location = new Point(469, 307);
            lbltotalnum.Name = "lbltotalnum";
            lbltotalnum.Size = new Size(57, 23);
            lbltotalnum.TabIndex = 10;
            lbltotalnum.Text = "label1";
            // 
            // SistemaVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(739, 343);
            Controls.Add(lbltotalnum);
            Controls.Add(lbltotal);
            Controls.Add(lst);
            Controls.Add(btnagregar);
            Controls.Add(txtcant);
            Controls.Add(txtprecio);
            Controls.Add(txtprod);
            Controls.Add(lblcant);
            Controls.Add(lblprecio);
            Controls.Add(lblprod);
            Controls.Add(lbltitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SistemaVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SistemaVentas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private Label lblprod;
        private Label lblprecio;
        private Label lblcant;
        private TextBox txtprod;
        private TextBox txtprecio;
        private TextBox txtcant;
        private Button btnagregar;
        private ListView lst;
        private Label lbltotal;
        private ColumnHeader Producto;
        private ColumnHeader Precio;
        private ColumnHeader Cantidad;
        private ColumnHeader Total;
        private Label lbltotalnum;
    }
}