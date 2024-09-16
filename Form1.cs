using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenda_de_contatos
{
    public partial class Form1 : Form
    {
        Contato contato = new Contato();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (validarCampos() && preencheContato())
            {

                listaContatos.Items.Add(contato.ToString());
                limparTextBox();
            } else
            {
                MessageBox.Show("Campos com valores inválidos, preencha de forma correta");
            }
        }

        private bool validarCampos()
        {
            return !boxNome.Text.Equals(String.Empty) && !boxTelefone.Equals(String.Empty) && !boxEmail.Equals(String.Empty);
        }

        private bool preencheContato()
        {
            String nome = boxNome.Text;
            String telefone = boxTelefone.Text;
            String email = boxEmail.Text;

            if (Regex.IsMatch(nome, "[0-9]")) //Verifica se o 
            {
                return false;
            }

            if(!email.Contains("@") && !email.Contains(".com"))
            {
                return false;
            }

            if(Regex.IsMatch(telefone, "[a-z A-Z]"))
            {
                return false;
            }

            contato.setTelefone(telefone);
            contato.setEmail(email);
            contato.setNome(nome);
            return true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (validarCampos() && preencheContato())
            {

                listaContatos.Items[listaContatos.SelectedIndex] = contato.ToString();
                limparTextBox();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(listaContatos.SelectedIndex != -1)
            {
                listaContatos.Items.RemoveAt(listaContatos.SelectedIndex);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listaContatos.Items.Clear();
        }

        private void limparTextBox()
        {
            boxNome.Text = String.Empty;
            boxTelefone.Text = String.Empty;
            boxEmail.Text = String.Empty;
        }
    }
}
