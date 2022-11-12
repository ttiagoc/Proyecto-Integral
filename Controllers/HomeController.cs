using System.Net.WebSockets;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Integral.Models;

namespace Proyecto_Integral.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.PeliExito = BD.PeliculaMasExitosa();
        ViewBag.PelisRecientes = BD.ObtenerPelisMasRecientes();

         List <Peliculas> TodasPelis = new List<Peliculas>();
         TodasPelis = BD.ListarPeliculas();

         int cantPelis = TodasPelis.Count();

         ViewBag.PeliRandom = BD.ObtenerPeliRandom(cantPelis);

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

     public IActionResult VerPeliculas()
    {
        ViewBag.Peliculas = BD.ListarPeliculas();
        ViewBag.Generos = BD.ObtenerGeneros();
        
        return View("Peliculas");
    }

       public IActionResult VerInfoPeliculas(int IdPelicula)
    {
         ViewBag.InfoPelicula = BD.ObtenerInfoPeliculas(IdPelicula);
         ViewBag.EstadisticaPelicula = BD.ObtenerEstadisticasPeliculas(IdPelicula);
          
        List<Reseñas> ListaReseñas = new List<Reseñas>();
        ListaReseñas = BD.ListarReseñas(IdPelicula,false);
        ViewBag.ListaReseñas = ListaReseñas;
       
         return View("DetallePeliculas");
    }

     public IActionResult VerSeries()
    {
        ViewBag.Series = BD.ListarSeries();

        return View("Series");
    }

     public IActionResult VerInfoSeries(int IdSerie)
    {
         ViewBag.InfoSerie = BD.ObtenerInfoSeries(IdSerie);
         ViewBag.EstadisticaSerie = BD.ObtenerEstadisticasSeries(IdSerie);
         List<Reseñas> ListaReseñas = new List<Reseñas>();
         ListaReseñas = BD.ListarReseñas(IdSerie,true);
         ViewBag.ListaReseñas = ListaReseñas;
        
         return View("DetalleSeries");
    }

    public IActionResult HacerBusqueda(string busc){

        ViewBag.ResultadosPeliculas = BD.BusquedaPersonalizadaPeliculas(busc);
        ViewBag.ResultadosSeries = BD.BusquedaPersonalizadaSeries(busc);
        ViewBag.Busqueda = busc;
        return View("Busqueda");
    }

    public Peliculas PeliculaRandom(){

        List <Peliculas> TodasPelis = new List<Peliculas>();
         TodasPelis = BD.ListarPeliculas();

         int cantPelis = TodasPelis.Count();
       //HACER BD QUE TRAIGA LA RANDOM
         Random random = new Random();
        int num = random.Next(0,cantPelis);
        
            System.Console.WriteLine(num);
            return TodasPelis[num];
    }




    public List<Peliculas> PelisGenero(int num){
        
        List <Peliculas> ListaPorGenero = new List<Peliculas>();
        ListaPorGenero = BD.ObtenerPeliculaPorGenero(num);
        
        foreach (Peliculas pel in ListaPorGenero)
        {
            System.Console.WriteLine(pel.Nombre);
            System.Console.WriteLine(1);
        }
           // System.Console.WriteLine(1);
            return ListaPorGenero;
    }

[HttpPost] public IActionResult GuardarReseñaPelicula(int IdPelicula, string contenido, int valoracion, string NombreUsuario){

            DateTime FechaActual = DateTime.Now;
            string Foto = "";
             switch (valoracion)
            {
                case 1:
                    Foto ="/Imagenes/1star.png";
                    break;
                case 2:
                     Foto ="/Imagenes/2star.png";
                    break;
                case 3:
                      Foto ="/Imagenes/3star.png";
                    break;
                case 4:
                     Foto ="/Imagenes/4star.png";
                    break;
                case 5:
                     Foto ="/Imagenes/5star.png";
                    break;
                default:
                    System.Console.WriteLine("nashex");
                    break;
            }
        
            Reseñas Res = new Reseñas(IdPelicula,contenido,valoracion,NombreUsuario,FechaActual,Foto);
            BD.AgregarReseña(Res);

            return RedirectToAction("VerInfoPeliculas" , "Home", new {IdPelicula = IdPelicula});
    }






}
