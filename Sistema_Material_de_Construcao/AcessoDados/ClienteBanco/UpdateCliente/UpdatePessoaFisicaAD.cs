using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.ClienteBanco.UpdateCliente
{
	public class UpdatePessoaFisicaAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void AlteraPessoaFisica(int idCliente, string cpf, string rg)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("UPDATE Pessoa_Fisica ");
					sql.Append("SET Cpf_Cliente = @cpf, Rg_Cliente = @rg ");
					sql.Append("WHERE Id_Cliente = @idCliente");

					comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));
					comandoSql.Parameters.Add(new SqlParameter("@rg", rg));
					comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método AlteraPessoaFisica. Caso o problema persista. entre em contato com o Administrador do Sistema");
			}
		}
	}
}
