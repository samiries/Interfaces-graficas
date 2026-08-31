namespace Interfaz_grafica
{
    partial class GestorTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorTareas));
            lbltitulo = new Label();
            lbltarea = new Label();
            txttarea = new TextBox();
            lblprioridad = new Label();
            cmbprioridad = new ComboBox();
            lblfecha = new Label();
            dtp = new DateTimePicker();
            btnagregar = new Button();
            lst = new ListView();
            nombre = new ColumnHeader();
            prioridad = new ColumnHeader();
            btneliminar = new Button();
            btncompletar = new Button();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Location = new Point(255, 9);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(60, 15);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Mis tareas";
            // 
            // lbltarea
            // 
            lbltarea.AutoSize = true;
            lbltarea.Location = new Point(169, 42);
            lbltarea.Name = "lbltarea";
            lbltarea.Size = new Size(38, 15);
            lbltarea.TabIndex = 1;
            lbltarea.Text = "Tarea:";
            // 
            // txttarea
            // 
            txttarea.Location = new Point(255, 39);
            txttarea.Name = "txttarea";
            txttarea.Size = new Size(155, 23);
            txttarea.TabIndex = 2;
            txttarea.TextChanged += txttarea_TextChanged;
            txttarea.KeyPress += txttarea_KeyPress;
            // 
            // lblprioridad
            // 
            lblprioridad.AutoSize = true;
            lblprioridad.Location = new Point(169, 75);
            lblprioridad.Name = "lblprioridad";
            lblprioridad.Size = new Size(61, 15);
            lblprioridad.TabIndex = 3;
            lblprioridad.Text = "Prioridad: ";
            // 
            // cmbprioridad
            // 
            cmbprioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbprioridad.FormattingEnabled = true;
            cmbprioridad.Items.AddRange(new object[] { "Baja", "Media", "Alta" });
            cmbprioridad.Location = new Point(255, 68);
            cmbprioridad.Name = "cmbprioridad";
            cmbprioridad.Size = new Size(121, 23);
            cmbprioridad.TabIndex = 4;
            cmbprioridad.SelectedIndexChanged += cmbprioridad_SelectedIndexChanged;
            // 
            // lblfecha
            // 
            lblfecha.AutoSize = true;
            lblfecha.Location = new Point(169, 106);
            lblfecha.Name = "lblfecha";
            lblfecha.Size = new Size(41, 15);
            lblfecha.TabIndex = 5;
            lblfecha.Text = "Fecha:";
            // 
            // dtp
            // 
            dtp.Format = DateTimePickerFormat.Short;
            dtp.Location = new Point(255, 100);
            dtp.Name = "dtp";
            dtp.Size = new Size(96, 23);
            dtp.TabIndex = 6;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(255, 145);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(96, 23);
            btnagregar.TabIndex = 7;
            btnagregar.Text = "Agregar tarea";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // lst
            // 
            lst.Columns.AddRange(new ColumnHeader[] { nombre, prioridad });
            lst.FullRowSelect = true;
            lst.Location = new Point(169, 174);
            lst.Name = "lst";
            lst.Size = new Size(298, 97);
            lst.TabIndex = 8;
            lst.UseCompatibleStateImageBehavior = false;
            lst.View = View.Details;
            lst.ItemCheck += lst_ItemCheck;
            lst.SelectedIndexChanged += lst_SelectedIndexChanged;
            // 
            // nombre
            // 
            nombre.Text = "Nombre";
            nombre.Width = 150;
            // 
            // prioridad
            // 
            prioridad.Text = "Prioridad";
            prioridad.TextAlign = HorizontalAlignment.Center;
            prioridad.Width = 130;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(194, 288);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(75, 23);
            btneliminar.TabIndex = 9;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // btncompletar
            // 
            btncompletar.Location = new Point(354, 288);
            btncompletar.Name = "btncompletar";
            btncompletar.Size = new Size(75, 23);
            btncompletar.TabIndex = 10;
            btncompletar.Text = "Completar";
            btncompletar.UseVisualStyleBackColor = true;
            btncompletar.Click += btncompletar_Click;
            // 
            // GestorTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(612, 344);
            Controls.Add(btncompletar);
            Controls.Add(btneliminar);
            Controls.Add(lst);
            Controls.Add(btnagregar);
            Controls.Add(dtp);
            Controls.Add(lblfecha);
            Controls.Add(cmbprioridad);
            Controls.Add(lblprioridad);
            Controls.Add(txttarea);
            Controls.Add(lbltarea);
            Controls.Add(lbltitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GestorTareas";
            Text = "GestorTareas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private Label lbltarea;
        private TextBox txttarea;
        private Label lblprioridad;
        private ComboBox cmbprioridad;
        private Label lblfecha;
        private DateTimePicker dtp;
        private Button btnagregar;
        private ListView lst;
        private Button btneliminar;
        private Button btncompletar;
        private ColumnHeader nombre;
        private ColumnHeader prioridad;
    }
}