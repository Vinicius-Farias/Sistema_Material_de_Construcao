using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.ClienteBanco.SaveCliente
{
	public class SavePessoaJuridicaAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void SavePessoaJuridica(int idCliente, string cnpj, string ie)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("INSERT INTO Pessoa_Juridica (Id_Cliente, Cnpj_Cliente, Ie_Cliente) ");
					sql.Append("VALUES (@idCliente, @cnpj, @ie)");

					comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));
					comandoSql.Parameters.Add(new SqlParameter("@cnpj", cnpj));
					comandoSql.Parameters.Add(new SqlParameter("@ie", ie));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método SavePessoaJuridica, Caso o problema persista, entre em contato com o Administrador do sistema");
			}
		}
	}
}
