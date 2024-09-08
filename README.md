# ej. numero de telefono

Este proyecto consiste en una función que toma un arreglo de 10 enteros (con valores entre 0 y 9) y devuelve una cadena que representa esos números en el formato estándar de un número de teléfono.

Funcionalidad
La función CreatePhoneNumber recibe un arreglo de enteros y devuelve una cadena de texto en el formato:

"(123) 456-7890"
Donde los números en el arreglo se formatean en un número de teléfono con el siguiente formato:

* Los primeros tres dígitos se colocan entre paréntesis.
* Los siguientes tres dígitos se colocan después de un espacio.
* Los últimos cuatro dígitos se colocan después de un guion.

var resultado = Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0});

// resultado será "(123) 456-7890"
