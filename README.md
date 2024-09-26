#LibroLargo--PrimerosPasos-

# Descripción del Problema

El objetivo de este proyecto es crear una clase `Libro` que represente un libro con tres propiedades esenciales: **Título**, **Autor** y **Páginas**. Esta clase debe almacenar la información básica de un libro y proporcionar métodos para mostrar esa información y determinar si el libro es "largo", es decir, si tiene más de 500 páginas.

## Requisitos

1. **Propiedades**:
   - **Título**: Almacena el título del libro.
   - **Autor**: Almacena el autor del libro.
   - **Páginas**: Almacena el número de páginas del libro.

2. **Métodos**:
   - **MostrarInformacion()**: Imprime en la consola la información del libro.
   - **EsLargo()**: Devuelve `true` si el libro tiene más de 500 páginas y `false` en caso contrario.

# Abordaje del Problema

Para abordar este problema, se desarrolló la clase `Libro` en C#. La implementación incluye las siguientes características:

1. **Definición de Propiedades**:
   - Se implementaron las propiedades `Titulo`, `Autor` y `Paginas`, con validaciones para asegurar que los valores ingresados sean válidos. Por ejemplo, se verifica que el título y el autor no estén vacíos o contengan solo espacios en blanco.

2. **Método `MostrarInformacion`**:
   - Este método se encarga de imprimir en la consola el título, autor y número de páginas del libro, facilitando al usuario la visualización de la información del libro.

3. **Método `EsLargo`**:
   - Se creó este método para evaluar si el número de páginas del libro es mayor a 500. Retorna `true` si es así, lo que permite clasificar el libro como "largo".

Este diseño modular no solo satisface los requisitos planteados, sino que también permite la posibilidad de expandir las funcionalidades en el futuro. La clase `Libro` puede ser fácilmente reutilizada y adaptada para incluir más características según sea necesario.

En resumen, la implementación de la clase `Libro` proporciona una solución efectiva para gestionar la información básica de los libros, cumpliendo con los requerimientos del problema presentado.
