using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.ProdutosBanco.DeleteProduto
{
	public class DeleteProdutoAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void ExcluirProduto(int idProduto)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("DELETE FROM Produtos ");
					sql.Append("WHERE Id_Produto = @idProduto");

					comandoSql.Parameters.Add(new SqlParameter("@idProduto", idProduto));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método ExcluirProduto. Caso o problema persista. entre em contato com o Administrador do Sistema");
			}
		}
	}
}
