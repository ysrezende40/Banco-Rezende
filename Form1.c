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
    public partial class Form1 : Form
    {
        string logincorreto = "";
        string senhacorreta = "";
        string nomeDoClienteCadrasto = "";
        int numeroDaconta = 345678;



        public Form1()
        {
            InitializeComponent();
           


        }
        public Form1(string login, string senha, string nomeDoCliente)
        {
            logincorreto = login;
            senhacorreta = senha;
            nomeDoClienteCadrasto = nomeDoCliente;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string logindigitado = txtTelaLogin.Text;
            string senhadigitada = txtTelaSenha.Text;
            if (logincorreto == "" && senhacorreta == "")
            {
                MessageBox.Show("Por gentileza, Preecha os campos", "ERR0", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (logincorreto != "" && senhacorreta != "")
            {
                if (logindigitado == logincorreto && senhadigitada == senhacorreta && logincorreto != "" && senhacorreta != "")
                {
                    MessageBox.Show($"Bem vindo {nomeDoClienteCadrasto}!!", "BEM VINDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TelaPrincipal abrirForm = new TelaPrincipal(nomeDoClienteCadrasto, numeroDaconta);
                    abrirForm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Crendenciais não reconhecidas", "ERR0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void btnCadrasto_Click(object sender, EventArgs e)
        {
            FormCadrasto abrirform = new FormCadrasto();
            abrirform.Show();
            this.Hide();
        }

        private void txtTelaLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelaSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            txtTelaSenha.PasswordChar = '*';
            this.MaximizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
