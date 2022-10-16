
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Proyecto_Integral.Models
{
    public class Generos
    {
        private int _idGenero;
        private string _genero;

        public Generos(){
            _genero = "";
        }

        public Generos(string pgenero){
            _genero = pgenero;
        }

        public int IdGenero{
            get{return _idGenero;}
            set{_idGenero = value;}
        }

        public string Genero{
            get{return _genero;}
            set{_genero = value;}
        }

    }
}