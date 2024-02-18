using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.ProdutosBanco.SelectProduto
{
	public class SelectProdutoAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();
		DataTable dadosTabela = new DataTable();

		public DataTable ListaProduto()
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT P.Id_Produto, P.Codigo_Barras_Produto, P.Nome_Produto, P.Descricao_Produto, P.Id_Unidade, ");
					sql.Append("U.Nome_Unidade_Produtos, P.Id_Categoria, C.Nome_Categoria_Produtos, P.Estoque_Minimo, P.Estoque_Atual, ");
					sql.Append("P.Valor_Compra, P.Valor_Venda, P.Margem, P.Situacao_Produto, P.Anotacoes_Produto, P.Data_Cadastro_Produto ");
					sql.Append("FROM Produtos AS P INNER JOIN Unidade_Produtos AS U ON P.Id_Unidade = U.Id_Unidade_Produtos ");
					sql.Append("INNER JOIN Categoria_Produtos AS C ON P.Id_Categoria = C.Nome_Categoria_Produtos ");
					sql.Append("ORDER BY P.Nome_Produto ASC");

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método ListaProduto. Caso o problema persista. entre em contato com o Administrador do Sistema");
			}
		}
	}
}
