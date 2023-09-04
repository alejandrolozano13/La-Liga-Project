using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaLiga
{
    public class RepositorioBanco : IRepositorio
    {       
        public void AtualizarTime(Time time)
        {
            throw new NotImplementedException();
        }

        public void CriarNovoTime(Time time)
        {
            var conexao = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings
            ["TimeConexao"].ToString());

            string sql = "INSERT INTO Times (NomeDoTime, DataFundacao, Imagem_Time)" +
                "VALUES (@NomeDoTime, @DataFundacao, @Imagem_Time)";

            SqlCommand comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@NomeDoTime", time.NomeDoTime);
            comando.Parameters.AddWithValue("@DataFundacao", time.AnoDeFundacaoDoTime);
            comando.Parameters.AddWithValue("@Imagem_Time", time.ImagemTime);

            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public Time ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Time> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void RemoverTime(int id)
        {
            throw new NotImplementedException();
        }
    }
}
