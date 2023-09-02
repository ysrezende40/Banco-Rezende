using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoRezende
{
    public partial class FormCadrasto : Form
    {
        string login = "";
        string senha = "";
        string nomeDoCliente = "";

        public FormCadrasto()
        {
            InitializeComponent();
            txtTelaSenhaCadrasto.PasswordChar= '*';
            this.MaximizeBox = false;
        }

        private void FormCadrasto_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrarCadrasto_Click(object sender, EventArgs e)
        {
            try
            {
                login = txtTelaLoginCadrasto.Text;
                senha = txtTelaSenhaCadrasto.Text;
                nomeDoCliente = txtnomeDoCliente.Text;

                if (login=="" && senha=="" && nomeDoCliente=="")
                {
                    MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (login.Length < 6 && senha.Length < 6 )
                {
                    MessageBox.Show("Os campos devem conter pelo menos 6 caracteres", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show($"Cadastrado com sucesso, Bem-vindo ao nosso Banco {nomeDoCliente}!!","BEM VINDO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 abrirform = new Form1(login, senha, nomeDoCliente);
                abrirform.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao realizar o cadastro, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


    }
}