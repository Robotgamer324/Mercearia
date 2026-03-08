namespace UIWinFormsApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarUsuario frm = new FormBuscarUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarProduto frm = new FormBuscarProduto())
            {
                frm.ShowDialog();
            }

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarCliente frm = new FormBuscarCliente())
            {
                frm.ShowDialog();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pnlMenuLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ptrboxFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptrboxFechar_MouseDown(object sender, MouseEventArgs e)
        {
            // Forçamos o tamanho menor (ex: 21x21)
            ptrboxFechar.Size = new Size(21, 21);

            // Ajustamos a posição para centralizar o efeito de encolhimento
            // (Aumentamos o X e Y em 2 pixels)
            ptrboxFechar.Location = new Point(ptrboxFechar.Location.X + 2, ptrboxFechar.Location.Y + 2);
        }

        private void ptrboxFechar_MouseUp(object sender, MouseEventArgs e)
        {
            // Forçamos o retorno EXATO ao tamanho original (25x25)
            if (ptrboxFechar.Width != 25)
            {
                ptrboxFechar.Size = new Size(25, 25);
                ptrboxFechar.Location = new Point(ptrboxFechar.Location.X - 2, ptrboxFechar.Location.Y - 2);
            }
        }

        private void ptrboxFechar_MouseLeave(object sender, EventArgs e)
        {
            // Se o usuário arrastou para fora e o botão ainda está "encolhido"
            if (ptrboxFechar.Width != 25)
            {
                ptrboxFechar.Size = new Size(25, 25);
                ptrboxFechar.Location = new Point(ptrboxFechar.Location.X - 2, ptrboxFechar.Location.Y - 2);
            }
        }
    }
}