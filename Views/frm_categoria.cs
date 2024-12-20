﻿using Projeto_Agenda.controller;
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

        private void AtualizarDataGrid()
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            DGV_categoria.DataSource = tabela;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();

            bool resultado = controleCategoria.AddCategoria(textbox_categoria.Text);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso.");
            }
            else
            {
                MessageBox.Show("Não foi possível efetuar o cadastro.");
            }

            CategoriaController controlaCategoria = new CategoriaController();

            DataTable tabela = controlaCategoria.GetCategorias();

            DGV_categoria.DataSource = tabela;

            AtualizarDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_categoria_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            int codigo = (int)(DGV_categoria.SelectedRows[0].Cells[0].Value);
            CategoriaController categoria = new CategoriaController();

            bool resultado = categoria.ExcluirCategoria(codigo);
            if (resultado)
            {
                MessageBox.Show("Categoria Excluìda.");

            }
            else
            {
                MessageBox.Show("Categoria não Excluìda.");
            }
            AtualizarDataGrid();
        }

        private void button_alterar_Click(object sender, EventArgs e)
        {
            int codigo = (int)DGV_categoria.SelectedRows[0].Cells[0].Value;
            CategoriaController controlecategoria = new CategoriaController();
            bool resultado = controlecategoria.UpdateCategoria(codigo, textbox_categoria.Text);

            if (resultado)
            {
                MessageBox.Show("Categoria atualizada.");
            }
            else
            {
                MessageBox.Show("Alteração não realizada.");
            }

            AtualizarDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
