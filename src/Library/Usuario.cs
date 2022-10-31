using System;
using System.Collections.Generic;

namespace Library
{
    public abstract class Usuario // Empleador, Administrador y Empleado heredan de esta clase
    {

        protected string nombre; //Protegido para que solo la misma clase o la clase instanciada pueda hacer uso.
        protected string apellido;
        public string email;
        protected int telefono;
        protected int id;
        
        protected Usuario(string nombre, string apellido, string email, int telefono, int id) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.id = id;
        }

        //A continuación establecemos las properties del usuario
        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public string Email { get { return this.email; } set { this.email = value; } } //Para que a su vez lo setee
        public int Telefono { get { return this.telefono; } set { this.telefono = value; } }
        public int Id { get { return this.id; } }
    
    }
}
