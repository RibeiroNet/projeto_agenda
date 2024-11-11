using Projeto_Agenda.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda.Views
{
    public partial class frm_categoria : Form
    {
        public frm_categoria()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();

            bool resultado = controleCategoria.AddCategoria(textbox_categoria.Text);

            if (resultado == true)
            {
                MessageBox.Show("Cadastro efeuado com sucesso.");
            }
            else
            {
                MessageBox.Show("Não foi possível efetuar o cadastro.");
            }

            CategoriaController controlaCategoria = new CategoriaController();
            DataTable tabela = controlaCategoria.GetCategorias();

            DGV_categoria.DataSource = tabela;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_categoria_Load(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();

            DGV_categoria.DataSource = tabela;
        }
    }
}
