using System;
using System.Data;
using System.Net;
using System.Dynamic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;



namespace Proyecto_Integral.Models
{
    public class BD
    {
        private static string server = Dns.GetHostName();
        private static string _connectionString = @$"Server={server};DataBase=TpFinal;Trusted_Connection=True;";       
    }
}