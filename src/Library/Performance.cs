using System;
using System.Collections.Generic;

namespace Library
{

    /// <summary>
    /// Esta clase es la encargada de brindar el historial o la performance general 
    /// </summary>
    public class Performance
    {

        public float valorPerformance;
        public List<Calificacion> calificaciones = new List <Calificacion>();


    /// <summary>
    /// Lista las calificaciones 
    /// </summary>
    public List<Calificacion> listarCalificaciones()
    {
        return this.calificaciones;
    }

    /// <summary>
    /// Agrega las calificaciones
    /// </summary>
    public void agregarCalificaciones(Calificacion calificacion)
    {
        
       this.calificaciones.Add(calificacion);

    }

    /// <summary>
    /// Quita las calificaciones
    /// </summary>

    public void quitarCalificaciones(Calificacion calificacion)
    {
        
       this.calificaciones.Remove(calificacion);

    }

  }

}