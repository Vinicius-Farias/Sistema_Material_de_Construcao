﻿using AcessoDados.ConectionBanco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.FuncionarioBanco.SelectFuncionario
{
	public class PesquisarCpfFuncionarioAD
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();
		DataTable dadosTabela = new DataTable();

		public DataTable PesquisaCpfFuncionario(string cpf)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT * FROM Funcionario ");
					sql.Append("WHERE Cpf_Funcionario LIKE '%'+@cpf+'%' ");
					sql.Append("ORDER BY Id_Funcionario DESC");

					comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;

				}
			}
			catch (Exception)
			{

				throw new Exception("Ocorreu um erro no método PesquisarCpfFuncionario. Caso o problema persista. entre em contato com o Administrador do Sistema");
			}
		}
	}
}
