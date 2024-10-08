using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda
{
    public partial class tela_inicial : Form
    {
        public tela_inicial()
        {
            InitializeComponent();
        }
        private void habilitarbotaocadastrar()
        {
            bool erro = false;
            if (textbox_nome.Text == "")
            {
                erro = true;
            }
            if (textbox_usuario2.Text ==  "")
            {  
                erro = true;
            }
            if (text_senha.Text.Length < 8)
            {
                erro = true;
            }
            if (text_senha.Text != text_senha_confirma.Text)
            {
                erro |= true;
            }
            if (erro == false)
            {

            }
       }
        private void button_cadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
