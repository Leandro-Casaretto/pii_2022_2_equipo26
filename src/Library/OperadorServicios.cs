using System;
using System.Collections.Generic;

namespace Library
{
    public class operadorServicios
    {

        public List<Servicio> servicios = new List<Servicio>(); 

        public void agregarServicio(Servicio serv)
        {
                    
        }
        
        public void cancelarServicios(int idCancelar)
        {

            for (int i = 0; i < servicios.Count; i++)
            {
                if(servicios[i].id == idCancelar){
                    servicios.RemoveAt(i);
                }
            }

        }

        public void editarServicios(int idEditar, Servicio servicio)
        {

            for (int i = 0; i < servicios.Count; i++)
            {
                if(servicios[i].id == idEditar){
                    servicios[i] = servicio;
                }
            }
        }
        
        public List<Servicio> listarServicios() //lista todos los servicios
        {
            return this.servicios;
        }
        
    } 
 }