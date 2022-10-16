using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace Proyecto_Integral.Models
{
    public class Reseñas
    {
        private int _idReseña, _idPelicula, _idSerie;
        private float _valoracion;
        private string _contenido, _nombreUsuario;

        private DateTime _fecha;

        public Reseñas(){

            _idPelicula = 0;
            _idSerie = 0;
            _valoracion = 0;
            _contenido = "";
            _nombreUsuario = "";
            _fecha = new DateTime();
        }

        public Reseñas(int pidPelicula, string pcontenido, float pvaloracion, string pnombreUsuario, DateTime pfecha){

            _idPelicula = pidPelicula;
            _contenido = pcontenido;
            _valoracion = pvaloracion;
            _nombreUsuario = pnombreUsuario;
            _fecha = pfecha;

        }

          public Reseñas( string pcontenido, int pidSerie, float pvaloracion, string pnombreUsuario, DateTime pfecha){

            _idSerie = pidSerie;
            _contenido = pcontenido;
            _valoracion = pvaloracion;
            _nombreUsuario = pnombreUsuario;
            _fecha = pfecha;

        }


        public int IdReseña{
            get{return _idReseña;}
            set{_idReseña = value;}
        }
         public int IdPelicula{
            get{return _idPelicula;}
            set{_idPelicula = value;}
        }
         public int IdSerie{
            get{return _idSerie;}
            set{_idSerie = value;}
        }

        public float Valoracion{
              get{return _valoracion;}
            set{_valoracion = value;}
        }

        public string Contenido{
            get{return _contenido;}
            set{_contenido = value;}
        }
           public string NombreUsuario{
            get{return _nombreUsuario;}
            set{_nombreUsuario = value;}
        }



    }
}