using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.ProdutosBanco.SaveCategoria
{
	public class SaveCategoriaAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void SalvarCategoria(string nome, string descricao)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("INSERT INTO Categoria_Produtos (Nome_Categoria_Produtos, Descricao_Categoria_Produtos) ");
					sql.Append("VALUES (@nome, @descricao)");

					comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
					comandoSql.Parameters.Add(new SqlParameter("@descricao", descricao));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método SalvarCategoria, Caso o problema persista, entre em contato com o Administrador do sistema");
			}
		}
	}
}
