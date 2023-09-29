using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaEndereco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbCEP_Leave(object sender, EventArgs e)
        {
            CEP_CorreiosService(tbCEP.Text);
        }

        private void CEP_CorreiosService (String CEP)
        {
            // foi usado https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?wsdl para adicionar o serviço do correio
            CorreiosRef.AtendeClienteClient correios = new CorreiosRef.AtendeClienteClient();
            CorreiosRef.enderecoERP consulta = correios.consultaCEP(CEP);

            if (consulta != null)
            {
                tbEndereco.Text = consulta.end;
                tbBairro.Text = consulta.bairro;
                tbCidade.Text = consulta.cidade;
                tbEstado.Text = consulta.uf;

                tbCEP.Focus();
            }
            else
            {
                MessageBox.Show("CEP não encontrado!", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
