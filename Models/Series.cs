using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Proyecto_Integral.Models
{
    public class Series
    {
        
        private int _idSerie, _idGenero, _capitulosTotales, _temporadas;
        private string _nombre, _protagonista, _sinopsis, _foto;
        private DateTime _fechaEstreno;

        
        public Series()
        {
            _idGenero = 0;
            _nombre = "";
            _protagonista = "";
            _sinopsis = "";
            _foto = "";
            _fechaEstreno = new DateTime();
            _capitulosTotales = 0;
            _temporadas = 0;

        }

        public Series(int pidGenero, int ptemporadas, int pcapitulosTotales, string pnombre, string pprotagonista, string psinopsis, string pfoto, DateTime pfechaEstreno){

            _idGenero = pidGenero;
            _nombre = pnombre;
            _protagonista = pprotagonista;
            _sinopsis = psinopsis;
            _foto = pfoto;
            _fechaEstreno = pfechaEstreno;
            _capitulosTotales = pcapitulosTotales;
            _temporadas = ptemporadas;

        }

        public int IdSerie{

            get{return _idSerie;}
            set{_idSerie = value;}

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

         public int Temporadas{
            get{return _temporadas;}
            set{_temporadas = value;}
        }

         public int CapitulosTotales{
            get{return _capitulosTotales;}
            set{_capitulosTotales = value;}
        }


        public DateTime FechaEstreno{
            get{
                return _fechaEstreno;
            }set{
                _fechaEstreno = value;
            }
        }
    }
}