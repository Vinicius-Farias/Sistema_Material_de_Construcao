using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.FuncionarioBanco.SelectFuncionario
{
	public class SelectFuncionarioAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();
		DataTable dadosTabela = new DataTable();

		public DataTable ListaFuncionarios()
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT * FROM Funcionario ");
					sql.Append("ORDER BY Id_Funcionario DESC");

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método ListarFuncionario. Caso o problema persista, entre em contato com o Administrador do Sitema.");
			}
		}
	}
}
