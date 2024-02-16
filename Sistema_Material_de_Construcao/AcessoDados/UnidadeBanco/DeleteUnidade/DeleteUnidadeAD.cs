using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.UnidadeBanco.DeleteUnidade
{
	public class DeleteUnidadeAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void ExcluirUnidade(int idUnidade)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("DELETE FROM Unidade_Produtos ");
					sql.Append("WHERE Id_Unidade_Produtos = @idUnidade");

					comandoSql.Parameters.Add(new SqlParameter("@idUnidade", idUnidade));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método ExcluirUnidade. Caso o problema persista. entre em contato com o Administrador do Sistema");
			}
		}
	}
}
