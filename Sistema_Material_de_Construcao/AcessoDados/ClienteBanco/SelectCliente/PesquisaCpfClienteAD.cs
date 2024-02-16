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
	public class PesquisaCpfClienteAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();
		DataTable dadosTabela = new DataTable();

		public DataTable PesquisaCpfCliente(string cpf)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT Cliente.*, Pessoa_Fisica.* FROM Cliente INNER JOIN Pessoa_Fisica ");
					sql.Append("ON Cliente.Id_Cliente = Pessoa_Fisica.Id_Cliente ");
					sql.Append("WHERE Cpf_Cliente LIKE '%'+@cpf+'%' ");
					sql.Append("ORDER BY Nome_Cliente ASC");

					comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método PesquisaCpfCliente. Caso o problema persista. entre em contato com o Administrador do Sistema");
			}
		}
	}
}
