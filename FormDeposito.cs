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
    public partial class FormDeposito : Form
    {
        private SistemaBank sistemaBanco; //novamnete eu declaro a variavel para acessar a classe 

        public FormDeposito()
        {
            InitializeComponent();
            this.MaximizeBox = false;

        }

        public FormDeposito(SistemaBank sistema)
        {
            InitializeComponent();
            sistemaBanco = sistema; // e aqui eu digo que a varivael que eu criei recebe os valores da variavel que eu recebi no form tela principal
        }

        private void btnRealizarDeposito_Click(object sender, EventArgs e)
        {
            try
            {
                string Valor = txtTelaDeposito.Text;
                double valordepositado = double.Parse(Valor);
                sistemaBanco.Depositar(valordepositado); // aqui eu passo novos dados
                MessageBox.Show("Deposito realizado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar o depósito: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Console.WriteLine($"Erro ao realizar o depósito. Tipo de exceção: {ex.GetType().Name}, Mensagem: {ex.Message}");
            }

        }

        private void btnRetornTelaPrincipal_Click(object sender, EventArgs e)
        {
            TelaPrincipal abrirForm = new TelaPrincipal(sistemaBanco); // e envio de volta os dados para a tela principal
            abrirForm.Show();
            this.Hide();
        }

        private void FormDeposito_Load(object sender, EventArgs e)
        {

        }

        private void FormDeposito_Load_1(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}