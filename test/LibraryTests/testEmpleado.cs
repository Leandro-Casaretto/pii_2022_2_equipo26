using NUnit.Framework;
using System.Collections.Generic;

using Library;

namespace Tests
{

    [TestFixture]
    public class testEmpleado
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void initEmpleado()
        {
            operadorUsuarios operador = new operadorUsuarios();

            Empleado Martin = new Empleado("Martin", "Rodriguez", "martin@gmail.com", 099887766, 0001);

            List<Usuario> usuarios = operador.listarUsuarios();

            operador.agregarUsuario(Martin);

            Assert.IsNotEmpty(usuarios);

        }

        [Test]
        public void quitarEmpleado()
        {
            Empleado Jose = new Empleado("José", "González", "jose@gmail.com", 099667788, 0002); 

            operadorUsuarios operador = new operadorUsuarios();

            List<Usuario> usuarios = operador.listarUsuarios();

            operador.agregarUsuario(Jose);

            operador.quitarUsuario(0002,Jose);

            Assert.IsEmpty(usuarios);
        }

        [Test]
        public void calificarEmpleador() 
        {
            Empleado Augusto = new Empleado ("Augusto", "Rodriguez", "augusto@gmail.com", 099886677, 0003);

            Empleador Matias = new Empleador("Matias", "Jimenez", "matias@gmail.com", 091998877, 0001); 

            Calificacion calificacion = new Calificacion(8);

            Performance performance = new Performance();

            Augusto.calificarEmpleador(Matias, calificacion);

            Assert.AreEqual(calificacion.valor,Matias.performance.calificaciones[0].valor);

        }

    }
}
