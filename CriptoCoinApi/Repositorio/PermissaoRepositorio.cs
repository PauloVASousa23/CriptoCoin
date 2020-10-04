using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CriptoCoinApi.Models;

namespace CriptoCoinApi.Repositorio
{
    public class PermissaoRepositorio
    {
        DAO dao = new DAO();
        public bool inserirPermissao(Permissao permissao)
        {
            String query = "INSERT INTO Permissao VALUES(@PermissaoUsuario,@Descricao)";
            using(SqlConnection cnx = dao.getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@PermissaoUsuario", permissao.PermissaoUsuario);
                cmd.Parameters.AddWithValue("@Descricao", permissao.Descricao);

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

        public Permissao selecionarPermissao(int id)
        {
            string query = "SELECT * FROM Permissao WHERE Id = @Id";
            using(SqlConnection cnx = dao.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cnx.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    Permissao permissao = new Permissao();
                    while (reader.Read())
                    {
                        permissao.Id = (int) reader[0];
                        permissao.PermissaoUsuario = reader[1].ToString();
                        permissao.Descricao = reader[2].ToString();
                    }

                    return permissao;
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

        public List<Permissao> selecionarPermissoes()
        {
            string query = "SELECT * FROM Permissao";
            using (SqlConnection cnx = dao.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cnx);

                    cnx.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Permissao> listaPermissao = new List<Permissao>();

                    while (reader.Read())
                    {
                        Permissao permissao = new Permissao();
                        permissao.Id = (int)reader[0];
                        permissao.PermissaoUsuario = reader[1].ToString();
                        permissao.Descricao = reader[2].ToString();
                        listaPermissao.Add(permissao);
                    }

                    return listaPermissao;
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

        public bool deletarPermissao(int id)
        {
            string query = "DELETE FROM Permissao WHERE Id = @Id";
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