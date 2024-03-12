using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegraNegocio.FuncionariosRN.ValidacoesFuncionarioRN;


namespace Sistema_Material_de_Construcao
{
	public partial class frmFuncionarios : KryptonForm
	{
		ValidaFuncionarioRN SalvarFuncionarioRN;
		public frmFuncionarios()
		{
			InitializeComponent();
		}

		private int idFuncionario = 0;

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				SalvarFuncionarioRN = new ValidaFuncionarioRN();
				if (idFuncionario == 0)
				{
					SalvarFuncionarioRN.ValidaFuncionario(idFuncionario, txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCep.Text, txtCidade.Text, txtEmail.Text, 
						dtpNascimento.Value, txtTelefone1.Text, txtTelefone2.Text, txtRg.Text, txtCpf.Text, txtObservacoes.Text, dtpDataCadastro.Value);

					MessageBox.Show("Funcionario Cadastrado Com Sucesso!");
				}

			}
			catch (Exception ex )
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
