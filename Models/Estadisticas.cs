
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace Proyecto_Integral.Models
{
    public class Estadisticas
    {
        private int _idEstadistica, _idSerie, _idPelicula, _visualizaciones;
        private string _paisConMasExito, _recaudacion, _presupuesto;

        public Estadisticas(){

            _idSerie = 0;
            _idPelicula = 0;
            _recaudacion = "";
            _presupuesto = "";
            _visualizaciones = 0;
            _paisConMasExito = "";


        }
        
        public Estadisticas(int pidPelicula, int pidSerie, string precaudacion, string ppresupuesto, int pvisualizaciones, string ppaisConMasExito){

            _idPelicula = pidPelicula;
             _idSerie = pidSerie;   
            _recaudacion = precaudacion;
            _presupuesto = ppresupuesto;
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
         public string Recaudacion{
            get{return _recaudacion;}
            set{_recaudacion = value;}
        }
         public string Presupuesto{
            get{return _presupuesto;}
            set{_presupuesto = value;}
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