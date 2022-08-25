using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AulasWEB.Models
{
   public class Conexao : IDisposable
   {
      public MySqlConnection conn;
      private readonly string host = "";
      private readonly string port = "";
      private readonly string db = "";
      private readonly string user = "";
      private readonly string pass = "";

      private void Conectar()
      {
         string StrConn = "";
         StrConn = "Server=" + host + "; Port=" + port + "; Database=" + db + "; Uid=" + user + "; Pwd=" + pass + ";  ";
         conn = new MySqlConnection(StrConn);
         try
         {
            conn.Open();
         }
         catch (Exception)
         {
            throw;
         }
      }

      public Conexao()
      {
         Conectar();
      }

      public void Dispose()
      {
         conn.Close();
         conn.Dispose();
      }
   }
}