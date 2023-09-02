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
    public partial class TelaPrincipal : Form
    {
        private SistemaBank sistemaBanco; // cria a variavel que armazena a classe que faz as operações e da um nome para ela

        public TelaPrincipal()
        {
            InitializeComponent();
            sistemaBanco = new SistemaBank(); //instancia a classe
            
        }
        public TelaPrincipal(SistemaBank sistema)
        {
            InitializeComponent();
            sistemaBanco = sistema;
        }
        public TelaPrincipal(string nomeDoCliente, int numeroDaConta)
        {
            InitializeComponent();
            sistemaBanco = new SistemaBank(nomeDoCliente, numeroDaConta); // so aqui que eu criei uma nova quera era para passar dados especificos que eu coletei em Form1

        }
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            FormDeposito abrirform = new FormDeposito(sistemaBanco); //passa a classe que eu instanciei para os forms para lidarmos com os mesmos dados
            abrirform.Show();
            this.Hide();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void btnSacar_Click(object sender, EventArgs e)
        {
            FormSaque abrirForm = new FormSaque(sistemaBanco); //passa a classe que eu instanciei para os forms para lidarmos com os mesmos dados
            abrirForm.Show();
            this.Hide();
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {

            MessageBox.Show($"Seu saldo é R$: {sistemaBanco.GetSaldo()}","SALDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TelaPrincipal_Load_1(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 sair = new Form1();
            sair.Show();
            this.Hide();
        }
    }
}