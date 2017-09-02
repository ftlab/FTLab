using FTCli;
using System;
using System.Data.SqlClient;

namespace FTTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cli.WriteLine("Hello");
            Cli.WriteLine(new { Hello = "World" });
            Cli.WriteLine(new Exception());

            foreach (var line in Cli.ConsumeLines((line) => line == "q"))
            {
                Cli.WriteLine(line);
            }
        }
    }
}
