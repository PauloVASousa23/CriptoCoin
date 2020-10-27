﻿using System;
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
            String query = "INSERT INTO Perfil VALUES(@Nome,@Senha,@Email,@Telefone,@Rg,@Cpf,@Cep,@Cidade,@Bairro,@Endereco,@Agencia,@Permissao, 0)";
            using (SqlConnection cnx = dao.getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@Nome", perfil.Nome);
                cmd.Parameters.AddWithValue("@Senha", perfil.Senha);
                cmd.Parameters.AddWithValue("@Email", perfil.Email);
                cmd.Parameters.AddWithValue("@Telefone", perfil.Telefone);
                cmd.Parameters.AddWithValue("@Rg", perfil.Rg);
                cmd.Parameters.AddWithValue("@Cpf", perfil.Cpf);
                cmd.Parameters.AddWithValue("@Cep", perfil.Cep);
                cmd.Parameters.AddWithValue("@Cidade", perfil.Cidade);
                cmd.Parameters.AddWithValue("@Bairro", perfil.Bairro);
                cmd.Parameters.AddWithValue("@Endereco", perfil.Endereco);
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
                        perfil.Telefone= reader[4].ToString();
                        perfil.Rg= reader[5].ToString();
                        perfil.Cpf= reader[6].ToString();
                        perfil.Cep= reader[7].ToString();
                        perfil.Cidade= reader[8].ToString();
                        perfil.Bairro= reader[9].ToString();
                        perfil.Endereco= reader[10].ToString();
                        perfil.Agencia = (int)reader[11];
                        perfil.Permissao = (int) reader[12];
                        perfil.Saldo = float.Parse(reader[13].ToString());
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

        public Perfil autenticarPerfil(string email, string senha)
        {
            string query = "SELECT * FROM Perfil WHERE Email = @Id AND Senha=@Senha";
            using (SqlConnection cnx = dao.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.Parameters.AddWithValue("@Id", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    cnx.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    Perfil perfil = new Perfil();
                    while (reader.Read())
                    {
                        perfil.Id = (int)reader[0];
                        perfil.Nome = reader[1].ToString();
                        perfil.Senha = reader[2].ToString();
                        perfil.Email = reader[3].ToString();
                        perfil.Telefone = reader[4].ToString();
                        perfil.Rg = reader[5].ToString();
                        perfil.Cpf = reader[6].ToString();
                        perfil.Cep = reader[7].ToString();
                        perfil.Cidade = reader[8].ToString();
                        perfil.Bairro = reader[9].ToString();
                        perfil.Endereco = reader[10].ToString();
                        perfil.Agencia = (int)reader[11];
                        perfil.Permissao = (int)reader[12];
                        perfil.Saldo = float.Parse(reader[13].ToString());
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
                        perfil.Telefone = reader[4].ToString();
                        perfil.Rg = reader[5].ToString();
                        perfil.Cpf = reader[6].ToString();
                        perfil.Cep = reader[7].ToString();
                        perfil.Cidade = reader[8].ToString();
                        perfil.Bairro = reader[9].ToString();
                        perfil.Endereco = reader[10].ToString();
                        perfil.Agencia = (int)reader[11];
                        perfil.Permissao = (int)reader[12];
                        perfil.Saldo = float.Parse(reader[13].ToString());
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

        public List<Perfil> selecionarPerfis(int id)
        {
            string query = "SELECT * FROM Perfil WHERE Agencia=@Id";
            using (SqlConnection cnx = dao.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.Parameters.AddWithValue("@Id",id);

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
                        perfil.Telefone = reader[4].ToString();
                        perfil.Rg = reader[5].ToString();
                        perfil.Cpf = reader[6].ToString();
                        perfil.Cep = reader[7].ToString();
                        perfil.Cidade = reader[8].ToString();
                        perfil.Bairro = reader[9].ToString();
                        perfil.Endereco = reader[10].ToString();
                        perfil.Agencia = (int)reader[11];
                        perfil.Permissao = (int)reader[12];
                        perfil.Saldo = float.Parse(reader[13].ToString());
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

        public List<Perfil> selecionarPerfis(String id)
        {
            string query = "SELECT * FROM Perfil WHERE Id IN(" + id + ")";
            using (SqlConnection cnx = dao.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.Parameters.AddWithValue("@Id", id);

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
                        perfil.Telefone = reader[4].ToString();
                        perfil.Rg = reader[5].ToString();
                        perfil.Cpf = reader[6].ToString();
                        perfil.Cep = reader[7].ToString();
                        perfil.Cidade = reader[8].ToString();
                        perfil.Bairro = reader[9].ToString();
                        perfil.Endereco = reader[10].ToString();
                        perfil.Agencia = (int)reader[11];
                        perfil.Permissao = (int)reader[12];
                        perfil.Saldo = float.Parse(reader[13].ToString());
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
        public bool atualizarPerfil(Perfil perfil)
        {
            string query = "UPDATE Perfil SET Nome=@Nome, Email=@Email,Telefone=@Telefone, Cep=@Cep, Cidade=@Cidade, Bairro=@Bairro, Endereco=@Endereco, Saldo=@Saldo WHERE Id=@Id";
            using (SqlConnection cnx = dao.getConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, cnx);
                    cmd.Parameters.AddWithValue("@Id", perfil.Id);
                    cmd.Parameters.AddWithValue("@Nome", perfil.Nome);
                    cmd.Parameters.AddWithValue("@Email", perfil.Email);
                    cmd.Parameters.AddWithValue("@Telefone", perfil.Telefone);
                    cmd.Parameters.AddWithValue("@Cep", perfil.Cep);
                    cmd.Parameters.AddWithValue("@Cidade", perfil.Cidade);
                    cmd.Parameters.AddWithValue("@Bairro", perfil.Bairro);
                    cmd.Parameters.AddWithValue("@Endereco", perfil.Endereco);
                    cmd.Parameters.AddWithValue("@Saldo", perfil.Saldo);

                    cnx.Open();
                    int i = 0;

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