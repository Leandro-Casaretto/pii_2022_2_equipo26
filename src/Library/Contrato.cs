using System;
using System.Collections.Generic;

namespace Library
{

    public class Contrato 
    {
        public Servicio servicio;
        public Empleador empleador;

        public Contrato (Servicio servicio, Empleador empleador)
        {
            this.servicio = servicio;
            this.empleador = empleador;
        }
    }
}