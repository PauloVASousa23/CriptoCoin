using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using CriptoCoinApi.Models;

namespace CriptoCoinApi.Repositorio
{
    public class CarteiraRepositorio
    {
        DAO dao = new DAO();
        public bool inserirCarteira(Carteira carteira)
        {
            String query = "INSERT INTO Carteira VALUES(@Perfil,@Criptomoeda,@Valor,@Data,@Operacao)";
            using (SqlConnection cnx = dao.getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@Perfil", carteira.Perfil);
                cmd.Parameters.AddWithValue("@Criptomoeda", carteira.Criptomoeda);
                cmd.Parameters.AddWithValue("@Valor", carteira.Valor);
                cmd.Parameters.AddWithValue("@Data", carteira.Data);
                cmd.Parameters.AddWithValue("@Operacao", carteira.Operacao);

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

        public List<Carteira> selecionarCarteira(int id)
        {
            string query = "SELECT * FROM Carteira WHERE Perfil = @Id";
            using (SqlConnection cnx = dao.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cnx.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Carteira> carteiras = new List<Carteira>();
                    while (reader.Read())
                    {
                        Carteira carteira = new Carteira();
                        carteira.Id = (int)reader[0];
                        carteira.Perfil= (int) reader[1];
                        carteira.Criptomoeda = reader[2].ToString();
                        carteira.Valor = float.Parse(reader[3].ToString());
                        carteira.Data = reader[4].ToString();
                        carteira.Operacao = reader[5].ToString();
                        carteiras.Add(carteira);
                    }

                    return carteiras;
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

        public List<Carteira> selecionarCarteiras()
        {
            string query = "SELECT * FROM Carteira";
            using (SqlConnection cnx = dao.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cnx);

                    cnx.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Carteira> listaCarteira = new List<Carteira>();

                    while (reader.Read())
                    {
                        Carteira carteira = new Carteira();
                        carteira.Id = (int)reader[0];
                        carteira.Perfil = (int)reader[1];
                        carteira.Criptomoeda = reader[2].ToString();
                        carteira.Valor = float.Parse(reader[3].ToString());
                        carteira.Data = reader[4].ToString();
                        carteira.Operacao = reader[5].ToString();
                        listaCarteira.Add(carteira);
                    }

                    return listaCarteira;
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

        public bool deletarCarteira(int id)
        {
            string query = "DELETE FROM Carteira WHERE Id = @Id";
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