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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            string contato = txt_contato.Text;
            string telefone = txt_telefone.Text;
            string categoria = txt_categoria.Text;

            ContatoController controlecontato = new ContatoController();

            bool resultado = controlecontato.AddUsuario(contato, telefone, categoria);  

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
        }
    }
}
