using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.ClienteBanco.SaveCliente
{
	public class SavePessoaFisicaAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void SavePessoaFisica(int idCliente, string cpf, string rg)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("INSERT INTO Pessoa_Fisica (Id_Cliente, Cpf_Cliente, Rg_Cliente) ");
					sql.Append("VALUES (@idCliente, @cpf, @rg)");

					comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));
					comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
					comandoSql.Parameters.Add(new SqlParameter("@rg", rg));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método SavePessoaFisica, Caso o problema persista, entre em contato com o Administrador do sistema");
			}
		}
		
	}
}
