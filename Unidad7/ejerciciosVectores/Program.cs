// 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

// int n, max, posicion;
// int[] numeros = new int[10];
// Console.WriteLine("Ingrese un num:");
// max = 0;
// posicion = 0;

// for (int i = 0; i < 10; i++) {
    // n = int.Parse(Console.ReadLine());
    // numeros[i] = n;

    // if (numeros[i] > max) {
        // max = numeros[i];
        // posicion = i + 1;
    // }
// };
// Console.WriteLine("El valor maximo es: "+max+" y su posicion es: "+posicion);

// 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

// int n, prom, acu;

// int[] numeros = new int[10];

// Console.WriteLine("Ingrese un num:");

// for (int i = 0; i < 10; i++) {
    // n = int.Parse(Console.ReadLine());
    // numeros[i] = n;
// }

// acu = 0;

// for (int i = 0; i < 10; i++) {
    // acu += numeros[i];
// }

// prom = acu / 10;

// Console.WriteLine("El promedio es de: "+prom);

// for (int i = 0; i < 10; i++) {
    // if (numeros[i] > prom) {
        // Console.WriteLine("El valor mayor al promedio es: "+numeros[i]);
    // }
// }

// 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
// CADENA FUENTE: “La mar estaba serena"
// CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
// CADENA RESULTADO: “Li mir estibi sereni"

// char[] frase = new char[30];
// char letraActual;
// char letraNueva;
// char letra;
// int indice = 0;

// Console.WriteLine("Ingrese una letra para la frase:");
// letra = char.Parse(Console.ReadLine());

// while (letra != '0' && indice < 30) {
    // frase[indice] = letra;
    // Console.WriteLine("Ingrese otra letra para la frase:");
    // letra = char.Parse(Console.ReadLine());
    // indice++;
// }

// frase[indice] = '\0';
// Console.WriteLine("La frase es:");
// indice = 0;

// while (frase[indice] != '\0') {
    // Console.WriteLine(frase[indice]);
    // indice++;
// }

// Console.WriteLine("Ingrese letra a reemplazar:");
// letraActual = char.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese la letra nueva:");
// letraNueva = char.Parse(Console.ReadLine());

// indice = 0;

// while (frase[indice] != '\0') {
    // if (frase[indice] == letraActual) {
        // frase[indice] = letraNueva;
    // }

    // indice++;
// }

// Console.WriteLine("La frase nueva es: ");
// indice = 0;
// while (frase[indice] != '\0') {
    // Console.WriteLine(frase[indice]);
    // indice++;
// }

// 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
// - Número de Artículo (1 a 15)
// - Cantidad Vendida 

// Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
// Se pide determinar e informar:
// a) El número de artículo que más se vendió en total.
// b) Los números de artículos que no registraron ventas.
// c) Cuantas unidades se vendieron del número de artículo 10.

// int nroArticulo;
// int cantidad;
// int[] totalCantidadVendida = new int[15];

// for (int i = 0; i < 15; i++) {
    // totalCantidadVendida[i] = 0;
// }

// Console.WriteLine("Ingrese el nro de articulo");
// nroArticulo = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese la cantidad vendida");
// cantidad = int.Parse(Console.ReadLine());

// while (nroArticulo != 0) {

    // totalCantidadVendida[nroArticulo - 1] += cantidad;

    // Console.WriteLine("Ingrese el nro de articulo");
    // nroArticulo = int.Parse(Console.ReadLine());
    // Console.WriteLine("Ingrese la cantidad vendida");
    // cantidad = int.Parse(Console.ReadLine());
// }

// //a
// int maxCantidad = totalCantidadVendida[0];
// int nroMaximo = 1;

// for(int i = 0; i < 15; i++) {
    // if(totalCantidadVendida[i] > maxCantidad) {
        // maxCantidad = totalCantidadVendida[i];
        // nroMaximo = i + 1;
    // }
// }
// // Console.WriteLine("El producto mas vendido es el: "+ nroArticulo +" con la cantidad de: "+ maxCantidad);

// //b

// for(int i = 0; i < 15; i++) {
    // if(totalCantidadVendida[i] == 0) {
        // Console.WriteLine("El producto "+(i+1)+" no tuvo ventas");
    // }
// }

// //c
// Console.WriteLine("La cantidad vendida del articulo 10 es: "+totalCantidadVendida[9]);