using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CriptoCoinApi.Repositorio
{
    public class DAO
    {
        string connectionString = "Data Source=localhost;Initial Catalog=Criptocoin;User ID=Criptocoin;Password=Cr1ptoC01n;Integrated Security=true;";

        public SqlConnection getConnection(){
            SqlConnection cnx = new SqlConnection(connectionString);
            return cnx;
        }
    }
}