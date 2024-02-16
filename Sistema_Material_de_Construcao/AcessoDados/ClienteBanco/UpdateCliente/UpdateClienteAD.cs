using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.ClienteBanco.UpdateCliente
{
	public class UpdateClienteAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void AlteraCliente(int idCliente, string nome, string endereco, string bairro, string cep, string cidade, string estado, string telefone1, string telefone2,
			string email, DateTime dataCadastro, DateTime nascimento, string observacoes)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("UPDATE Cliente ");
					sql.Append("SET Nome_Cliente = @nome, Endereco_Cliente = @endereco, Bairro_Cliente = @bairro, Cep_Cliente = @cep, Cidade_Cliente = @cidade, ");
					sql.Append("Estado_Cliente = @estado, Telefone1_Cliente = @telefone1, Telefone2_Cliente = @telefone2, Email_Cliente = @email, ");
					sql.Append("Data_Cadastro_Cliente = @dataCadastro, Nascimento_Cliente = @nascimento, Observacoes_Cliente = @observacoes ");

					sql.Append("WHERE Id_Cliente = @idCliente");

					comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
					comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
					comandoSql.Parameters.Add(new SqlParameter("@bairro", bairro));
					comandoSql.Parameters.Add(new SqlParameter("@cep", cep));
					comandoSql.Parameters.Add(new SqlParameter("@cidade", cidade));
					comandoSql.Parameters.Add(new SqlParameter("@estado", estado));
					comandoSql.Parameters.Add(new SqlParameter("@telefone1", telefone1));
					comandoSql.Parameters.Add(new SqlParameter("@telefone2", telefone2));
					comandoSql.Parameters.Add(new SqlParameter("@email", email));
					comandoSql.Parameters.Add(new SqlParameter("@dataCadastro", dataCadastro));
					comandoSql.Parameters.Add(new SqlParameter("@nascimento", nascimento));
					comandoSql.Parameters.Add(new SqlParameter("@observacoes", observacoes));
					comandoSql.Parameters.Add(new SqlParameter("@idCliente", idCliente));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método AlteraCliente. Caso o problema persista. entre em contato com o Administrador do Sistema");
			}
		}
	}
}
