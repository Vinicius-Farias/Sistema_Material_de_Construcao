using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.ClienteBanco.SaveCliente
{
	public class SaveClienteAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void SaveCliente(string nome, string endereco, string bairro, string cep, string cidade, string estado, string telefone1, string telefone2,
			string email, DateTime dataCadastro, DateTime nascimento, string observacoes)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("INSERT INTO Cliente (Nome_Cliente, Endereco_Cliente, Bairro_Cliente, Cep_Cliente, Cidade_Cliente, Estado_Cliente, ");
					sql.Append("Telefone1_Cliente, Telefone2_Cliente, Email_Cliente, Data_Cadastro_Cliente, Nascimento_Cliente, Observacoes_Cliente) ");
					sql.Append("VALUES (@nome, @endereco, @bairro, @cep, @cidade, @estado, @telefone1, @telefone2, @email, @dataCadastro, @nascimento, observacoes)");

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

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();

				}

			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método SaveCliente, Caso o problema persista, entre em contato com o Administrador do sistema");
			}
		}
	}
}
