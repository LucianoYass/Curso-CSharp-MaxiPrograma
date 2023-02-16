namespace ejerciciosCicloFor;
class Program
{
    static void Main(string[] args)
    {
        //Guia ejercicios ciclo FOR
        // 1. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

        // int n = 0, max = 0;

        // for (int i=0; i < 10; i++) {
            // Console.WriteLine("Introduzca un numero:");
            // n = int.Parse(Console.ReadLine());

            // if (n > max) {
                // max = n;
            // }
        // }

        // Console.WriteLine("El mayor de ellos es: "+max);

        // 2. Hacer un programa que solicite 20 números y calcule y emita por pantalla cuántos son positivos (mayores a cero). Se debe mostrar un solo valor: el conteo final.

        // int n = 0, contMayor = 0;

        // for (int i=0; i < 20;  i++) {
            // Console.WriteLine("Ingrese un numero: ");
            // n = int.Parse(Console.ReadLine());

            // if (n > 0) {
                // contMayor++;
            // }
        // }

        // Console.WriteLine("La cantidad de numeros mayores a 0 es: "+contMayor);

        // 3. Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos.

            // for (int i=1; i<=10; i++) {
                // Console.WriteLine(i);
            // };

        // 4. Hacer un programa para mostrar los números del 10 al 1. No se debe realizar ningún pedido de datos.

            // for (int i=10; i>=1; i--) {
                // Console.WriteLine(i);
            // };

        // 5. Hacer un programa que muestre los números del 1 al 100 de 5 en 5. Ejemplo: 0, 5, 10, 15, 20.... 100.

            // for (int i=0; i<=100; i+=5) {
                // Console.WriteLine(i);
            // }

        // 6. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo. Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

            // int n, con = 0;
            // Console.WriteLine("Ingrese  un numero: ");
            // n = int.Parse(Console.ReadLine());

            // for (int i = 1; i <= n; i++) {
                // if (n % i == 0) {
                    // con++;
                // };
            // };
            // if (con == 2) {
                // Console.WriteLine("El numero es primo.");
            // } else {
                // Console.WriteLine("El numero no es primo.");
            // }

        // 7. Hacer un programa que solicite 10 números y luego mostrar por pantalla el máximo de ellos y la posición en la que fue ingresado.

            // int n, numMayor = 0, posicion = 1;

            // for (int i=0; i<10; i++) {
                // Console.WriteLine("Ingrese un numero: ");
                // n = int.Parse(Console.ReadLine());

                // if (n > numMayor) {
                    // numMayor = n;
                    // posicion = i + 1;
                // }
            // }

            // Console.WriteLine("El numero mayor es: "+numMayor+" y su posicion es: "+posicion);

        // 8. Hacer un programa que solicite 20 números y luego mostrar por pantalla el menor de ellos y la posición en la que fue encontrado.

            // int min = int.MaxValue, position = 0;

            // for (int i=0; i<20; i++) {
                // Console.WriteLine("Ingresa un numero: ");
                // int n = int.Parse(Console.ReadLine());
                
                // if(n < min) {
                    // min = n;
                    // position = i+1;
                // }
            // }

            // Console.WriteLine("El menor es "+min+" y la posicion es "+position);

        // 9. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

            // int edades, promedioEdades, mayores = 0, cont = 0;

            // for (int i=0; i<20; i++) {
                // Console.WriteLine("Ingrese la edad");
                // edades = int.Parse(Console.ReadLine());

                // if (edades > 18) {
                    // mayores += edades;
                    // cont++;
                // }
            // }

            // promedioEdades = mayores / cont;
            // Console.WriteLine("El promedio de edades es "+promedioEdades);

        // 10. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

            // int n, maxPares = 0, minImpares = 0, pares = 0, impares = 0;

            // for (int i=0; i<20; i++) {
                // Console.WriteLine("Ingrese un numero:");
                // n = int.Parse(Console.ReadLine());

                // if (n % 2 == 0) {
                    // pares++;
                    // if (pares == 1) {
                        // maxPares = n;
                    // } else  if (n > maxPares) {
                        // maxPares = n;
                    // }
                // } else {
                    // impares++;
                    // if (impares == 1) {
                        // minImpares = n;
                    // } else if (n < minImpares) {
                        // minImpares = n;
                    // }
                // }
            // }

            // Console.WriteLine("El maximo de los pares "+maxPares+" y el minimo de los impares "+minImpares);

        // 11. Hacer un programa para ingresar 10 números y luego calcule y emita el mayor de los primos de la lista. En caso de no haber ningún número primo, deberá aclararlo con un cartel.

        // int number;
        // bool isPrime = false;
        // int maxPrime = 0;

        // Console.WriteLine("Ingrese 10 números:");

        // // Ingresar los 10 números
        // for (int i = 1; i <= 10; i++)
        // {
            // number = int.Parse(Console.ReadLine());

            // // Revisar si el número es primo
            // isPrime = true;
            // if (number < 2)
            // {
                // isPrime = false;
            // }
            // else
            // {
                // for (int j = 2; j <= number / 2; j++)
                // {
                    // if (number % j == 0)
                    // {
                        // isPrime = false;
                        // break;
                    // }
                // }
            // }

            // // Si el número es primo, compararlo con el máximo primo encontrado
            // if (isPrime)
            // {
                // maxPrime = Math.Max(maxPrime, number);
            // }
        // }

        // // Si se encontró al menos un número primo, imprimirlo
        // if (maxPrime > 0)
        // {
            // Console.WriteLine("El número primo más grande es: " + maxPrime);
        // }
        // else
        // {
            // Console.WriteLine("No se encontraron números primos en la lista.");
        // }
    }
}
