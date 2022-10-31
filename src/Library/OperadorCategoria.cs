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

        public void agregarCategoria(Categoria cat){

            categorias.Add(cat);            
        }

        public void editarCaregoria(int idEditar, Categoria cat){
            
            for (int i = 0; i < categorias.Count; i++)
            {
                if(categorias[i].id == idEditar){
                    cat.catServicio = categorias[i].catServicio;
                    categorias[i] = cat;
                }
            }
        }

        public void cancelarCategoria(int idCancelar, Categoria cat){

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


        public List<Servicio> listarCatServicios(int categoriaID)
        {   
            
            var categoria =  this.categorias.FirstOrDefault(c => c.id==categoriaID);

            if(categoria != null)
            {
                return categoria.catServicio;
            }
            else{

                throw new Exception("No se existen categorias con ese ID"); //Hacemos uso de las excepciones
            }

           
        }
        
    }    
}

