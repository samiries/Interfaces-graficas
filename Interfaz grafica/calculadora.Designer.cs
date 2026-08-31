namespace Interfaz_grafica
{
    partial class calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculadora));
            lbltitulo = new Label();
            lblnums = new Label();
            lblresultado = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            pnlbtns = new Panel();
            btnsuma = new Button();
            btnresta = new Button();
            btnmult = new Button();
            btndiv = new Button();
            pnlbtns.SuspendLayout();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = Color.Transparent;
            lbltitulo.Font = new Font("Impact", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltitulo.Location = new Point(12, 9);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(170, 36);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "calculadora";
            // 
            // lblnums
            // 
            lblnums.AutoSize = true;
            lblnums.BackColor = Color.Transparent;
            lblnums.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnums.ForeColor = SystemColors.ControlLightLight;
            lblnums.Location = new Point(156, 74);
            lblnums.Name = "lblnums";
            lblnums.Size = new Size(51, 20);
            lblnums.TabIndex = 1;
            lblnums.Text = "label1";
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.BackColor = Color.Transparent;
            lblresultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblresultado.Location = new Point(226, 219);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(65, 25);
            lblresultado.TabIndex = 3;
            lblresultado.Text = "label1";
            // 
            // txt1
            // 
            txt1.Location = new Point(246, 74);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 8;
            txt1.TextChanged += txt1_TextChanged;
            txt1.KeyPress += txt1_KeyPress;
            // 
            // txt2
            // 
            txt2.Location = new Point(246, 112);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 23);
            txt2.TabIndex = 9;
            txt2.TextChanged += txt2_TextChanged;
            txt2.KeyPress += txt2_KeyPress;
            // 
            // pnlbtns
            // 
            pnlbtns.BackColor = Color.Transparent;
            pnlbtns.Controls.Add(btnsuma);
            pnlbtns.Controls.Add(btnresta);
            pnlbtns.Controls.Add(btnmult);
            pnlbtns.Controls.Add(btndiv);
            pnlbtns.Location = new Point(80, 158);
            pnlbtns.Name = "pnlbtns";
            pnlbtns.Size = new Size(427, 58);
            pnlbtns.TabIndex = 10;
            // 
            // btnsuma
            // 
            btnsuma.BackColor = Color.Silver;
            btnsuma.Location = new Point(35, 31);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(75, 23);
            btnsuma.TabIndex = 4;
            btnsuma.Text = "+";
            btnsuma.UseVisualStyleBackColor = false;
            btnsuma.Click += btnsuma_Click;
            // 
            // btnresta
            // 
            btnresta.BackColor = Color.Silver;
            btnresta.Location = new Point(125, 31);
            btnresta.Name = "btnresta";
            btnresta.Size = new Size(75, 23);
            btnresta.TabIndex = 5;
            btnresta.Text = "-";
            btnresta.UseVisualStyleBackColor = false;
            btnresta.Click += btnresta_Click;
            // 
            // btnmult
            // 
            btnmult.BackColor = Color.Silver;
            btnmult.Location = new Point(221, 31);
            btnmult.Name = "btnmult";
            btnmult.Size = new Size(75, 23);
            btnmult.TabIndex = 6;
            btnmult.Text = "x";
            btnmult.UseVisualStyleBackColor = false;
            btnmult.Click += btnmult_Click;
            // 
            // btndiv
            // 
            btndiv.BackColor = Color.Silver;
            btndiv.Location = new Point(323, 31);
            btndiv.Name = "btndiv";
            btndiv.Size = new Size(75, 23);
            btndiv.TabIndex = 7;
            btndiv.Text = "÷";
            btndiv.UseVisualStyleBackColor = false;
            btndiv.Click += btndiv_Click;
            // 
            // calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(601, 278);
            Controls.Add(pnlbtns);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(lblresultado);
            Controls.Add(lblnums);
            Controls.Add(lbltitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "calculadora";
            pnlbtns.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private Label lblnums;
        private Label lblresultado;
        private TextBox txt1;
        private TextBox txt2;
        private Panel pnlbtns;
        private Button btnsuma;
        private Button btnresta;
        private Button btnmult;
        private Button btndiv;
    }
}