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


         public static List <Peliculas> ListarPeliculas()
         {
             List <Peliculas> _ListaPeliculas = new List<Peliculas>();
             using(SqlConnection db = new SqlConnection(_connectionString))
             {
                string sql = "SELECT * FROM Peliculas";
                _ListaPeliculas = db.Query<Peliculas>(sql).ToList();
             }

               return _ListaPeliculas;

            }


           public static List <Series> ListarSeries()
         {
             List <Series> _ListaSeries = new List<Series>();
             using(SqlConnection db = new SqlConnection(_connectionString))
             {
                string sql = "SELECT * FROM Series";
                _ListaSeries = db.Query<Series>(sql).ToList();
             }

               return _ListaSeries;

            }

               public static Peliculas PeliculaMasExitosa(){

                Peliculas peliculaExitosa;
              
                string sql = "select top 1 Peliculas.* from Estadisticas inner join  Peliculas on Estadisticas.IdPelicula = Peliculas.IdPelicula order by Visualizaciones desc";
                using(SqlConnection db = new SqlConnection(_connectionString)){
                      
                      peliculaExitosa = db.QueryFirstOrDefault<Peliculas>(sql);
                    }
                    return peliculaExitosa;
            }






    }
}