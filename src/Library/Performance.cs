using System;
using System.Collections.Generic;

namespace Library
{///
    public class Performance
    {

        public float valorPerformance;
        public List<Calificacion> calificaciones = new List <Calificacion>();

    public List<Calificacion> listarCalificaciones()
    {
        return this.calificaciones;
    }

    public void agregarCalificaciones(Calificacion calificacion)
    {
        
       this.calificaciones.Add(calificacion);

    }

  }

}