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

         
          // private static string _connectionString = @"Server=DESKTOP-P8MR2F6\SQLEXPRESS;
          // DataBase=TpFinal;Trusted_Connection=True;";



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

              public static Peliculas ObtenerPeliRandom(int cant)
         {
            Peliculas peliRandom = new Peliculas();
               Random random = new Random();
               int num = random.Next(1,13);
             using(SqlConnection db = new SqlConnection(_connectionString))
            
             {
                string sql = "SELECT * FROM Peliculas where Random =" + num;
                peliRandom = db.QueryFirstOrDefault<Peliculas>(sql);
             }

               return peliRandom;

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

            
         public static List <Reseñas> ListarReseñas(int id,bool tipo)
         {
             List <Reseñas> _ListaReseñas = new List<Reseñas>();
             string sql;
             if(tipo){
                   sql = "SELECT * FROM Reseñas where IdSerie = @serie";
             }else{
                   sql = "SELECT * FROM Reseñas where IdPelicula = @serie";
             }
                  
                     using(SqlConnection db = new SqlConnection(_connectionString))
                      {
                         _ListaReseñas = db.Query<Reseñas>(sql,new{serie = id}).ToList();
                      }

               return _ListaReseñas;

            }

               public static Peliculas PeliculaMasExitosa(){

                Peliculas peliculaExitosa;
              
                string sql = "select top 1 Peliculas.* from Estadisticas inner join  Peliculas on Estadisticas.IdPelicula = Peliculas.IdPelicula order by Visualizaciones desc";
                using(SqlConnection db = new SqlConnection(_connectionString)){
                      
                      peliculaExitosa = db.QueryFirstOrDefault<Peliculas>(sql);
                    }
                    return peliculaExitosa;
            }

               public static List<Peliculas> ObtenerPelisMasRecientes(){

                  List <Peliculas> ListaPeliculasRecientes = new List<Peliculas>();

                   string SQL = "SELECT top 3 * FROM Peliculas order by FechaEstreno desc";
                   using(SqlConnection db = new SqlConnection(_connectionString)){
                   ListaPeliculasRecientes = db.Query<Peliculas>(SQL).ToList();
            }

               return ListaPeliculasRecientes;
                  
               }
           
            public static List<Peliculas> BusquedaPersonalizadaPeliculas(string busc){

                  List <Peliculas> ListaResultados = new List<Peliculas>();

                  
                   string SQL = "SELECT * FROM Peliculas where Nombre like '" + busc + "%'";
                   using(SqlConnection db = new SqlConnection(_connectionString)){
                   ListaResultados = db.Query<Peliculas>(SQL).ToList();
                   }
            

               return ListaResultados;

                   }



              public static List<Series> BusquedaPersonalizadaSeries(string busc){

                  List <Series> ListaResultados = new List<Series>();

                  
                   string SQL = "SELECT * FROM Series where Nombre like '" + busc + "%'";
                   using(SqlConnection db = new SqlConnection(_connectionString)){
                   ListaResultados = db.Query<Series>(SQL).ToList();
                   }
            

               return ListaResultados;

                   }

               
              public static Peliculas ObtenerInfoPeliculas(int IdPelicula){
              Peliculas miPelicula;
                string SQL = "SELECT * FROM Peliculas WHERE IdPelicula = @a";
              using(SqlConnection db = new SqlConnection(_connectionString)){
                miPelicula = db.QueryFirstOrDefault<Peliculas>(SQL, new{a = IdPelicula});
            }
            return miPelicula;
        }

          public static Estadisticas ObtenerEstadisticasPeliculas(int IdPelicula){
              Estadisticas miEstadistica;
                string SQL = "SELECT * FROM Estadisticas WHERE IdPelicula = @a";
              using(SqlConnection db = new SqlConnection(_connectionString)){
                miEstadistica = db.QueryFirstOrDefault<Estadisticas>(SQL, new{a = IdPelicula});
            }
            return miEstadistica;
        }

            public static List<Peliculas> ObtenerPeliculaPorGenero(int genero){
                  
                List <Peliculas> _ListaPeliGenero = new List<Peliculas>();
                string sql;
                if(genero != 0)
                {
                     sql = "SELECT * FROM Peliculas where IdGenero = @b";
                     using(SqlConnection db = new SqlConnection(_connectionString))
                      {
                         _ListaPeliGenero = db.Query<Peliculas>(sql,new{b = genero}).ToList();
                      }
                }else{
                     sql = "SELECT * FROM Peliculas";
                     using(SqlConnection db = new SqlConnection(_connectionString))
                     {
                       _ListaPeliGenero = db.Query<Peliculas>(sql).ToList();
                      }
             }
               
            
               return _ListaPeliGenero;


            }


              public static List<Series> ObtenerSeriePorGenero(int genero){
                  
                List <Series> _ListaSerieGenero = new List<Series>();
                string sql;
                if(genero != 0)
                {
                     sql = "SELECT * FROM Series where IdGenero = @b";
                     using(SqlConnection db = new SqlConnection(_connectionString))
                      {
                         _ListaSerieGenero = db.Query<Series>(sql,new{b = genero}).ToList();
                      }
                }else{
                     sql = "SELECT * FROM Series";
                     using(SqlConnection db = new SqlConnection(_connectionString))
                     {
                       _ListaSerieGenero = db.Query<Series>(sql).ToList();
                      }
             }
               
            
               return _ListaSerieGenero;


            }
         
            public static List<Generos> ObtenerGeneros(){

                List <Generos> _ListaGeneros = new List<Generos>();
             using(SqlConnection db = new SqlConnection(_connectionString))
             {
                string sql = "SELECT * FROM Generos";
                _ListaGeneros = db.Query<Generos>(sql).ToList();
             }

               return _ListaGeneros;



            }

              public static Series ObtenerInfoSeries(int IdSerie){
              Series miSerie;
                string SQL = "SELECT * FROM Series WHERE IdSerie = @qh";
              using(SqlConnection db = new SqlConnection(_connectionString)){
                miSerie = db.QueryFirstOrDefault<Series>(SQL, new{qh = IdSerie});
            }
           System.Console.WriteLine(miSerie.Nombre); 
           System.Console.WriteLine(122);
            return miSerie;
        }

          public static Estadisticas ObtenerEstadisticasSeries(int IdSerie){
              Estadisticas miEstadistica;
                string SQL = "SELECT * FROM Estadisticas WHERE IdSerie = @y";
              using(SqlConnection db = new SqlConnection(_connectionString)){
                miEstadistica = db.QueryFirstOrDefault<Estadisticas>(SQL, new{y = IdSerie});
            }
            return miEstadistica;
        }

            public static void AgregarReseña(Reseñas Res){

              string SQL = "INSERT INTO Reseñas(IdPelicula, Contenido, Valoracion, NombreUsuario, Fecha, Foto) VALUES (@pIdPelicula, @pContenido, @pValoracion, @pNombreUsuario, @pFecha, @pFoto)";

                using(SqlConnection db = new SqlConnection(_connectionString)){
                    db.Execute(SQL, new {pIdPelicula = Res.IdPelicula, pContenido = Res.Contenido, pValoracion = Res.Valoracion, pNombreUsuario = Res.NombreUsuario, pFecha = Res.Fecha, pFoto = Res.Foto} );
                }

            }

             public static void AgregarReseñaSerie(Reseñas Res){

              string SQL = "INSERT INTO Reseñas(Contenido, IdSerie, Valoracion, NombreUsuario, Fecha, Foto) VALUES (@pContenido, @pIdSerie, @pValoracion, @pNombreUsuario, @pFecha, @pFoto)";

                using(SqlConnection db = new SqlConnection(_connectionString)){
                    db.Execute(SQL, new {pContenido = Res.Contenido, pIdSerie = Res.IdSerie,pValoracion = Res.Valoracion, pNombreUsuario = Res.NombreUsuario, pFecha = Res.Fecha, pFoto = Res.Foto} );
                }

            }

        public static int EliminarReseña(int id){
                 int reseñasEliminadas = 0;
                 string sql = "DELETE FROM Reseñas WHERE IdReseña = @reseña";
                    using(SqlConnection db = new SqlConnection(_connectionString)){
                      reseñasEliminadas = db.Execute(sql, new {reseña = id} );
                    }

                        return reseñasEliminadas;
            }

} 

}