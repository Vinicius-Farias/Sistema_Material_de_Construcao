using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegraNegocio.VerificaCampos;
using AcessoDados.FuncionarioBanco.SelectFuncionario;

namespace RegraNegocio.FuncionariosRN
{
	public class PesquisarNomeFuncionarioRN
	{
		public DataTable PesquisarNomeFuncionario(string nome)
		{
			try
			{
				PesquisarNomeFuncionarioAD PesquisarNome = new PesquisarNomeFuncionarioAD();
				DataTable dadosTabela = new DataTable();

				VerificaCamposRN.ValidaTextBox(nome, "Pesquisar");
				
				return dadosTabela = PesquisarNome.PesquisarNomeFuncionario(nome);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
