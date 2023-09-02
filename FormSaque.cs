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
    public partial class FormSaque : Form
    {
        private SistemaBank sistemaBanco;


        public FormSaque()
        {
            InitializeComponent();
            this.MaximizeBox = false;

        }

        public FormSaque(SistemaBank sistema)
        {
            InitializeComponent();
            sistemaBanco = sistema;
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            try
            {
                double valorSacado = double.Parse(txtSaque.Text);
                if (sistemaBanco.GetSaldo()> valorSacado)
                {
                    sistemaBanco.Sacar(valorSacado);
                    MessageBox.Show("Obrigado, valor retirado!!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Saldo insuficiente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
                
            }
            catch
            {
                MessageBox.Show("Saldo insuficiente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormSaque_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            TelaPrincipal abrirForm = new TelaPrincipal(sistemaBanco);
            abrirForm.Show();
            this.Hide();

        }

        private void FormSaque_Load_1(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}