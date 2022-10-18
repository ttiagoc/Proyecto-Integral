
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace Proyecto_Integral.Models
{
    public class Estadisticas
    {
        private int _idEstadistica, _idSerie, _idPelicula, _recaudacion, _plataInvertida, _visualizaciones;
        private string _paisConMasExito;

        public Estadisticas(){

            _idSerie = 0;
            _idPelicula = 0;
            _recaudacion = 0;
            _plataInvertida = 0;
            _visualizaciones = 0;
            _paisConMasExito = "";


        }
        
        public Estadisticas(int pidPelicula, int precaudacion, int pplataInvertida, int pvisualizaciones, string ppaisConMasExito){

            _idPelicula = pidPelicula;
            _recaudacion = precaudacion;
            _plataInvertida = pplataInvertida;
            _visualizaciones = pvisualizaciones;
            _paisConMasExito = ppaisConMasExito;


        }

          public Estadisticas(string ppaisConMasExito, int precaudacion, int pidSerie, int pplataInvertida, int pvisualizaciones){

            _recaudacion = precaudacion;
            _idSerie = pidSerie;   
            _plataInvertida = pplataInvertida;
            _visualizaciones = pvisualizaciones;
            _paisConMasExito = ppaisConMasExito;


        }


        public int IdSerie{
            get{return _idSerie;}
            set{_idSerie = value;}
        }
         public int IdPelicula{
            get{return _idPelicula;}
            set{_idPelicula = value;}
        }

         public int IdEstadistica{
            get{return _idEstadistica;}
            set{_idEstadistica = value;}
        }
         public int Recaudacion{
            get{return _recaudacion;}
            set{_recaudacion = value;}
        }
         public int PlataInvertida{
            get{return _plataInvertida;}
            set{_plataInvertida = value;}
        }
         public int Visualizaciones{
            get{return _visualizaciones;}
            set{_visualizaciones = value;}
        }

        public string PaisConMasExito{
            get{return _paisConMasExito;}
            set{_paisConMasExito = value;}
        }






    }
}