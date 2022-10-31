using System;
using System.Collections.Generic;

namespace Library
{

    public class Servicio : operadorServicios
    {

        private string nombre;
        public int id;
        private string descripcion;
        private int precio;
        private Empleado empleado;
        

        public Servicio(string nombre, int id, string descripcion, int precio, Empleado empleado)
        {

            this.nombre = nombre;
            this.id = id;   
            this.descripcion = descripcion;
            this.precio = precio;
            this.empleado = empleado;
        }
    }          
}