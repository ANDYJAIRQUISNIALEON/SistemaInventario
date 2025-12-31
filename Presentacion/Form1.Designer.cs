namespace Presentacion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MenuVertical = new Panel();
            btnproducto = new Button();
            pictureBox1 = new PictureBox();
            BarraTitulo = new Panel();
            btnSlide = new PictureBox();
            panelContenedor = new Panel();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSlide).BeginInit();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(46, 125, 50);
            MenuVertical.Controls.Add(btnproducto);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(250, 650);
            MenuVertical.TabIndex = 0;
            // 
            // btnproducto
            // 
            btnproducto.BackColor = Color.Transparent;
            btnproducto.FlatAppearance.BorderSize = 0;
            btnproducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnproducto.FlatStyle = FlatStyle.Flat;
            btnproducto.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnproducto.ForeColor = Color.White;
            btnproducto.Image = (Image)resources.GetObject("btnproducto.Image");
            btnproducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnproducto.Location = new Point(0, 128);
            btnproducto.Name = "btnproducto";
            btnproducto.Size = new Size(250, 40);
            btnproducto.TabIndex = 0;
            btnproducto.Text = "Productos";
            btnproducto.UseVisualStyleBackColor = false;
            btnproducto.Click += btnproducto_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = SystemColors.ControlLightLight;
            BarraTitulo.Controls.Add(btnSlide);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(250, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1050, 50);
            BarraTitulo.TabIndex = 1;
            // 
            // btnSlide
            // 
            btnSlide.Cursor = Cursors.Hand;
            btnSlide.Image = (Image)resources.GetObject("btnSlide.Image");
            btnSlide.Location = new Point(16, 9);
            btnSlide.Name = "btnSlide";
            btnSlide.Size = new Size(35, 35);
            btnSlide.SizeMode = PictureBoxSizeMode.Zoom;
            btnSlide.TabIndex = 0;
            btnSlide.TabStop = false;
            btnSlide.Click += btnSlide_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.ControlLightLight;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(250, 50);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1050, 600);
            panelContenedor.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1300, 650);
            Controls.Add(panelContenedor);
            Controls.Add(BarraTitulo);
            Controls.Add(MenuVertical);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSlide).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuVertical;
        private Panel BarraTitulo;
        private PictureBox btnSlide;
        private PictureBox pictureBox1;
        private Panel panelContenedor;
        private Button btnproducto;
    }
}
