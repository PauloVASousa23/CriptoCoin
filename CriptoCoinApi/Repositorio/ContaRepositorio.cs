using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using CriptoCoinApi.Models;

namespace CriptoCoinApi.Repositorio
{
    public class ContaRepositorio
    {
        DAO dao = new DAO();
        public bool inserirConta(Conta conta)
        {
            String query = "INSERT INTO Conta VALUES(@Numero,@Agencia,@Banco,@Saldo)";

            using (SqlConnection cnx = dao.getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@Numero", conta.Conta_Numero);
                cmd.Parameters.AddWithValue("@Agencia", conta.Conta_Agencia);
                cmd.Parameters.AddWithValue("@Banco", conta.Banco);
                cmd.Parameters.AddWithValue("@Saldo", conta.Saldo);

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

        public Conta selecionarConta(int id)
        {
            string query = "SELECT * FROM Conta WHERE Id = @Id";
            using (SqlConnection cnx = dao.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cnx.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    Conta conta = new Conta();
                    while (reader.Read())
                    {
                        conta.Id = (int)reader[0];
                        conta.Conta_Numero = reader[1].ToString();
                        conta.Conta_Agencia = reader[2].ToString();
                        conta.Banco = reader[3].ToString();
                        conta.Saldo= float.Parse(reader[4].ToString());
                    }

                    return conta;
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

        public List<Conta> selecionarContas()
        {
            string query = "SELECT * FROM Conta";
            using (SqlConnection cnx = dao.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cnx);

                    cnx.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Conta> listaConta = new List<Conta>();

                    while (reader.Read())
                    {
                        Conta conta = new Conta();
                        conta.Id = (int)reader[0];
                        conta.Conta_Numero = reader[1].ToString();
                        conta.Conta_Agencia = reader[2].ToString();
                        conta.Banco = reader[3].ToString();
                        conta.Saldo = float.Parse(reader[4].ToString());
                        listaConta.Add(conta);
                    }

                    return listaConta;
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


        public bool deletarConta(int id)
        {
            string query = "DELETE FROM Conta WHERE Id = @Id";
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