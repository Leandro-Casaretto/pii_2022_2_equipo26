using System;
using System.Collections.Generic;

namespace Library
{
    public class Admin : Usuario //Aplicamos herencia desde la clase Usuario
    {
        public Admin(string nombre, string apellido, string email, int telefono, int id) : base(nombre,apellido,email,telefono,id)
        {
    
        }
        public void agregarCategorias(Categoria categoria) //Agrega categorias
        {
            
        }
        public void quitarCategorias(Categoria categoria) //Elimina categorias
        {
            
        }
        public void hablarConOfertante(Servicio servicio)
        {
            
        }
    }
}