using System;
using System.Collections.Generic;

namespace Library
{
    public class Empleador : Usuario
    {
        public Empleador(string nombre, string apellido, string email, int telefono, int id) : base(nombre,apellido,email,telefono,id)
        {
    
        }
        
        public void calificarEmpleado(Empleado empleado, Calificacion calificacion)
        {

            empleado.performance.agregarCalificaciones(calificacion);


        }
    } 
}