using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.ClienteBanco.SelectCliente
{
	public class PesquisaCnpjClienteAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();
		DataTable dadosTabela = new DataTable();

		public DataTable PesquisaCnpjCliente(string cnpj)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT Cliente.*, Pessoa_Juridica.* FROM Cliente INNER JOIN Pessoa_Juridica ");
					sql.Append("ON Cliente.Id_Cliente = Pessoa_Juridica.Id_Cliente ");
					sql.Append("WHERE Cnpj_Cliente LIKE '%'+@cnpj+'%' ");
					sql.Append("ORDER BY Nome_Cliente ASC");

					comandoSql.Parameters.Add(new SqlParameter("@cnpj", cnpj));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método PesquisaCnpjCliente. Caso o problema persista. entre em contato com o Administrador do Sistema");
			}
		}
	}
}
