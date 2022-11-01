
using System.Collections.Generic;
using NUnit.Framework;

using Library;

namespace Tests
{
    [TestFixture]
    public class testEmpleador
    {
        
        [SetUp]
        public void Setup()
        {
        }
    
        [Test]
        public void initEmpleador()
        {
            operadorUsuarios operador = new operadorUsuarios();
            
            Empleador Martin = new Empleador("Martin", "Gutierrez", "martingut@gmail.com", 099887744, 0001);
            
            List<Usuario> usuarios = operador.listarUsuarios();         
            
            operador.agregarUsuario(Martin);
            
            Assert.IsNotEmpty(usuarios);
        }

        [Test]
        public void quitarEmpleador()
        {
            Empleador Ignacio = new Empleador("Ignacio", "Torres", "ignacio123@gmail.com", 099887788, 0004); 
            
            operadorUsuarios operador = new operadorUsuarios();
            
            List<Usuario> usuarios = operador.listarUsuarios();         
            
            operador.agregarUsuario(Ignacio);
            
            operador.quitarUsuario(0004,Ignacio);
            
            Assert.IsEmpty(usuarios);
        }


        [Test]
        public void calificarEmpleado() 
        {
            Empleador Ignacio = new Empleador("Ignacio", "Torres", "ignacio123@gmail.com", 099887788, 0004);
            
            Empleado Augusto = new Empleado ("Augusto", "Rodriguez", "augusto@gmail.com", 099886677, 0003);
            
            Calificacion calificacion = new Calificacion(5);
            
            Performance performance = new Performance();
            
            Ignacio.calificarEmpleado(Augusto, calificacion);
            
            Assert.AreEqual(calificacion.valor, Augusto.performance.calificaciones[0].valor);

        }

    }
}
