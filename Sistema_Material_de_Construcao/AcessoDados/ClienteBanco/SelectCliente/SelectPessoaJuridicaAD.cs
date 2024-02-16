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
	public class SelectPessoaJuridicaAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();
		DataTable dadosTabela = new DataTable();

		public DataTable ListaPessoaJuridica(int idCliente)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT Cnpj_Cliente, Ie_Cliente FROM Pessoa_Juridica");
					sql.Append("WHERE Id_Cliente = @idCliente");

					comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método ListaPessoaJuridica. Caso o problema persista, entre em contato com o Administrador do Sitema.");
			}
		}
	}
}
