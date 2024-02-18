using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.ProdutosBanco.UpdateProduto
{
	public class UpdateProdutoAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void AlterarProduto(int idProduto, string codigoBarras, string nome, string descricao, int idUnidade, int idCategoria, int estoqueMinimo,
			 int estoqueAtual, decimal valorCompra, decimal valorVenda, decimal margem, bool situacao, string anotacoes, DateTime dataCadastro) 
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("UPDATE Produtos ");
					sql.Append("SET Codigo_Barras_Produto = @codigoBarras, Nome_Produto = @nome, Descricao_Produto = @descricao, Id_Unidade = @idUnidade, ");
					sql.Append("Id_Categoria = @idCategoria, Estoque_Minimo = @estoqueMinimo, Estoque_Atual = @estoqueAtual, Valor_Compra = @valorCompra, ");
					sql.Append("Valor_Venda = @valorVenda, Margem = @margem, Situacao_Produto = @situacao, ");
					sql.Append("Anotacoes_Produto = @anotacoes, Data_Cadastro_Produto = @dataCadastro");

					sql.Append("WHERE Id_Produto = @idProduto");

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
					comandoSql.Parameters.Add(new SqlParameter("@idProduto", idProduto));
					comandoSql.Parameters.Add(new SqlParameter("@dataCadastro", dataCadastro));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método AlterarProduto. Caso o problema persista. entre em contato com o Administrador do Sistema");
			}
		}
	}
}
