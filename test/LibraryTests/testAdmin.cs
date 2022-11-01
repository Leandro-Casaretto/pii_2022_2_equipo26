using NUnit.Framework;
using System.Collections.Generic;
using Library;

namespace Tests
{


    [TestFixture]
    public class adminTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Creamos el admin
        /// </summary>

        [Test]
        public void initAdmin()
        {
            operadorUsuarios operador = new operadorUsuarios();

            Admin Pedro = new Admin("Pedro", "Gonzalez", "pedro@gmail.com", 091889900, 0001);

            List<Usuario> usuarios = operador.listarUsuarios();

            operador.agregarUsuario(Pedro);

            Assert.IsNotEmpty(usuarios);

        }

        /// <summary>
        /// Quitamos el admin
        /// </summary>
        
        [Test]
        public void quitarAdmin()
        {
            Admin Pedro = new Admin("Pedro", "Gonzalez", "pedro@gmail.com", 099887766, 0002); 

            operadorUsuarios operador = new operadorUsuarios();

            List<Usuario> usuarios = operador.listarUsuarios();

            operador.agregarUsuario(Pedro);

            operador.quitarUsuario(0002,Pedro);

            Assert.IsEmpty(usuarios);
        }

        /// <summary>
        /// Agregamos categorias
        /// </summary>

        [Test]
        public void agregarCategorias()
        {
            Admin Pedro = new Admin("Pedro", "Gonzalez", "pedro@gmail.com", 099887766, 0002); 

            operadorCategorias operador = new operadorCategorias();

            Categoria Construccion = new Categoria("Construccion", 0004); 

            List<Categoria> categorias = operador.listarCategoria();

            operador.agregarCategoria(Construccion); 

            Assert.IsNotEmpty(categorias);
        }


    }


}
