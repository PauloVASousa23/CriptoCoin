using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using CriptoCoinApi.Models;

namespace CriptoCoinApi.Repositorio
{
    public class PerfilRepositorio
    {
        DAO dao = new DAO();
        public bool inserirPerfil(Perfil perfil)
        {
            String query = "INSERT INTO Perfil VALUES(@Nome,@Senha,@Email,@Rg,@Cpf,@Cep,@Cidade,@Bairro,@Endereco,@Conta,@Agencia,@Permissao)";
            using (SqlConnection cnx = dao.getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@Nome", perfil.Nome);
                cmd.Parameters.AddWithValue("@Senha", perfil.Senha);
                cmd.Parameters.AddWithValue("@Email", perfil.Email);
                cmd.Parameters.AddWithValue("@Rg", perfil.Rg);
                cmd.Parameters.AddWithValue("@Cpf", perfil.Cpf);
                cmd.Parameters.AddWithValue("@Cep", perfil.Cep);
                cmd.Parameters.AddWithValue("@Cidade", perfil.Cidade);
                cmd.Parameters.AddWithValue("@Bairro", perfil.Bairro);
                cmd.Parameters.AddWithValue("@Endereco", perfil.Endereco);
                cmd.Parameters.AddWithValue("@Conta", perfil.Conta);
                cmd.Parameters.AddWithValue("@Agencia", perfil.Agencia);
                cmd.Parameters.AddWithValue("@Permissao", perfil.Permissao);

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

        public Perfil selecionarPerfil(int id)
        {
            string query = "SELECT * FROM Perfil WHERE Id = @Id";
            using (SqlConnection cnx = dao.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cnx.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    Perfil perfil = new Perfil();
                    while (reader.Read())
                    {
                        perfil.Id = (int)reader[0];
                        perfil.Nome = reader[1].ToString();
                        perfil.Senha= reader[2].ToString();
                        perfil.Email= reader[3].ToString();
                        perfil.Rg= reader[4].ToString();
                        perfil.Cpf= reader[5].ToString();
                        perfil.Cep= reader[6].ToString();
                        perfil.Cidade= reader[7].ToString();
                        perfil.Bairro= reader[8].ToString();
                        perfil.Endereco= reader[9].ToString();
                        perfil.Conta = (int) reader[10];
                        perfil.Agencia = reader[11].ToString();
                        perfil.Permissao = (int) reader[12];
                    }

                    return perfil;
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

        public List<Perfil> selecionarPerfis()
        {
            string query = "SELECT * FROM Perfil";
            using (SqlConnection cnx = dao.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cnx);

                    cnx.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Perfil> listaPerfil = new List<Perfil>();

                    while (reader.Read())
                    {
                        Perfil perfil = new Perfil();
                        perfil.Id = (int)reader[0];
                        perfil.Nome = reader[1].ToString();
                        perfil.Senha = reader[2].ToString();
                        perfil.Email = reader[3].ToString();
                        perfil.Rg = reader[4].ToString();
                        perfil.Cpf = reader[5].ToString();
                        perfil.Cep = reader[6].ToString();
                        perfil.Cidade = reader[7].ToString();
                        perfil.Bairro = reader[8].ToString();
                        perfil.Endereco = reader[9].ToString();
                        perfil.Conta = (int)reader[10];
                        perfil.Agencia = reader[11].ToString();
                        perfil.Permissao = (int)reader[12];
                        listaPerfil.Add(perfil);
                    }

                    return listaPerfil;
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

        public bool deletarPerfil(int id)
        {
            string query = "DELETE FROM Perfil WHERE Id = @Id";
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