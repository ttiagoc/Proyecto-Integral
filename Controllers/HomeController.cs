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

         Random random = new Random();
        int num = random.Next(0,cantPelis);
        
         ViewBag.PeliRandom = TodasPelis[num];

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

        return View("Peliculas");
    }

       public IActionResult VerInfoPeliculas(int IdPelicula)
    {
         ViewBag.InfoPelicula = BD.ObtenerInfoPeliculas(IdPelicula);
         ViewBag.EstadisticaPelicula = BD.ObtenerEstadisticasPeliculas(IdPelicula);
     

        return View("DetallePeliculas");
    }

     public IActionResult VerSeries()
    {
        ViewBag.Series = BD.ListarSeries();

        return View("Series");
    }

     public IActionResult VerInfoSeries(int id)
    {
      // ViewBag.InfoPelicula = BD.ObtenerInfoPelicula(id);

        return View("DetalleSeries");
    }

    public IActionResult HacerBusqueda(string busc){

        ViewBag.Resultados = BD.BusquedaPersonalizada(busc);
       
       
        return View("Busqueda");
    }

    public Peliculas PeliculaRandom(){

        List <Peliculas> TodasPelis = new List<Peliculas>();
         TodasPelis = BD.ListarPeliculas();

         int cantPelis = TodasPelis.Count();
       //HACER BD QUE TRAIGA LA RANDOM
         Random random = new Random();
        int num = random.Next(0,cantPelis);
        
            
            return TodasPelis[num];
    }




    public List<Peliculas> PelisGenero(int num){

        List <Peliculas> ListaPorGenero = new List<Peliculas>();
        ListaPorGenero = BD.ObtenerPeliculaPorGenero(num);
        
            
            return ListaPorGenero;
    }

}
