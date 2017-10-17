using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;
using FluentDb;
using System.Linq;

namespace FluentDb.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var con = new SqliteConnection("Data Source=:memory:"))
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.SetCommandText("Create Table TestTable(A,B)")
                        .ExecuteNonQuery();

                    cmd.SetCommandText("insert into TestTable(A,B) values(@A,@B)")
                        .AddParameters(new { A = "sdfs", B = "sdfsdf" })
                        .ExecuteNonQuery();

                    var rows = cmd.SetCommandText("select A, B from TestTable")
                        .ExecuteReader(r => new { A = r["A"], B = r["B"] })
                        .ToArray();
                }
            }
        }
    }
}
