using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Master
/// </summary>
public class Master
{
    public SqlConnection cnn = new SqlConnection();
    public SqlDataReader reg;

    public void ini()
    {
        cnn.ConnectionString = (@"Data Source=PC06-SALA1;Initial Catalog=autos;Integrated Security=True");
        cnn.Open();
    }
    public void fin()
    {
        cnn.Close();
    }
    public void envia(string texto)
    {
        SqlCommand con = new SqlCommand(texto, cnn);
        con.ExecuteNonQuery();
    }
    public SqlDataReader recibe(string texto)
    {
        SqlCommand con = new SqlCommand(texto, cnn);
        con.ExecuteNonQuery();
        reg = con.ExecuteReader();
        return reg;
    }

}