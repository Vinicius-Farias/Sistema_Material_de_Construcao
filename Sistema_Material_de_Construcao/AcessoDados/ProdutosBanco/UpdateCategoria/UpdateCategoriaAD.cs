using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.ProdutosBanco.UpdateCategoria
{
	public class UpdateCategoriaAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void AlteraCategoria(int idCategoria, string nome, string descricao)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("UPDATE Categoria_Produtos ");
					sql.Append("SET Nome_Categoria_Produtos = @nome, Descricao_Categoria_Produtos = @descricao ");
					sql.Append("WHERE Id_Categoria_Produtos = @idCategoria");

					comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
					comandoSql.Parameters.Add(new SqlParameter("@descricao", descricao));
					comandoSql.Parameters.Add(new SqlParameter("@idCategoria", idCategoria));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método AlteraCategoria. Caso o problema persista. entre em contato com o Administrador do Sistema");
			}
		}
	}
}
