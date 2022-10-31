using System;
using System.Collections.Generic;

namespace Library
{
    public class Empleado : Usuario
    {

        public Empleado(string nombre, string apellido,string email, int telefono, int id) : base(nombre,apellido,email,telefono,id)
        {
            
        }
        
        public void ofrecerServicio(Servicio servicio)
        {
    
        }
        public void aceptarServicio(Empleador empleador) //El servicio es aceptado por el empleador
        {
            
        }

    }
}
