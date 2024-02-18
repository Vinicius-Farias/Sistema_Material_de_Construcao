using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.ProdutosBanco.SaveProduto
{
	public class SaveProdutoAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void SalvarProduto(string codigoBarras, string nome, string descricao, int idUnidade, int idCategoria, int estoqueMinimo, int estoqueAtual,
			decimal valorCompra, decimal valorVenda, decimal margem, bool situacao, string anotacoes, DateTime dataCadastro)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("INSERT INTO Produtos (Codigo_Barras_Produto, Nome_Produto, Descricao_Produto, Id_Unidade, Id_Categoria, ");
					sql.Append("Estoque_Minimo, Estoque_Atual, Valor_Compra, Valor_Venda, Margem, Situacao_Produto, Anotacoes_Produto, Data_Cadastro_Produto) ");

					sql.Append("VALUES (@codigoBarras, @nome, @descricao, @idUnidade, @idCategoria, @estoqueMinimo, @estoqueAtual, @valorCompra, ");
					sql.Append("@valorVenda, @margem, @situacao, @anotacoes, @dataCadastro)");

					comandoSql.Parameters.Add(new SqlParameter("@codigoBarras", codigoBarras));
					comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
					comandoSql.Parameters.Add(new SqlParameter("@descricao", descricao));
					comandoSql.Parameters.Add(new SqlParameter("@idUnidade", idUnidade));
					comandoSql.Parameters.Add(new SqlParameter("@idCategoria", idCategoria));
					comandoSql.Parameters.Add(new SqlParameter("@estoqueMinimo", estoqueMinimo));
					comandoSql.Parameters.Add(new SqlParameter("@estoqueAtual", estoqueAtual));
					comandoSql.Parameters.Add(new SqlParameter("@valorCompra", valorCompra));
					comandoSql.Parameters.Add(new SqlParameter("@valorVenda", valorVenda));
					comandoSql.Parameters.Add(new SqlParameter("@margem", margem));
					comandoSql.Parameters.Add(new SqlParameter("@situacao", situacao));
					comandoSql.Parameters.Add(new SqlParameter("@anotacoes", anotacoes));
					comandoSql.Parameters.Add(new SqlParameter("@dataCadastro", dataCadastro));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método SalvarProduto, Caso o problema persista, entre em contato com o Administrador do sistema");
			}
		}
	}
}
