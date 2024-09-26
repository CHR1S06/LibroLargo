using System;

namespace LibroLongitud.Clases
{
    /// <summary>
    /// Clase que representa un libro con su nombre, autor y cantidad de páginas.
    /// </summary>
    public class Libro
    {
        private string nombre;  // Almacena el nombre del libro
        private string autor;   // Almacena el autor del libro
        private int paginas;    // Almacena la cantidad de páginas del libro

        /// <summary>
        /// Propiedad para obtener y establecer el nombre del libro.
        /// </summary>
        public string Nombre
        {
            get
            {
                return nombre;  // Devuelve el nombre del libro
            }
            set
            {
                // Verifica que el valor no esté vacío ni contenga solo espacios
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nombre = value;  // Asigna el valor a la variable nombre
                }
                else
                {
                    Console.WriteLine("El nombre no puede estar vacío o contener solo espacios en blanco. Intente nuevamente.");
                }
            }
        }

        /// <summary>
        /// Propiedad para obtener y establecer el autor del libro.
        /// </summary>
        public string Autor
        {
            get
            {
                return autor;  // Devuelve el autor del libro
            }
            set
            {
                // Verifica que el valor no esté vacío ni contenga solo espacios
                if (!string.IsNullOrWhiteSpace(value))
                {
                    autor = value;  // Asigna el valor a la variable autor
                }
                else
                {
                    Console.WriteLine("El nombre no puede estar vacío o contener solo espacios en blanco. Intente nuevamente.");
                }
            }
        }

        /// <summary>
        /// Propiedad para obtener y establecer la cantidad de páginas del libro.
        /// </summary>
        public int Paginas
        {
            get
            {
                return paginas;  // Devuelve la cantidad de páginas
            }
            set
            {
                paginas = value;  // Asigna el valor al campo 'paginas'
            }
        }

        /// <summary>
        /// Método para mostrar la información del libro en forma de tupla.
        /// </summary>
        /// <returns>Una tupla que contiene el nombre, autor y cantidad de páginas del libro.</returns>
        public (string, string, int) MostrarInformacion()
        {
            return (nombre, autor, paginas);  // Devuelve los datos del libro
        }

        /// <summary>
        /// Método que determina si el libro es largo (más de 500 páginas).
        /// </summary>
        /// <returns>true si el libro tiene más de 500 páginas; de lo contrario, false.</returns>
        public bool EsLargo()
        {
            return paginas > 500;  // Retorna verdadero si páginas es mayor a 500
        }

        /// <summary>
        /// Método para solicitar al usuario información sobre el libro.
        /// </summary>
        public void Info()
        {
            Console.Write("Introduzca el nombre del libro: ");
            Nombre = Console.ReadLine();  // Llama a la propiedad Nombre para establecer el nombre

            Console.Write("");  // Línea en blanco

            Console.Write("Introduzca el Autor: ");
            Autor = Console.ReadLine();  // Llama a la propiedad Autor para establecer el autor

            Console.Write("");

            Console.Write("Introduzca la cantidad de paginas: ");
            // Ciclo para validar la entrada de páginas
            while (true)
            {
                try
                {
                    Paginas = Convert.ToInt32(Console.ReadLine());  // Establece la cantidad de páginas
                    if (Paginas > 0)  // Verifica que el número de páginas sea mayor a cero
                    {
                        break;  // Sale del bucle si es válido
                    }
                    else
                    {
                        Console.WriteLine("El numero de paginas debe ser mayor a cero.");  // Mensaje de error
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error en la entrada, intente nuevamente.");  // Mensaje de error en caso de excepción
                }
            }

            Console.Clear();  // Limpia la consola

            // Obtiene la información del libro y la almacena en variables
            (string nom, string aut, int pag) = MostrarInformacion();

            Console.WriteLine("Informacion del libro:");
            Console.Write("");
            Console.WriteLine($"Nombre: {nom}");  // Muestra el nombre del libro
            Console.WriteLine($"Autor: {aut}");  // Muestra el autor del libro
            Console.WriteLine($"Paginas: {pag}");  // Muestra la cantidad de páginas

            // Verifica si el libro es largo y muestra el resultado
            bool LargOnoLarg = EsLargo();
            if (LargOnoLarg)
            {
                Console.WriteLine($"\nEl libro tiene mas de 500 paginas, por lo tanto es ({LargOnoLarg}).");
            }
            else
            {
                Console.WriteLine($"\nEl libro tiene menos de 500 paginas, por lo tanto es ({LargOnoLarg}).");
            }
        }
    }
}
