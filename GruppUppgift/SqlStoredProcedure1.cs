using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void SqlStoredProcedure1 ()
    {
        SqlConnection conn = new SqlConnection();
        conn.ConnectionString = "Context Connection=true";

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        conn.Open();
        cmd.CommandText= "SELECT  COUNT(characterID), class FROM dbo.characterr JOIN dbo.class ON characterr.classID = class.classID GROUP BY class";

        SqlDataReader sqdr = cmd.ExecuteReader();
        SqlContext.Pipe.Send(sqdr);

        sqdr.Close();
        conn.Close();
    }
}
/**/
