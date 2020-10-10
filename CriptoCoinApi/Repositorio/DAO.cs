using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CriptoCoinApi.Repositorio
{
    public class DAO
    {
        //string connectionString = "Data Source=liviastore.database.windows.net;Initial Catalog=LiviaStore;User ID=Livia;Password=P@ulo2018;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";

        string connectionString = "Data Source=criptocoin.database.windows.net;Initial Catalog=Criptocoin;User ID=criptocoin;Password=Cr1ptoC01n;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public SqlConnection getConnection(){
            SqlConnection cnx = new SqlConnection(connectionString);
            return cnx;
        }
    }
}