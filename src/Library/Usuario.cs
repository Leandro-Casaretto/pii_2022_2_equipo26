using System;
using System.Collections.Generic;

namespace Library
{

    /// <summary>
    /// Empleador, Administrador y Empleado heredarán de esta clase
    /// </summary>
    public abstract class Usuario 
    {

        /// <summary>
        /// Establecemos las propiedades
        /// </summary>
        public string nombre; 
        public string apellido;
        public string email;
        public int telefono;
        public int id;

        public Performance performance;
        
        protected Usuario(string nombre, string apellido, string email, int telefono, int id) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.id = id;
        }

        /// <summary>
        /// Establecemos las propiedades del usuario
        /// </summary>
        
        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public string Email { get { return this.email; } set { this.email = value; } } //Para que a su vez lo setee
        public int Telefono { get { return this.telefono; } set { this.telefono = value; } }
        public int Id { get { return this.id; } }
    
    }
}
