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
    public partial class Frm_Contato : Form
    {
        public Frm_Contato()
        {
            InitializeComponent();
        }

        private void AtualizarDataGrid()
        {
            ContatoController controlecontato = new ContatoController();
            DataTable tabela = controlecontato.GetContato();
            DGV_contato.DataSource = tabela;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            string contato = txt_contato.Text;
            string telefone = txt_telefone.Text;
            string categoria = cmb_categoria.Text;

            ContatoController controlecontato = new ContatoController();

            bool resultado = controlecontato.AddContato(contato, telefone, categoria);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso.");
            }
            else
            {
                MessageBox.Show("Cadastro não efetuado.");
            }

            DataTable tabela = controlecontato.GetContato();
            DGV_contato.DataSource = tabela;

            AtualizarDataGrid();
            CategoriaController controlecategoria = new CategoriaController();
            DataTable ttabela = controlecategoria.GetCategorias();
            cmb_categoria.DataSource = ttabela;
            cmb_categoria.DisplayMember = "categoria";
        }

        private void Frm_Contato_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            string telefone = Convert.ToString(DGV_contato.SelectedRows[0].Cells[1].Value);
            ContatoController contato = new ContatoController();
            bool resultado = contato.ExcluirContato(telefone);
            AtualizarDataGrid();
        }

        private void button_alterar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
