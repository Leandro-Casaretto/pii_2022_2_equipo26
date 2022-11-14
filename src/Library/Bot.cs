using System;
using System.Collections;

/// <summary>
/// Demo BOT
/// </summary>

namespace Library
{
    public class Bot
    {
        public ChatBot()
        {
            Console.WriteLine("Hola, ingrese su rol (empleado / empleador");
            string respuesta = Console.ReadLine();

            respuesta.ToUpper;

            if (respuesta=="EMPLEADO")
            {
                Console.WriteLine("Ingrese su nombre");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su apellido");
                string apellido = Console.ReadLine();

                Console.WriteLine("Ingrese su email");
                string email = Console.ReadLine();

                Console.WriteLine("Ingrese su telefono");
                int telefono = Console.ReadLine();


                /// <summary>
                /// A continuación creamos un id aleatorio
                /// </summary>

                int generarId()
                {
                int _min = 0000;
                int _max = 9999;
                Random id = new Random();
                return id.Next(_min, _max);
                }
                
                List<object> datosPersonales = new List<object>();

                datosPersonales.Add(nombre);
                datosPersonales.Add(apellido);
                datosPersonales.Add(email);
                datosPersonales.Add(telefono);
                datosPersonales.Add(id); 

                if (respuesta=="EMPLEADOR")
                {
                Console.WriteLine("Ingrese su nombre");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su apellido");
                string apellido = Console.ReadLine();

                Console.WriteLine("Ingrese su email");
                string email = Console.ReadLine();

                Console.WriteLine("Ingrese su telefono");
                int telefono = Console.ReadLine();

                }

                /// <summary>
                /// A continuación creamos un id aleatorio
                /// </summary>

                int generarId()
                {
                int _min = 0000;
                int _max = 9999;
                Random id = new Random();
                return id.Next(_min, _max);
                }
                
                List<object> datosPersonales = new List<object>();

                datosPersonales.Add(nombre);
                datosPersonales.Add(apellido);
                datosPersonales.Add(email);
                datosPersonales.Add(telefono);
                datosPersonales.Add(id);           

                /// <summary>
                /// Crear oferta (empleado)
                /// </summary>
                 
                if( respuesta == "EMPLEADO")
                
                    Console.WriteLine("Para crear una nueva oferta de servicio, escriba 1");
                    string respuesta = Console.ReadLine();

                    if  (respuesta=="1")
                    {

                    Console.WriteLine("Ingrese el nombre del servicio");
                    string nombreServicio = Console.ReadLine();

                    Console.WriteLine("Ingrese el id del servicio");
                    int id = Console.ReadLine();

                    Console.WriteLine("Ingrese la descripccion del servicio");
                    string descripcion = Console.ReadLine();

                    Console.WriteLine("Ingrese el precio");
                    int precio = Console.ReadLine();                  
                    
                    } 

            
            }   

        }
    }

    

}