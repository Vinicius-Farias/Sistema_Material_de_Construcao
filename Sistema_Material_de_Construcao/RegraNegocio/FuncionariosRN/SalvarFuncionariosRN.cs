using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados.FuncionarioBanco;

namespace RegraNegocio.FuncionariosRN
{
	public class SalvarFuncionariosRN
	{
		private SaveFuncionariosAD SaveFuncionarioAD;

		public void salvarFuncionarioRN(string nome, string endereco, string bairro, string cep, string cidade, string email, DateTime nascimento,
			string telefone1, string telefone2, string rg, string cpf, string observacoes, DateTime dataCadastro)
		{
			try
			{
				SaveFuncionarioAD = new SaveFuncionariosAD();
				SaveFuncionarioAD.SaveFuncionarios(nome, endereco, bairro, cep, cidade, email, nascimento, telefone1, telefone2, rg, cpf, observacoes, dataCadastro);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
