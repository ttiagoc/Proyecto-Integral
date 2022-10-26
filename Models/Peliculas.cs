using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Proyecto_Integral.Models
{
    public class Peliculas
    {
        private int _idPelicula, _idGenero;
        private string _director, _nombre, _protagonista, _sinopsis, _foto;
        private DateTime _fechaEstreno;

        public Peliculas()
        {

            _idGenero = 0;
            _director = "";
            _nombre = "";
            _protagonista = "";
            _sinopsis = "";
            _foto = "";
            _fechaEstreno = new DateTime();

        }

        public Peliculas(int pidPelicula, int pidGenero, string pdirector, string pnombre, string pprotagonista, string psinopsis, string pfoto, DateTime pfechaEstreno){
            
            
            _idGenero = pidGenero;
            _director = pdirector;
            _nombre = pnombre;
            _protagonista = pprotagonista;
            _sinopsis = psinopsis;
            _foto = pfoto;
            _fechaEstreno = pfechaEstreno;

        }

        public int IdPelicula{

            get{return _idPelicula;}
            set{_idPelicula = value;}

        }

         public int IdGenero{

            get{return _idGenero;}
            set{_idGenero = value;}

        }

        public string Protagonista{
            get{return _protagonista;}
            set{_protagonista = value;}
        }

         public string Nombre{
            get{return _nombre;}
            set{_nombre = value;}
        }

         public string Sinopsis{
            get{return _sinopsis;}
            set{_sinopsis = value;}
        }

         public string Foto{
            get{return _foto;}
            set{_foto = value;}
        }

         public string Director{
            get{return _director;}
            set{_director = value;}
        }


    }
}