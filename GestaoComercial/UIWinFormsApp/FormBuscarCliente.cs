using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWinFormsApp
{
    public partial class FormBuscarCliente : Form
    {
        public FormBuscarCliente()
        {
            InitializeComponent();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            switch (comboBoxBuscarPor.SelectedIndex)
            {
                case 0:
                    clienteBindingSource.DataSource = new ClienteBLL().BuscarPorNome(textBoxBuscarPor.Text);
                    break;
                case 1:
                    clienteBindingSource.DataSource = new ClienteBLL().BuscarPorFone(textBoxBuscarPor.Text);
                    break;

                default:
                    clienteBindingSource.DataSource = new ClienteBLL().BuscarTodos();
                    break;
            }
        }

        private void textBoxBuscarPor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
