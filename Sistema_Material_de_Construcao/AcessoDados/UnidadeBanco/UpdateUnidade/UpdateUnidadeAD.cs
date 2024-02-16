using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.UnidadeBanco.UpdateUnidade
{
	public class UpdateUnidadeAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void AlteraUnidade(int idUnidade, string nome, string descricao)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("UPDATE Unidade_Produtos ");
					sql.Append("SET Nome_Unidade_Produtos = @nome, Descricao_Unidade_Produtos = @descricao ");
					sql.Append("WHERE Id_Unidade_Produtos = @idUnidade");

					comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
					comandoSql.Parameters.Add(new SqlParameter("@descricao", descricao));
					comandoSql.Parameters.Add(new SqlParameter("@idUnidade", idUnidade));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método AlteraUnidade. Caso o problema persista. entre em contato com o Administrador do Sistema");
			}
		}
	}
}
