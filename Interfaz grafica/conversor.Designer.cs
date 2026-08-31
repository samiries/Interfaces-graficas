namespace Interfaz_grafica
{
    partial class conversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conversor));
            lbltitulo = new Label();
            lbldatos = new Label();
            txtvalor = new TextBox();
            cmbdesde = new ComboBox();
            cmbhacia = new ComboBox();
            btn = new Button();
            lblresultado = new Label();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Stencil", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(147, 9);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(131, 25);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "conversor";
            // 
            // lbldatos
            // 
            lbldatos.AutoSize = true;
            lbldatos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldatos.Location = new Point(69, 71);
            lbldatos.Name = "lbldatos";
            lbldatos.Size = new Size(52, 21);
            lbldatos.TabIndex = 1;
            lbldatos.Text = "label1";
            // 
            // txtvalor
            // 
            txtvalor.Location = new Point(231, 69);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(100, 23);
            txtvalor.TabIndex = 2;
            txtvalor.TextChanged += txtvalor_TextChanged;
            txtvalor.KeyPress += txtvalor_KeyPress;
            // 
            // cmbdesde
            // 
            cmbdesde.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbdesde.FormattingEnabled = true;
            cmbdesde.Location = new Point(219, 110);
            cmbdesde.Name = "cmbdesde";
            cmbdesde.Size = new Size(121, 23);
            cmbdesde.TabIndex = 3;
            cmbdesde.SelectedIndexChanged += cmbdesde_SelectedIndexChanged;
            // 
            // cmbhacia
            // 
            cmbhacia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbhacia.FormattingEnabled = true;
            cmbhacia.Location = new Point(219, 139);
            cmbhacia.Name = "cmbhacia";
            cmbhacia.Size = new Size(121, 23);
            cmbhacia.TabIndex = 4;
            cmbhacia.SelectedIndexChanged += cmbhacia_SelectedIndexChanged;
            // 
            // btn
            // 
            btn.Location = new Point(147, 204);
            btn.Name = "btn";
            btn.Size = new Size(131, 39);
            btn.TabIndex = 5;
            btn.Text = "Convertir";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblresultado.Location = new Point(161, 278);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(52, 21);
            lblresultado.TabIndex = 6;
            lblresultado.Text = "label1";
            // 
            // conversor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(470, 308);
            Controls.Add(lblresultado);
            Controls.Add(btn);
            Controls.Add(cmbhacia);
            Controls.Add(cmbdesde);
            Controls.Add(txtvalor);
            Controls.Add(lbldatos);
            Controls.Add(lbltitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "conversor";
            Text = "conversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private Label lbldatos;
        private TextBox txtvalor;
        private ComboBox cmbdesde;
        private ComboBox cmbhacia;
        private Button btn;
        private Label lblresultado;
    }
}