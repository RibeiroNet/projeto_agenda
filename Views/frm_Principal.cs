using Projeto_Agenda.VariableGlobal;
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
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_usuário usuario = new frm_usuário();
            usuario.Show();
        }

        private void arquivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categoria categoria = new frm_categoria();
            categoria.Show();
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            string boasvindas = $"Seja muito bem vindo, {UserSession.usuario}";
            lbl_bv.Text = boasvindas;
        }

        private void lbl_bv_Click(object sender, EventArgs e)
        {

        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Contato contato = new Frm_Contato();    
            contato.Show();
        }
    }
}
