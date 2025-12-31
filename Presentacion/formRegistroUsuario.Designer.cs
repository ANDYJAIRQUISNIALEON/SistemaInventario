namespace Presentacion
{
    partial class formRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegistroUsuario));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label8 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            txtCedula = new TextBox();
            panel3 = new Panel();
            panel4 = new Panel();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label9 = new Label();
            label1 = new Label();
            label6 = new Label();
            label10 = new Label();
            label4 = new Label();
            panel11 = new Panel();
            panel12 = new Panel();
            textBox4 = new TextBox();
            panel13 = new Panel();
            panel14 = new Panel();
            textBox5 = new TextBox();
            panel7 = new Panel();
            panel8 = new Panel();
            textBox1 = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel11.SuspendLayout();
            panel13.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 125, 50);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 59);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(581, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(624, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(230, 14);
            label3.Name = "label3";
            label3.Size = new Size(207, 30);
            label3.TabIndex = 0;
            label3.Text = "CREA UNA CUENTA";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LawnGreen;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(668, 3);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(365, 78);
            label2.Name = "label2";
            label2.Size = new Size(74, 16);
            label2.TabIndex = 6;
            label2.Text = "APELLIDOS:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 125, 50);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(161, 264);
            button1.Name = "button1";
            button1.Size = new Size(349, 35);
            button1.TabIndex = 15;
            button1.Text = "REGISTAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(367, 302);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(75, 15);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ingresa Aquí";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(226, 302);
            label8.Name = "label8";
            label8.Size = new Size(135, 15);
            label8.TabIndex = 17;
            label8.Text = "¿Ya tienes una cuenta?";
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(txtCedula);
            panel5.Location = new Point(58, 97);
            panel5.Name = "panel5";
            panel5.Size = new Size(245, 25);
            panel5.TabIndex = 18;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(46, 125, 50);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 24);
            panel6.Name = "panel6";
            panel6.Size = new Size(245, 1);
            panel6.TabIndex = 0;
            // 
            // txtCedula
            // 
            txtCedula.BorderStyle = BorderStyle.None;
            txtCedula.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCedula.Location = new Point(0, 3);
            txtCedula.Multiline = true;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(245, 23);
            txtCedula.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(textBox2);
            panel3.Location = new Point(58, 148);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 25);
            panel3.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(46, 125, 50);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(245, 1);
            panel4.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(0, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 23);
            textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial", 11.25F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ADMINISTRADOR", "SUPERVISOR", "CAJERO", "BODEGUERO" });
            comboBox1.Location = new Point(367, 148);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 25);
            comboBox1.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(58, 78);
            label9.Name = "label9";
            label9.Size = new Size(67, 16);
            label9.TabIndex = 22;
            label9.Text = "NOMBRES:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 129);
            label1.Name = "label1";
            label1.Size = new Size(52, 16);
            label1.TabIndex = 23;
            label1.Text = "CÉDULA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(365, 129);
            label6.Name = "label6";
            label6.Size = new Size(34, 16);
            label6.TabIndex = 24;
            label6.Text = "ROL:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(58, 194);
            label10.Name = "label10";
            label10.Size = new Size(86, 16);
            label10.TabIndex = 25;
            label10.Text = "CONTRASEÑA:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 223);
            label4.Name = "label4";
            label4.Size = new Size(136, 16);
            label4.TabIndex = 26;
            label4.Text = "REPETIR CONTRASEÑA:";
            // 
            // panel11
            // 
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(textBox4);
            panel11.Location = new Point(150, 185);
            panel11.Name = "panel11";
            panel11.Size = new Size(460, 25);
            panel11.TabIndex = 27;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(46, 125, 50);
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(0, 24);
            panel12.Name = "panel12";
            panel12.Size = new Size(460, 1);
            panel12.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(0, 3);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(460, 23);
            textBox4.TabIndex = 4;
            // 
            // panel13
            // 
            panel13.Controls.Add(panel14);
            panel13.Controls.Add(textBox5);
            panel13.Location = new Point(200, 214);
            panel13.Name = "panel13";
            panel13.Size = new Size(410, 25);
            panel13.TabIndex = 28;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(46, 125, 50);
            panel14.Dock = DockStyle.Bottom;
            panel14.Location = new Point(0, 24);
            panel14.Name = "panel14";
            panel14.Size = new Size(410, 1);
            panel14.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(0, 3);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.Size = new Size(410, 23);
            textBox5.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(textBox1);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(367, 97);
            panel7.Name = "panel7";
            panel7.Size = new Size(245, 25);
            panel7.TabIndex = 29;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(46, 125, 50);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 24);
            panel8.Name = "panel8";
            panel8.Size = new Size(245, 1);
            panel8.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 23);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, -23);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 14;
            label5.Text = "Segundo Apellido:";
            // 
            // formRegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(668, 322);
            Controls.Add(comboBox1);
            Controls.Add(panel7);
            Controls.Add(panel13);
            Controls.Add(panel11);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(label8);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formRegistroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formRegistroUsuario";
            Load += formRegistroUsuario_Load;
            MouseDown += formRegistroUsuario_MouseDown;
            MouseMove += formRegistroUsuario_MouseMove;
            MouseUp += formRegistroUsuario_MouseUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label2;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label8;
        private Panel panel5;
        private Panel panel6;
        private TextBox txtCedula;
        private Panel panel3;
        private Panel panel4;
        private TextBox textBox2;
        private Label label9;
        private Label label1;
        private Label label6;
        private Label label10;
        private Label label4;
        private Panel panel11;
        private Panel panel12;
        private TextBox textBox4;
        private Panel panel13;
        private Panel panel14;
        private TextBox textBox5;
        private Panel panel7;
        private Panel panel8;
        private TextBox textBox1;
        private Label label5;
        private PictureBox pictureBox3;
        private ComboBox comboBox1;
    }
}