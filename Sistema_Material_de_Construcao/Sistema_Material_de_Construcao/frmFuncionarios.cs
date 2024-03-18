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
using RegraNegocio.FuncionariosRN;
using System.Runtime.CompilerServices;


namespace Sistema_Material_de_Construcao
{
	public partial class frmFuncionarios : KryptonForm
	{
		private ValidaFuncionarioRN SalvarFuncionarioRN;
		private ExcluirFuncionarioRN ExcluirFuncionarioRN;

		private int idFuncionario = 0;
		public frmFuncionarios()
		{
			InitializeComponent();

			idFuncionario = FuncionarioIT.idFuncionario;
		}

		private void ReceberCadastro()
		{
			if (idFuncionario > 0)
			{
				txtNome.Text = FuncionarioIT.nome;
				txtEndereco.Text = FuncionarioIT.endereco;
				txtBairro.Text = FuncionarioIT.bairro;
				txtCep.Text = FuncionarioIT.cep;
				txtCidade.Text = FuncionarioIT.cidade;
				txtEmail.Text = FuncionarioIT.email;
				dtpNascimento.Value = FuncionarioIT.nascimento;
				txtTelefone1.Text = FuncionarioIT.telefone1;
				txtTelefone2.Text = FuncionarioIT.telefone2;
				txtRg.Text = FuncionarioIT.Rg;
				txtCpf.Text = FuncionarioIT.Cpf;
				txtObservacoes.Text = FuncionarioIT.observacoes;
				dtpDataCadastro.Value = FuncionarioIT.dataCadastro; 
			}
		}

		private void Limpar(Control.ControlCollection controles)
		{
			foreach (Control ctrl in controles)
			{
				if (ctrl is TextBox)
				{
					((TextBox)ctrl).Text = string.Empty;
				}
				else if (ctrl is MaskedTextBox)
				{
					((MaskedTextBox)ctrl).Text = string.Empty;
				}
				else if (ctrl is KryptonDateTimePicker)
				{
					((KryptonDateTimePicker)ctrl).Value = DateTime.Today;
				}
				else if (ctrl.HasChildren)
				{
					Limpar(ctrl.Controls);
				}
			}

			idFuncionario = 0;
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				
				SalvarFuncionarioRN = new ValidaFuncionarioRN();
				SalvarFuncionarioRN.ValidaFuncionario(idFuncionario, txtNome.Text, txtEndereco.Text, txtBairro.Text, txtCep.Text, txtCidade.Text, txtEmail.Text, 
					dtpNascimento.Value, txtTelefone1.Text, txtTelefone2.Text, txtRg.Text, txtCpf.Text, txtObservacoes.Text, dtpDataCadastro.Value);

				if (idFuncionario > 0)
				{
					MessageBox.Show("Funcionario Alterado Com Sucesso!");
				}
				else
				{
					MessageBox.Show("Funcionario Cadastrado Com Sucesso!");
				}

				Limpar(this.Controls);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			try
			{
				ExcluirFuncionarioRN = new ExcluirFuncionarioRN();
				ExcluirFuncionarioRN.ExcluirFuncionario(idFuncionario);

				MessageBox.Show("Funcionario Excluirdo Com Sucesso!");
				Limpar(this.Controls);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmFuncionarios_Load(object sender, EventArgs e)
		{
			ReceberCadastro();
		}

		private void btnApagar_Click(object sender, EventArgs e)
		{
			Limpar(this.Controls);
		}
	}
}
