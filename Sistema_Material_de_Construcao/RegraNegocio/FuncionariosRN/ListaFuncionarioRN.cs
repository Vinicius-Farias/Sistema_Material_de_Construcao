using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados.FuncionarioBanco.SelectFuncionario;

namespace RegraNegocio.FuncionariosRN
{
	public class ListaFuncionarioRN
	{
		public DataTable ListaFuncionario()
		{
			try
			{
				SelectFuncionarioAD SelectFuncionario = new SelectFuncionarioAD();
				DataTable dadosTabela = new DataTable();

				return dadosTabela = SelectFuncionario.ListaFuncionarios();
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

	}
}
