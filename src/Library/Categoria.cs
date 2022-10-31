using System;
using System.Collections.Generic;

namespace Library 
{

    public class Categoria : operadorCategorias
    {
        public string nombre;
        public int id;
        public List<Servicio> catServicio;


        public Categoria(string nombre, int id) {

            this.nombre = nombre;
            this.id = id;
            this.catServicio = new List<Servicio>();
        }
    }
}