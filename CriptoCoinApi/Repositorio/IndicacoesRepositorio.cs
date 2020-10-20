using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using CriptoCoinApi.Models;

namespace CriptoCoinApi.Repositorio
{
    public class IndicacoesRepositorio
    {
        DAO dao = new DAO();
        public bool inserirIndicacoes(Indicacoes indicacoes)
        {
            String query = "INSERT INTO Indicacoes VALUES(@Criptomoeda,@Motivo,@DataIndicacao,@PerfilAgencia)";
            using (SqlConnection cnx = dao.getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@Criptomoeda", indicacoes.Criptomoeda);
                cmd.Parameters.AddWithValue("@Motivo", indicacoes.Motivo);
                cmd.Parameters.AddWithValue("@DataIndicacao", indicacoes.Data_Indicacao);
                cmd.Parameters.AddWithValue("@PerfilAgencia", indicacoes.Perfil_Agencia);

                try
                {
                    int i = 0;
                    cnx.Open();
                    i = cmd.ExecuteNonQuery();

                    return i > 0;
                }
                catch (Exception e)
                {
                    //TODO LOG
                    Console.WriteLine(e);
                }
                finally
                {
                    cnx.Close();
                }
            }

            return false;
        }

        public List<Indicacoes> selecionarIndicacao(int id)
        {
            string query = "SELECT * FROM Indicacoes WHERE Perfil_Agencia = @Id";
            using (SqlConnection cnx = dao.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cnx.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Indicacoes> indicacoes = new List<Indicacoes>();
                    while (reader.Read())
                    {
                        Indicacoes indicacao = new Indicacoes();
                        indicacao.Id = (int)reader[0];
                        indicacao.Criptomoeda= reader[1].ToString();
                        indicacao.Motivo = reader[2].ToString();
                        indicacao.Data_Indicacao = reader[3].ToString();
                        indicacao.Perfil_Agencia = (int) reader[4];
                        indicacoes.Add(indicacao);
                    }

                    return indicacoes;
                }
                catch (Exception e)
                {

                }
                finally
                {
                    cnx.Close();
                }
                return null;
            }
        }

        public List<Indicacoes> selecionarIndicacoes()
        {
            string query = "SELECT * FROM Indicacoes";
            using (SqlConnection cnx = dao.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cnx);

                    cnx.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Indicacoes> listaIndicacoes = new List<Indicacoes>();

                    while (reader.Read())
                    {
                        Indicacoes indicacao = new Indicacoes();
                        indicacao.Id = (int)reader[0];
                        indicacao.Criptomoeda = reader[1].ToString();
                        indicacao.Motivo = reader[2].ToString();
                        indicacao.Data_Indicacao = reader[3].ToString();
                        indicacao.Perfil_Agencia = (int)reader[4];
                        listaIndicacoes.Add(indicacao);
                    }

                    return listaIndicacoes;
                }
                catch (Exception e)
                {

                }
                finally
                {
                    cnx.Close();
                }
                return null;
            }
        }

        public bool deletarIndicacao(int id)
        {
            string query = "DELETE FROM Indicacoes WHERE Id = @Id";
            using (SqlConnection cnx = dao.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.Parameters.AddWithValue("@Id", id);

                    int i = 0;
                    cnx.Open();

                    i = cmd.ExecuteNonQuery();

                    return i > 0;
                }
                catch (Exception e)
                {

                }
                finally
                {
                    cnx.Close();
                }
                return false;
            }
        }

    }
}