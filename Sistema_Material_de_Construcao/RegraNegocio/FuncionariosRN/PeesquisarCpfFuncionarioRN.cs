using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados.FuncionarioBanco.SelectFuncionario;
using RegraNegocio.VerificaCampos;

namespace RegraNegocio.FuncionariosRN
{
	public class PeesquisarCpfFuncionarioRN
	{
		public DataTable PesquisarCpfFuncionario(string cpf)
		{
			try
			{
				PesquisarCpfFuncionarioAD pesquisarCpf = new PesquisarCpfFuncionarioAD();
				DataTable dadosTabela = new DataTable();

				VerificaCamposRN.ValidaTextBox(cpf, "Pesquisar");

				return dadosTabela = pesquisarCpf.PesquisaCpfFuncionario(cpf);

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
