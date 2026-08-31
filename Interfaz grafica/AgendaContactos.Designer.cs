namespace Interfaz_grafica
{
    partial class AgendaContactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaContactos));
            lbltitulo = new Label();
            lblnombre = new Label();
            lbltelefono = new Label();
            txtnombre = new TextBox();
            txtphone = new TextBox();
            btnagregar = new Button();
            btneliminar = new Button();
            lst = new ListBox();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Lucida Console", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(165, 9);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(94, 21);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Agenda";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(100, 83);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(54, 14);
            lblnombre.TabIndex = 1;
            lblnombre.Text = "Nombre";
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltelefono.Location = new Point(97, 116);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(57, 14);
            lbltelefono.TabIndex = 2;
            lbltelefono.Text = "Telefono";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(178, 79);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 3;
            txtnombre.TextChanged += txtnombre_TextChanged;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(178, 112);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(100, 23);
            txtphone.TabIndex = 4;
            txtphone.TextChanged += txtphone_TextChanged;
            txtphone.KeyPress += txtphone_KeyPress;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(100, 168);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(75, 23);
            btnagregar.TabIndex = 5;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(227, 168);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(75, 23);
            btneliminar.TabIndex = 6;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // lst
            // 
            lst.FormattingEnabled = true;
            lst.Location = new Point(100, 215);
            lst.Name = "lst";
            lst.Size = new Size(217, 94);
            lst.TabIndex = 7;
            lst.SelectedIndexChanged += lst_SelectedIndexChanged;
            // 
            // AgendaContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(466, 321);
            Controls.Add(lst);
            Controls.Add(btneliminar);
            Controls.Add(btnagregar);
            Controls.Add(txtphone);
            Controls.Add(txtnombre);
            Controls.Add(lbltelefono);
            Controls.Add(lblnombre);
            Controls.Add(lbltitulo);
            Name = "AgendaContactos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgendaContactos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private Label lblnombre;
        private Label lbltelefono;
        private TextBox txtnombre;
        private TextBox txtphone;
        private Button btnagregar;
        private Button btneliminar;
        private ListBox lst;
    }
}