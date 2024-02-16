using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.CategoriaBanco.DeleteCategoria
{
	public class DeleteCategoriaAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void ExcluirCategoria(int idCategoria)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("DELETE FROM Categoria_Produtos ");
					sql.Append("WHERE Id_Categoria_Produtos = @idCategoria");

					comandoSql.Parameters.Add(new SqlParameter("@idCategoria", idCategoria));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método ExcluirCategoria. Caso o problema persista. entre em contato com o Administrador do Sistema");
			}
		}
	}
}
