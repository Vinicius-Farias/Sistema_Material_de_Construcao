using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.ProdutosBanco.SelectCategoria
{
	public class SelectCategoriaAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();
		DataTable dadosTabela = new DataTable();

		public DataTable ListaCategoria()
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT * FROM Categoria_Produtos ");
					sql.Append("ORDER BY Id_Categoria_Produtos DESC");

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método ListaCategoria. Caso o problema persista, entre em contato com o Administrador do Sitema.");
			}
		}
	}
}
