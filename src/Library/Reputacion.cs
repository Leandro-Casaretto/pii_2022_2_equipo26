using System;
using System.Collections.Generic;

namespace Library
{
    public class Reputacion
    {
        public float valorReputacion;
        public List<Calificacion> calificaciones = new List <Calificacion>();

        public void agregarCalificacion(Calificacion calificacion)
        {
        
            this.calificaciones.Add(calificacion);

        }
        public List<Calificacion> listarCalificaciones()
        {
        return this.calificaciones;
        }
    
    }

}