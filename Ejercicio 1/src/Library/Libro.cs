using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }


        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        /*
        La clase libro es la principal, es el lugar en donde se reciben los libros,
        en cambio la clase AlmacenarLibro, puede llegar a estar en otra clase.
        */
    }
}
