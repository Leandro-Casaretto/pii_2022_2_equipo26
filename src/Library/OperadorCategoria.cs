using System;
using System.Collections.Generic;
using System.Linq;

namespace Library{

    public class operadorCategorias
    {

        public List<Categoria> categorias;

        public operadorCategorias()
        {

            this.categorias = new List<Categoria>();
        }

        public void agregarCategoria(Categoria categoria){

            categorias.Add(categoria);            
        }

        public void editarCaregoria(int idEditar, Categoria categoria){
            
            for (int i = 0; i < categorias.Count; i++)
            {
                if(categorias[i].id == idEditar){
                    categoria.catServicio = categorias[i].catServicio;
                    categorias[i] = categoria;
                }
            }
        }

        public void cancelarCategoria(int idCancelar, Categoria categoria){

            for (int i = 0; i < categorias.Count; i++)
            {
                if(categorias[i].id == idCancelar){
                    categorias.RemoveAt(i);
                }
            }

        }

        public void agregarServicioCategoria(int ID, Servicio servicio)
        {   
            for (int i = 0; i < categorias.Count; i++)
            {
                if(categorias[i].id == ID)
                {
                    this.categorias[i].catServicio.Add(servicio);
                }
            }
        }

        public void cancelarServicioCategoria(int ID, Servicio servicio)
        {   
            for (int i = 0; i < categorias.Count; i++)
            {
                if(categorias[i].id == ID)
                {
                    this.categorias[i].catServicio.Remove(servicio);
                }
            }
        }

        public List<Categoria> listarCategoria()
        {
            return this.categorias;  // Nos devuleve la lista de categorias
        }


        public List<Servicio> listarCatServicios(int idCategoria)
        {   
            
            var categoria =  this.categorias.FirstOrDefault(c => c.id==idCategoria);

            if(categoria != null)
            {
                return categoria.catServicio;
            }
            else
            {
                return null;
            }

        
        }
        
    }    
}

