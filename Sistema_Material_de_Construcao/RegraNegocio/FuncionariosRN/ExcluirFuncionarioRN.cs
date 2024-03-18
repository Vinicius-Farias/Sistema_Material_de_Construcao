using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados.FuncionarioBanco.DeleteFuncionario;

namespace RegraNegocio.FuncionariosRN
{
	public class ExcluirFuncionarioRN
	{
		private DeleteFuncionarioAD DeleteFuncionario;

		public void ExcluirFuncionario(int idFuncionario)
		{
			try
			{
				if (idFuncionario == 0)
				{
					throw new Exception("Funcionario não encontrado");
				}
				else
				{
					DeleteFuncionario = new DeleteFuncionarioAD();
					DeleteFuncionario.DeleteFuncionario(idFuncionario);
				}
				
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
