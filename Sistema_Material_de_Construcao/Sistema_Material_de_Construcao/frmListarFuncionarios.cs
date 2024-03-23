using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegraNegocio.FuncionariosRN;
using ComponentFactory.Krypton.Toolkit;

namespace Sistema_Material_de_Construcao
{
	public partial class frmListarFuncionarios : KryptonForm
	{
		private frmPrincipal FrmPrincipal;
		private ListaFuncionarioRN ListaFuncionarioRN;
		private ExcluirFuncionarioRN ExcluirFuncionarioRN;
		private PeesquisarCpfFuncionarioRN PeesquisarCpfFuncionario;
		private PesquisarNomeFuncionarioRN PesquisarNomeFuncionarioRN;
		
		public frmListarFuncionarios(frmPrincipal frmPrincipal)
		{
			InitializeComponent();
			this.FrmPrincipal = frmPrincipal;
		}

		internal void ListaFuncionarios()
		{
			try
			{
				ListaFuncionarioRN = new ListaFuncionarioRN();
				dgvFuncionario.DataSource = ListaFuncionarioRN.ListaFuncionario();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Pesquisar()
		{
			try
			{
				if(rbCPF.Checked)
				{
					PeesquisarCpfFuncionario = new PeesquisarCpfFuncionarioRN();

					dgvFuncionario.DataSource = PeesquisarCpfFuncionario.PesquisarCpfFuncionario(txtPesquisar.Text);
				}
				else if (rbNome.Checked)
				{
					PesquisarNomeFuncionarioRN = new PesquisarNomeFuncionarioRN();

					dgvFuncionario.DataSource = PesquisarNomeFuncionarioRN.PesquisarNomeFuncionario(txtPesquisar.Text);
				}
				else
				{
					MessageBox.Show("Selecione alguma opção de pesquisa: Nome ou CPF", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnBusca_Click(object sender, EventArgs e)
		{
			Pesquisar();
		}

		private void btnListarProdutos_Click(object sender, EventArgs e)
		{
			FrmPrincipal.ChamaListaProdutos();
			this.Close();
		}

		private void btnListaCliente_Click(object sender, EventArgs e)
		{
			FrmPrincipal.ChamaListaCliente();
			this.Close();
		}

		private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				if (dgvFuncionario.Columns[e.ColumnIndex].Name == "btnEditar")
				{
					FuncionarioIT.idFuncionario = Convert.ToInt32(dgvFuncionario.Rows[e.RowIndex].Cells["Id_Funcionario"].Value.ToString());
					FuncionarioIT.nome = dgvFuncionario.Rows[e.RowIndex].Cells["Nome_Funcionario"].Value.ToString();
					FuncionarioIT.endereco = dgvFuncionario.Rows[e.RowIndex].Cells["Endereco_Funcionario"].Value.ToString();
					FuncionarioIT.bairro = dgvFuncionario.Rows[e.RowIndex].Cells["Bairro_Funcionario"].Value.ToString();
					FuncionarioIT.cep = dgvFuncionario.Rows[e.RowIndex].Cells["Cep_Funcionario"].Value.ToString();
					FuncionarioIT.cidade = dgvFuncionario.Rows[e.RowIndex].Cells["Cidade_Funcionario"].Value.ToString();
					FuncionarioIT.email = dgvFuncionario.Rows[e.RowIndex].Cells["Email_Funcionario"].Value.ToString();
					FuncionarioIT.nascimento = Convert.ToDateTime(dgvFuncionario.Rows[e.RowIndex].Cells["Nascimento_Funcionario"].Value.ToString());
					FuncionarioIT.telefone1 = dgvFuncionario.Rows[e.RowIndex].Cells["Telefone1_Funcionario"].Value.ToString();
					FuncionarioIT.telefone2 = dgvFuncionario.Rows[e.RowIndex].Cells["Telefone2_Funcionario"].Value.ToString();
					FuncionarioIT.Rg = dgvFuncionario.Rows[e.RowIndex].Cells["Rg_Funcionario"].Value.ToString();
					FuncionarioIT.Cpf = dgvFuncionario.Rows[e.RowIndex].Cells["Cpf_Funcionario"].Value.ToString();
					FuncionarioIT.observacoes = dgvFuncionario.Rows[e.RowIndex].Cells["Observacoes_Funcionario"].Value.ToString();
					FuncionarioIT.dataCadastro = Convert.ToDateTime(dgvFuncionario.Rows[e.RowIndex].Cells["Data_Cadastro_Funcionario"].Value.ToString());

					FrmPrincipal.ChamafrmFuncionario();
					this.Close();
				}
				else if (dgvFuncionario.Columns[e.ColumnIndex].Name == "btnExcluir" && MessageBox.Show("Deseja realmente excluir?", "Deseja excluir?",
						MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						ExcluirFuncionarioRN = new ExcluirFuncionarioRN();
						ExcluirFuncionarioRN.ExcluirFuncionario(Convert.ToInt32(dgvFuncionario.Rows[e.RowIndex].Cells["Id_Funcionario"].Value));
						MessageBox.Show("Funcionario excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
						ListaFuncionarios();
					}
					catch (Exception ex)
					{

						MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void frmListarFuncionarios_Load(object sender, EventArgs e)
		{
			ListaFuncionarios();
		}

		private void txtPesquisar_TextChanged(object sender, EventArgs e)
		{
			if (txtPesquisar.Text == "")
			{
				ListaFuncionarios();
			}
		}

		private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Pesquisar();
			}
		}
	}
}
