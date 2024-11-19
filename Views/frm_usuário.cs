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
    public partial class frm_usuário : Form
    {
        public frm_usuário()
        {
            InitializeComponent();
        }

        private void AtualizarDataGrid()
        {
            UsuarioController controleCategoria = new UsuarioController();
            DataTable tabela = controleCategoria.GetUsuario();
            DGV_usuario.DataSource = tabela;
        }

        private void button_excluir_usuario_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(DGV_usuario.SelectedRows[0].Cells[1].Value);
            UsuarioController categoria = new UsuarioController();
            bool resultado = categoria.ExcluirUsuario(nome);
            AtualizarDataGrid();
        }

        private void button_cadastrar_usuario_Click(object sender, EventArgs e)
        {
            //recolhendo dados
            string senha = txt_nova_senha.Text;
            string usuario = txt_usuario.Text;  

            //instanciando objet Usuariocontroller
            UsuarioController controleusuario = new UsuarioController();  

            //inserindo o user
            bool resultado = controleusuario.AlterarSenha(senha, usuario);

            if (resultado)
            {
                MessageBox.Show("Cadastro reefetuado com sucesso.");
            }
            else
            {
                MessageBox.Show("Cadastro não efetuado.");
            }
        }
    }
}
