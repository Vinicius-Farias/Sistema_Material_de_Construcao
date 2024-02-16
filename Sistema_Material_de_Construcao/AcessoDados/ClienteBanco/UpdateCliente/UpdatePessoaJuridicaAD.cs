using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.ClienteBanco.UpdateCliente
{
	public class UpdatePessoaJuridicaAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void AlteraPessoaJuridica(int idCliente, string cnpj, string ie)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("UPDATE Pessoa_Juridica ");
					sql.Append("SET Cnpj_Cliente = @cnpj, Ie_Cliente = @ie ");
					sql.Append("WHERE Id_Cliente = @idCliente");

					comandoSql.Parameters.Add(new SqlParameter("@cnpj", cnpj));
					comandoSql.Parameters.Add(new SqlParameter("@ie", ie));
					comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método AlteraPessoaJuridica. Caso o problema persista. entre em contato com o Administrador do Sistema");
			}
		}
	}
}
