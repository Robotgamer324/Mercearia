namespace UIWinFormsApp
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            pnlMenuLateral = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            pnlConteudo = new Panel();
            pnlBarraTitulo = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            ptrboxFechar = new PictureBox();
            lblGestãoComercial = new Label();
            menuStrip1.SuspendLayout();
            pnlMenuLateral.SuspendLayout();
            pnlConteudo.SuspendLayout();
            pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptrboxFechar).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem });
            menuStrip1.Location = new Point(3, 9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(188, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.AutoSize = false;
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuáriosToolStripMenuItem, clientesToolStripMenuItem, produtosToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.ShowShortcutKeys = false;
            cadastroToolStripMenuItem.Size = new Size(122, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(122, 22);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(122, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(122, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // pnlMenuLateral
            // 
            pnlMenuLateral.BackColor = Color.MidnightBlue;
            pnlMenuLateral.Controls.Add(button5);
            pnlMenuLateral.Controls.Add(button4);
            pnlMenuLateral.Controls.Add(button3);
            pnlMenuLateral.Controls.Add(button2);
            pnlMenuLateral.Controls.Add(button1);
            pnlMenuLateral.Controls.Add(label1);
            pnlMenuLateral.Dock = DockStyle.Left;
            pnlMenuLateral.Location = new Point(0, 29);
            pnlMenuLateral.Name = "pnlMenuLateral";
            pnlMenuLateral.Size = new Size(200, 411);
            pnlMenuLateral.TabIndex = 1;
            pnlMenuLateral.Paint += pnlMenuLateral_Paint;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 8;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Bahnschrift Condensed", 9F);
            button5.Location = new Point(0, 226);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Padding = new Padding(20, 0, 0, 0);
            button5.Size = new Size(200, 50);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 8;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Bahnschrift Condensed", 9F);
            button4.Location = new Point(0, 176);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Padding = new Padding(20, 0, 0, 0);
            button4.Size = new Size(200, 50);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 8;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bahnschrift Condensed", 9F);
            button3.Location = new Point(0, 126);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Padding = new Padding(20, 0, 0, 0);
            button3.Size = new Size(200, 50);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 8;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bahnschrift Condensed", 9F);
            button2.Location = new Point(0, 76);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(200, 50);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.White;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 8;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift Condensed", 9F);
            button1.Location = new Point(0, 26);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(200, 50);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 26);
            label1.TabIndex = 0;
            label1.Text = "Gestão Comercial";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlConteudo
            // 
            pnlConteudo.Controls.Add(menuStrip1);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(200, 29);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(500, 411);
            pnlConteudo.TabIndex = 2;
            // 
            // pnlBarraTitulo
            // 
            pnlBarraTitulo.BackColor = SystemColors.GrayText;
            pnlBarraTitulo.BorderStyle = BorderStyle.FixedSingle;
            pnlBarraTitulo.Controls.Add(pictureBox3);
            pnlBarraTitulo.Controls.Add(pictureBox2);
            pnlBarraTitulo.Controls.Add(ptrboxFechar);
            pnlBarraTitulo.Controls.Add(lblGestãoComercial);
            pnlBarraTitulo.Dock = DockStyle.Top;
            pnlBarraTitulo.Location = new Point(0, 0);
            pnlBarraTitulo.Name = "pnlBarraTitulo";
            pnlBarraTitulo.Size = new Size(700, 29);
            pnlBarraTitulo.TabIndex = 3;
            pnlBarraTitulo.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(600, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 23);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(634, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // ptrboxFechar
            // 
            ptrboxFechar.Cursor = Cursors.Hand;
            ptrboxFechar.Image = (Image)resources.GetObject("ptrboxFechar.Image");
            ptrboxFechar.Location = new Point(668, 4);
            ptrboxFechar.Name = "ptrboxFechar";
            ptrboxFechar.Size = new Size(28, 23);
            ptrboxFechar.SizeMode = PictureBoxSizeMode.Zoom;
            ptrboxFechar.TabIndex = 1;
            ptrboxFechar.TabStop = false;
            ptrboxFechar.Click += ptrboxFechar_Click;
            ptrboxFechar.MouseDown += ptrboxFechar_MouseDown;
            ptrboxFechar.MouseLeave += ptrboxFechar_MouseLeave;
            ptrboxFechar.MouseUp += ptrboxFechar_MouseUp;
            // 
            // lblGestãoComercial
            // 
            lblGestãoComercial.AutoSize = true;
            lblGestãoComercial.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGestãoComercial.Location = new Point(13, 4);
            lblGestãoComercial.Name = "lblGestãoComercial";
            lblGestãoComercial.Size = new Size(198, 23);
            lblGestãoComercial.TabIndex = 0;
            lblGestãoComercial.Text = "Gestão Comercial - Mercearia";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(700, 440);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlMenuLateral);
            Controls.Add(pnlBarraTitulo);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.Manual;
            Text = "Gestão Comercial - Mercearia";
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlMenuLateral.ResumeLayout(false);
            pnlMenuLateral.PerformLayout();
            pnlConteudo.ResumeLayout(false);
            pnlBarraTitulo.ResumeLayout(false);
            pnlBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptrboxFechar).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private Panel pnlMenuLateral;
        private Panel pnlConteudo;
        private Label label1;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel pnlBarraTitulo;
        private Label lblGestãoComercial;
        private PictureBox ptrboxFechar;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}