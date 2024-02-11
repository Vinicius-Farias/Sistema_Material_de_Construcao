using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.FuncionarioBanco.DeleteFuncionario
{
	public class DeleteFuncionarioAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void DeleteFuncionario(int idFuncionario)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("DELETE FROM Funcionario ");
					sql.Append("WHERE (Id_Funcionario = @idFuncionario)");

					comandoSql.Parameters.Add(new SqlParameter("@idFuncionario", idFuncionario));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método UpdateFuncionario. Caso o problema persista. entre em contato com o Administrador do Sistema");
			}
		}
	}
}
