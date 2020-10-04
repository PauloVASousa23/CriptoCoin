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
            String query = "INSERT INTO Carteira VALUES(@Perfil,@Criptomoeda,@ValorCompra,@ValorVenda,@DataCompra,@DataVenda)";
            using (SqlConnection cnx = dao.getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@Perfil", carteira.Perfil);
                cmd.Parameters.AddWithValue("@Criptomoeda", carteira.Criptomoeda);
                cmd.Parameters.AddWithValue("@ValorCompra", carteira.Valor_Compra);
                cmd.Parameters.AddWithValue("@ValorVenda", carteira.Valor_Venda);
                cmd.Parameters.AddWithValue("@DataCompra", carteira.Data_Compra);
                cmd.Parameters.AddWithValue("@DataVenda", carteira.Data_Venda);

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

        public Carteira selecionarCarteira(int id)
        {
            string query = "SELECT * FROM Carteira WHERE Id = @Id";
            using (SqlConnection cnx = dao.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cnx.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    Carteira carteira = new Carteira();
                    while (reader.Read())
                    {
                        carteira.Id = (int)reader[0];
                        carteira.Perfil= (int) reader[1];
                        carteira.Criptomoeda = reader[2].ToString();
                        carteira.Valor_Compra = float.Parse(reader[3].ToString());
                        carteira.Valor_Venda = float.Parse(reader[4].ToString());
                        carteira.Data_Compra = (DateTime) reader[5];
                        carteira.Data_Venda = (DateTime)reader[6];
                    }

                    return carteira;
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
                        carteira.Valor_Compra = float.Parse(reader[3].ToString());
                        carteira.Valor_Venda = float.Parse(reader[4].ToString());
                        carteira.Data_Compra = (DateTime)reader[5];
                        carteira.Data_Venda = (DateTime)reader[6];
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