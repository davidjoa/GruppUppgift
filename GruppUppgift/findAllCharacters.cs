using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void findAllCharacters (string firstLetter)
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString= "Context Connection=true";

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        conn.Open();
        cmd.CommandText = "SELECT characterr.characterName FROM characterr WHERE characterr.characterName LIKE @firstLetter + '%'";
        SqlParameter paramfirstLetter = new SqlParameter();
        paramfirstLetter.Value = firstLetter;
        paramfirstLetter.Direction = ParameterDirection.Input;
        paramfirstLetter.DbType = DbType.String;
        paramfirstLetter.ParameterName = "@firstLetter";
        cmd.Parameters.Add(paramfirstLetter);

        SqlDataReader sqdr = cmd.ExecuteReader();
        SqlContext.Pipe.Send(sqdr);

        sqdr.Close();
        conn.Close();
    }
}
