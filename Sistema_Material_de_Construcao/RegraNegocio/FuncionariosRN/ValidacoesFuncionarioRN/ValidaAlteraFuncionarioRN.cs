using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados.FuncionarioBanco.SelectFuncionario;

namespace RegraNegocio.FuncionariosRN.ValidacoesFuncionarioRN
{
	internal class ValidaAlteraFuncionarioRN
	{
		private PesquisarIDFuncionarioAD PesquisarIDFuncionario;
		private ValidaFuncionarioRN ValidaFuncionario;
		private DataTable dadosTabela;
		
		internal void ValidaAlteraFuncionario(int idFuncionario, string rg, string cpf)
		{
			try
			{
				PesquisarIDFuncionario = new PesquisarIDFuncionarioAD();
				dadosTabela = new DataTable();
				dadosTabela = PesquisarIDFuncionario.PesquisarIDFuncionario(idFuncionario);

				if (dadosTabela.Rows[0]["Rg_Funcionario"].ToString() != rg)
				{
					ValidaFuncionario = new ValidaFuncionarioRN();
					ValidaFuncionario.ValidaRG(rg);
				}
				else if (dadosTabela.Rows[0]["Cpf_Funcionario"].ToString() != cpf)
				{
					ValidaFuncionario = new ValidaFuncionarioRN();
					ValidaFuncionario.ValidaCPF(cpf);
				}

				
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
