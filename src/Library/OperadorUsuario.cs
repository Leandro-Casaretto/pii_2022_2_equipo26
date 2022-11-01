
using System;
using System.Collections.Generic;

namespace Library
{

    /// <summary>
    /// Esta clase es la encargada de agregar, quitar y listar los usuarios (ofertas)
    /// </summary>
    public class operadorUsuarios
    {

        public List<Usuario> usuario = new List<Usuario>(); 
        public void agregarUsuario(Usuario usuario1)
        {
            usuario.Add(usuario1);
        }

        public void quitarUsuario(int nUsuario, Usuario usuario1)
        {
            for (int i = 0; i < usuario.Count; i++)
            {
                if(usuario[i].id == nUsuario)
                {
                    usuario.RemoveAt(i);
                }
            }
        }
        public List<Usuario> listarUsuarios()
        {
            return this.usuario;
        }

    }
}
